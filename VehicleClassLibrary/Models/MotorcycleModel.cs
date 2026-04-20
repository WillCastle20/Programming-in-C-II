/*
 * William Castellanos
 * CST-250
 * Activity 1
 * 4/20/2026
 * Citation: Grand Canyon University CST-250 Activity 1 Guide
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleClassLibrary.Models
{
    public class MotorcycleModel : VehicleModel
    {
        public bool HasSidecar { get; set; }
        public int EngineCc { get; set; }


        public override string ToString()
        {
            return base.ToString() +
                   $" | Sidecar: {HasSidecar} | Engine CC: {EngineCc}";
        }

    }
}
