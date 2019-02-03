using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoNetConnection
{
    class Program
    {
        static void Main(string[] args)
        {
            //Клас самого підлючення
            SqlConnection connection = new SqlConnection();
            //Рядок підключення до БД
            connection.ConnectionString = 
            "Data Source=.;Initial Catalog=AdoNetLibrary;Integrated Security=True";
            //Відкриття підлкючення дл БД
            connection.Open();
            //Рядок запиту
            string insertString = @"INSERT INTO dbo.tbl_Authors VALUES ('Georgiy','Kesha')";
            //Із рядка комнади зроибли саму команду
            SqlCommand command = new SqlCommand(insertString, connection);
            //Виконать команду
            command.ExecuteNonQuery();
            //Закриття підключення до БД
            connection.Close();
        }
    }
}
