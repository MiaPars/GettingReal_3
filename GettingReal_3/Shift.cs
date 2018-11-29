using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GettingReal_3
{
    public class Shift
    {
        List<string> storeList = new List<string>();

        public void AddStore()
        {
            storeList.Add("nørregade");
            storeList.Add("thomas gade");
        }
        public bool CheckStore(string store)
        {
            foreach (string item in storeList)
            {
                if (store.Equals(item))
                {
                    return true;
                }
            }
            return false;

        }
        public void ShowStores()
        {
            for (int i = 0; i < storeList.Count; i++)
            {
                Console.WriteLine(i + " : " + storeList[i]);
            }
        }
        public void timer(string startDateString, string endDateString)
        {
            // string skal angives: 00/00/00
            DateTime startShift = DateTime.Parse(startDateString);
            DateTime endShift = DateTime.Parse(endDateString);
            //TimeSpan kagemand = DateTime.Now.Subtract(kage);
            TimeSpan interval = endShift - startShift;

            Console.WriteLine(interval.TotalHours.ToString());
            Console.ReadKey();

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
        }
    }
}
