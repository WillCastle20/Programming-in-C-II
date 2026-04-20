/*
 * William Castellanos
 * CST-250
 * Activity 1
 * 4/20/2026
 * Citation: Grand Canyon University CST-250 Activity 1 Guide
 */

using System;
using System.Collections.Generic;
using System.IO;
using VehicleClassLibrary.Models;

namespace VehicleClassLibrary.Services.DataAccessLayer
{
    /// <summary>
    /// Handles data access for the vehicle store inventory and shopping cart.
    /// </summary>
    public class StoreDAO
    {
        private List<VehicleModel> _inventory;
        private List<VehicleModel> _shoppingCart;
        private string _directory;
        private string _filePath;

        /// <summary>
        /// Default constructor for StoreDAO.
        /// </summary>
        public StoreDAO()
        {
            _inventory = new List<VehicleModel>();
            _shoppingCart = new List<VehicleModel>();
            _directory = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Data");
            _filePath = Path.Combine(_directory, "inventory.txt");
        }

        /// <summary>
        /// Returns the inventory list.
        /// </summary>
        /// <returns>The inventory list.</returns>
        public List<VehicleModel> GetInventory()
        {
            return _inventory;
        }

        /// <summary>
        /// Returns the shopping cart list.
        /// </summary>
        /// <returns>The shopping cart list.</returns>
        public List<VehicleModel> GetShoppingCart()
        {
            return _shoppingCart;
        }

        /// <summary>
        /// Adds a vehicle to the inventory and assigns an ID.
        /// </summary>
        /// <param name="vehicle">The vehicle to add.</param>
        /// <returns>The assigned vehicle ID.</returns>
        public int AddVehicleToInventory(VehicleModel vehicle)
        {
            vehicle.Id = _inventory.Count + 1;
            _inventory.Add(vehicle);
            return vehicle.Id;
        }

        /// <summary>
        /// Adds a vehicle from inventory to the shopping cart by ID.
        /// </summary>
        /// <param name="id">The vehicle ID.</param>
        /// <returns>The number of items now in the shopping cart.</returns>
        public int AddVehicleToCart(int id)
        {
            foreach (VehicleModel vehicle in _inventory)
            {
                if (vehicle.Id == id)
                {
                    _shoppingCart.Add(vehicle);
                    break;
                }
            }

            return _shoppingCart.Count;
        }

        /// <summary>
        /// Writes the inventory to a text file.
        /// </summary>
        /// <returns>True if successful; otherwise false.</returns>
        public bool WriteInventory()
        {
            try
            {
                if (!Directory.Exists(_directory))
                {
                    Directory.CreateDirectory(_directory);
                }

                using (StreamWriter writer = new StreamWriter(_filePath))
                {
                    foreach (VehicleModel vehicle in _inventory)
                    {
                        string line = "";

                        if (vehicle is CarModel car)
                        {
                            line = $"Car|{car.Make}|{car.Model}|{car.Year}|{car.Price}|{car.NumWheels}|{car.IsConvertible}|{car.TrunkSize}";
                        }
                        else if (vehicle is MotorcycleModel motorcycle)
                        {
                            line = $"Motorcycle|{motorcycle.Make}|{motorcycle.Model}|{motorcycle.Year}|{motorcycle.Price}|{motorcycle.NumWheels}|{motorcycle.HasSideCar}|{motorcycle.SeatHeight}";
                        }
                        else if (vehicle is PickupModel pickup)
                        {
                            line = $"Pickup|{pickup.Make}|{pickup.Model}|{pickup.Year}|{pickup.Price}|{pickup.NumWheels}|{pickup.HasBedCover}|{pickup.BedSize}";
                        }
                        else
                        {
                            line = $"Vehicle|{vehicle.Make}|{vehicle.Model}|{vehicle.Year}|{vehicle.Price}|{vehicle.NumWheels}";
                        }

                        writer.WriteLine(line);
                    }
                }

                return true;
            }
            catch
            {
                return false;
            }
        } // End WriteInventory

        /// <summary>
        /// Reads the inventory from a text file.
        /// </summary>
        /// <returns>The loaded inventory list.</returns>
        public List<VehicleModel> ReadInventory()
        {
            string? line;
            string[] parts;

            string make;
            string model;
            int year;
            decimal price;
            int numWheels;

            bool specialtyBoolean;
            decimal specialtyDecimal;

            _inventory.Clear();

            if (!File.Exists(_filePath))
            {
                return _inventory;
            }

            try
            {
                using (StreamReader reader = new StreamReader(_filePath))
                {
                    while ((line = reader.ReadLine()) != null)
                    {
                        parts = line.Split('|');

                        if (parts.Length < 6)
                        {
                            continue;
                        }

                        make = parts[1];
                        model = parts[2];
                        year = ParseInteger(parts[3]);
                        price = ParseDecimal(parts[4]);
                        numWheels = ParseInteger(parts[5]);

                        if (parts[0] == "Car" && parts.Length >= 8)
                        {
                            specialtyBoolean = ParseBoolean(parts[6]);
                            specialtyDecimal = ParseDecimal(parts[7]);

                            AddVehicleToInventory(new CarModel(0, make, model, year, price, numWheels, specialtyBoolean, specialtyDecimal));
                        }
                        else if (parts[0] == "Motorcycle" && parts.Length >= 8)
                        {
                            specialtyBoolean = ParseBoolean(parts[6]);
                            specialtyDecimal = ParseDecimal(parts[7]);

                            AddVehicleToInventory(new MotorcycleModel(0, make, model, year, price, numWheels, specialtyBoolean, specialtyDecimal));
                        }
                        else if (parts[0] == "Pickup" && parts.Length >= 8)
                        {
                            specialtyBoolean = ParseBoolean(parts[6]);
                            specialtyDecimal = ParseDecimal(parts[7]);

                            AddVehicleToInventory(new PickupModel(0, make, model, year, price, numWheels, specialtyBoolean, specialtyDecimal));
                        }
                        else
                        {
                            AddVehicleToInventory(new VehicleModel(0, make, model, year, price, numWheels));
                        }
                    }
                }
            }
            catch
            {
                return _inventory;
            }

            return _inventory;
        } // End ReadInventory

        /// <summary>
        /// Safely parses an integer value.
        /// </summary>
        /// <param name="input">The string input to parse.</param>
        /// <returns>The parsed integer, or 0 if parsing fails.</returns>
        private int ParseInteger(string input)
        {
            try
            {
                return int.Parse(input);
            }
            catch
            {
                return 0;
            }
        }

        /// <summary>
        /// Safely parses a decimal value.
        /// </summary>
        /// <param name="input">The string input to parse.</param>
        /// <returns>The parsed decimal, or 0.0m if parsing fails.</returns>
        private decimal ParseDecimal(string input)
        {
            try
            {
                return decimal.Parse(input);
            }
            catch
            {
                return 0.0m;
            }
        }

        /// <summary>
        /// Safely parses a Boolean value.
        /// </summary>
        /// <param name="input">The string input to parse.</param>
        /// <returns>The parsed Boolean, or false if parsing fails.</returns>
        private bool ParseBoolean(string input)
        {
            try
            {
                return bool.Parse(input);
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// Calculates the total cost of the shopping cart and clears it.
        /// </summary>
        /// <returns>The total cost.</returns>
        public decimal Checkout()
        {
            decimal total = 0.0m;

            foreach (VehicleModel vehicle in _shoppingCart)
            {
                total += vehicle.Price;
            }

            _shoppingCart.Clear();
            return total;
        }
    }
}