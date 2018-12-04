using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GettingReal_3
{
    public class Employee
    {
        public Employee(string name)
        {
            Name = name;
            
        }
        public string Name
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
