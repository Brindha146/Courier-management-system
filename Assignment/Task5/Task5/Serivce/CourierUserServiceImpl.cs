using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5.Serivce
{
    internal class CourierUserServiceImpl :iCourierUserService
    {
        private readonly CourierCompany companyObj;
        public CourierUserServiceImpl(CourierCompany company)
        {
            companyObj = company;
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

    }
}
