using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlyZoo.models
{
    internal class Tag
    {
        public Guid Id { get; private set; }
        public string Name { get; set; }
        public Tag(Guid id, string name) {
            Id = id;
            Name = name;
        }
        public Tag(string name)
        {
            Id = Guid.NewGuid();
            Name = name;
        }
        public Tag() { }
    }
}
