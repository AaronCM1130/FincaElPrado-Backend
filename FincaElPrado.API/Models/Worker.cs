using System;
using System.Collections.Generic;


namespace fincaElPrado.API.Models

{
    public class Worker
    {
        public string IdWorker { get; set; }
        public string FullName { get; set; }
        public string Role { get; set; }
        public string phoneNumber { get; set; }

        public ICollection<Treatment> Treatments { get; set; }

    }

}