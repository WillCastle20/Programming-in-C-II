using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * William Castellanos
 * CST-250
 * 01/16/2026
 * Car Class Library
 * Homework
 */

namespace VehicleClassLibrary.Models
{
    public class CarModel : VehicleModel
    {
        public bool IsConvertible { get; set; }
        public decimal TrunkSize { get; set; }


        public override string ToString()
        {
            return base.ToString() +
                   $" | Convertible: {IsConvertible} | Trunk Size: {TrunkSize}";
        }


    }
}
