using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleClassLibrary.Models
{
    public class PickupModel : VehicleModel
    {
        public decimal BedLength { get; set; }
        public bool FourWheelDrive { get; set; }
    }
}
