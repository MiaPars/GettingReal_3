using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GettingReal_3
{
    
    public class Menu
    {
        Admin adm = new Admin();
        AdminEmployee admEmp = new AdminEmployee();
        Shift shift = new Shift();
        Store store = new Store();

        public void Show()

        {
            Console.ForegroundColor = ConsoleColor.Red;
            

            Console.WriteLine(@"  *             )         ");
            Console.WriteLine(@" (  `          /(         ");
            Console.WriteLine(@" )\))(   (    )\())    (  ");
            Console.WriteLine(@"((_)()\  )\  ((_)\     )\ ");
            Console.WriteLine(@"(_()((_)((_) (_((_) _ ((_)");
            Console.WriteLine(@"|  \/  ||___|| \| || | | |");
            Console.WriteLine(@"| |\/| ||__| | \' || |_| |");
            Console.WriteLine(@"|_|  |_||___||_|\_|\ ___ /");

            Console.ResetColor();

            Console.WriteLine("------------------------------");

            Console.WriteLine("\nVælg punkt mellem 1-4");
            Console.WriteLine("1: Registrér timer");
            Console.WriteLine("2: Se afsluttede vagter for denne måned");
            Console.WriteLine("3: Administration");
            Console.WriteLine("4: Luk ned");

            Console.WriteLine("------------------------------");

            int switchCase = Convert.ToInt32(Console.ReadLine());
            switch (switchCase)
            {
                case 1:

                    Console.WriteLine("Registrer Timer: ");
                    RegistrerTimer();

                    
                    break;

                case 2:
                    Console.Clear();
                    Console.WriteLine("Se afsluttede vagter for denne måned");
                    AfsluttedeVagter();
                    break;

                case 3:
                    Console.Clear();
                    Console.WriteLine("Administration");
                    Console.WriteLine("Indtast administratorkode: ");

                    AdminPass();

                    Console.Clear();

                    Console.WriteLine("Vælg mellem 1-5");
                    Console.WriteLine("1. Eksportér liste til Excel");
                    Console.WriteLine("2. Tjek om vagter er taget");
                    Console.WriteLine("3. Tilføj medarbejder");
                    Console.WriteLine("4. Slet medarbejder");
                    Console.WriteLine("5. Luk ned");

                    Administration();

                    break;

                case 4:
                    Environment.Exit(0);

                    break;
            }
        }
        public void RegistrerTimer()
        {
            Console.Clear();
            // fake employees for nu
            store.AddEmployee();

            Console.Write("Indtast navn: ");
            string input = Console.ReadLine();

            while (store.CheckEmployee(input) == null)
            {
                Console.Clear();
                Console.WriteLine("du har intastet forkert navn, prøv igen: ");
                input = Console.ReadLine();
            }
            
            Console.Clear();
            Console.WriteLine("du har valgt: " + input);

            Console.WriteLine("Butikker: ");

            // midlertidlige falske butikker
            shift.AddStore();
            shift.ShowStores();

            Console.WriteLine("skriv butik navn: ");
            string butikInput = Console.ReadLine();

            while (shift.CheckStore(butikInput) == null)
            {
                Console.WriteLine("Du har intastet forkert butik navn, prøv igen: ");
                butikInput = Console.ReadLine();
            }

            Console.WriteLine("du har valgt " + butikInput + "butikken");

            admEmp.RegistrerTimer(store.CheckEmployee(input), shift.CheckStore(butikInput));
            

        }

        public void AfsluttedeVagter()
        {

        }

        public void Administration()
        {
            int s = Convert.ToInt32(Console.ReadLine());
            switch (s)
            {
                case 1:
                    Console.WriteLine("Eksportér liste til Excel");

                    break;

                case 2:
                    Console.WriteLine("Tjek om vagter er taget");

                    break;

                case 3:
                    Console.WriteLine("Tilføj medarbejder");

                    adm.AddEmployee2();

                    break;

                case 4:
                    Console.WriteLine("Slet medarbejder");

                    break;

                case 5:
                    Console.WriteLine("Luk ned");
                    Environment.Exit(0);
                    break;
            }
        }

        public void AdminPass()
        {
            string password;
            int counter = 0, pw = 0;
            do
            {
                password = Console.ReadLine();
                if (password == "1234")
                {
                    pw = 1;
                    counter = 3;
                }

                else
                {
                    pw = 0;
                    counter++;
                }
            }
            while (password != "1234" && (counter != 3));

            if (pw == 0)
            {
                Console.WriteLine("Mere end 3 loginforsøg, prøv igen senere");
                Environment.Exit(0);
            }
            else
            if (pw == 1)
            {
                Console.WriteLine("Kodeord godkendt!");

            }

        }

        
    }


}

