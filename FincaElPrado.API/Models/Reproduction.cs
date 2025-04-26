using System;
using System.Collections.Generic;


namespace FincaElPrado.API.Models
{
    public class Reproduction
    {
        public int IdReproduction { get; set; }
        public string Description { get; set; }
        public string ReproductionType { get; set; }
        public DateTime ReproductionDate { get; set; }
        public DateTime ExpectedBirthDate { get; set; }

        public int AnimalId { get; set; }

        public Animal Animal { get; set; }
    }
}
