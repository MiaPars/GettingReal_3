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

            Program prog = new Program();
            prog.Run();
            //Shift hej = new Shift();
            //hej.timer("2018/03/13 08:30", "2018/03/14 08:45"); DET VIRKERRRRRRR
        }
        public void Run()
        {
            Menu menu = new Menu();
            menu.Show();
        }
    }
}


        
