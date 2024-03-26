using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    internal class Employee
    {
        public string EmployeeID { get; set; }
        public string EmployeeName { get; set; }
        public string Email { get; set; }
        public string ContactNumber { get; set; }
        public string Role { get; set; }
        public double Salary { get; set; }

        // Default Constructor
        public Employee()
        {
            // Initialize default values
            EmployeeID = "";
            EmployeeName = "";
            Email = "";
            ContactNumber = "";
            Role = "";
            Salary = 0.0;
        }

        // Overloaded Constructor
        public Employee(string employeeID, string employeeName, string email, string contactNumber, string role, double salary)
        {
            EmployeeID = employeeID;
            EmployeeName = employeeName;
            Email = email;
            ContactNumber = contactNumber;
            Role = role;
            Salary = salary;
        }

        public void PrintEmployeeInfo()
        {
            Console.WriteLine($"Employee ID: {EmployeeID}");
            Console.WriteLine($"Employee Name: {EmployeeName}");
            Console.WriteLine($"Email: {Email}");
            Console.WriteLine($"Contact Number: {ContactNumber}");
            Console.WriteLine($"Role: {Role}");
            Console.WriteLine($"Salary: {Salary}");
        }
    }
}
