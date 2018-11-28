using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GettingReal_3
{
    class Menu
    {
        List<string> employees = new List<string>();
        public void Show()
        {
            List<Employee> employees = new List<Employee>();


            Console.WriteLine("Vælg punkt mellem 1-4");
            Console.WriteLine("1: Registrér timer");
            Console.WriteLine("2: Se afsluttede vagter for denne måned");
            Console.WriteLine("3: Administration");
            Console.WriteLine("4: Luk ned");

            int switchCase = Convert.ToInt32(Console.ReadLine());
            switch (switchCase)
            {
                case 1:

                    Console.WriteLine("Registrer Timer: ");
                    break;

                case 2:
                    Console.Clear();
                    Console.WriteLine("2. Se afsluttede vagter for denne måned");


                    break;

                case 3:
                    Console.Clear();
                    Console.WriteLine("3. Administration");

                    

                    Admin.AdminPass();

                    break;

                case 4:
                    Environment.Exit(0);

                    break;
            }
        }
        public void RegistrerTimer()
        {
            Console.Clear();
            

            foreach (string item in employees)
            {
                Console.WriteLine(item);
                Console.WriteLine();
            }
            Console.WriteLine("skriv navn:");
            string s = Console.ReadLine();
        }
    }
}
