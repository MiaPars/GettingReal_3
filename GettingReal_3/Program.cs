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

            //Console.CursorVisible = false;
            //Program prog = new Program();
            //prog.Run();

            SQL s = new SQL();
            s.GetEmployeeData("kat");

        }
        public void Run()
        {
            Menu menu = new Menu();
            menu.Show();
        }
    }
}


        
