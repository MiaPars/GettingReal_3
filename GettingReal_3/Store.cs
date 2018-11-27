using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GettingReal_3
{
    public class Store
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
        public string storeName {

            get
            {
                return storeName;
            }
            set
            {
                foreach(string item in storeList)
                {
                    if (storeName.Equals(item))
                    {
                        storeName = value;
                    }
                    else
                    {
                        Console.WriteLine("du har intastet forkert butiknavn");
                        Menu m = new Menu();
                        m.Show();
                        
                    }
                }
            }

        }

        
    }
}
