using OnlyZoo.DAO;
using OnlyZoo.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlyZoo.util
{
    internal class DataBuffer
    {
        public List<Pet> PetCollection { get; private set; }
        public List<Breed> BreedCollection { get; private set; }
        private static DataBuffer Instance { get; set; }
        private DataBuffer() {
            LoadData();
        }
        public static DataBuffer GetInstance()
        {
            if (Instance == null) Instance = new DataBuffer();
            return Instance;
        }
        private void LoadData()
        {
            PetCollection = PetDAO.GetInstance().GetAll();
            BreedCollection = BreedDAO.GetInstance().GetAll();
        }
        public Breed GetBreed(Pet mascota)
        {
            return BreedCollection.FirstOrDefault(b => b.Id == mascota.Breed);
        }
    }
}
