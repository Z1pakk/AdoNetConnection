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
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.InputEncoding= System.Text.Encoding.Unicode;
            string firstName=string.Empty;
            string lastName = string.Empty;

            Console.WriteLine("Реєстрація автора");
            Console.Write("Введіть ім'я автора=>>");
            firstName=Console.ReadLine();
            Console.Write("Введіть прізвище автора=>>");
            lastName = Console.ReadLine();

            //Клас самого підлючення
            SqlConnection connection = new SqlConnection();
            //Рядок підключення до БД
            connection.ConnectionString = 
            "Data Source=.;Initial Catalog=AdoNetLibrary;Integrated Security=True";
            //Відкриття підлкючення дл БД
            connection.Open();
            //Рядок запиту
            string insertString = $@"INSERT INTO dbo.tbl_Authors VALUES ('{firstName}','{lastName}')";
            //Із рядка комнади зроибли саму команду
            SqlCommand command = new SqlCommand(insertString, connection);
            //Виконать команду
            Console.WriteLine($"Успішно додано {command.ExecuteNonQuery()} авторів");
            //Закриття підключення до БД
            connection.Close();
        }
    }
}
