using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GettingReal_3
{
    public class Admin
    {
        Store store = new Store();
        public void AddEmployee2()
        {
            store.AddEmployee();
        }

        public void RemoveEmployee2()
        {
            store.RemoveEmployee();
        }

    }
}

