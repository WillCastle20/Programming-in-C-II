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
    /// <summary>
    /// Represents a motorcycle in the vehicle store.
    /// </summary>
    public class MotorcycleModel : VehicleModel
    {
        /// <summary>
        /// Gets or sets whether the motorcycle has a side car.
        /// </summary>
        public bool HasSideCar { get; set; }

        /// <summary>
        /// Gets or sets the seat height of the motorcycle.
        /// </summary>
        public decimal SeatHeight { get; set; }

        /// <summary>
        /// Default constructor for MotorcycleModel.
        /// </summary>
        public MotorcycleModel() : base()
        {
            HasSideCar = false;
            SeatHeight = 0.0m;
        }

        /// <summary>
        /// Parameterized constructor for MotorcycleModel.
        /// </summary>
        public MotorcycleModel(int id, string make, string model, int year, decimal price, int numWheels,
            bool hasSideCar, decimal seatHeight)
            : base(id, make, model, year, price, numWheels)
        {
            HasSideCar = hasSideCar;
            SeatHeight = seatHeight;
        }

        /// <summary>
        /// Returns a formatted string for the motorcycle.
        /// </summary>
        /// <returns>A formatted motorcycle string.</returns>
        public override string ToString()
        {
            return base.ToString() + $" | Side Car: {HasSideCar} | Seat Height: {SeatHeight}";
        }
    }
}