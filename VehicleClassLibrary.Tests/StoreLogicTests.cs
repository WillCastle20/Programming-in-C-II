/*
 * William Castellanos
 * CST-250
 * Activity 1
 * 4/20/2026
 * Citation: Grand Canyon University CST-250 Activity 1 Guide
 */

using VehicleClassLibrary.Models;
using VehicleClassLibrary.Services.BusinessLogicLayer;
using Xunit;

namespace VehicleClassLibrary.Tests
{
    public class StoreLogicTests
    {
        [Fact]
        public void GetInventory_ShouldReturnInventoryList()
        {
            var store = new StoreLogic();
            var car = new CarModel { Id = 1, Make = "Toyota", Model = "Camry", Year = 2020, Price = 25000m, NumWheels = 4, IsConvertible = true, TrunkSize = 2.5m };

            store.AddVehicleToInventory(car);
            var inventory = store.GetInventory();

            Assert.NotNull(inventory);
            Assert.Single(inventory);
        }

        [Fact]
        public void AddVehicleToCart_ShouldAddVehicle()
        {
            var store = new StoreLogic();
            var car = new CarModel { Id = 1, Make = "Toyota", Model = "Camry", Year = 2020, Price = 25000m, NumWheels = 4, IsConvertible = true, TrunkSize = 2.5m };

            store.AddVehicleToCart(car);
            var cart = store.GetShoppingCart();

            Assert.Contains(car, cart);
        }

        [Fact]
        public void GetShoppingCart_ShouldReturnCartList()
        {
            var store = new StoreLogic();
            var car = new CarModel { Id = 1, Make = "Toyota", Model = "Camry", Year = 2020, Price = 25000m, NumWheels = 4, IsConvertible = true, TrunkSize = 2.5m };

            store.AddVehicleToCart(car);
            var cart = store.GetShoppingCart();

            Assert.NotNull(cart);
            Assert.Single(cart);
        }

        [Fact]
        public void Checkout_ShouldReturnTotalPrice()
        {
            var store = new StoreLogic();

            var car1 = new CarModel { Id = 1, Make = "Toyota", Model = "Camry", Year = 2020, Price = 25000m, NumWheels = 4, IsConvertible = true, TrunkSize = 2.5m };
            var car2 = new CarModel { Id = 2, Make = "Honda", Model = "Civic", Year = 2021, Price = 20000m, NumWheels = 4, IsConvertible = false, TrunkSize = 2.0m };

            store.AddVehicleToCart(car1);
            store.AddVehicleToCart(car2);

            var total = store.Checkout();

            Assert.Equal(45000m, total);
        }
    }
}
