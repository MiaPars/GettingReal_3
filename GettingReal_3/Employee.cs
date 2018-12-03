using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GettingReal_3
{
    public class Employee
    {
        public string Name
        {
            get;
            set;
        }

        public string Address
        {
            get;
            set;
        }
        public string Email
        {
            get;
            set;
        }

        public Employee(string name, string address, string email)
        {
            Name = name;
            Address = address;
            Email = email;
        }

        private TimeSpan hoursWorked = TimeSpan.Parse("00:00");

        public TimeSpan HoursWorked
        {
            get;
            set;
        }

    }
}
