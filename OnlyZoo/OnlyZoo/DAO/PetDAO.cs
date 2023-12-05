using MySql.Data.MySqlClient;
using OnlyZoo.drivers;
using OnlyZoo.util;
using OnlyZoo.models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlyZoo.DAO
{
    public class PetDAO : DAO<Pet>
    {
        public List<Pet> GetAll(object obj)
        {
            List<Pet> pets = new List<Pet>();
            try
            {
                string query = "SELECT * FROM Pet";

                using (MySqlCommand cmd = new MySqlCommand(query, DBConnection.GetConnection()))
                {
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Pet pet = new Pet(reader.GetGuid("Id"), reader.GetString("Name"), reader.GetDateTime("Birth"), reader.GetString("Description"), reader.GetGuid("Bread"), reader.GetString("Picture"));
                            pets.Add(pet);
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

            return pets;
        }

        public bool InsertObject(Pet obj)
        {
            try
            {
                string query = "INSERT INTO Pet (Id, Name, Birth, Description, BreedId) VALUES (@Id, @Name, @Birth, @Description, @Breed, @Picture)";

                using (MySqlCommand cmd = new MySqlCommand(query, DBConnection.GetConnection()))
                {
                    cmd.Parameters.AddWithValue("@Id", obj.Id);
                    cmd.Parameters.AddWithValue("@Name", obj.Name);
                    cmd.Parameters.AddWithValue("@Birth", obj.Birth.ToString());
                    cmd.Parameters.AddWithValue("@Description", obj.Description);
                    cmd.Parameters.AddWithValue("@Breed", obj.Breed);
                    cmd.Parameters.AddWithValue("@Picture", obj.Picture);
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

        public Pet SelectObject(Guid uuid)
        {
            Pet pet = null;
            try
            {
                string query = "SELECT * FROM PetTable WHERE UUID = @UUID";
                using (MySqlCommand cmd = new MySqlCommand(query, DBConnection.GetConnection()))
                {
                    cmd.Parameters.AddWithValue("@UUID", uuid);
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            pet = new Pet(uuid, reader.GetString("Name"), reader.GetDateTime("Birth"), reader.GetString("Description"), reader.GetGuid("Bread"), reader.GetString("Picture"));
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error en selectObject: {ex.Message}");
            }
            finally
            {
                DBConnection.Close();
            }
            return pet;
        }

        public Pet UpdateObject(Pet obj)
        {
            try
            {
                string query = "UPDATE Pet SET Name = @Name, Description = @Description, Breed = @Breed, Picture = @Picture WHERE Id = @Id";
                using (MySqlCommand cmd = new MySqlCommand(query, DBConnection.GetConnection()))
                {
                    cmd.Parameters.AddWithValue("@Id", obj.Id);
                    cmd.Parameters.AddWithValue("@Name", obj.Name);
                    cmd.Parameters.AddWithValue("@Description", obj.Description);
                    cmd.Parameters.AddWithValue("@Breed", obj.Breed);
                    cmd.Parameters.AddWithValue("@Picture", obj.Picture);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error en updateObject: {ex.Message}");
            }
            finally
            {
                DBConnection.Close();
            }
            return obj;
        }
    }
}
