using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GettingReal_3
{
    public class Shift
    {
        //public TimeSpan GetHourSpan(DateTime fromTime, DateTime toTime);
        //{
        //TimeSpan fromH = TimeSpan.FromHours(fromTime.Hour);
        //TimeSpan toH = TimeSpan.FromHours(toTime.Hour);
        //TimeSpan hourTotalSpan = toH.Subtract(fromH);
        //return hourTotalSpan;
        //}

        ////Count the hours and minutes
        //TimeSpan total = toTime - fromTime;
        //int hours = total.Hours;
        //int minutes = total.Minutes;
        public void timer()
        {
            DateTime start = new DateTime(08, 30, 00);

            Console.WriteLine(start);
            DateTime end = new DateTime();
            //DateTime start = DateTime.Parse("08:30");
            //DateTime end = DateTime.Parse("12:30");
            Console.WriteLine((end - start).TotalHours);

        }
    }
}
