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
