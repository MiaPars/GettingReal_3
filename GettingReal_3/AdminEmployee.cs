using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GettingReal_3
{
    public class AdminEmployee
    {
        Shift vagt = new Shift();
        Store butik = new Store();
        Employee e = new Employee();
        public void RegistrerTimer(Employee employee,  Store store)
        {
            Console.Write("Registrer en vagt. Skriv som DD/MM: \n");

            string start = "../..";

            StringBuilder sb = new StringBuilder(start);

            for (int i = 0; i < sb.Length ; i++)
            {
                if (sb[i].Equals('/'))
                {
                    continue;
                }

                Console.Clear();
                Console.WriteLine("intast et tal: ");
                Console.WriteLine(sb);

                sb[i] = Console.ReadKey().KeyChar;
                
            }
            Console.WriteLine(sb);






            //string day = "";
            //for (int i = 0; i < 2; i++)
            //{
            //    do
            //    {
            //        char c = Console.ReadKey().KeyChar;
            //        sb[i] = c;
            //        Console.WriteLine(sb);
            //        day += c;

            //    }
            //    while (day.Length < 2);
            //}


            //Console.Write("/");
            //string month = "";
            //do
            //{
            //    char c = Console.ReadKey().KeyChar;
            //    month += c;

            //} while (month.Length < 2);
            //Console.WriteLine();

            //Console.WriteLine("Dato: " + day + "/" + month);

            //int monthSomTal = int.Parse(month);
            //int daySomTal = int.Parse(day);

            //string datoVagt = day + "/" + month;
            //if (monthSomTal <= 12 && monthSomTal >= 1 && daySomTal <= 31 && daySomTal >= 1)
            //{
            //    DateTime dag = DateTime.Parse(datoVagt);

            //    e.vagtDato = dag;
            //    //skal gemmes

            //}


            //Console.WriteLine("angiv starttid: ");
            //string startDate = Console.ReadLine();
            //Console.WriteLine("angiv sluttid: ");
            //string endDate = Console.ReadLine();


            //TimeSpan s = vagt.Timer(startDate, endDate);
            //Console.WriteLine(employee.TotalHoursWorked = s);


        }
    }
}
