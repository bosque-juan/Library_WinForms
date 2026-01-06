using Library_WinForms.Domain.DTOs;
using Library_WinForms.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data;


namespace Library_WinForms.Data
{
    internal class DaoRestockingBooks
    {
        DataAccess oDb;

        public DaoRestockingBooks()
        {
            oDb = new DataAccess();
        }

        public List<BookDTO> GetBooksForStocking(AuthorDTORecomended filter)
        {
            List<BookDTO> bookList = new List<BookDTO>();
            List<Parameter> parametros = new List<Parameter>();

            string SQLquery =
                "SELECT DISTINCT l.isbn, l.titulo, l.precio, l.stock " +
                "FROM libros l " +
                "JOIN libros_generos lg ON l.cod_libro = lg.id_libro " +
                "JOIN generos g ON g.id_genero = lg.id_genero " +
                "WHERE 1 = 1 ";

            if (filter != null)
            {
                SQLquery += " AND l.precio BETWEEN 1 AND 50000 ";
                SQLquery += " AND l.stock < 300 ";

                if (!string.IsNullOrEmpty(filter.Title))
                {
                    SQLquery += " AND l.titulo LIKE @titulo";
                    parametros.Add(new Parameter("@titulo", "%" + filter.Title + "%"));
                }

                if (filter != null)
                {
                    SQLquery += " AND g.id_genero = @genero";
                    parametros.Add(new Parameter("@genero", filter.Genre));
                }
            }

            DataTable dt = oDb.QueryDb(SQLquery, parametros);

            foreach (DataRow dr in dt.Rows)
            {
                bookList.Add(new BookDTO
                {
                    Isbn = dr["isbn"].ToString(),
                    Title = dr["titulo"].ToString(),
                    Price = Convert.ToDouble(dr["precio"]),
                    Stock = (int)dr["stock"]
                });
            }

            return bookList;
        }


    }
}
