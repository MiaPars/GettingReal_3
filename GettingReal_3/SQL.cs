using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace GettingReal_3
{
    public class SQL

    {
        private static string connectionString = "Data Source= den1.mssql7.gear.host; Initial Catalog=gettingreal ; User Id=gettingreal; Password=Kx8ig9R5w~h-;";

        public void InsertToEmployee(string employeeNavn)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                try
                {
                    SqlCommand insertToEmployee = new SqlCommand("InsertToMedarbejder", conn);
                    insertToEmployee.CommandType = CommandType.StoredProcedure;
                    insertToEmployee.Parameters.Add(new SqlParameter("@Navn", employeeNavn));
                    
                    insertToEmployee.ExecuteNonQuery();
                }


                catch (SqlException e)
                {
                    Console.WriteLine("Insert to employee fejl" + e.Message);
                }
            }
        }

        public void InsertToShift(DateTime dato, DateTime startTid, DateTime slutTid)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                try
                {
                    SqlCommand insertToShift = new SqlCommand("InsertToVagt", conn);
                    insertToShift.CommandType = CommandType.StoredProcedure;
                    insertToShift.Parameters.Add(new SqlParameter("@date", dato));
                    insertToShift.Parameters.Add(new SqlParameter("@startTid", startTid));
                    insertToShift.Parameters.Add(new SqlParameter("@slutTid", slutTid));
                    insertToShift.ExecuteNonQuery();
                }
                catch(SqlException e)
                {
                    Console.WriteLine("Insert to shift fejl" + e.Message);
                }
            }
        }
        
    }
}
