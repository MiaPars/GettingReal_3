﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GettingReal_3
{
    class Menu
    {
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

                    Admin.AdminPass();

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

            Employee r = new Employee();

            foreach (Employee item in r.employees)
            {
                Console.WriteLine(item);
                Console.WriteLine();
            }
            Console.WriteLine("skriv navn:");
            string s = Console.ReadLine();

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

                    Employee employee = new Employee();

                    employee.AddEmployee();

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
        
        
    }
}
