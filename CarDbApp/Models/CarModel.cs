using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarDbApp.Models
{
    public class CarModel
    {
        public int CarId { get; set; } = 0;
        public int State { get; set; }
        public string Spz { get; set; }
        public string Model { get; set; }
        public DateTime LastUpdate { get; set; }
        public string FirstDriver { get; set; }
        public bool Exists { get; set; }
        public bool Error { get; set; }

        public int Line { get; set; }
    }
}
