using Library_WinForms.Business;
using Library_WinForms.Domain.DTOs;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using BookDTO = Library_WinForms.Domain.DTOs.BookDTO;

namespace Library_WinForms.Data
{
    internal class DaoSuggestedBooks
    {
        DataAccess oDbSuggestedBooks;

        public DaoSuggestedBooks()
        {
            oDbSuggestedBooks = new DataAccess();
        }

        internal List<BookDTO> GetSuggestedBooks(AuthorDTORecomended ofilter)
        {
            List<BookDTO> list = new List<BookDTO>();
            List<Parameter> parameters = new List<Parameter>();

            string QuerySQL =
                "SELECT l.cod_libro, l.titulo, l.fecha_lanzamiento, l.precio, l.stock, " +
                "CONCAT(a.nombre, ', ', a.apellido) AS autor, g.genero " +
                "FROM libros l " +
                "JOIN autores_libros al ON l.cod_libro = al.id_libro " +
                "JOIN autores a ON al.id_autor = a.id_autor " +
                "JOIN libros_generos lg ON l.cod_libro = lg.id_libro " +
                "JOIN generos g ON g.id_genero = lg.id_genero " +
                "WHERE l.precio BETWEEN @precioMin AND @precioMax " +
                "AND l.stock <> 0 ";

            parameters.Add(new Parameter("@precioMin", 30000));
            parameters.Add(new Parameter("@precioMax", 100000));

            if (ofilter.Genre >0)
            {
                QuerySQL += " AND g.id_genero = @genero";
                parameters.Add(new Parameter("@genero", ofilter.Genre));
            }

            if (ofilter.From > 0 && ofilter.To > 0)
            {
                QuerySQL += " AND YEAR(l.fecha_lanzamiento) BETWEEN @desde AND @hasta";
                parameters.Add(new Parameter("@desde", ofilter.From));
                parameters.Add(new Parameter("@hasta", ofilter.To));
            }

            QuerySQL += " ORDER BY l.titulo";

            DataTable table = oDbSuggestedBooks.QueryDb(QuerySQL, parameters);

            foreach (DataRow row in table.Rows)
            {
                list.Add(new BookDTO
                {
                    Code = (int)row["cod_libro"],
                    Title = row["titulo"].ToString(),
                    RealeseDate = (DateTime)row["fecha_lanzamiento"],
                    Price = Convert.ToDouble(row["precio"]),
                    Stock = (int)row["stock"],
                    Author = row["autor"].ToString(),
                    Genre = row["genero"].ToString()
                });
            }

            return list;
        }

    }
}
