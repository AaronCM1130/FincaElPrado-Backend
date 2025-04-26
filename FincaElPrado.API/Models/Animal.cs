using System;
using System.Collections.Generic;

namespace FincaElPrado.API.Models
{
    public class Animal
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime BirthDate { get; set; }
        public string Gender { get; set; }

        
        public int BreedId { get; set; }

        public Breed Breeds { get; set; }
        

        public ICollection<MilkProduction> MilkProductions { get; set; }
        public ICollection<HealthRecord> HealthRecords { get; set; }
        public ICollection<Reproduction> Reproductions { get; set; }
       

    }
}
