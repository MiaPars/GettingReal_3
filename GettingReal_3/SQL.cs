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

        public void Run()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();

                    SqlCommand insertToEmployee = new SqlCommand("SP", con);
                    insertToEmployee.CommandType = CommandType.StoredProcedure;




                    insertToEmployee.ExecuteNonQuery();




                }

                catch (SqlException e)
                {
                    Console.WriteLine("Insert to employee fejl" + e.Message);
                }
            }
        }

    }
}
