using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
                /*Task 2: Loops and Iteration
                Display all orders for a specific customer using a for loop*/
                string[,] orders = {
                                    {"Customer1", "Order1"},
                                    {"Customer2", "Order2"},
                                    {"Customer1", "Order3"},
                                    {"Customer4", "Order4"}
                };

                string customerID = "Customer1";

                Console.WriteLine($"Orders for customer {customerID}:");
                for (int i = 0; i < orders.GetLength(0); i++)
                {
                    if (orders[i, 0] == customerID)
                    {
                        Console.WriteLine(orders[i, 1]);
                    }
                }
                Console.ReadLine();

                //Implement a while loop to track the real-time location of a courier until it reaches its destination
                Console.WriteLine("Enter the distance to the destination (in kilometers):");
                int distanceToDestination = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter Your current position (in kilometers):");
                int currentPosition = int.Parse(Console.ReadLine());

                Console.WriteLine("Courier tracking started...");

                // While loop to track the courier until it reaches the destination
                while (currentPosition < distanceToDestination)
                {
                    Console.WriteLine($"Courier is at position {currentPosition} km.");
                    currentPosition += 10; // Assuming the courier moves 10 km in each iteration

                    System.Threading.Thread.Sleep(1000);
                }

                Console.WriteLine("Courier has reached its destination.");
            Console.ReadLine();
            }
    }
}
