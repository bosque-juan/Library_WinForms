
using Library_WinForms.Domain.DTOs;
using Library_WinForms.Domain.Entities;
using Library_WinForms.Domain.Interfaces;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BookDTO = Library_WinForms.Domain.DTOs.BookDTO;

namespace Library_WinForms.Data
{
    public class DaoBookManagment : IBookRepository
    {
        DataAccess oBD;

        public DaoBookManagment()
        {
            oBD = new DataAccess();
        }

        public List<BookDTO> GetBooks(AuthorDTORecomended filter)
        {
            List<BookDTO> bookList = new List<BookDTO>();

            string querySQL =
                "SELECT l.cod_libro, l.titulo, a.nombre " +
                "FROM libros l " +
                "JOIN autores_libros al ON al.id_libro = l.cod_libro " +
                "JOIN autores a ON a.id_autor = al.id_autor " +
                "WHERE 1 = 1 ";

            List<Parameter> parameters = new List<Parameter>();

            if (filter != null)
            {
                if (filter.Author != 0)
                {
                    querySQL += " AND a.id_autor = @id_autor";
                    parameters.Add(new Parameter("@id_autor", filter.Author));
                }

                if (!string.IsNullOrEmpty(filter.Title))
                {
                    querySQL += " AND l.titulo LIKE @titulo";
                    parameters.Add(new Parameter("@titulo", "%" + filter.Title + "%"));
                }
            }

            DataTable table = oBD.QueryDb(querySQL, parameters);

            foreach (DataRow row in table.Rows)
            {
                BookDTO oBook = new BookDTO
                {
                    Code = (int)row["cod_libro"],
                    Title = row["titulo"].ToString(),
                    Author = row["nombre"].ToString()
                };

                bookList.Add(oBook);
            }

            return bookList;
        }

        public Book GetBookById(int code)
        {
            string querySQL =
                "SELECT l.*, " +
                "a.id_autor, a.nombre, " +
                "e.editorial, " +
                "i.idioma, " +
                "g.id_genero, g.genero " +
                "FROM libros l " +
                "JOIN autores_libros al ON al.id_libro = l.cod_libro " +
                "JOIN autores a ON a.id_autor = al.id_autor " +
                "JOIN editoriales e ON e.id_editorial = l.id_editorial " +
                "JOIN idiomas i ON i.id_idioma = l.id_idioma " +
                "LEFT JOIN libros_generos lg ON lg.id_libro = l.cod_libro " +
                "LEFT JOIN generos g ON g.id_genero = lg.id_genero " +
                "WHERE l.cod_libro = @cod";

            var parameters = new List<Parameter>
    {
        new Parameter("@cod", code)
    };

            DataTable dt = oBD.QueryDb(querySQL, parameters);

            if (dt.Rows.Count == 0)
                return null;

            DataRow dr = dt.Rows[0];

            Book obook = new Book
            {
                Code = (int)dr["cod_libro"],
                Isbn = dr["isbn"].ToString(),
                Title = dr["titulo"].ToString(),
                Price = Convert.ToDouble(dr["precio"]),
                Description = dr["descripcion"].ToString(),
                Stock = (int)dr["stock"],
                ReleaseDate = (DateTime)dr["fecha_lanzamiento"],
                _Editorial = new Publisher
                {
                    Id = (int)dr["id_editorial"],
                    Name = dr["editorial"].ToString()
                },
                Languaje = new Book_Language
                {
                    Id = (int)dr["id_idioma"],
                    LanguajeName = dr["idioma"].ToString()
                },
                Author = new Author
                {
                    Code = (int)dr["id_autor"],
                    Name = dr["nombre"].ToString()
                },
            };

            if (dr["id_genero"] != DBNull.Value)
            {
                obook.Genre = new Genre
                {
                    IdGenre = (int)dr["id_genero"],
                    genre = dr["genero"].ToString()
                };
            }

            return obook;
        }

