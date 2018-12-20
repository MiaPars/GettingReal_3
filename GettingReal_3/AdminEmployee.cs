using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GettingReal_3
{
    public class AdminEmployee
    {
        Shift shift = new Shift();
        Employee employee = new Employee();
        SQL sql = new SQL();
        public void RegisterHours(Employee employeee, Store store)
        {
            Console.WriteLine("intast morgen eller aften: ");
            string morgenAften = Console.ReadLine();
            morgenAften.ToLower();

            while (!morgenAften.Equals("morgen") && !morgenAften.Equals("aften"))
            {
                Console.WriteLine("Du har intastet forkert, prøv igen: ");
                morgenAften = Console.ReadLine();
            }

            DateTime dag = new DateTime();
            DateTime startTime = new DateTime();
            DateTime endTime = new DateTime();

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
            
            string ShiftDate = dato.ToString();
            string ShiftStartTime = startTid.ToString();
            string ShiftEndTime = slutTid.ToString();

            string day = dato[0].ToString() + dato[1].ToString();
            string month = dato[3].ToString() + dato[4].ToString();

            //for at tjekke om det er en rigtig dato:
            int dayAsNum = int.Parse(day);
            int monthAsNum = int.Parse(month);

            if (monthAsNum <= 12 && monthAsNum >= 1 && dayAsNum <= 31 && dayAsNum >= 1)
            {
                dag = DateTime.Parse(ShiftDate);
                this.employee.ShiftDate = dag;
            }

            startTime = DateTime.Parse(startTid.ToString());
            endTime = DateTime.Parse(slutTid.ToString());

            //insæt til properties:
            shift.Day = dag;
            shift.StartTime = startTime;
            shift.EndTime = endTime;
            
            TimeSpan s = shift.Timer(startTid.ToString(), slutTid.ToString());
            employee.TotalHoursWorked = s;

            //insætter til sql:
            sql.InsertToShift(store.StoreName, shift.Day, morgenAften, employeee.EmployeeName, shift.StartTime, shift.EndTime, employee.TotalHoursToDouble());

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

        public void EndedShifts()
        {
            sql.GetData();
        }
    }
    
}
