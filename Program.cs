using System;

namespace MyFleetManager
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("--- Fleet Management Input System ---");

                // 1. Get User Input for a Bus
                Console.Write("Enter Bus ID (e.g., EB-01): ");
                string bId = Console.ReadLine();

                Console.Write("Enter Bus Model Name: ");
                string bName = Console.ReadLine();

                Console.Write("Enter Battery Percentage (0-100): ");
                double bLevel = Convert.ToDouble(Console.ReadLine());

                // Create the object with your inputs
                ElectricBus userBus = new ElectricBus(bId, bName, bLevel);
                userBus.CalculateRange();

                Console.WriteLine("\n-------------------------------\n");

                // 2. Get User Input for a Van
                Console.Write("Enter Van ID (e.g., GV-05): ");
                string vId = Console.ReadLine();

                Console.Write("Enter Van Model Name: ");
                string vName = Console.ReadLine();

                Console.Write("Enter Fuel Level (Liters): ");
                double vLevel = Convert.ToDouble(Console.ReadLine());

                GasPoweredVan userVan = new GasPoweredVan(vId, vName, vLevel);
                userVan.CalculateRange();
            }
            catch (FormatException)
            {
                Console.WriteLine("Input Error: Please enter a valid number for energy levels.");
            }
            catch (ArgumentException ex)
            {
                // This triggers if you enter a negative number
                Console.WriteLine($"Validation Error: {ex.Message}");
            }
            catch (Exception ex)
            {
                // This triggers if you enter a number below 5
                Console.WriteLine($"System Alert: {ex.Message}");
            }
            finally
            {
                Console.WriteLine("\nSession Ended. System Shutdown.");
                Console.ReadKey(); // Keeps the console open so you can see the result
            }
        }
    }
}