        public int UpdateBook(Book book)
        {
            var commands = new List<(string, List<Parameter>)>();


            commands.Add((
                @"UPDATE libros SET
            isbn = @isbn,
            titulo = @titulo,
            precio = @precio,
            descripcion = @descripcion,
            stock = @stock,
            id_editorial = @id_editorial,
            fecha_lanzamiento = @fecha_lanzamiento,
            id_idioma = @id_idioma
          WHERE cod_libro = @cod_libro",
                new List<Parameter>
                {
            new Parameter("@isbn", book.Isbn),
            new Parameter("@titulo", book.Title),
            new Parameter("@precio", book.Price),
            new Parameter("@descripcion", book.Description),
            new Parameter("@stock", book.Stock),
            new Parameter("@id_editorial", book._Editorial.Id),
            new Parameter("@fecha_lanzamiento", book.ReleaseDate),
            new Parameter("@id_idioma", book.Languaje.Id),
            new Parameter("@cod_libro", book.Code)
                }
            ));

            // 2️⃣ Autor → borrar relación anterior
            commands.Add((
                "DELETE FROM autores_libros WHERE id_libro = @libro",
                new List<Parameter>
                {
            new Parameter("@libro", book.Code)
                }
            ));

            // 3️⃣ Autor → insertar nuevo
            commands.Add((
                @"INSERT INTO autores_libros (id_libro, id_autor)
          VALUES (@libro, @autor)",
                new List<Parameter>
                {
            new Parameter("@libro", book.Code),
            new Parameter("@autor", book.Author.Code)
                }
            ));

            // 4️⃣ Género → borrar anterior
            commands.Add((
                "DELETE FROM libros_generos WHERE id_libro = @libro",
                new List<Parameter>
                {
            new Parameter("@libro", book.Code)
                }
            ));

            // 5️⃣ Género → insertar nuevo
            commands.Add((
                @"INSERT INTO libros_generos (id_libro, id_genero)
          VALUES (@libro, @genero)",
                new List<Parameter>
                {
            new Parameter("@libro", book.Code),
            new Parameter("@genero", book.Genre.IdGenre)
                }
            ));

            return oBD.ExecuteTransaction(commands);
        }

        public int InsertBook(Book obook)
        {
            var commands = new List<(string, List<Parameter>)>();

            commands.Add((
                @"INSERT INTO libros (cod_libro, isbn, titulo, precio, descripcion, stock, id_editorial, fecha_lanzamiento, id_idioma)
          VALUES (@cod, @isbn, @titulo, @precio, @desc, @stock, @editorial, @fecha, @idioma)",
                new List<Parameter>
                {
            new Parameter("@cod", obook.Code),
            new Parameter("@isbn", obook.Isbn),
            new Parameter("@titulo", obook.Title),
            new Parameter("@precio", obook.Price),
            new Parameter("@desc", obook.Description),
            new Parameter("@stock", obook.Stock),
            new Parameter("@editorial", obook._Editorial.Id),
            new Parameter("@fecha", obook.ReleaseDate),
            new Parameter("@idioma", obook.Languaje.Id)
                }
            ));

            commands.Add((
                @"INSERT INTO autores_libros (id_libro, id_autor)
          VALUES (@libro, @autor)",
                new List<Parameter>
                {
            new Parameter("@libro", obook.Code),
            new Parameter("@autor", obook.Author.Code)
                }
            ));
            commands.Add((
    @"INSERT INTO libros_generos (id_libro, id_genero)
      VALUES (@libro, @genero)",
    new List<Parameter>
    {
        new Parameter("@libro", obook.Code),
        new Parameter("@genero", obook.Genre.IdGenre)
    }
));


            return oBD.ExecuteTransaction(commands);

        }

        public int DeleteBook(int codigo)
        {
            int rowsAffected = 0;

            List<Parameter> parameters = new List<Parameter>
    {
        new Parameter("@codigo", codigo)
    };

            // 1️⃣ Borrar relación libro–género
            oBD.UpdateBD(
                "DELETE FROM libros_generos WHERE id_libro = @codigo",
                parameters
            );

            // 2️⃣ Borrar relación libro–autor
            oBD.UpdateBD(
                "DELETE FROM autores_libros WHERE id_libro = @codigo",
                parameters
            );

            // 3️⃣ Borrar libro
            rowsAffected = oBD.UpdateBD(
                "DELETE FROM libros WHERE cod_libro = @codigo",
                parameters
            );

            return rowsAffected;
        }

        public List<int> GetBookByYear()
        {
            List<int> listYears = new List<int>();
            string SQLquery = "SELECT DISTINCT YEAR(fecha_lanzamiento) " +
                                           " FROM libros " +
                                       " ORDER BY YEAR(fecha_lanzamiento) DESC";
            SqlDataReader dr = oBD.dbReaderQuery(SQLquery);

            while (dr.Read())
            {
                listYears.Add(dr.GetInt32(0));
            }

            dr.Close();
            return listYears;
        }


        public List<Genre> GetBookGenders()
        {
            List<Genre> genderList = new List<Genre>();
            DataTable dt = oBD.QueryTable("Generos");

            foreach (DataRow dr in dt.Rows)
            {
                Genre gender = new Genre();
                gender.IdGenre = (int)dr["id_genero"];
                gender.genre = dr["genero"].ToString();
                genderList.Add(gender);
            }

            return genderList;
        }

        public List<Book_Language> GetBookLanguages()
        {
            List<Book_Language> lista = new List<Book_Language>();
            DataTable dt = oBD.QueryTable("Idiomas");

            foreach (DataRow dr in dt.Rows)
            {
                Book_Language bl = new Book_Language();
                bl.Id = (int)dr["id_idioma"];
                bl.LanguajeName = dr["idioma"].ToString();
                lista.Add(bl);
            }

            return lista;
        }


    }
}
