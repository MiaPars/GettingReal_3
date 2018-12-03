using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GettingReal_3
{
    public class Employee
    {
        public Employee(string name, string address, string email)
        {
            Name = name;
            Address = address;
            Email = email;
        }
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

        private TimeSpan timespan = new TimeSpan(00,00,00);
        
        public TimeSpan TotalHoursWorked
        {
            get { return timespan; }
            set { this.timespan.Add(value); }
        }

    }
}
