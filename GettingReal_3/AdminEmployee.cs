using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GettingReal_3
{
    public class AdminEmployee
    {
        Shift vagt = new Shift();
        Store butik = new Store();
        public void RegisterHours(Employee employee,  Store store)
        {
            Console.WriteLine("antal timer arbejdet: ");

            Console.WriteLine("angiv starttid: ");
            string startDate = Console.ReadLine();
            Console.WriteLine("angiv sluttid: ");
            string endDate = Console.ReadLine();

            TimeSpan s = vagt.Timer(startDate, endDate);
            Console.WriteLine(employee.TotalHoursWorked = s);

            
        }
    }
}
