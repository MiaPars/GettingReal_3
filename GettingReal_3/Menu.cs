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

        public void Show()
        {
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
                    Console.WriteLine("Input a password: ");

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
            
            admEmp.RegistrerTimer();
            

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

        //Gemme fra C# til Excel
        //Kopieret fra nettet
        //OdbcConnection connection = new OdbcConnection(@"Driver={Microsoft Excel Driver (*.xls)};DriverId=790;Dbq=" + xlsFilePath + "; ReadOnly=False; DefaultDir=" + xlsDir + ";");
        //then you can create a IDbCommand like this: IDbCommand command = connection.CreateCommand();
    }


}

