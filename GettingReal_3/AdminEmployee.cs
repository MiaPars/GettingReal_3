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
        SQL sql = new SQL();
        public void RegistrerTimer(Employee employee,  Store store)
        {
            DateTime dag = new DateTime();

            string startString1 = "../..";
            string startString2 = "..:..";
            char ignore = '/';
            char ignore1 = ':';
            string message = "Registrer en vagt. Skriv som DD/MM: \n";
            string message1 = "Registrer start tid. Skriv som TT:MM \n";
            string message2 = "Registrer slut tid. Skriv som TT:MM \n";

            StringBuilder dato = InputDateTime(startString1, ignore, message);
            Console.ReadKey();
            StringBuilder startTid = InputDateTime(startString2, ignore1, message1);
            Console.ReadKey();
            StringBuilder slutTid = InputDateTime(startString2, ignore1, message2);

            string day = dato[0].ToString() + dato[1].ToString();
            string month = dato[3].ToString() + dato[4].ToString();

            string datoVagt = dato.ToString();

            int daySomTal = int.Parse(day);
            int monthSomTal = int.Parse(month);

            if (monthSomTal <= 12 && monthSomTal >= 1 && daySomTal <= 31 && daySomTal >= 1)
            {
                dag = DateTime.Parse(datoVagt);
                e.VagtDato = dag;
                //skal gemmes
            }
            
            //tjekker ikke for hvilket tal man sætter ind..
            TimeSpan s = vagt.Timer(startTid.ToString(), slutTid.ToString());


            employee.TotalHoursWorked = s;

            //insætter til sql:
            sql.InsertToShift(vagt.Day, vagt.StartTime, vagt.EndTime, employee.TotalHoursToDouble());

        }
        private StringBuilder InputDateTime(string startString, char ignoreChar, string message)
        {
            string start = startString;

            StringBuilder sb = new StringBuilder(start);
            for (int i = 0; i < sb.Length; i++)
            {
                if (sb[i].Equals(ignoreChar))
                {
                    i++;
                }

                Console.Clear();
                Console.Write(message);

                Console.WriteLine(sb);
                sb[i] = Console.ReadKey(true).KeyChar;
                Console.WriteLine(sb);
            }
            Console.Clear();
            Console.Write(message);
            Console.WriteLine(sb);
            return sb;
        }
    }
}
