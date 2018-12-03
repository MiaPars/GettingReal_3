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
        public string Name
        {
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
            employees = new List<Employee>
            {
                new Employee("Egon", "jagade 21", "123@gmail.com"),
                new Employee("hans", "nejgade 21", "1223@gmail.com"),
                new Employee("Rudy", "måskevej", "123123123@gmail.com")
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

        public bool CheckEmployee(string input)
        {
            foreach (Employee item in employees)
            {
                if (input.Equals(item.Name))
                {
                    return true;
                }
                else if (!input.Equals(item.Name))
                {
                    throw new Exception("prøv igen");
                }
            }
            return false;

        }
    }
}
