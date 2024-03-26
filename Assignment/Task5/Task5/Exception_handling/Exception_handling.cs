using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5.Exception_handling
{
    internal class Exception_handling
    {
        private string message;

        public Exception_handling(string message)
        {
            this.message = message;
        }

        public class TrackingNumberNotFoundException : Exception_handling
        {
            public TrackingNumberNotFoundException(string message) : base(message)
            {
            }

            public object Message { get; internal set; }
        }

        // Custom exception for invalid employee ID
        public class InvalidEmployeeIdException : Exception_handling
        {
            public InvalidEmployeeIdException(string message) : base(message)
            {
            }

            public object Message { get; internal set; }
        }
    }
}
