/*
 * William Castellanos
 * CST-250
 * Activity 1
 * 4/20/2026
 * Citation: Grand Canyon University CST-250 Activity 1 Guide
 */

using System.Collections.Generic;
using VehicleClassLibrary.Models;
using VehicleClassLibrary.Services.DataAccessLayer;

namespace VehicleClassLibrary.Services.BusinessLogicLayer
{
    /// <summary>
    /// Handles business logic for the vehicle store application.
    /// </summary>
    public class StoreLogic
    {
        private StoreDAO _storeDAO;

        /// <summary>
        /// Default constructor for StoreLogic.
        /// </summary>
        public StoreLogic()
        {
            _storeDAO = new StoreDAO();
        }

        /// <summary>
        /// Returns the inventory list.
        /// </summary>
        /// <returns>The inventory list.</returns>
        public List<VehicleModel> GetInventory()
        {
            return _storeDAO.GetInventory();
        }

        /// <summary>
        /// Returns the shopping cart list.
        /// </summary>
        /// <returns>The shopping cart list.</returns>
        public List<VehicleModel> GetShoppingCart()
        {
            return _storeDAO.GetShoppingCart();
        }

        /// <summary>
        /// Adds a vehicle to inventory.
        /// </summary>
        /// <param name="vehicle">The vehicle to add.</param>
        /// <returns>The assigned vehicle ID.</returns>
        public int AddVehicleToInventory(VehicleModel vehicle)
        {
            return _storeDAO.AddVehicleToInventory(vehicle);
        }

        /// <summary>
        /// Adds a vehicle to the cart by vehicle ID.
        /// </summary>
        /// <param name="id">The vehicle ID.</param>
        /// <returns>The number of items in the shopping cart.</returns>
        public int AddVehicleToCart(int id)
        {
            return _storeDAO.AddVehicleToCart(id);
        }

        /// <summary>
        /// Writes the inventory to a file.
        /// </summary>
        /// <returns>True if successful; otherwise false.</returns>
        public bool WriteInventory()
        {
            return _storeDAO.WriteInventory();
        }

        /// <summary>
        /// Reads the inventory from a file.
        /// </summary>
        /// <returns>The loaded inventory list.</returns>
        public List<VehicleModel> ReadInventory()
        {
            return _storeDAO.ReadInventory();
        }

        /// <summary>
        /// Checks out the shopping cart and returns the total.
        /// </summary>
        /// <returns>The checkout total.</returns>
        public decimal Checkout()
        {
            return _storeDAO.Checkout();
        }
    }
}