using System;
using System.Collections.Generic;

namespace FincaElPrado.API.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }  // Medicamento, Vacuna, Suplemento
        public DateTime ExpirationDate { get; set; }
        public int Stock { get; set; }

        public ICollection<Treatment> Treatments { get; set; }
    }
}
