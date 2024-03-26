using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Task 1: Control Flow Statements
            /*Write a program that checks whether a given order is delivered or not based on its status(e.g.,
            "Processing," "Delivered," "Cancelled"). Use if-else statements for this.*/

            Console.WriteLine("Enter your OrderStatus: ");
            string orderStatus = Console.ReadLine();

            if (orderStatus == "Delivered")
            {
                Console.WriteLine("The order has been delivered.");
            }
            else if (orderStatus == "In Transit")
            {
                Console.WriteLine("The order is still processing.");
            }
            else if (orderStatus == "Cancelled")
            {
                Console.WriteLine("The order has been cancelled.");
            }
            else
            {
                Console.WriteLine("Invalid order status.");
            }
            Console.ReadLine();

            /*Implement a switch-case statement to categorize parcels based on their weight into "Light,"
            "Medium," or "Heavy."*/
            Console.WriteLine("Enter your ParcelWeight: ");
            int parcelWeight = int.Parse(Console.ReadLine());
            switch (parcelWeight)
            {
                case int w when (w <= 50):
                    Console.WriteLine("Light parcel.");
                    break;
                case int w when (w > 50 && w <= 100):
                    Console.WriteLine("Medium parcel.");
                    break;
                case int w when (w > 100):
                    Console.WriteLine("Heavy parcel.");
                    break;
                default:
                    Console.WriteLine("Invalid parcel weight.");
                    break;
            }
            Console.ReadLine();

            /*Implement User Authentication 1.Create a login system for employees and customers using C#
            control flow statements.*/

            Console.WriteLine("Welcome to the Login System!");
            string[] usernames = { "employee1", "customer1" };
            string[] passwords = { "password1", "password2" };

            Console.Write("Enter username: ");
            string username = Console.ReadLine();
            Console.Write("Enter password: ");
            string password = Console.ReadLine();

            bool isAuthenticated = false;
            for (int i = 0; i < usernames.Length; i++)
            {
                if (username == usernames[i] && password == passwords[i])
                {
                    isAuthenticated = true;
                    break;
                }
            }

            if (isAuthenticated)
            {
                Console.WriteLine("Login successful!");
            }
            else
            {
                Console.WriteLine("Invalid username or password.");
            }
            Console.ReadLine();
        }
    }
}
