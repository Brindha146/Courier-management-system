using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Task4
{
    internal class Program
    {
        private static readonly Random random = new Random();
        static void Main(string[] args)
        {
            // Task 4: Strings, 2D Arrays, User-defined functions, Hashmap
            // 9. Parcel Tracking

            string[,] parcelTracking = {
            {"123", "Parcel in transit"},
            {"789", "Parcel out for delivery"},
            {"345", "Parcel delivered"}
            };

            Console.WriteLine("Enter parcel tracking number:");
            string trackingNumber = Console.ReadLine();

            bool found = false;
            for (int i = 0; i < parcelTracking.GetLength(0); i++)
            {
                if (parcelTracking[i, 0] == trackingNumber)
                {
                    Console.WriteLine($"Tracking status for parcel {trackingNumber}: {parcelTracking[i, 1]}");
                    found = true;
                    break;
                }
            }

            if (!found)
            {
                Console.WriteLine("Parcel tracking number not found.");
            }

            Console.ReadLine();

            // Task 10: Customer Data Validation
            ValidateCustomerData("John", "Name");
            ValidateCustomerData("123 Main St.", "Address");
            ValidateCustomerData("555-123-4567", "Phone number");

            //Task 11: Format Address
            string formattedAddress = FormatAddress("123 main street", "cityville", "ny", "12345");
            Console.WriteLine(formattedAddress);

            //Task 12: Order Confirmation Email
            string customerName = "John Doe";
            string orderNumber = "ORD123456";
            string deliveryAddress = "123 Main Street, Cityville, NY 12345";
            DateTime expectedDeliveryDate = DateTime.Now.AddDays(7);

            string confirmationEmail = GenerateOrderConfirmationEmail(customerName, orderNumber, deliveryAddress, expectedDeliveryDate);
            Console.WriteLine(confirmationEmail);

            //Task 13: Calculate Shipping Cost

            string sourceAddress = "123 Main St, City1, State1, Zip1";
            string destinationAddress = "456 Elm St, City2, State2, Zip2";
            double weight = 5; // in kilograms
            double shippingCost = CalculateShippingCost(sourceAddress, destinationAddress, weight);
            Console.WriteLine($"Shipping cost: ${shippingCost}");

            //Task 14: Password Generator

            int passwordLength = 10; 
            string generatedPassword = GeneratePassword(passwordLength);
            Console.WriteLine($"Generated Password: {generatedPassword}");

            //Task 15: Find Similiar Address
            List<string> addresses = new List<string>
            {
                "123 Main St, City1, State1, Zip1",
                "456 Elm St, City2, State2, Zip2",
                "789 Oak St, City3, State3, Zip3",
                "321 Pine St, City4, State4, Zip4"
            };

            string targetAddress = "124 Main St, City1, State1, Zip1"; // Example target address
            int threshold = 5; // Adjust the threshold as needed

            List<string> similarAddresses = FindSimilarAddresses(addresses, targetAddress, threshold);

            Console.WriteLine("Similar Addresses:");
            foreach (string address in similarAddresses)
            {
                Console.WriteLine(address);
            }
        }

        //Task 10 function Definition
        static void ValidateCustomerData(string data, string detail)
        {
            if (detail == "Name")
            {
                // Validate name: contains only letters and properly capitalized
                if (Regex.IsMatch(data, @"^[A-Za-z]+$"))
                {
                    Console.WriteLine($"{detail} '{data}' is valid.");
                }
                else
                {
                    Console.WriteLine($"{detail} '{data}' is invalid. Names should contain only letters and be properly capitalized.");
                }
            }
            else if (detail == "Address")
            {
                // Validate address: does not contain special characters
                if (!Regex.IsMatch(data, @"[^a-zA-Z0-9\s]"))
                {
                    Console.WriteLine($"{detail} '{data}' is valid.");
                }
                else
                {
                    Console.WriteLine($"{detail} '{data}' is invalid. Addresses should not contain special characters.");
                }
            }
            else if (detail == "Phone number")
            {
                //Validate Phone number in format ##########
                if (Regex.IsMatch(data, @"^\d{10}$"))
                {
                    Console.WriteLine($"{detail} '{data}' is valid.");
                }
                else
                {
                    Console.WriteLine($"{detail} '{data}' is invalid. Phone numbers should be in the format ###-###-####.");
                }
            }
            else
            {
                Console.WriteLine("Invalid detail specified.");
            }
        }

        //Task 11 Function Definition
        static string FormatAddress(string street, string city, string state, string zipCode)
        {
            // Capitalize the first letter of each word in the address
            street = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(street.ToLower());
            city = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(city.ToLower());
            state = state.ToUpper();

            // Format the zip code correctly
            if (zipCode.Length > 5)
            {
                zipCode = zipCode.Substring(0, 5); // Trim zip code to 5 characters
            }
            else if (zipCode.Length < 5)
            {
                zipCode = zipCode.PadRight(5, '0'); // Pad zip code with leading zeros if it's less than 5 characters
            }

            // Construct the formatted address
            string formattedAddress = $"{street}, {city}, {state} {zipCode}";
            return formattedAddress;
        }

        //Task 12 Function Definition
        static string GenerateOrderConfirmationEmail(string customerName, string orderNumber, string deliveryAddress, DateTime expectedDeliveryDate)
        {
            // Construct the order confirmation email
            string emailBody = $"Dear {customerName},\n\n";
            emailBody += $"Thank you for your order. Your order number is: {orderNumber}.\n";
            emailBody += $"Your order will be delivered to the following address:\n{deliveryAddress}.\n";
            emailBody += $"Expected delivery date: {expectedDeliveryDate:dddd, MMMM d, yyyy}.\n\n";
            emailBody += "Please let us know if you have any questions or concerns.\n";
            emailBody += "Best regards,\nThe XYZ Company Team";

            return emailBody;
        }

        //Task 13 Function Definition
        public static double CalculateShippingCost(string sourceAddress, string destinationAddress, double weight)
        {
            // Calculate distance between source and destination 
            double distance = CalculateDistance(sourceAddress, destinationAddress);
            double shippingCost = distance * 0.1 + weight * 0.5; // Example formula (adjust as needed)

            return shippingCost;
        }

        // Function to calculate distance between two locations (mock implementation)
        private static double CalculateDistance(string sourceAddress, string destinationAddress)
        {
            return 100;
        }

        //Task 14 Function Definition
        public static string GeneratePassword(int length)
        {
            const string validChars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890!@#$%^&*()_+";

            char[] password = new char[length];

            for (int i = 0; i < length; i++)
            {
                password[i] = validChars[random.Next(validChars.Length)];
            }

            // Shuffle the characters to increase randomness
            for (int i = 0; i < length; i++)
            {
                int randIndex = random.Next(length);
                char temp = password[i];
                password[i] = password[randIndex];
                password[randIndex] = temp;
            }

            return new string(password);
        }

        //Task 15 Function Definition
        private static int CalculateLevenshteinDistance(string s1, string s2)
        {
            int[,] dp = new int[s1.Length + 1, s2.Length + 1];

            for (int i = 0; i <= s1.Length; i++)
            {
                dp[i, 0] = i;
            }

            for (int j = 0; j <= s2.Length; j++)
            {
                dp[0, j] = j;
            }

            for (int i = 1; i <= s1.Length; i++)
            {
                for (int j = 1; j <= s2.Length; j++)
                {
                    int cost = (s1[i - 1] == s2[j - 1]) ? 0 : 1;
                    dp[i, j] = Math.Min(Math.Min(dp[i - 1, j] + 1, dp[i, j - 1] + 1), dp[i - 1, j - 1] + cost);
                }
            }

            return dp[s1.Length, s2.Length];
        }

        // Function to find similar addresses in the system
        public static List<string> FindSimilarAddresses(List<string> addresses, string targetAddress, int threshold)
        {
            List<string> similarAddresses = new List<string>();

            foreach (string address in addresses)
            {
                int distance = CalculateLevenshteinDistance(address.ToLower(), targetAddress.ToLower());
                if (distance <= threshold)
                {
                    similarAddresses.Add(address);
                }
            }

            return similarAddresses;
        }
    }
}
