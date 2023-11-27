using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlyZoo.models
{
    public class Breed
    {
        public Guid Id { get; private set; }
        public string Species { get; set; }
        public string Kind { get; set; }
        public Breed(Guid id, string species, string kind)
        {
            Id = id;
            Species = species;
            Kind = kind;
        }
        public Breed(string species, string kind)
        {
            Id = Guid.NewGuid();
            Species = species;
            Kind = kind;
        }
        public Breed(){}
    }
}
