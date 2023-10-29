using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Net.NetworkInformation;

namespace DashboardApp.DB
{
    internal class DB
    {
        private string connectionString;

        public DB(string dbPath)
        {
            // Configurar a string de conexão com base no caminho do banco de dados
            connectionString = $"Data Source={dbPath}";
        }

        public void CreateDatabase()
        {
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                string createTableSQL = "CREATE TABLE IF NOT EXISTS Manutencao (" +
        "ID INTEGER PRIMARY KEY," +
        "Area TEXT," +
        "TotalDispositivos INTEGER," +
        "Operacional INTEGER," +
        "Inoperante INTEGER," +
        "PercentualOperante REAL," +
        "PercentualInoperante REAL" +
        ");";

                using (SQLiteCommand cmd = new SQLiteCommand(createTableSQL, connection))
                {
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void InsertData(string tableName, string data)
        {
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                using (SQLiteCommand cmd = new SQLiteCommand($"INSERT INTO {tableName} (Data) VALUES (@Data)", connection))
                {
                    cmd.Parameters.AddWithValue("@Data", data);
                    cmd.ExecuteNonQuery();
                }
            }
        }

       
    }
}

