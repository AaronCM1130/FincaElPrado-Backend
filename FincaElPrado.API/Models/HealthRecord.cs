using System;
using System.Collections.Generic;

namespace FincaElPrado.API.Models
{
    public class HealthRecord
    {
        public int IdHealthRecord  { get; set; }
        public int AnimalId { get; set; }
        public Animal Animal { get; set; }

        public DateTime DateHealthRecord { get; set; }
        public string Notes { get; set; }

        public ICollection<Treatment> Treatments { get; set; }
    }
}
