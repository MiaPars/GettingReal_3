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
        private string connectionString = "Data Source= den1.mssql7.gear.host; Initial Catalog=gettingreal ; User Id=gettingreal; Password=Kx8ig9R5w~h-;";

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
        public void DeleteEmployee(string employeeNavn)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                try
                {
                    SqlCommand deleteEmployee = new SqlCommand("DeleteEmployee", conn);
                    deleteEmployee.CommandType = CommandType.StoredProcedure;
                    deleteEmployee.Parameters.Add(new SqlParameter("@Medarbejder", employeeNavn));

                    deleteEmployee.ExecuteNonQuery();
                }
                catch (SqlException n)
                {
                    Console.WriteLine("Delete employee virker ikke" + n.Message);

                }
            }
        }

        public void InsertToShift(string butikNavn, DateTime dato, string morgenAften, string medarbejder, DateTime startTid, DateTime slutTid)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                try
                {
                    SqlCommand insertToShift = new SqlCommand("IndsætVagt", conn);
                    insertToShift.CommandType = CommandType.StoredProcedure;
                    insertToShift.Parameters.Add(new SqlParameter("@ButikNavn", butikNavn));
                    insertToShift.Parameters.Add(new SqlParameter("@Dato", dato));
                    insertToShift.Parameters.Add(new SqlParameter("@MorgenAften", morgenAften));
                    insertToShift.Parameters.Add(new SqlParameter("@Medarbejder", medarbejder));
                    insertToShift.Parameters.Add(new SqlParameter("@startTid", startTid));
                    insertToShift.Parameters.Add(new SqlParameter("@slutTid", slutTid));

                    insertToShift.ExecuteNonQuery();

                }
                catch (SqlException e)
                {
                    Console.WriteLine("Insert to shift fejl" + e.Message);
                }
            }


        }

        public void PlanShift(string ButikNavn, DateTime dato, string MorgenAften, string Medarbejder)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                try
                {
                    SqlCommand planShift = new SqlCommand("Planlæg", conn);
                    planShift.CommandType = CommandType.StoredProcedure;
                    planShift.Parameters.Add(new SqlParameter("@ButikNavn", ButikNavn));
                    planShift.Parameters.Add(new SqlParameter("@Dato", dato));
                    planShift.Parameters.Add(new SqlParameter("@MorgenAften", MorgenAften));
                    planShift.Parameters.Add(new SqlParameter("@Medarbejder", Medarbejder));
                    planShift.ExecuteNonQuery();

                }
                catch (SqlException e)
                {
                    Console.WriteLine("PlanShift virker ikke" + e.Message);
                }
                
                
            }
        }

        
    }
}