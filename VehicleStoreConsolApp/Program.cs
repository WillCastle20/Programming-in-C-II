/*
 * William Castellanos
 * CST-250
 * Activity 1
 * 4/20/2026
 * Citation: Grand Canyon University CST-250 Activity 1 Guide
 */

using System;
using System.Collections.Generic;
using VehicleClassLibrary.Models;
using VehicleClassLibrary.Services.BusinessLogicLayer;

// Welcome message for the user.
Console.WriteLine("Welcome to the Vehicle Shop!");
Console.WriteLine("Create vehicles, add them to inventory, add to cart, then checkout.");
Console.WriteLine();

// Call the main control loop for the console application.
ControlLoop();


// Reads the user's menu choice and returns it as an integer.
static int ReadChoice()
{
    string input = "";
    int choice = -1;

    while (choice == -1)
    {
        Console.WriteLine("0) Exit");
        Console.WriteLine("1) View Inventory");
        Console.WriteLine("2) View Cart");
        Console.WriteLine("3) Create Vehicle");
        Console.WriteLine("4) Add Vehicle to Cart");
        Console.WriteLine("5) Checkout");
        Console.WriteLine("6) Write Inventory to File");
        Console.WriteLine("7) Read Inventory from File");
        Console.Write("Choice: ");

        input = Console.ReadLine() ?? "";

        try
        {
            choice = int.Parse(input);

            if (choice < 0 || choice > 7)
            {
                Console.WriteLine("Please enter a number between 0 and 7.");
                Console.WriteLine();
                choice = -1;
            }
        }
        catch (FormatException)
        {
            Console.WriteLine("Invalid input. Please enter a whole number.");
            Console.WriteLine();
        }
        catch (OverflowException)
        {
            Console.WriteLine("The number entered is too large.");
            Console.WriteLine();
        }
        catch (Exception)
        {
            Console.WriteLine("An unexpected error occurred while reading your choice.");
            Console.WriteLine();
        }
    }

    return choice;
} // End ReadChoice


