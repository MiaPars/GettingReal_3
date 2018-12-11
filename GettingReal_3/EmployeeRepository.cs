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
            
            //Console.WriteLine("Indtast navn: ");
            //string newEmployee = Console.ReadLine();
            //Console.WriteLine(newEmployee);
            //noget værre kagemand.
            

            //Console.WriteLine("Navn?");
            //medarbejder.Navn = Console.ReadLine();


            //employees.Add(medarbejder);
        }

        public void RemoveEmployee()
        {

        }

        public Employee CheckEmployee(string input)
        {
            string navn = input;
            string lower = navn.ToLower();

            foreach (Employee item in employees)
            {
                item.Name.ToLower();

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
