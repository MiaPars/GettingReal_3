using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GettingReal_3
{
    public class Admin
    {
        EmployeeRepository RepoEmp = new EmployeeRepository();
        Program p = new Program();
        public void AddEmployee()
        {
            RepoEmp.AddEmployee();
            Console.Clear();
            p.Run();
        }

        public void RemoveEmployee()
        {
            RepoEmp.RemoveEmployee();
        }
        public void PlanShift()
        {

        }




        //public void ExportExcel()
        //{
        //    Gemme fra C# til Excel
        //    Kopieret fra nettet
        //    OdbcConnection connection = new OdbcConnection(@"Driver={Microsoft Excel Driver (*.xls)};DriverId=790;Dbq=" + xlsFilePath + "; ReadOnly=False; DefaultDir=" + xlsDir + ";");
        //    then you can create a IDbCommand like this: IDbCommand command = connection.CreateCommand();
        //}


    }
}

