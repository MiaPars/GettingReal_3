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
            Employee e = new Employee();
            Store s = new Store();
            AdminEmployee adm = new AdminEmployee();
            adm.RegistrerTimer(e, s);
            Console.WriteLine("ok");


            //Console.WriteLine(15 % 8);


            //Console.WriteLine(e.VagtDato.ToString());

            //Program prog = new Program();
            //prog.Run();




            //DateTime date1 = new DateTime(2008, 5, 1);
            //DateTime date2 = new DateTime(12, 01, 01);
            //DateTime date3 = new DateTime(12, 12, 12);
            ////5 / 1 / 2008
            //string dateString = "8:30:52";
            //DateTime date4 = DateTime.Parse(dateString);
            //string skal angives: 00 / 00 / 00 00:00:00
            //SQL s = new SQL();
            //s.insertToShift(date4, date4, date4, date4);
            //Console.WriteLine("ok");

            //SQL ss = new SQL();
            //ss.InsertToEmployee("employeeNavn");
            //ss.InsertToEmployee("Thomas");

            //ss.DeleteEmployee("employeeNavn");

        }
        public void Run()
        {
            Menu menu = new Menu();
            menu.Show();
        }
    }
}


        
