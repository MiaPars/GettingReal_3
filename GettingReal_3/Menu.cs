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
                    Console.WriteLine("Se afsluttede vagter for denne måned");


                    break;

                case 3:
                    Console.Clear();
                    Console.WriteLine("Administration");
                                        
                    Admin.AdminPass();
                    Console.Clear();

                    Console.WriteLine("Vælg mellem 1-5");
                    Console.WriteLine("1. Eksportér liste til Excel");
                    Console.WriteLine("2. Tjek om vagter er taget");
                    Console.WriteLine("3. Tilføj medarbejder");
                    Console.WriteLine("4. Slet medarbejder");
                    Console.WriteLine("5. Luk ned");


                    switch (switchCase)
                    {
                        case 1:
                            Console.WriteLine("Eksportér liste til Excel");

                            break;

                        case 2:
                            Console.WriteLine("Tjek om vagter er taget");

                            break;

                        case 3:
                            Console.WriteLine("Tilføj medarbejder");

                            break;

                        case 4:
                            Console.WriteLine("Slet medarbejder");

                            break;

                        case 5:
                            Console.WriteLine("Luk ned");
                            Environment.Exit(0);
                            break;
                    }

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

            DateTime start = new DateTime();



        }
        
    }
}
