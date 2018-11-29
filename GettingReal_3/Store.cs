using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GettingReal_3
{
    public class Store
    {
        public List<Employee> employees = new List<Employee>();
        public string Name {
            get;
            set;
        }
        public void ShowEmployeeList()
        {
            foreach (Employee item in employees)
            {
                Console.WriteLine(item);
            }
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
