using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Task 3: Arrays and Data Structures
    Create an array to store the tracking history of a parcel, where each entry represents a location update.*/
            string[] trackingHistory = { "Location A", "Location B", "Location C", "Location D", "Location E" };

            // Output the tracking history
            Console.WriteLine("Tracking history of the parcel:");
            foreach (var location in trackingHistory)
            {
                Console.WriteLine(location);
            }
            Console.ReadLine();

            //Nearest Courier
            Courier[] couriers = {
            new Courier("Courier A", 10),
            new Courier("Courier B", 20),
            new Courier("Courier C", 15)
        };

            Console.WriteLine("Enter the location area : ");
            int newOrderLocation = int.Parse(Console.ReadLine());

            // Find the nearest courier
            Courier nearestCourier = FindNearestCourier(newOrderLocation, couriers);

            // Output the nearest courier
            Console.WriteLine($"The nearest courier is: {nearestCourier.Name} (Distance: {nearestCourier.Distance})");
            Console.ReadLine();
        }


        //Implement a method to find the nearest available courier for a new order using an array of couriers. 
        static Courier FindNearestCourier(int newOrderLocation, Courier[] couriers)
        {
            Courier nearestCourier = null;
            int minDistance = int.MaxValue;

            // Iterate through each courier and find the nearest one
            foreach (Courier courier in couriers)
            {
                int distance = Math.Abs(courier.Distance - newOrderLocation);
                if (distance < minDistance)
                {
                    minDistance = distance;
                    nearestCourier = courier;
                }
            }
            return nearestCourier;
        }
        
    }
}
