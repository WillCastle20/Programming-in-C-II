/*
 * William Castellanos
 * CST-250
 * 01/16/2026
 * Car Class Library
 * Homework
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace VehicleClassLibrary.Models
{
    /// <summary>
    /// Represents a car in the vehicle store.
    /// </summary>
    public class CarModel : VehicleModel
    {
        /// <summary>
        /// Gets or sets whether the car is convertible.
        /// </summary>
        public bool IsConvertible { get; set; }

        /// <summary>
        /// Gets or sets the trunk size of the car.
        /// </summary>
        public decimal TrunkSize { get; set; }

        /// <summary>
        /// Default constructor for CarModel.
        /// </summary>
        public CarModel() : base()
        {
            IsConvertible = false;
            TrunkSize = 0.0m;
        }

        /// <summary>
        /// Parameterized constructor for CarModel.
        /// </summary>
        public CarModel(int id, string make, string model, int year, decimal price, int numWheels,
            bool isConvertible, decimal trunkSize)
            : base(id, make, model, year, price, numWheels)
        {
            IsConvertible = isConvertible;
            TrunkSize = trunkSize;
        }

        /// <summary>
        /// Returns a formatted string for the car.
        /// </summary>
        /// <returns>A formatted car string.</returns>
        public override string ToString()
        {
            return base.ToString() + $" | Convertible: {IsConvertible} | Trunk Size: {TrunkSize}";
        }
    }
}