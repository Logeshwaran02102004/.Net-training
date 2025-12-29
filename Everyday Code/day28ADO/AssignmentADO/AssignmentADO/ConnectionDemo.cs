using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentADO
{
    internal class ConnectionDemo
    {
        // procedures to return the values between the two dates
        public void Showprocedure()
        {
            using (SqlConnection con = new SqlConnection("Integrated security=true;database=SQL_DAY_1;server=(localdb)\\MSSQLLocalDB"))
            {
                con.Open();

                SqlCommand cmd = new SqlCommand("sp_getempusingdate", con);
                cmd.CommandType = CommandType.StoredProcedure;
                Console.WriteLine("Enter the FromDate :");
                DateTime Fromdate = Convert.ToDateTime(Console.ReadLine());

                Console.WriteLine("Enter the toddate :");
                DateTime Todate = Convert.ToDateTime(Console.ReadLine());

                cmd.Parameters.AddWithValue("@fromdate",Fromdate);
                cmd.Parameters.AddWithValue("@todate",Todate);

                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    Console.WriteLine($"{dr[0]}   {dr[1]}   {dr[2]}    {dr[3]}    {dr[4]}");
                }
            }
        }

        public void EmpTransaction()
        {

            SqlTransaction tr = null;

            try
            {
                // Add records to employee table
                SqlConnection con = new SqlConnection("Integrated security=true;database=SQL_DAY_1;server=(localdb)\\MSSQLLocalDB");
                con.Open(); // creates a new connection

                tr = con.BeginTransaction();// starts the transaction
                                            // writes a command

                SqlCommand cmd1 = new SqlCommand("insert into one values(2,'vijay')", con);
                SqlCommand cmd2 = new SqlCommand("insert into two values(1,'vijay')", con);

                cmd1.Transaction = tr;// now cmd1 will be part of transaction
                cmd2.Transaction = tr;// now cmd2 will be part of transaction
                int rowaffected1 = cmd1.ExecuteNonQuery();
                int rowaffected2 = cmd2.ExecuteNonQuery();
                Console.WriteLine("Total Records Inserted is " + rowaffected1);
                Console.WriteLine("Total Records Inserted is " + rowaffected2);
                tr.Commit();
                con.Close();

            }
            catch (Exception ex)
            {
                tr.Rollback();
                Console.WriteLine("Could not complete.. try again...");
            }






        }

        public void InsertRecordsusingtrans()
        {
            SqlTransaction sqlTransaction = null;

            Console.Write("Enter The New Name: ");
            string EmployeeName = Console.ReadLine();
            Console.Write("Enter The Employee Salary: ");
            decimal NewSalary = Convert.ToDecimal(Console.ReadLine());
            Console.Write("Enter Date of Joining: ");
            string Empjoingdate = Console.ReadLine();
            Console.Write("Enter the Dept id: ");
            int deptId = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the Dept id: ");
            string deptName = Console.ReadLine();

            try
            {
                SqlConnection connection = new SqlConnection("Integrated security = true; database = SQL_DAY_1; server = (localdb)\\MSSQLLocalDB");
                connection.Open();

                sqlTransaction = connection.BeginTransaction();

                string query1 = "insert into Employee (EmpName, Salary, DateOfJoin, DeptID) " +
                               "values (@EmpName, @Salary, @DateOfJoin, @DeptID)";

                string query2 = "insert into Department (DeptID, DeptName) " + "values (@DeptID, @DeptName)";
                SqlCommand cmd = new SqlCommand(query1, connection);
                SqlCommand cmd2 = new SqlCommand(query2, connection);
                cmd.Transaction = sqlTransaction;
                cmd2.Transaction = sqlTransaction;
                cmd.Parameters.AddWithValue("@EmpName", EmployeeName);
                cmd.Parameters.AddWithValue("@Salary", NewSalary);
                cmd.Parameters.AddWithValue("@DateOfJoin", Empjoingdate);
                cmd.Parameters.AddWithValue("@DeptID", deptId);
                cmd2.Parameters.AddWithValue("@DeptName", deptName);

                int r1 = cmd.ExecuteNonQuery();
                int r2 = cmd2.ExecuteNonQuery();
                sqlTransaction.Commit();

                Console.WriteLine("Total Records Inserted: " + r1);
                Console.WriteLine("Total Records Inserted: " + r2);


                connection.Close();
            }
            catch (Exception ex)
            {
                sqlTransaction.Rollback();
                Console.WriteLine("Error:" + ex.Message);
            }
        }

    }
}
