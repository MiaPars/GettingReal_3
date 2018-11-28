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
        //

        ////Count the hours and minutes
        //TimeSpan total = toTime - fromTime;
        //int hours = total.Hours;
        //int minutes = total.Minutes;
        public void timer(string start, string end)
        {
            // string skal angives: 00/00/00
            DateTime kage = DateTime.Parse(start);
            DateTime kagetis = DateTime.Parse(end);
            //TimeSpan kagemand = DateTime.Now.Subtract(kage);
            TimeSpan interval = kagetis-kage;

            Console.WriteLine(interval.TotalHours.ToString());
            Console.ReadKey();

        }
    }
}
