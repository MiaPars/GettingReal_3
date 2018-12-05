using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GettingReal_3
{
    public class EmployeeRepository
    {
        public List<Employee> employees = new List<Employee>();

        public void ShowEmployeeList()
        {
            foreach (Employee item in employees)
            {
                Console.WriteLine(item);
            }
        }
        public void AddEmployee()
        {
            employees = new List<Employee>
            {
                new Employee("Egon"),
                new Employee("hans"),
                new Employee("Rudy")
            };


            //Employee medarbejder = new Employee();

            //Console.WriteLine("Navn?");
            //medarbejder.Navn = Console.ReadLine();

            //Console.WriteLine("Addresse?");
            //medarbejder.Addresse = Console.ReadLine();

            //Console.WriteLine("Email?");
            //medarbejder.Email = Console.ReadLine();

            //employees.Add(medarbejder);
        }

        public void RemoveEmployee()
        {

        }

        public Employee CheckEmployee(string input)
        {
            foreach (Employee item in employees)
            {
                if (input.Equals(item.Name))
                {
                    return item;
                }
                //else if (!input.Equals(item.Name))
                //{
                //    throw new Exception("prøv igen");
                //}
            }
            return null;
        }
    }
}
