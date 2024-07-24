using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace cc1
{
    class EmployeeManagement
    {
        static void Main(string[] args)
        {
            string con = (@"data source=ICS-LT-17YRQ73\SQLEXPRESS; initial catalog=EmployeeManagement;" + "user id=sa; password=santu2001;");

            Console.Write("Enter Employee Name: ");
            string empName = Console.ReadLine();

            Console.Write("Enter Employee Salary: ");
            int empSal = int.Parse(Console.ReadLine());

            Console.Write("Enter Employee Type (F for Fulltime, P for Parttime): ");
            char empType = char.Parse(Console.ReadLine().ToUpper());

            using (SqlConnection connection = new SqlConnection(con))
            {
                try
                {
                    connection.Open();
                    Console.WriteLine("Connection to database successful!");

                    // Call the stored procedure & add employee and get the new Empno
                    using (SqlCommand cmd = new SqlCommand("InsertEmployee", connection))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@EmpName", empName);
                        cmd.Parameters.AddWithValue("@Empsal", empSal);
                        cmd.Parameters.AddWithValue("@Emptype", empType);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                int newEmpno = reader.GetInt32(reader.GetOrdinal("NewEmpno"));
                                Console.WriteLine($"New employee inserted with Empno: {newEmpno}");
                            }
                        }
                    }

                    // Retrieve & display all employee details
                    string selectQuery = "SELECT * FROM Employee_Details";
                    using (SqlCommand sc = new SqlCommand(selectQuery, connection))
                    {
                        using (SqlDataReader reader = sc.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Console.WriteLine($"Empno: {reader["Empno"]}, EmpName: {reader["EmpName"]}, Empsal: {reader["Empsal"]}, Emptype: {reader["Emptype"]}");
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("An error occurred: " + ex.Message);
                }
            }
            Console.Read();
        }
    }
}
