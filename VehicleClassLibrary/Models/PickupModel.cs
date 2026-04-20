using System;
/*
 * William Castellanos
 * CST-250
 * Activity 1
 * 4/20/2026
 * Citation: Grand Canyon University CST-250 Activity 1 Guide
 */

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
