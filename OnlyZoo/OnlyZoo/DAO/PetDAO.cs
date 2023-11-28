﻿using MySql.Data.MySqlClient;
using OnlyZoo.drivers;
using OnlyZoo.util;
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
        public List<Pet> getAll(object obj)
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
                            Pet pet = new Pet
                            {
                                Id = Convert.ToInt32(reader["Id"]),
                                Name = reader["Name"].ToString(),
                                Description = reader["Description"].ToString(),
                                Breed = Convert.ToInt32(reader["Breed"])
                            };
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

        public bool insertObject(Pet obj)
        {
            try
            {
                string query = "INSERT INTO Pet (Id, Name, Description, BreedId) VALUES (@Id, @Name, @Description, @Breed)";

                using (MySqlCommand cmd = new MySqlCommand(query, DBConnection.GetConnection()))
                {
                    cmd.Parameters.AddWithValue("@Id", obj.Id);
                    cmd.Parameters.AddWithValue("@Name", obj.Name);
                    cmd.Parameters.AddWithValue("@Description", obj.Description);
                    cmd.Parameters.AddWithValue("@Breed", obj.Breed);
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

        public Pet selectObject(string uuid)
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
                            pet = new Pet
                            {
                                Id = uuid,
                                Name = reader["Name"].ToString(),
                                Description = reader["Description"].ToString(),
                                Breed = Convert.ToInt32(reader["Breed"])
                            };
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

        public Pet updateObject(Pet obj)
        {
            try
            {
                string query = "UPDATE Pet SET Name = @Name, Description = @Description, Breed = @Breed WHERE Id = @Id";
                using (MySqlCommand cmd = new MySqlCommand(query, DBConnection.GetConnection()))
                {
                    cmd.Parameters.AddWithValue("@Id", obj.Id);
                    cmd.Parameters.AddWithValue("@Name", obj.Name);
                    cmd.Parameters.AddWithValue("@Description", obj.Description);
                    cmd.Parameters.AddWithValue("@Breed", obj.Breed);

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