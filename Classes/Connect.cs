using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaAppLOLGG.Classes
{
    internal class Connect
    {
        private SqlConnection connection = new SqlConnection("Data Source=HOME-PC\\GGEZ;Initial Catalog=CinemaGG;Integrated Security=True");
        public SqlConnection GetConnection()
        {
            return connection;

        }
        public void openConnection()
        {
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
        }
        public void closeConnection()
        {
            if (connection.State == ConnectionState.Open)
            {
                connection.Close();
            }
        }
        public DataTable Select(string selectSQL) //метод для подключения БД
        {
            DataTable dataTable = new DataTable("dataBase"); //новую таблу создаём
            SqlConnection sqlConnection = new SqlConnection("Data Source=HOME-PC\\GGEZ;Initial Catalog=CinemaGG;Integrated Security=True");
            sqlConnection.Open();
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandText = selectSQL;
            SqlDataAdapter SqlDataAdapter = new SqlDataAdapter(sqlCommand); //обработчик комманды
            SqlDataAdapter.Fill(dataTable); //получаем таблицу с результатами
            return dataTable;
        }
        public bool ProverkaSdachi(string query)
        {
            Connect conn = new Connect();
            SqlCommand command = new SqlCommand();
            string insertQuery = query;
            command.CommandText = insertQuery;
            command.Connection = conn.GetConnection();

            //command.Parameters.Add("", SqlDbType.VarChar).Value=name;

            conn.openConnection();

            if (command.ExecuteNonQuery() > 0)
            {
                conn.closeConnection();
                return true;
            }
            else
            {
                conn.openConnection();
                return false;

            }
        }
        public DataTable getTable(string query)
        {
            Connect conn = new Connect();
            SqlCommand command = new SqlCommand(query, conn.GetConnection());
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            adapter.SelectCommand = command;
            adapter.Fill(dataTable);

            return dataTable;

        }
    }
}
