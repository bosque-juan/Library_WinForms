using Library_WinForms.Business;
using Library_WinForms.Domain.DTOs;
using Library_WinForms.Domain.Entities;
using Library_WinForms.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;


namespace Library_WinForms.Data
{
    public class DaoAuthorManagment : IAuthorRepository
    {
        DataAccess oDb;

        public DaoAuthorManagment()
        {
            oDb = new DataAccess();
        }

        public List<AuthorDTO> GetAuthors()
        {
            List<AuthorDTO> authorList = new List<AuthorDTO>();
            DataTable dt = oDb.QueryTable("Autores");

            foreach (DataRow dr in dt.Rows)
            {
                AuthorDTO author = new AuthorDTO();
                author.Code = (int)dr["id_autor"];
                author.Name = dr["nombre"].ToString();
                author.Surname = dr["apellido"].ToString();
                authorList.Add(author);
            }

            return authorList;
        }
        public AuthorDTO GetAuthorById(int id)
        {
            string sql = @"SELECT a.id_autor, a.nombre, a.apellido, a.fecha_nacimiento, n.id_nacionalidad, n.nacionalidad, s.id_sexo, s.sexo
                             FROM autores a
                             JOIN nacionalidades n ON a.id_nacionalidad = n.id_nacionalidad
                             JOIN sexos s ON a.id_sexo = s.id_sexo
                            WHERE a.id_autor = @id";

            var parameters = new List<Parameter>
    {
        new Parameter("@id", id)
    };

            DataTable dt = oDb.QueryDb(sql, parameters);

            if (dt.Rows.Count == 0)
                return null;

            DataRow dr = dt.Rows[0];

            return new AuthorDTO
            {
                Code = (int)dr["id_autor"],
                Name = dr["nombre"].ToString(),
                Surname = dr["apellido"].ToString(),
                BirthDate = Convert.ToDateTime(dr["fecha_nacimiento"]),
                Nationality = new NationalityDTO
                {
                    Id = (int)dr["id_nacionalidad"],
                    Description = dr["nacionalidad"].ToString()
                },
                SexType = new SexDTO
                {
                    IdSex = (int)dr["id_sexo"],
                    SexType = dr["sexo"].ToString()
                }
            };
        }

        public List<AuthorDTO> GetAuthorsByFilter(AuthorDTORecomended filter)
        {
            List<AuthorDTO> list = new List<AuthorDTO>();

            string querySQL =
                "SELECT id_autor, nombre, apellido " +
                "FROM autores " +
                "WHERE 1 = 1 ";

            List<Parameter> parameters = new List<Parameter>();


            if (filter != null)
            {
                if (filter.Code > 0)
                {
                    querySQL += " AND id_autor = @id";
                    parameters.Add(new Parameter("@id", filter.Code));
                }
                if (!string.IsNullOrEmpty(filter.AuthorName))
                {
                    querySQL += " AND (nombre + ' ' + apellido LIKE @name OR nombre LIKE @name OR apellido LIKE @name)";
                    parameters.Add(new Parameter("@name", "%" + filter.AuthorName.Trim() + "%"));
                }
            }


            DataTable dt = oDb.QueryDb(querySQL, parameters);

            foreach (DataRow dr in dt.Rows)
            {
                list.Add(new AuthorDTO
                {
                    Code = (int)dr["id_autor"],
                    Name = dr["nombre"].ToString(),
                    Surname = dr["apellido"].ToString()
                });
            }

            return list;
        }
        public int InsertAuthor(AuthorDTO author)
        {
            string sql = @"
        INSERT INTO autores 
        (id_autor, nombre, apellido, fecha_nacimiento, id_sexo, id_nacionalidad)
        VALUES
        (@id, @nombre, @apellido, @fecha, @sexo, @nacionalidad)
    ";

            List<Parameter> parameters = new List<Parameter>
    {
        new Parameter("@id", author.Code),
        new Parameter("@nombre", author.Name),
        new Parameter("@apellido", author.Surname),
        new Parameter("@fecha", author.BirthDate),
        new Parameter("@sexo", author.SexType.IdSex),
        new Parameter("@nacionalidad", author.Nationality.Id)
    };

            return oDb.UpdateBD(sql, parameters);
        }

        public int UpdateAuthor(AuthorDTO author)
        {
            string sql = @"
        UPDATE autores SET
            nombre = @nombre,
            apellido = @apellido,
            fecha_nacimiento = @fecha,
            id_sexo = @sexo,
            id_nacionalidad = @nacionalidad
        WHERE id_autor = @id
    ";

            List<Parameter> parameters = new List<Parameter>
    {
        new Parameter("@id", author.Code),
        new Parameter("@nombre", author.Name),
        new Parameter("@apellido", author.Surname),
        new Parameter("@fecha", author.BirthDate),
        new Parameter("@sexo", author.SexType.IdSex),
        new Parameter("@nacionalidad", author.Nationality.Id)
    };

            return oDb.UpdateBD(sql, parameters);
        }

        public int DeleteAuthor(int idAuthor)
        {
            var commands = new List<(string sql, List<Parameter> parameters)>();

            var param = new List<Parameter> { new Parameter("@id", idAuthor) };

            commands.Add(("DELETE FROM autores_libros WHERE id_autor = @id", param));

            commands.Add(("DELETE FROM autores_editoriales WHERE id_autor = @id", param));

            commands.Add(("DELETE FROM autores WHERE id_autor = @id", param));

            return oDb.ExecuteTransaction(commands);
        }
        public List<SexDTO> GetSexes()
        {
            List<SexDTO> sexList = new List<SexDTO>();
            DataTable dt = oDb.QueryTable("sexos");

            foreach (DataRow dr in dt.Rows)
            {
                SexDTO sex = new SexDTO();
                sex.IdSex = (int)dr["id_sexo"];
                sex.SexType = dr["sexo"].ToString();
                sexList.Add(sex);
            }

            return sexList;
        }
    }
}


