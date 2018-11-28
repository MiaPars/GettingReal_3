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

            //Program prog = new Program();
            //prog.Run();
            Shift hej = new Shift();
            hej.timer("28/11/2018", "29/11/2018");
        }
        public void Run()
        {
            Menu menu = new Menu();
            menu.Show();
        }
    }
}


        
