using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task5.Database;
using static Task5.Exception_handling.Exception_handling;
using static Task5.Exception_handling.Exception_handling;

namespace Task5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            iCourierUserService userService = new Courier();

            // Example courier object
            Courier courier = new Courier
            {
                SenderName = "John",
                ReceiverName = "Alice"
                // Add other properties as needed
            };

            // Place an order
            string trackingNumber = userService.PlaceOrder(courier);
            Console.WriteLine($"Order placed successfully. Tracking number: {trackingNumber}");

            // Get order status
            string status = userService.GetOrderStatus(trackingNumber);
            Console.WriteLine($"Order status: {status}");

            // Cancel order
            bool isCancelled = userService.CancelOrder(trackingNumber);
            if (isCancelled)
            {
                Console.WriteLine("Order cancelled successfully.");
            }
            else
            {
                Console.WriteLine("Failed to cancel the order.");
            }

            List<Courier> assignedOrders = userService.GetAssignedOrders("staffId");

            // Display assigned orders
            foreach (var order in assignedOrders)
            {
                Console.WriteLine($"Order assigned to {order.ReceiverName}");
            }
            //Interface 2 Implementation
            iCourierAdminService adminService = new CourierCompany();

            // Example usage of the AddCourierStaff method
            int newEmployeeId = adminService.AddCourierStaff("John Doe", "1234567890");
            Console.WriteLine($"New courier staff member added. Employee ID: {newEmployeeId}");

            //Exception Handling
            try
            {
                string trackingNum = courier.PlaceOrder("John", "Alice");
                Console.WriteLine($"Order placed successfully. Tracking number: {trackingNumber}");

                courier.AssignCourier("EMP789");
                Console.WriteLine("Courier assigned successfully.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
            finally
            {
                Console.WriteLine("Exception handling completed.");
            }


            //Database connection
            Databaseconnection dbcon = new Databaseconnection();
            List<Courier> allcouriers=dbcon.Getallcouriers();
            foreach (Courier item in allcouriers)
            {
                Console.WriteLine(item);
            }
        }
    }
}
