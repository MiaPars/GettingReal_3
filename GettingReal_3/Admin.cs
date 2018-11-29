using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GettingReal_3
{
    public class Admin
    {
            
        public static void AdminPass()
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

