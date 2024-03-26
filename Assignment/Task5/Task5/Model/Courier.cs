using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Task5.Exception_handling.Exception_handling;

namespace Task5
{
    internal class Courier : iCourierUserService
    {
        public string CourierID { get; set; }
        public string SenderName { get; set; }
        public string SenderAddress { get; set; }
        public string ReceiverName { get; set; }
        public string ReceiverAddress { get; set; }
        public double Weight { get; set; }
        public string Status { get; set; }
        public string TrackingNumber { get; set; }
        public DateTime DeliveryDate { get; set; }
        public string UserID { get; set; }

        // Default Constructor
        public Courier()
        {
            // Initialize default values
            CourierID = "";
            SenderName = "";
            SenderAddress = "";
            ReceiverName = "";
            ReceiverAddress = "";
            Weight = 0.0;
            Status = "";
            TrackingNumber = "";
            DeliveryDate = DateTime.MinValue;
            UserID = "";
        }

        // Overloaded Constructor
        public Courier(string courierID, string senderName, string senderAddress, string receiverName, string receiverAddress, double weight, string status, string trackingNumber, DateTime deliveryDate, string userID)
        {
            CourierID = courierID;
            SenderName = senderName;
            SenderAddress = senderAddress;
            ReceiverName = receiverName;
            ReceiverAddress = receiverAddress;
            Weight = weight;
            Status = status;
            TrackingNumber = trackingNumber;
            DeliveryDate = deliveryDate;
            UserID = userID;
        }

        public void PrintCourierInfo()
        {
            Console.WriteLine($"Courier ID: {CourierID}");
            Console.WriteLine($"Sender Name: {SenderName}");
            Console.WriteLine($"Sender Address: {SenderAddress}");
            Console.WriteLine($"Receiver Name: {ReceiverName}");
            Console.WriteLine($"Receiver Address: {ReceiverAddress}");
            Console.WriteLine($"Weight: {Weight}");
            Console.WriteLine($"Status: {Status}");
            Console.WriteLine($"Tracking Number: {TrackingNumber}");
            Console.WriteLine($"Delivery Date: {DeliveryDate}");
            Console.WriteLine($"User ID: {UserID}");
        }
        public override string ToString()
        {
            return $"Id : {CourierID} \t SenderName : {SenderName} \t SenderAddress : {SenderAddress} \t ReceiveName : {ReceiverAddress} \t Weight : {Weight} \tStatus : {Status}\tTrackingNumber :{TrackingNumber}\tUserID : {UserID}"; 
        }
        //Interface functions
        private static int uniqueTrackingNumber = 1000;//Initial Tracking Number
        public string PlaceOrder(Courier courierObj)
        {
            string trackingNumber = $"TRACK{uniqueTrackingNumber++}";
            return trackingNumber;
        }

        public string GetOrderStatus(string trackingNumber)
        {
            return "In Transit"; // Placeholder value
        }

        public bool CancelOrder(string trackingNumber)
        {
            return true; // Placeholder value
        }
        public List<Courier> GetAssignedOrders(string courierStaffId)
        {
            List<Courier> assignedOrders = new List<Courier>();
            // Populate assignedOrders based on the courierStaffId
            return assignedOrders;
        }


        //Exception_handling example

        public string PlaceOrder(string senderName, string receiverName)
        {
            // Generate unique tracking number
            string trackingNumber = $"TRACK{uniqueTrackingNumber++}";

            // Example logic
            if (string.IsNullOrEmpty(senderName) || string.IsNullOrEmpty(receiverName))
            {
                throw new TrackingNumberNotFoundException("Sender name or receiver name is not provided.");
            }

            return trackingNumber;
        }

        public void AssignCourier(string employeeId)
        {
            // Example logic
            if (employeeId != "EMP789")
            {
                throw new InvalidEmployeeIdException("Invalid employee ID while assigning courier.");
            }

        }
    }
}
