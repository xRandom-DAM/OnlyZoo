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
        public string Picture {get; set; }
        public Pet(Guid id, string name, string description, Guid breed, string picture)
        {
            Id = id;
            Name = name;
            Description = description;
            Breed = breed;
            Picture = picture;
        }
        public Pet(string name, string description, Guid breed, string picture)
        {
            Id = Guid.NewGuid();
            Name = name;
            Description = description;
            Breed = breed;
            Picture = picture;
        }
        public Pet() { }
    }
}
