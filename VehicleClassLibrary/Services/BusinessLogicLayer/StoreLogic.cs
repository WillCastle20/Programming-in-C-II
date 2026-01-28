using System.Collections.Generic;
using System.Linq;
using VehicleClassLibrary.Models;
using VehicleClassLibrary.Services.DataAccessLayer;

namespace VehicleClassLibrary.Services.BusinessLogicLayer
{
    public class StoreLogic
    {
        private readonly StoreDAO _dao = new();

        // Inventory
        public void AddVehicleToInventory(VehicleModel vehicle)
        {
            _dao.AddVehicleToInventory(vehicle);
        }

        public List<VehicleModel> GetInventory()
        {
            return _dao.GetInventory();
        }

        // Shopping cart
        public void AddVehicleToCart(VehicleModel vehicle)
        {
            _dao.AddVehicleToCart(vehicle);
        }

        public List<VehicleModel> GetShoppingCart()
        {
            return _dao.GetShoppingCart();
        }

        // Checkout
        public decimal Checkout()
        {
            return _dao.GetShoppingCart().Sum(v => v.Price);
        }
    }
}
