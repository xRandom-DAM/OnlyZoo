using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlyZoo.models
{
    public class Pet
    {
        public Guid Id { get; private set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Guid Breed { get; set; }
        public Pet(Guid id, string name, string description, Guid breed) {
            Id = id;
            Name = name;
            Description = description;
            Breed = breed;
        }
        public Pet(string name, string description, Guid breed)
        {
            Id = Guid.NewGuid();
            Name = name;
            Description = description;
            Breed = breed;
        }
        public Pet() { }
    }
}
