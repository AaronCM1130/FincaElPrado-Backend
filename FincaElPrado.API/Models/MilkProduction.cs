using System;
using System.Collections.Generic;


namespace FincaElPrado.API.Models
{
    public class MilkProduction
    {
        public int IdMilkProduction { get; set; }
        public int AnimalId { get; set; }
        public double QuantityProduction { get; set; }
        public DateTime DateProduction { get; set; }
        public string Description { get; set; }

        public Animal Animal { get; set; }

    }
}
