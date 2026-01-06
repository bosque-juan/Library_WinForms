using Library_WinForms.Business;
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

namespace Library_WinForms.Data
{
    public class DaoPublisherManagment : IEditorialRepository
    {
        DataAccess oDb;

        public DaoPublisherManagment()
        {
            oDb = new DataAccess();
        }

        public List<Publisher> GetEditorials()
        {
            List<Publisher> editorialList = new List<Publisher>();
            DataTable dt = oDb.QueryTable("Editoriales");

            foreach (DataRow dr in dt.Rows)
            {
                Publisher editorial = new Publisher();
                editorial.Id = (int)dr["id_editorial"];
                editorial.Name = dr["editorial"].ToString();
                editorialList.Add(editorial);
            }

            return editorialList;
        }
        public List<Publisher> GetPublisherByFilter(List<Parameter> filters)
        {
            List<Publisher> publisherlist = new List<Publisher>();

            string querySQL =
                "SELECT id_editorial, editorial " +
                "FROM editoriales " +
                "WHERE 1 = 1 ";

            List<Parameter> parameters = new List<Parameter>();

            foreach (Parameter filter in filters)
            {
                if (filter != null)
                {
                    if (filter.Name == "code")
                    {
                        querySQL += " AND id_editorial = @id";
                        parameters.Add(new Parameter("@id", filter.Value));
                    }
                    if (!string.IsNullOrEmpty(filter.Name) && filter.Name == "publisher")
                    {
                        querySQL += " AND (editorial LIKE @name )";
                        parameters.Add(new Parameter("@name", "%" + filter.Value + "%"));
                    }
                }
            }


            DataTable dt = oDb.QueryDb(querySQL, parameters);

            foreach (DataRow dr in dt.Rows)
            {
                publisherlist.Add(new Publisher
                {
                    Id = (int)dr["id_editorial"],
                    Name = dr["editorial"].ToString()
                });
            }

            return publisherlist;
        }

        public Publisher GetEditorialById(int id)
        {
            string sql = "SELECT id_editorial, editorial FROM Editoriales WHERE id_editorial = @id";
            var parameters = new List<Parameter> { new Parameter("@id", id) };
            DataTable dt = oDb.QueryDb(sql, parameters);

            if (dt.Rows.Count == 0) return null;

            DataRow dr = dt.Rows[0];
            return new Publisher
            {
                Id = (int)dr["id_editorial"],
                Name = dr["editorial"].ToString()
            };
        }

        public int InsertEditorial(Publisher editorial)
        {
            string sql = "INSERT INTO Editoriales (id_editorial,editorial) VALUES (@id_editorial, @editorial)";
            var parameters = new List<Parameter>{
                new Parameter("@id_editorial", editorial.Id),
                new Parameter("@editorial", editorial.Name)
            };


            return oDb.UpdateBD(sql, parameters);
        }

        public int UpdateEditorial(Publisher editorial)
        {
            string sql = "UPDATE Editoriales SET editorial = @name WHERE id_editorial = @id";
            var parameters = new List<Parameter> {
                new Parameter("@id", editorial.Id),
                new Parameter("@name", editorial.Name)
            };
            return oDb.UpdateBD(sql, parameters);
        }

        public int DeleteEditorial(int id)
        {
            var commands = new List<(string sql, List<Parameter> parameters)>();
            var param = new List<Parameter> { new Parameter("@id", id) };

            commands.Add(("DELETE FROM autores_editoriales WHERE id_editorial = @id", param));


            commands.Add(("DELETE FROM libros WHERE id_editorial = @id", param));

            commands.Add(("DELETE FROM Editoriales WHERE id_editorial = @id", param));

            return oDb.ExecuteTransaction(commands);
        }

    }
}
