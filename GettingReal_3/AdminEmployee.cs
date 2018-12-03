using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GettingReal_3
{
    public class AdminEmployee
    {
        Shift a = new Shift();
        Store s = new Store();
        public void RegistrerTimer()
        {          
            s.AddEmployee();

            Console.WriteLine("Indtast navn");
            string input = Console.ReadLine();

            s.CheckEmployee(input);
            Console.WriteLine(s.CheckEmployee(input));
            
            Console.Clear();

            Console.WriteLine("Skriv butiknavn");

            a.AddStore();
            a.ShowStores();

            string butikInput = Console.ReadLine();

            a.CheckStore(butikInput);

            Console.WriteLine(a.CheckStore(butikInput));
        }
    }
}