// Main control loop for the vehicle store console application.
static void ControlLoop()
{
    StoreLogic store = new StoreLogic();

    int choice = -1;
    int id = 0;
    int typeChoice = 0;
    int year = 0;
    int numWheels = 0;

    string make = "";
    string model = "";

    decimal price = 0.0m;
    decimal total = 0.0m;

    bool specialtyBoolean = false;
    decimal specialtyDecimal = 0.0m;

    List<VehicleModel> vehicleList = new List<VehicleModel>();
    VehicleModel vehicle;

    while (choice != 0)
    {
        choice = ReadChoice();

        switch (choice)
        {
            case 0:
                Console.WriteLine("Exiting the program...");
                Console.WriteLine();
                break;

            case 1:
                Console.WriteLine("---- Inventory ----");
                vehicleList = store.GetInventory();

                if (vehicleList.Count == 0)
                {
                    Console.WriteLine("Inventory is empty.");
                }
                else
                {
                    foreach (VehicleModel currentVehicle in vehicleList)
                    {
                        Console.WriteLine(currentVehicle.ToString());
                    }
                }

                Console.WriteLine();
                break;

            case 2:
                Console.WriteLine("---- Shopping Cart ----");
                vehicleList = store.GetShoppingCart();

                if (vehicleList.Count == 0)
                {
                    Console.WriteLine("Shopping cart is empty.");
                }
                else
                {
                    foreach (VehicleModel currentVehicle in vehicleList)
                    {
                        Console.WriteLine(currentVehicle.ToString());
                    }
                }

                Console.WriteLine();
                break;

            case 3:
                Console.WriteLine("Choose Vehicle Type:");
                Console.WriteLine("1) Car");
                Console.WriteLine("2) Motorcycle");
                Console.WriteLine("3) Pickup");
                Console.WriteLine("4) Vehicle");
                Console.Write("Vehicle type: ");

                try
                {
                    typeChoice = int.Parse(Console.ReadLine() ?? "0");
                }
                catch
                {
                    Console.WriteLine("Invalid vehicle type.");
                    Console.WriteLine();
                    break;
                }

                Console.Write("Make: ");
                make = Console.ReadLine() ?? "";

                Console.Write("Model: ");
                model = Console.ReadLine() ?? "";

                try
                {
                    Console.Write("Year: ");
                    year = int.Parse(Console.ReadLine() ?? "0");

                    Console.Write("Price: ");
                    price = decimal.Parse(Console.ReadLine() ?? "0");

                    Console.Write("Number of Wheels: ");
                    numWheels = int.Parse(Console.ReadLine() ?? "0");
                }
                catch
                {
                    Console.WriteLine("Invalid number entered for year, price, or wheels.");
                    Console.WriteLine();
                    break;
                }

                switch (typeChoice)
                {
                    case 1:
                        try
                        {
                            Console.Write("Is Convertible (true/false): ");
                            specialtyBoolean = bool.Parse(Console.ReadLine() ?? "false");

                            Console.Write("Trunk Size: ");
                            specialtyDecimal = decimal.Parse(Console.ReadLine() ?? "0");

                            vehicle = new CarModel(0, make, model, year, price, numWheels, specialtyBoolean, specialtyDecimal);
                            store.AddVehicleToInventory(vehicle);
                            Console.WriteLine("Car added to inventory.");
                        }
                        catch
                        {
                            Console.WriteLine("Invalid car data entered.");
                        }
                        break;

                    case 2:
                        try
                        {
                            Console.Write("Has Side Car (true/false): ");
                            specialtyBoolean = bool.Parse(Console.ReadLine() ?? "false");

                            Console.Write("Seat Height: ");
                            specialtyDecimal = decimal.Parse(Console.ReadLine() ?? "0");

                            vehicle = new MotorcycleModel(0, make, model, year, price, numWheels, specialtyBoolean, specialtyDecimal);
                            store.AddVehicleToInventory(vehicle);
                            Console.WriteLine("Motorcycle added to inventory.");
                        }
                        catch
                        {
                            Console.WriteLine("Invalid motorcycle data entered.");
                        }
                        break;

                    case 3:
                        try
                        {
                            Console.Write("Has Bed Cover (true/false): ");
                            specialtyBoolean = bool.Parse(Console.ReadLine() ?? "false");

                            Console.Write("Bed Size: ");
                            specialtyDecimal = decimal.Parse(Console.ReadLine() ?? "0");

                            vehicle = new PickupModel(0, make, model, year, price, numWheels, specialtyBoolean, specialtyDecimal);
                            store.AddVehicleToInventory(vehicle);
                            Console.WriteLine("Pickup added to inventory.");
                        }
                        catch
                        {
                            Console.WriteLine("Invalid pickup data entered.");
                        }
                        break;

                    case 4:
                        vehicle = new VehicleModel(0, make, model, year, price, numWheels);
                        store.AddVehicleToInventory(vehicle);
                        Console.WriteLine("Vehicle added to inventory.");
                        break;

                    default:
                        Console.WriteLine("Invalid vehicle type selection.");
                        break;
                }

                Console.WriteLine();
                break;

            case 4:
                try
                {
                    Console.Write("Enter Vehicle ID to add to cart: ");
                    id = int.Parse(Console.ReadLine() ?? "0");

                    store.AddVehicleToCart(id);
                    Console.WriteLine("Vehicle added to shopping cart.");
                }
                catch
                {
                    Console.WriteLine("Unable to add vehicle to cart. Please check the ID.");
                }

                Console.WriteLine();
                break;

            case 5:
                total = store.Checkout();
                Console.WriteLine("Checkout complete.");
                Console.WriteLine("Total: " + total.ToString("C2"));
                Console.WriteLine();
                break;

            case 6:
                if (store.WriteInventory())
                {
                    Console.WriteLine("Inventory successfully written to file.");
                }
                else
                {
                    Console.WriteLine("Failed to write inventory to file.");
                }

                Console.WriteLine();
                break;

            case 7:
                vehicleList = store.ReadInventory();

                if (vehicleList.Count > 0)
                {
                    Console.WriteLine("Inventory successfully read from file.");
                }
                else
                {
                    Console.WriteLine("No inventory was loaded from file.");
                }

                Console.WriteLine();
                break;

            default:
                Console.WriteLine("Invalid selection.");
                Console.WriteLine();
                break;
        }
    }
} // End ControlLoop