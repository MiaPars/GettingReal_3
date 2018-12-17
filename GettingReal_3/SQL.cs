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
            if (CheckEmployee(employeeNavn) != null)
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
                        Console.WriteLine("Feeeeeeeeeejl" + n.Message);

                    }
                }
            }
            else
            {
                Console.WriteLine("Forkert navn");
            }

        }

        public Employee CheckEmployee(string employeeNavn)
        {
            Employee empl = new Employee();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                try
                {
                    SqlCommand checkEmployee = new SqlCommand("CheckMedarbejder", conn);
                    checkEmployee.CommandType = CommandType.StoredProcedure;
                    checkEmployee.Parameters.Add(new SqlParameter("@Medarbejder", employeeNavn));

                    string Medarbejder = checkEmployee.ExecuteScalar()?.ToString();
                    string lower = Medarbejder.ToLower();
                    string inputToLower = employeeNavn.ToLower();
                    
                    if (lower == inputToLower)
                    {
                        return empl;
                    }
                    else
                    {
                        return null;
                    }
                }
                catch (SqlException p)
                {
                    Console.WriteLine("Puha" + p.Message);
                    return null;
                }
            }
        }

        public void InsertToShift(string butikNavn, DateTime dato, string morgenAften, string medarbejder, DateTime startTid, DateTime slutTid, double antalTimer)
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
                    insertToShift.Parameters.Add(new SqlParameter("@antalTimer", antalTimer));
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

        public void GetData()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                using (SqlCommand getData = new SqlCommand("UdskrivVagt", conn))
                {
                    using (SqlDataReader reader = getData.ExecuteReader())
                    {
                        while (reader.Read())
                        {

                           
                                string Butiknavn = reader["ButikNavn"].ToString();
                                string Dato = reader["Dato"].ToString();
                                string MorgenAften = reader["MorgenAften"].ToString();
                                string Medarbejder = reader["Medarbejder"].ToString();
                                string StartTid = reader["StartTid"].ToString();
                                string SlutTid = reader["SlutTid"].ToString();
                                string AntalTimer = reader["AntalTimer"].ToString();

                                Console.Write("Butiknavn: " + Butiknavn + "\nDato: " + Dato + "\nMorgen eller Aften: " + 
                                    MorgenAften + "\nMedarbejder navn: " + Medarbejder + "\nStart tid: " + StartTid + "\nSlut tid: " +
                                    SlutTid + "\nAntal timer arbejdet: " + AntalTimer);
                            Console.WriteLine();
                            

                        }
                    }
                }
            }
        }

        
    }
}