using ABMCLibros.Negocio;
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

namespace ABMCLibros.Datos
{
    public class LibroDao
    {
        AccesoDatos oBD;
        public LibroDao()
        {
            oBD = new AccesoDatos();
        }

        //MÉTODOS PARA CARGAR COMBOS
        public List<Autor> TraerAutores()
        {
            List<Autor> lista = new List<Autor>();

            DataTable dt = oBD.ConsultarTabla("Autores");

            foreach (DataRow dr in dt.Rows)
            {
                Autor a = new Autor();

                a.Codigo = (int)dr["id_autor"];
                a.Nombre = dr["nombre"].ToString();

                lista.Add(a);
            }

            return lista;
        }
        public List<Editorial> TraerEditoriales()
        {
            List<Editorial> lista = new List<Editorial>();

            DataTable dt = oBD.ConsultarTabla("Editoriales");

            foreach (DataRow dr in dt.Rows)
            {
                Editorial e = new Editorial();

                e.Id = (int)dr["id_editorial"];
                e.Nombre = dr["editorial"].ToString();

                lista.Add(e);
            }

            return lista;
        }
        public List<Idioma> TraerIdiomas()
        {
            List<Idioma> lista = new List<Idioma>();

            DataTable dt = oBD.ConsultarTabla("Idiomas");

            foreach (DataRow dr in dt.Rows)
            {
                Idioma i = new Idioma();

                i.Id = (int)dr["id_idioma"];
                i.Nombre = dr["idioma"].ToString();

                lista.Add(i);
            }

            return lista;
        }

        //SELECT
        public List<LibroVista> RecuperarLibros(Filtro filtro)
        {
            List<LibroVista> Lista = new List<LibroVista>();
            string consultaSQL = "SELECT l.cod_libro, l.titulo, a.nombre " +
                                " from libros l join autores_libros al on al.id_libro = l.cod_libro " +
                                " join autores a on a.id_autor = al.id_autor where 1=1 ";
            if (filtro != null)
            {
                if (filtro.Autor != 0)
                {
                    consultaSQL += " and a.id_autor = " + filtro.Autor;
                }

                if (!string.IsNullOrEmpty(filtro.Titulo))
                {
                    consultaSQL += " AND l.titulo like '%" + filtro.Titulo + "%'";
                }
            }

            DataTable tabla = oBD.ConsultarBD(consultaSQL);

            foreach (DataRow fila in tabla.Rows)
            {
                LibroVista oLibro = new LibroVista();
                oLibro.Codigo = (int)fila[0];
                oLibro.Titulo = fila[1].ToString();
                oLibro.Autor = fila[2].ToString();
                Lista.Add(oLibro);
            }
            return Lista;
        }

        public Libro RecuperarLibroPorId(int codigo)
        {


            string consultaSQL = " SELECT l.*, a.id_autor, a.nombre, e.editorial, i.idioma " +
                                    " FROM Libros l " +
                                    " join autores_libros al on al.id_libro = l.cod_libro " +
                                    " join Autores a on a.id_autor = al.id_autor " +
                                    " join editoriales e on e.id_editorial = l.id_editorial " +
                                    " join idiomas i on i.id_idioma = l.id_idioma " +
                                    " Where l.cod_libro = " + codigo;

            DataTable dt = oBD.ConsultarBD(consultaSQL);

            if (dt.Rows.Count == 0)
            {
                return null;
            }
            DataRow dr = dt.Rows[0];

            Libro oLibro = new Libro();

            oLibro.Codigo = (int)dr["cod_libro"];
            oLibro.Isbn = dr["isbn"].ToString();
            oLibro.Titulo = dr["titulo"].ToString();
            oLibro.Precio = Convert.ToDouble(dr["precio"]);
            oLibro.Descripcion = dr["descripcion"].ToString();
            oLibro.Stock = (int)dr["stock"];
            oLibro.Editorial = new Editorial();
            oLibro.Editorial.Id = (int)dr["id_editorial"];
            oLibro.FechaLanzamiento = (DateTime)dr["fecha_lanzamiento"];
            oLibro.Idioma = new Idioma();
            oLibro.Idioma.Id = (int)dr["id_idioma"];
            oLibro.Autor = new Autor();
            oLibro.Autor.Codigo = (int)dr["id_autor"];
            oLibro.Autor.Nombre = dr["nombre"].ToString();
            oLibro.Editorial.Nombre = dr["editorial"].ToString();
            oLibro.Idioma.Nombre = dr["idioma"].ToString();


            return oLibro;
        }

