using MySql.Data.MySqlClient;
using MySqlX.XDevAPI;
using OnlyZoo.drivers;
using OnlyZoo.models;
using OnlyZoo.util;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlyZoo.development.tests
{
    internal class TestConnection
    {
        public static bool Create()
        {
           
            ArrayList arrayList = new ArrayList();

            arrayList.Add("DROP TABLE IF EXISTS USER");
            arrayList.Add("DROP TABLE IF EXISTS User");
            arrayList.Add("CREATE TABLE User (EMAIL VARCHAR(30) PRIMARY KEY, USERNAME VARCHAR(15) NOT NULL, PASSWORD_HASH VARCHAR(64) NOT NULL)");
            arrayList.Add("DROP TABLE IF EXISTS Tag");
            arrayList.Add("CREATE TABLE IF NOT EXISTS Tag ( Id CHAR(36) PRIMARY KEY  NOT NULL, Name VARCHAR(50) NOT NULL, Breed VARCHAR(50))");
            arrayList.Add("DROP TABLE IF EXISTS Breed");
            arrayList.Add("CREATE TABLE IF NOT EXISTS Breed ( Id CHAR(36) PRIMARY KEY  NOT NULL, Kind VARCHAR (50) NOT NULL, Species VARCHAR (50) NOT NULL )");
            arrayList.Add("DROP TABLE IF EXISTS Pet");
            arrayList.Add("CREATE TABLE IF NOT EXISTS Pet ( Id CHAR(36) PRIMARY KEY , Name VARCHAR(50), Birth DATE, breed INTEGER REFERENCES Breed (id), Description VARCHAR (250), Picture VARCHAR (250))");

            try
            {
                foreach (string item in arrayList)
                {
                    Sqlconnection(item);
                }

                DBConnection.Close();
                return true;
            }
            catch (MySqlException mysqlEx)
            {
                ErrorManager.Register(mysqlEx);
                DBConnection.Close();
                return false;
            }
            catch (Exception ex)
            {
                ErrorManager.Register(ex);
                DBConnection.Close();
                return false;
            }
        }

        public static void Sqlcommand(String sentence, MySqlConnection connection)
        {
            using (MySqlCommand cmd = new MySqlCommand(sentence, connection))
            {
                cmd.ExecuteNonQuery();
            }
        }

        public static void Sqlconnection(String sentence)
        {
            using (MySqlConnection connection = DBConnection.GetConnection())
            {
                Sqlcommand(sentence,connection);
            }
        }

        public static bool Insert()
        {
            string query = "INSERT INTO User VALUES (@email, @username, @password)";
            try
            {
                using (MySqlConnection connection = DBConnection.GetConnection())
                {
                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@email", "prueba@prueba.com");
                        cmd.Parameters.AddWithValue("@username", "prueba");
                        cmd.Parameters.AddWithValue("@password", PasswordEncrypter.Hash("prueba"));
                        cmd.ExecuteNonQuery();
                    }
                }
                DBConnection.Close();
                return true;
            }
            catch (MySqlException mysqlEx)
            {
                ErrorManager.Register(mysqlEx);
                DBConnection.Close();
                return false;
            }
            catch (Exception ex)
            {
                ErrorManager.Register(ex);
                DBConnection.Close();
                return false;
            }
        }

        public static bool Select()
        {
            string query = "SELECT * FROM User";
            try
            {
                using (MySqlConnection connection = DBConnection.GetConnection())
                {
                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                // Agregar cada número a la lista
                                Console.WriteLine(reader.GetString("Email"));
                            }
                        }
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                ErrorManager.Register(ex);
                DBConnection.Close();
                return false; // O manejar el error según sea necesario en tu aplicación
            }
        }
    }
}
