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
    /// Represents a general vehicle in the store inventory.
    /// </summary>
    public class VehicleModel
    {
        /// <summary>
        /// Gets or sets the vehicle ID.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the make of the vehicle.
        /// </summary>
        public string Make { get; set; }

        /// <summary>
        /// Gets or sets the model of the vehicle.
        /// </summary>
        public string Model { get; set; }

        /// <summary>
        /// Gets or sets the year of the vehicle.
        /// </summary>
        public int Year { get; set; }

        /// <summary>
        /// Gets or sets the price of the vehicle.
        /// </summary>
        public decimal Price { get; set; }

        /// <summary>
        /// Gets or sets the number of wheels.
        /// </summary>
        public int NumWheels { get; set; }

        /// <summary>
        /// Default constructor for VehicleModel.
        /// </summary>
        public VehicleModel()
        {
            Id = 0;
            Make = "Unknown";
            Model = "Unknown";
            Year = 0;
            Price = 0.0m;
            NumWheels = 0;
        }

        /// <summary>
        /// Parameterized constructor for VehicleModel.
        /// </summary>
        public VehicleModel(int id, string make, string model, int year, decimal price, int numWheels)
        {
            Id = id;
            Make = make;
            Model = model;
            Year = year;
            Price = price;
            NumWheels = numWheels;
        }

        /// <summary>
        /// Returns a formatted string for the vehicle.
        /// </summary>
        /// <returns>A formatted vehicle string.</returns>
        public override string ToString()
        {
            return $"{Id}: {Year} {Make} {Model} with {NumWheels} wheels - {Price:C2}";
        }
    }
}
