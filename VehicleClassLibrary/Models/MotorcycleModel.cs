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
