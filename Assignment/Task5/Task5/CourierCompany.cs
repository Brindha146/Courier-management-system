using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    internal class CourierCompany :iCourierAdminService
    {
        public string CompanyName { get; set; }
        public List<Courier> CourierDetails { get; set; }
        public List<Employee> EmployeeDetails { get; set; }
        public List<Location> LocationDetails { get; set; }

        // Default Constructor
        public CourierCompany()
        {
            // Initialize lists
            CourierDetails = new List<Courier>();
            EmployeeDetails = new List<Employee>();
            LocationDetails = new List<Location>();
        }

        // Overloaded Constructor
        public CourierCompany(string companyName)
        {
            CompanyName = companyName;
            CourierDetails = new List<Courier>();
            EmployeeDetails = new List<Employee>();
            LocationDetails = new List<Location>();
        }

        public void PrintCompanyInfo()
        {
            Console.WriteLine($"Company Name: {CompanyName}");

            Console.WriteLine("\nCourier Details:");
            foreach (var courier in CourierDetails)
            {
                courier.PrintCourierInfo();
                Console.WriteLine();
            }

            Console.WriteLine("\nEmployee Details:");
            foreach (var employee in EmployeeDetails)
            {
                employee.PrintEmployeeInfo();
                Console.WriteLine();
            }

            Console.WriteLine("\nLocation Details:");
            foreach (var location in LocationDetails)
            {
                location.PrintLocationInfo();
                Console.WriteLine();
            }
        }

        //Interface implementation
        private static int nextEmployeeId = 1001; // Initial value for generating employee IDs

        public int AddCourierStaff(string name, string contactNumber)
        {
            // Example logic to add a new courier staff member to the system
            // This could involve database operations or other business logic

            // Generate employee ID
            string employeeId = $"EMP{nextEmployeeId++}";

            // Create new employee object
            Employee newEmployee = new Employee
            {
                EmployeeID = employeeId,
                EmployeeName = name,
                ContactNumber = contactNumber
            };
            return nextEmployeeId - 1; // Return the ID of the newly added courier staff member
        }
    }
}
