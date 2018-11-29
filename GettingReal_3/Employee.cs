using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GettingReal_3
{
    public class Employee
    {
        List<Employee> employees = new List<Employee>();

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

        public void AddEmployee(string Navn, string Addresse, string Email)
        {
            Employee medarbejder = new Employee();
            medarbejder.Navn = Navn;
            medarbejder.Addresse = Addresse;
            medarbejder.Email = Email;

            employees.Add(medarbejder);
        }

        public void RemoveEmployee()
        {

        }

    }
}