        //UPDATE
        public int ActualizarLibro(Libro libro)
        {


            string consultaSQL = $" UPDATE libros SET " +
                                 $" isbn = '{libro.Isbn}', " +
                                 $" titulo = '{libro.Titulo}', " +
                                 $" precio = {libro.Precio}, " +
                                 $" descripcion = '{libro.Descripcion}', " +
                                 $" stock = {libro.Stock} , " +
                                 $" id_editorial = {libro.Editorial.Id}, " +
                                 $" fecha_lanzamiento = '{libro.FechaLanzamiento:yyyy-MM-dd}', " +
                                 $" id_idioma = {libro.Idioma.Id} " +
                                 $" WHERE cod_libro = {libro.Codigo}";

            return oBD.ActualizarBD(consultaSQL);
        }

        // CREAR LIBRO
        
        public int InsertarLibro(Libro oLibro)
        {
            int filasAfectadas = 0;

            // 1. Insertar el libro en la tabla Libros
            string consultaSQL =
                @"INSERT INTO Libros 
        (cod_libro, isbn, titulo, precio, descripcion, stock, id_editorial, fecha_lanzamiento, id_idioma)
        VALUES 
        (@cod_libro, @isbn, @titulo, @precio, @descripcion, @stock, @id_editorial, @fecha_lanzamiento, @id_idioma)";

            List<Parametro> listaParametros = new List<Parametro>
    {
        new Parametro("@cod_libro", oLibro.Codigo),
        new Parametro("@isbn", oLibro.Isbn),
        new Parametro("@titulo", oLibro.Titulo),
        new Parametro("@precio", oLibro.Precio),
        new Parametro("@descripcion", oLibro.Descripcion),
        new Parametro("@stock", oLibro.Stock),
        new Parametro("@id_editorial", oLibro.Editorial.Id),
        new Parametro("@fecha_lanzamiento", oLibro.FechaLanzamiento),
        new Parametro("@id_idioma", oLibro.Idioma.Id)
    };
            filasAfectadas = oBD.ActualizarBD(consultaSQL, listaParametros);

            // Insertar libros

            string insertAutorLibro = "INSERT INTO autores_libros (id_libro, id_autor) VALUES (@id_libro, @id_autor)";

            // si se insertó libros, insertar libro y autor en autores_libros
            List<Parametro> parametrosAutor = new List<Parametro>
            {
                new Parametro("@id_libro", oLibro.Codigo),
                new Parametro("@id_autor", (int)oLibro.Autor.Codigo)
            };
            if (filasAfectadas > 0)
            {
                filasAfectadas = 0;
                filasAfectadas = oBD.ActualizarBD(insertAutorLibro, parametrosAutor);
            }

            return filasAfectadas;
        }

        public int BorrarLibro(int codigo)
        {
            int filasAfectadas = 0;

            // Primero eliminar registros en autores_libros
            string borrarAutorLibro = "Delete FROM autores_libros WHERE id_libro = @codigo";
            List<Parametro> parametros = new List<Parametro>
    {
        new Parametro("@codigo", codigo)
    };
            oBD.ActualizarBD(borrarAutorLibro, parametros);

            // Luego eliminar el libro
            string borrarLibro = "Delete FROM Libros WHERE cod_libro = @codigo";
            filasAfectadas = oBD.ActualizarBD(borrarLibro, parametros);

            return filasAfectadas;
        }

        //CONSULTA 2

        public List<Genero> TraerGeneros()
        {
            List<Genero> lista = new List<Genero>();

            DataTable dt = oBD.ConsultarTabla("Generos");

            foreach (DataRow dr in dt.Rows)
            {
                Genero g = new Genero();

                g.IdGenero = (int)dr["id_genero"];
                g.Nombre = dr["genero"].ToString();

                lista.Add(g);
            }
            return lista;
        }
        public List<Libro> TraerLibrosParaStockear(Filtro filtro)
        {
            List<Libro> lista = new List<Libro>();

            string consultaSQL =
                "SELECT DISTINCT l.isbn, l.titulo, l.precio, l.stock " +
                "FROM libros l " +
                "LEFT JOIN libros_generos lg ON l.cod_libro = lg.id_libro " +
                "LEFT JOIN generos g ON g.id_genero = lg.id_genero " +
                "WHERE l.precio BETWEEN 30000 AND 50000 " +
                "AND l.stock < 30";

            if (filtro != null)
            {
                if (!string.IsNullOrEmpty(filtro.Titulo))
                {
                    consultaSQL += " AND l.titulo LIKE '%" + filtro.Titulo + "%'";
                }

                if (filtro.Genero.HasValue && filtro.Genero.Value > 0)
                {
                    consultaSQL += " AND g.id_genero = " + filtro.Genero.Value;
                }
            }

            DataTable dt = oBD.ConsultarBD(consultaSQL);

            foreach (DataRow dr in dt.Rows)
            {
                Libro l = new Libro
                {
                    Isbn = dr["isbn"].ToString(),
                    Titulo = dr["titulo"].ToString(),
                    Precio = Convert.ToDouble(dr["precio"]),
                    Stock = (int)dr["stock"]
                };

                lista.Add(l);
            }

            return lista;
        }
    }
}
