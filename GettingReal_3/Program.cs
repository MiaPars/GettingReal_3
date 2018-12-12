using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GettingReal_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Employee e = new Employee();
            //Store s = new Store();
            //AdminEmployee adm = new AdminEmployee();
            //adm.RegistrerTimer(e, s);

            Program prog = new Program();
            prog.Run();
        }
        public void Run()
        {
            Menu menu = new Menu();
            menu.Show();
        }
    }
}


        
