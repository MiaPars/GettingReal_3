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
        SQL sql = new SQL();


        public void ShowEmployeeList()
        {
            foreach (Employee item in employees)
            {
                Console.WriteLine(item.Name);
            }
            
        }
        public void AddEmployee()
        {
            Console.Write("Navn på ny medarbejder: ");
            string empName = Console.ReadLine();

            sql.InsertToEmployee(empName);

            //ved ikke om vi har brug for listen
            employees.Add(new Employee(empName));
            
            Console.WriteLine("Medarbejder tilføjet");
            
        }

        public void RemoveEmployee()
        {
            Console.Write("Navn på slet af employee: ");
            string empName = Console.ReadLine();

            for (int i = 0; i < employees.Count; i++)
            {
                if (empName.Equals(employees[i].Name))
                {
                    employees.RemoveAt(i);
                    Console.WriteLine(employees[i].Name + "Er nu blevet slettet");
                }
            
            }

            
        }

        public Employee CheckEmployee(string input)
        {
            foreach (Employee item in employees)
            {
                if (input.Equals(item.Name, StringComparison.OrdinalIgnoreCase))
                {
                    return item;
                }
            }
            return null;
        }
    }
}
