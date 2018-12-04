using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GettingReal_3
{
    public class Admin
    {
        Store store = new Store();
        public void AddEmployee()
        {
            store.AddEmployee();
        }

        public void RemoveEmployee()
        {
            store.RemoveEmployee();
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

