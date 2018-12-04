using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GettingReal_3
{
    public class Shift
    {
        List<Store> storeList = new List<Store>();

        public void AddStore()
        {
            storeList = new List<Store>
            {
                new Store("norregade"),
                new Store("thomasgade"),
            };
        }

        public Store CheckStore(string store)
        {
            foreach (Store item in storeList)
            {
                if (item.StoreName.Equals(store))
                {
                    return item;
                }
            }
            return null;
        }

        public void ShowStores()
        {
            for (int i = 0; i < storeList.Count; i++)
            {
                Console.WriteLine(i + 1 + ": " + storeList[i]);
            }
        }
        public TimeSpan Timer(string startDateString, string endDateString)
        {
            // string skal angives: 00/00/00
            DateTime startShift = DateTime.Parse(startDateString);//skal gemmes
            DateTime endShift = DateTime.Parse(endDateString);
            //TimeSpan kagemand = DateTime.Now.Subtract(kage);
            TimeSpan interval = endShift - startShift;

            return interval;

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
