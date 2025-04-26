using System;
using System.Collections.Generic;

namespace FincaElPrado.API.Models
{
    public class Breed
    {
        public int Id { get; set; }
        public string Name { get; set; }


        public ICollection<Animal> Animals { get; set; }
    }
}
