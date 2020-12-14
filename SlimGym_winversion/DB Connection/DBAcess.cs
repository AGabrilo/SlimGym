using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;
using System.Data;

namespace SlimGym_winversion.DB_Connection
{
    class DBAcess
    {
        static NpgsqlConnection connection = new NpgsqlConnection("Server=dumbo.db.elephantsql.com;Port=5432;Database=vivgwnxs;User Id=vivgwnxs;Password=HvcCahQUTTHQC-x3qAF3cLprTVQSp0DW");
        static NpgsqlCommand command = new NpgsqlCommand();
        static NpgsqlDataReader dataReader;

        public static DataTable get(string query)
        {
            DataTable dataTable = new DataTable();

            connection.Open();
            command.Connection = connection;
            command.CommandType = CommandType.Text;
            command.CommandText = query;
            dataReader = command.ExecuteReader();

            if(!dataReader.HasRows)
            {
                connection.Close();
                MessageBox.Show("DB Table result empty");
                return null;
            }

            dataTable.Load(dataReader);
            connection.Close();
            return dataTable;
        }

        public static void put(string query)
        {
            DataTable dataTable = new DataTable();

            connection.Open();
            command.Connection = connection;
            command.CommandType = CommandType.Text;
            command.CommandText = query;
            command.ExecuteReader();

            MessageBox.Show("Successful!!");
            connection.Close();
        }
    }
}
