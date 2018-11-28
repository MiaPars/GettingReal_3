using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GettingReal_3
{
    public static class Admin
    {
            
        public static void AdminPass()
        {
            string password;
            int counter = 0, dd = 0;
            
            do
            {
                Console.WriteLine("Input a password: ");
                password = Console.ReadLine();
                if (password == "1234")
                {
                    dd = 1;
                    counter = 3;
                }

                else
                {
                    dd = 0;
                    counter++;
                }
            }
            while (password != "1234" && (counter != 3));

            if (dd == 0)
            {
                Console.Write("\nMere end 3 loginforsøg, prøv igen senere\n\n");
            }
            else
            if (dd == 1)
            {
                Console.Write("\nKodeord godkendt!\n\n");
            }
        }
    }

}

