/*
 * William Castellanos
 * CST-250
 * Activity 1
 * 4/20/2026
 * Citation: Grand Canyon University CST-250 Activity 1 Guide
 */

using System.Collections.Generic;
using VehicleClassLibrary.Models;
using VehicleClassLibrary.Services.BusinessLogicLayer;
using Xunit;

namespace VehicleClassLibrary.Tests
{
    public class StoreLogicTests
    {
        [Fact]
        public void AddVehicleToInventory_ShouldIncreaseInventoryCount()
        {
            // Arrange
            StoreLogic store = new StoreLogic();
            CarModel car = new CarModel(0, "Toyota", "Camry", 2020, 25000m, 4, true, 2.5m);

            // Act
            store.AddVehicleToInventory(car);
            List<VehicleModel> inventory = store.GetInventory();

            // Assert
            Assert.Equal(1, inventory.Count);
            Assert.Equal("Toyota", inventory[0].Make);
        }

        [Fact]
        public void GetInventory_ShouldReturnEmptyList_WhenNoVehiclesAdded()
        {
            // Arrange
            StoreLogic store = new StoreLogic();

            // Act
            List<VehicleModel> inventory = store.GetInventory();

            // Assert
            Assert.Empty(inventory);
        }

        [Fact]
        public void AddVehicleToCart_ShouldAddVehicle_WhenValidVehicleIdGiven()
        {
            // Arrange
            StoreLogic store = new StoreLogic();
            CarModel car = new CarModel(0, "Honda", "Civic", 2019, 20000m, 4, true, 2.5m);

            // Act
            int vehicleId = store.AddVehicleToInventory(car);
            int result = store.AddVehicleToCart(vehicleId);
            List<VehicleModel> cart = store.GetShoppingCart();

            // Assert
            Assert.Equal(1, result);
            Assert.Equal(1, cart.Count);
            Assert.Equal(vehicleId, cart[0].Id);
        }

        [Fact]
        public void GetShoppingCart_ShouldReturnEmptyList_WhenNoVehiclesAdded()
        {
            // Arrange
            StoreLogic store = new StoreLogic();

            // Act
            List<VehicleModel> cart = store.GetShoppingCart();

            // Assert
            Assert.Empty(cart);
        }

        [Fact]
        public void Checkout_ShouldReturnCorrectTotal_AndClearCart()
        {
            // Arrange
            StoreLogic store = new StoreLogic();

            CarModel car1 = new CarModel(0, "Ford", "F150", 2021, 40000m, 4, true, 2.5m);
            CarModel car2 = new CarModel(0, "Chevrolet", "Silverado", 2022, 45000m, 4, true, 2.5m);

            int id1 = store.AddVehicleToInventory(car1);
            int id2 = store.AddVehicleToInventory(car2);

            store.AddVehicleToCart(id1);
            store.AddVehicleToCart(id2);

            // Act
            decimal total = store.Checkout();
            List<VehicleModel> cartAfterCheckout = store.GetShoppingCart();

            // Assert
            Assert.Equal(85000m, total);
            Assert.Empty(cartAfterCheckout);
        }
    }
}