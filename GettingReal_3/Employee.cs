using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GettingReal_3
{
    public class Employee
    {
        public List<Employee> employees = new List<Employee>();

        public string Navn
        {
            get;
            set;
        }

        public string Addresse
        {
            get;
            set;
        }
        public string Email
        {
            get;
            set;
        }

        public void AddEmployee()
        {
            Employee medarbejder = new Employee();

            Console.WriteLine("Navn?");            
            medarbejder.Navn = Console.ReadLine();

            Console.WriteLine("Addresse?");
            medarbejder.Addresse = Console.ReadLine();

            Console.WriteLine("Email?");
            medarbejder.Email = Console.ReadLine();

            employees.Add(medarbejder);
        }

        public void RemoveEmployee()
        {

        }

    }
}
