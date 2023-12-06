using MySql.Data.MySqlClient;
using OnlyZoo.drivers;
using OnlyZoo.models;
using OnlyZoo.util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlyZoo.DAO
{
    public class BreedDAO : DAO<Breed>
    {
        private static BreedDAO Instance { get; set; }
        private BreedDAO() { }
        public static BreedDAO GetInstance()
        {
            if (Instance == null) Instance = new BreedDAO();
            return Instance;
        }
        public List<Breed> GetAll()
        {
            List<Breed> breeds = new List<Breed>();
            try
            {
                string query = "SELECT * FROM Breed";

                using (MySqlCommand cmd = new MySqlCommand(query, DBConnection.GetConnection()))
                {
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Breed breed = new Breed(
                                reader.GetGuid(Constants.BreedIdColumnName),
                                reader.GetString(Constants.BreedSpeciesColumnName),
                                reader.GetString(Constants.BreedKindColumnName)
                                );
                            breeds.Add(breed);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                ErrorManager.Register(ex);
            }
            finally
            {
                DBConnection.Close();
            }

            return breeds;
        }

        public bool InsertObject(Breed obj)
        {
            try
            {
                string query = "INSERT INTO Breed (Id, Species, Kind) VALUES (@Id, @Species, @Kind)";

                using (MySqlCommand cmd = new MySqlCommand(query, DBConnection.GetConnection()))
                {
                    cmd.Parameters.AddWithValue("@Id", obj.Id);
                    cmd.Parameters.AddWithValue("@Species", obj.Species);
                    cmd.Parameters.AddWithValue("@Kind", obj.Kind);
                    cmd.ExecuteNonQuery();
                }
                DBConnection.Close();
                return true;
            }
            catch (Exception ex)
            {
                ErrorManager.Register(ex);
            }
            DBConnection.Close();
            return false;
        }

        public Breed SelectObject(Guid id)
        {
            Breed breed = null;
            try
            {
                string query = "SELECT * FROM Breed WHERE Id = @Id";
                using (MySqlCommand cmd = new MySqlCommand(query, DBConnection.GetConnection()))
                {
                    cmd.Parameters.AddWithValue("@Id", id);
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            breed = new Breed(
                                reader.GetGuid(Constants.BreedIdColumnName),
                                reader.GetString(Constants.BreedSpeciesColumnName),
                                reader.GetString(Constants.BreedKindColumnName)
                                );
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error en SelectObject: {ex.Message}");
            }
            finally
            {
                DBConnection.Close();
            }
            return breed;
        }

        public Breed UpdateObject(Breed obj)
        {
            try
            {
                string query = "UPDATE Breed SET Species = @Species, Kind = @Kind WHERE Id = @Id";
                using (MySqlCommand cmd = new MySqlCommand(query, DBConnection.GetConnection()))
                {
                    cmd.Parameters.AddWithValue("@Id", obj.Id);
                    cmd.Parameters.AddWithValue("@Species", obj.Species);
                    cmd.Parameters.AddWithValue("@Kind", obj.Kind);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error en UpdateObject: {ex.Message}");
            }
            finally
            {
                DBConnection.Close();
            }
            return obj;
        }
    }
}