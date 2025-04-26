using System;
using System.Collections.Generic;


namespace FincaElPrado.API.Models
{
    public class InventoryMovement
    {
        public int Id { get; set; }

        public int ProductId { get; set; }
        public Product Product { get; set; }

        public int Quantity { get; set; }
        public string Type { get; set; }  // Entrada / Salida
        public DateTime Date { get; set; }

    }
}
