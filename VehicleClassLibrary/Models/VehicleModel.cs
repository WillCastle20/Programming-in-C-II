using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleClassLibrary.Models
{
    // Base class for vehicles (used in inventory list)
    public abstract class VehicleModel
    {
        public int Id { get; set; }
        public string Make { get; set; } = "";
        public string Model { get; set; } = "";
        public int Year { get; set; }
        public decimal Price { get; set; }
        public int NumWheels { get; set; }

        public override string ToString()
        {
            return $"Id: {Id} | {Year} {Make} {Model} | ${Price} | Wheels: {NumWheels}";
        }

    }
}
