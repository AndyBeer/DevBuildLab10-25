using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DevBuildLab10_25_UsedCarLot
{
    class CarLot
    {
        public List<Car> Cars = new List<Car>();
        
        public Car Metro = new UsedCar("Geo", "Metro", 1986, 800, 200000);
        public Car Sable = new UsedCar("Mercury", "Sable", 1997, 1200, 185000);
        public Car F150 = new UsedCar("Ford", "F150", 1974, 6200,98000);
        public Car R8 = new Car("Audi", "R8", 2021, 156000);
        public Car Escape = new Car("Ford", "Escape", 2021, 30000);
        public Car Gladiator = new Car("Jeep", "Gladiator", 2021, 64000);

        public CarLot()
        {
            Cars.Add(Metro);
            Cars.Add(Sable);
            Cars.Add(F150);
            Cars.Add(R8); 
            Cars.Add(Escape);
            Cars.Add(Gladiator);
        }
        public void PrintInv()
        {
            
            for (int i = 1; i < Cars.Count; i++)
            {
                //Console.WriteLine($"Car Lot Number: [{i}]\n{Cars.OrderBy(Car => Car.Make).ToList()[i]}\n------------\n");
                //^ dont need to sort here - messes up the indexing when removing
                
                Console.WriteLine($"Lot No: [{i}] - {Cars[i].Make} {Cars[i].Model}");
                Console.WriteLine(String.Format("{0,10} {1,15}", $"Year: { Cars[i].Year}", $"Price: ${Cars[i].Price}\n"));

            }
        }
        public void AddCar()
        {
            Console.WriteLine("Please provide info about the vehicle:");
            string newOrUsed = GetInput("New or Used [n] or [u]");
            if (newOrUsed.ToLower() == "n")
            {
                string make = GetInput("Make: ");
                string model = GetInput("Model: ");
                Console.WriteLine("Year: 2021 (NEW)");
                decimal price = decimal.Parse(GetInput("Price: "));

                Car newCar = new Car(make, model, 2021, price);
                Cars.Add(newCar);
                Console.WriteLine($"\n{make} {model} has been added to inventory.\nCurrent Inventory:\n");
                PrintInv();
            }
            else if (newOrUsed.ToLower() == "u")
            {
                string make = GetInput("Make: ");
                string model = GetInput("Model: ");
                int year = int.Parse(GetInput("Year: "));
                decimal price = decimal.Parse(GetInput("Price: ")); //I know I should add validation in here, but I can add that later
                double mileage = double.Parse(GetInput("Mileage: ")); //I know I should add validation in here, but I can add that later

                Car oldCar = new UsedCar(make, model, year, price, mileage);
                Cars.Add(oldCar);
                Console.WriteLine($"{make} {model} has been added to inventory.\nCurrent Inventory:\n");
                PrintInv();
            }
            else
            {
                Console.WriteLine("Invalid input.  Please input \"n\" or \"u\".\n");
                AddCar();
            }
        }
        public void RemoveCar() // Use this method when cars are "purchased"
        {
            PrintInv();
            int i = int.Parse(GetInput("Which car is being purchased?\n[Lot Number]: ")); //I know I should add validation in here, but I can add that later
            if (i < Cars.Count)
            {
                Cars.Remove(Cars[i-1]);
                Console.WriteLine($"\n{Cars[i-1].Make} {Cars[i-1].Model} has been removed.\nCurrent Inventory:\n");
                PrintInv();
            }
            else
            {
                Console.WriteLine("That car is not in the inventory.  Here are the current cars on the lot:\n");
                PrintInv();
            }
        }
        public static string GetInput(string prompt)
        {
            Console.Write(prompt);
            string output = Console.ReadLine();
            return output;
        }
    }
}
