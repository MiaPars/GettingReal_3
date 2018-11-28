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
            long datetimeS = 03 - 02 - 2018 - 08 - 30 - 00;
            long datetimeE = 06 - 03 - 2018 - 08 - 45 - 00;
            //Program prog = new Program();
            //prog.Run();

            Shift duration = new Shift();
            duration.timer(datetimeS,datetimeE);
            

        }
        public void Run()
        {
            Menu menu = new Menu();
            menu.Show();
        }


    }
}


        
