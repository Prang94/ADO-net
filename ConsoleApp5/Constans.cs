using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.Sqlite;
using ConsoleApp5;

namespace ConsoleApp5
{
    internal class Constans
    {
        public const string DatabaseFile = "Invest.sqlite";
        public const string DatabaseConnectionString = "Data Source=" + DatabaseFile;

        public string SetTable()
        {
            SqliteConnection sqliteConnection = new SqliteConnection(DatabaseConnectionString);
            using var command = sqliteConnection.CreateCommand();
            command.CommandType = System.Data.CommandType.Text;
            Console.WriteLine("Какую таблицу хотите заполнить?");
            string nameTable = Console.ReadLine();
            Console.WriteLine($"name {nameTable}:");
            string name = Console.ReadLine();
            Console.WriteLine($"number {nameTable}:");
            int num = int.Parse( Console.ReadLine() );
            Console.WriteLine($"date {nameTable} (xx-xx-xxxx):");
            string dates = Console.ReadLine();

            return $"INSERT INTO {nameTable}(Name, Number, Data) VALUES ('{nameTable}', {num}, '{dates}')";
        }
    }
}
