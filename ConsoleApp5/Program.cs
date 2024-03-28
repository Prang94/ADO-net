using ConsoleApp5;
using Microsoft.Data.Sqlite;

Constans C = new Constans();

File.Create(path:Constans.DatabaseFile).Close();

using (SqliteConnection databaseConnection = new SqliteConnection(Constans.DatabaseConnectionString))
{
    databaseConnection.Open();

    using (var command = databaseConnection.CreateCommand())
    {
        command.CommandType = System.Data.CommandType.Text;
        command.CommandText = "CREATE TABLE Brent (ID INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT, Name Text(50), Number INT, Data DATE);" +
                              "CREATE TABLE Gold (ID INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT, Name Text(50), Number INT, Data DATE);" +
                              "CREATE TABLE RTS (ID INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT, Name Text(50), Number INT, Data DATE);";

        command.ExecuteNonQuery();

        command.CommandText = C.SetTable();
        command.ExecuteNonQuery();

        command.CommandText = C.SetTable();
        command.ExecuteNonQuery();

        command.CommandText = C.SetTable();
        command.ExecuteNonQuery();

    }

    databaseConnection.Close();
}
