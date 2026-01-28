/*
 * William Castellanos
 * CST-250
 * 1/27/2026
 * Entry Point of our Console App
 * In Class Exercise
 */

using VehicleClassLibrary.Models;
using VehicleClassLibrary.Services.BusinessLogicLayer;
using System.Linq;

// Create ONE store instance
var store = new StoreLogic();

Console.WriteLine("Welcome to the Vehicle Shop!");
Console.WriteLine("Create vehicles, add them to inventory, add to cart, then checkout.\n");

// Start menu loop
ControlLoop(store);

// ---------------------- Local Functions ----------------------

static void ControlLoop(StoreLogic store)
{
    int choice = -1;

    while (choice != 0)
    {
        choice = ReadChoice();

        switch (choice)
        {
            case 0:
                Console.WriteLine("Goodbye!");
                break;

            case 1:
                Console.WriteLine("---- Inventory ----");
                var inventory = store.GetInventory();
                if (inventory.Count == 0)
                    Console.WriteLine("(empty)");
                else
                    foreach (var v in inventory)
                        Console.WriteLine($"Id {v.Id}: {v.Make} {v.Model} - ${v.Price}");
                Console.WriteLine();
                break;

            case 2:
                Console.WriteLine("---- Shopping Cart ----");
                var cart = store.GetShoppingCart();
                if (cart.Count == 0)
                    Console.WriteLine("(empty)");
                else
                    foreach (var v in cart)
                        Console.WriteLine($"{v.Make} {v.Model} - ${v.Price}");
                Console.WriteLine();
                break;

            case 3:
                CreateVehicle(store);
                break;

            case 4:
                Console.Write("Enter Vehicle Id to add to cart: ");
                int id = int.Parse(Console.ReadLine() ?? "0");

                var found = store.GetInventory().FirstOrDefault(v => v.Id == id);
                if (found == null)
                    Console.WriteLine("Vehicle not found.\n");
                else
                {
                    store.AddVehicleToCart(found);
                    Console.WriteLine("Added to cart.\n");
                }
                break;

            case 5:
                Console.WriteLine($"Total: {store.Checkout():C}\n");
                break;
        }
    }
}

static void CreateVehicle(StoreLogic store)
{
    Console.WriteLine("Vehicle Type: 1) Car  2) Motorcycle  3) Pickup");
    int type = int.Parse(Console.ReadLine() ?? "0");

    Console.Write("Make: ");
    string make = Console.ReadLine() ?? "";

    Console.Write("Model: ");
    string model = Console.ReadLine() ?? "";

    Console.Write("Year: ");
    int year = int.Parse(Console.ReadLine() ?? "0");

    Console.Write("Price: ");
    decimal price = decimal.Parse(Console.ReadLine() ?? "0");

    Console.Write("Number of Wheels: ");
    int wheels = int.Parse(Console.ReadLine() ?? "0");

    VehicleModel vehicle;

    if (type == 1)
    {
        Console.Write("Convertible (true/false): ");
        bool conv = bool.Parse(Console.ReadLine() ?? "false");

        Console.Write("Trunk Size: ");
        decimal trunk = decimal.Parse(Console.ReadLine() ?? "0");

        vehicle = new CarModel
        {
            IsConvertible = conv,
            TrunkSize = trunk
        };
    }
    else if (type == 2)
    {
        Console.Write("Has Sidecar (true/false): ");
        bool sidecar = bool.Parse(Console.ReadLine() ?? "false");

        Console.Write("Engine CC: ");
        int cc = int.Parse(Console.ReadLine() ?? "0");

        vehicle = new MotorcycleModel
        {
            HasSidecar = sidecar,
            EngineCc = cc
        };
    }
    else
    {
        Console.Write("Bed Length: ");
        decimal bed = decimal.Parse(Console.ReadLine() ?? "0");

        Console.Write("Four Wheel Drive (true/false): ");
        bool fourBy = bool.Parse(Console.ReadLine() ?? "false");

        vehicle = new PickupModel
        {
            BedLength = bed,
            FourWheelDrive = fourBy
        };
    }

    vehicle.Make = make;
    vehicle.Model = model;
    vehicle.Year = year;
    vehicle.Price = price;
    vehicle.NumWheels = wheels;
    vehicle.Id = store.GetInventory().Count + 1;

    store.AddVehicleToInventory(vehicle);
    Console.WriteLine("Vehicle added!\n");
}

static int ReadChoice()
{
    Console.WriteLine("0) Exit");
    Console.WriteLine("1) View Inventory");
    Console.WriteLine("2) View Cart");
    Console.WriteLine("3) Create Vehicle");
    Console.WriteLine("4) Add Vehicle to Cart");
    Console.WriteLine("5) Checkout");
    Console.Write("Choice: ");

    return int.TryParse(Console.ReadLine(), out int c) ? c : -1;
}
