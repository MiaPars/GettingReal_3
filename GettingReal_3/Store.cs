using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GettingReal_3
{
    public class Store
    {
        public Store(string butikNavn)
        {
            StoreName = butikNavn;
        }
        // employee repo
        // employee admin

        public Store() { }
        public string StoreName
        {
            get;
            set;
        }
    }
}
