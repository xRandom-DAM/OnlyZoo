using MySql.Data.MySqlClient;
using MySqlX.XDevAPI;
using OnlyZoo.drivers;
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
            arrayList.Add("CREATE TABLE USER (EMAIL VARCHAR(30) PRIMARY KEY, USERNAME VARCHAR(15) NOT NULL, PASSWORD_HASH VARCHAR(64) NOT NULL)");
            arrayList.Add("DROP TABLE IF EXISTS Tag");
            arrayList.Add("CREATE TABLE IF NOT EXISTS Tag ( id INT PRIMARY KEY  NOT NULL, name VARCHAR(50) NOT NULL,tipo VARCHAR(50))");
            arrayList.Add("DROP TABLE IF EXISTS Breed");
            arrayList.Add("CREATE TABLE IF NOT EXISTS Breed  ( id INT PRIMARY KEY  NOT NULL, kind VARCHAR (50) NOT NULL, species VARCHAR (50) NOT NULL )");
            arrayList.Add("DROP TABLE IF EXISTS Pet");
            arrayList.Add("CREATE TABLE IF NOT EXISTS Pet ( id INT PRIMARY KEY , name VARCHAR(50), birth_date  DATE, breed INTEGER REFERENCES Breed (id), description VARCHAR (250))");

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
            string query = "INSERT INTO USER VALUES (@email, @username, @password)";
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
            string query = "SELECT * FROM USER";
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
