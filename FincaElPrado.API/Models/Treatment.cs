using System;
using System.Collections.Generic;


namespace FincaElPrado.API.Models
{
    public class Treatment
    {
        public int IdTreatment { get; set; }
        public int HealthRecordId { get; set; }
        public HealthRecord HealthRecord { get; set; }

        public int WorkerId { get; set; }
        public Worker Worker { get; set; }

        public string Description { get; set; }
        public DateTime ApplicationDate { get; set; }

        public ICollection<Product> Products { get; set; }
    }
}
