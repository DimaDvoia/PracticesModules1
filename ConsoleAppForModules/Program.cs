using ClassLibrary1;
using practice_modules.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity.Infrastructure;
using System.Data.Entity;
using practice_modules;
using System.Data.SqlClient;
using System.Text.RegularExpressions;

namespace ConsoleAppForModules
{
    class Program

    {
        static void Main(string[] args)
        {
            string connectionString = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=AEROPORT_modules;Integrated Security=True";
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    Console.WriteLine("Создание новой учетной записи\n");


                    string login = "";
                    while (string.IsNullOrEmpty(login) || !Regex.IsMatch(login, "^[a-zA-Z0-9]+$"))
                    {
                        Console.Write("Введите login пользователя:");
                        login = Console.ReadLine();
                        if (string.IsNullOrEmpty(login) || !Regex.IsMatch(login, "^[a-zA-Z0-9]+$"))
                        {
                            Console.WriteLine("Некорректный login. Введите только английские буквы и цифры без пробелов.");
                        }
                    }
                    int role_id = 0;
                    while (!int.TryParse(Console.ReadLine(), out role_id) || role_id < 1 || role_id > 3)
                    {
                        Console.WriteLine("Введите должность пользователя от 1 до 3 ");
                        if (!int.TryParse(Console.ReadLine(), out role_id) || role_id < 1 || role_id > 3)
                        {
                            Console.WriteLine("Некорректная должность пользователя. Введите число от 1 до 3.");
                        }
                    }

                    string password = "";
                    while (string.IsNullOrEmpty(password))
                    {
                        Console.WriteLine("Введите пароль:");
                        password = Console.ReadLine();
                        if (string.IsNullOrEmpty(password))
                        {
                            Console.WriteLine("Пароль не может быть пустым.");
                        }
                    }
                    string hashedPassword = Class1.HashPassword1(password);

                    string query = "INSERT INTO USERS (login, role_id, password) VALUES (@login, @role_id, @password)";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@login", login);
                        command.Parameters.AddWithValue("@role_id", role_id);
                        command.Parameters.AddWithValue("@password", hashedPassword);

                        command.ExecuteNonQuery();
                    }

                    Console.WriteLine("Пользователь успешно добавлен в таблицу!");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Произошла ошибка: {ex.Message}");
            }

            Console.ReadLine();

        }
    }
}
    

