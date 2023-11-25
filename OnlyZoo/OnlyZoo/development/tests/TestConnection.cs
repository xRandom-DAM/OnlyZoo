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
            string query = "CREATE TABLE IF NOT EXISTS TESTS (Number INT)";
            try
            {
                using (MySqlConnection connection = DBConnection.GetConnection())
                {
                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        // Ejecutar la consulta
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

        public static bool Insert()
        {
            int number = 69;
            string query = "INSERT INTO TESTS VALUES (@number)";
            try
            {
                using (MySqlConnection connection = DBConnection.GetConnection())
                {
                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@number", number);

                        // Ejecutar la consulta
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
            string query = "SELECT * FROM TESTS";
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
                                Console.WriteLine(reader.GetInt32("Number"));
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
