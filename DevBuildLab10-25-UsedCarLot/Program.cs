using System;

namespace DevBuildLab10_25_UsedCarLot
{
    class Program
    {
        static void Main(string[] args)
        {
            CarLot AndysCars = new CarLot();
            bool keepGoing = true;
            Console.WriteLine(("~~~Welcome to Crazy Andy's Car Lot!~~~\n"));
            while (keepGoing)
            {
                AndysCars.PrintInv();
                string userSelect = GetInput("[1] Complete Car Purchase\n[2] Add to Inventory\n[3] View Current inventory\n"); //can add validation here as well, but not necessary
                
                switch (userSelect)
                {
                    case "1":
                        {
                            AndysCars.RemoveCar();
                            keepGoing = ContinueLoop("Need anything else? [y] or [n] ");
                            break;
                        }
                    case "2":
                        {
                            AndysCars.AddCar();
                            keepGoing = ContinueLoop("Need anything else? [y] or [n] ");
                            break;
                        }
                    case "3":
                        {
                            Console.WriteLine("CURRENT LOT INVENTORY:\n");
                            AndysCars.PrintInv();
                            keepGoing = ContinueLoop("Need anything else? [y] or [n] ");
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("That is not a valid response.");
                            keepGoing = ContinueLoop("Try again? ");
                            break;
                        }
                }
                Console.WriteLine("\nGoodbye!");
            }
            
        }
        public static bool ContinueLoop(string question)
        {
            string response = GetInput(question);
            if (response.ToLower() == "y")
            {
                return true;
            }
            else if (response.ToLower() == "n")
            {
                return false;
            }
            else
            {
                Console.WriteLine("Invalid input.  Please input \"y\" or \"n\".\n");
                return ContinueLoop(question);
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
