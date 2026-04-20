/*
 * William Castellanos
 * CST-250
 * Activity 1
 * 4/20/2026
 * Citation: Grand Canyon University CST-250 Activity 1 Guide
 */

using System.Collections.Generic;
using VehicleClassLibrary.Models;

namespace VehicleClassLibrary.Services.DataAccessLayer
{
    public class StoreDAO
    {
        private readonly List<VehicleModel> _inventory = new();
        private readonly List<VehicleModel> _shoppingCart = new();

        // Inventory
        public void AddVehicleToInventory(VehicleModel vehicle)
        {
            _inventory.Add(vehicle);
        }

        public List<VehicleModel> GetInventory()
        {
            return _inventory;
        }

        // Shopping Cart
        public void AddVehicleToCart(VehicleModel vehicle)
        {
            _shoppingCart.Add(vehicle);
        }

        public List<VehicleModel> GetShoppingCart()
        {
            return _shoppingCart;
        }
    }
}
