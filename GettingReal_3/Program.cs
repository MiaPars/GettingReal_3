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
            Console.WriteLine("Vælg punkt mellem 1-4");
            Console.WriteLine("1: Registrér timer");
            Console.WriteLine("2: Se afsluttede vagter for denne måned");
            Console.WriteLine("3: Administration");
            Console.WriteLine("4: Luk ned");

            int switchCase = Convert.ToInt32(Console.ReadLine());
            switch (switchCase)
            {
                case 1:
                    Console.Clear();
                    Console.WriteLine("1. Registrér timer");


                    break;

                case 2:
                    Console.Clear();
                    Console.WriteLine("2. Se afsluttede vagter for denne måned");

                    break;

                case 3:
                    Console.Clear();
                    Console.WriteLine("3. Administration");

                    break;

                case 4:
                    Console.Clear();
                    Console.WriteLine("4. Luk ned");
                    //hej
                    break;

            }
        }
    }
}


        
