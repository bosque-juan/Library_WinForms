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
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_WinForms.Data
{
    public class DaoNationality : INationalityRepository
    {
        DataAccess oDb;

        public DaoNationality()
        {
            oDb = new DataAccess();
        }

        public List<Nationality> GetNationalities()
        {
            List<Nationality> nationalityList = new List<Nationality>();
            string SqlQuery = "nacionalidades";
            DataTable NationalitiesDt = oDb.QueryTable(SqlQuery);

            foreach (DataRow row in NationalitiesDt.Rows)
            {
                nationalityList.Add(new Nationality
                {
                    Id = (int)row["id_nacionalidad"],
                    Description = row["nacionalidad"].ToString()
                });
            }
            return nationalityList;
        }
    }
}

