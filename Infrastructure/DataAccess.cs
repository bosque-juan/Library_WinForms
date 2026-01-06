using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Library_WinForms.Data
{
    public class DataAccess
    {
        private string CadenaConexion = Properties.Resources.CadenaConexion;

        private SqlConnection _connection;
        private SqlCommand comamnd;
        private SqlDataReader reader;
        public DataAccess()
        {
            _connection = new SqlConnection(CadenaConexion);
        }
        private void Connect()
        {
            _connection.Open();
            comamnd = new SqlCommand();
            comamnd.Connection = _connection;
            comamnd.CommandType = CommandType.Text;
        }
        public void Disconnect()
        {
            _connection.Close();
        }
        public DataTable QueryTable(string TableName)
        {
            DataTable table = new DataTable();
            this.Connect();
            comamnd.CommandText = "SELECT * FROM " + TableName;
            table.Load(comamnd.ExecuteReader());
            this.Disconnect();
            return table;
        }
        public DataTable QueryDb(string sql, List<Parameter> parameters)
        {
            DataTable table = new DataTable();

            this.Connect();

            SqlCommand cmd = new SqlCommand(sql, _connection);

            foreach (var p in parameters)
            {
                cmd.Parameters.AddWithValue(p.Name, p.Value);
            }

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(table);

            this.Disconnect();

            return table;
        }
        public int UpdateDb(string querySQL)
        {
            int rowAffected = 0;
            this.Connect();
            comamnd.CommandText = querySQL;
            rowAffected = comamnd.ExecuteNonQuery();
            this.Disconnect();
            return rowAffected;
        }
        public int UpdateBD(string querySQL, List<Parameter> lista)
        {
            int rowAffected = 0;
            this.Connect();
            comamnd.CommandText = querySQL;
            foreach (Parameter param in lista)
            {
                comamnd.Parameters.AddWithValue(param.Name, param.Value);
            }
            rowAffected = comamnd.ExecuteNonQuery();
            this.Disconnect();
            return rowAffected;
        }
        public SqlDataReader dbReaderQuery(string queryDb)
        {
            this.Connect();
            comamnd.CommandText = queryDb;
            reader = comamnd.ExecuteReader(CommandBehavior.CloseConnection);

            return reader;
        }

        public int ExecuteTransaction(List<(string sql, List<Parameter> parameters)> commands)
        {
            int totalAffected = 0;

            this.Connect();
            SqlTransaction transaction = _connection.BeginTransaction();

            try
            {
                comamnd.Transaction = transaction;

                foreach (var comand in commands)
                {
                    comamnd.Parameters.Clear();
                    comamnd.CommandText = comand.sql;

                    foreach (var parameter in comand.parameters)
                        comamnd.Parameters.AddWithValue(parameter.Name, parameter.Value);

                    totalAffected += comamnd.ExecuteNonQuery();
                }

                transaction.Commit();
            }
            catch
            {
                transaction.Rollback();
                throw;
            }
            finally
            {
                this.Disconnect();
            }

            return totalAffected;
        }


    }
}
