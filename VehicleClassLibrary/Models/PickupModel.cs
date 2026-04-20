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
    /// <summary>
    /// Represents a pickup truck in the vehicle store.
    /// </summary>
    public class PickupModel : VehicleModel
    {
        /// <summary>
        /// Gets or sets whether the pickup has a bed cover.
        /// </summary>
        public bool HasBedCover { get; set; }

        /// <summary>
        /// Gets or sets the bed size of the pickup.
        /// </summary>
        public decimal BedSize { get; set; }

        /// <summary>
        /// Default constructor for PickupModel.
        /// </summary>
        public PickupModel() : base()
        {
            HasBedCover = false;
            BedSize = 0.0m;
        }

        /// <summary>
        /// Parameterized constructor for PickupModel.
        /// </summary>
        public PickupModel(int id, string make, string model, int year, decimal price, int numWheels,
            bool hasBedCover, decimal bedSize)
            : base(id, make, model, year, price, numWheels)
        {
            HasBedCover = hasBedCover;
            BedSize = bedSize;
        }

        /// <summary>
        /// Returns a formatted string for the pickup.
        /// </summary>
        /// <returns>A formatted pickup string.</returns>
        public override string ToString()
        {
            return base.ToString() + $" | Bed Cover: {HasBedCover} | Bed Size: {BedSize}";
        }
    }
}