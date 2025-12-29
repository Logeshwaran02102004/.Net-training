using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADOdemo
{
    internal class ConnectedDemo
    {
        public void ShowEmployee()
        {
            // display all records from employee table

            SqlConnection con = new SqlConnection("Integrated security=true;database=SQL_DAY_1;server=(localdb)\\MSSQLLocalDB");
            con.Open(); // creates a new connection

            // writes a command

            SqlCommand cmd = new SqlCommand("select * from employee", con);

            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read()) // run the loop only if record is found 
            {
                // it reads row by row

                Console.WriteLine($"{dr[0]}   {dr[1]}   {dr[2]}    {dr[3]}    {dr[4]}");

            }



            con.Close();

        }

        public void AddEmployee()
        {
            Console.Write("Enter The employee Name: ");
            string name = Console.ReadLine();

            Console.Write("Enter The Employee Salary: ");
            decimal newSalary = Convert.ToDecimal(Console.ReadLine());


            Console.Write("Enter Date of Joining: ");
            string doj = Console.ReadLine();


            Console.Write("Enter The Dept Id Of The Employee : ");
            int deptId = Convert.ToInt32(Console.ReadLine());

            SqlConnection con = new SqlConnection("Integrated Security=true;Database=PracticeDB;Server=(localdb)\\MSSQLLocalDB");

            con.Open();

            string query = "insert into Employee (EmpName, Salary, DateOfJoin, DeptID) " + "VALUES ('" + name + "', " + newSalary + ", '" + doj + "', " + deptId + ")";
            SqlCommand cmd = new SqlCommand(query, con);

            int rows = cmd.ExecuteNonQuery();
            Console.WriteLine("Total Records Inserted: " + rows);

            con.Close();


        }


        public void UpdateEmployee()
        {
            // update to employee table

            //update salary by id;

            Console.Write("Enter Employee Id to Update: ");
            int empId = Convert.ToInt16(Console.ReadLine());

            Console.Write("Enter employees new Name: ");
            string newName = Console.ReadLine();

            Console.Write("Enter New Salary: ");
            decimal newSalary = Convert.ToDecimal(Console.ReadLine());

            SqlConnection con = new SqlConnection("Integrated security=true;database=SQL_DAY_1;server=(localdb)\\MSSQLLocalDB");

            con.Open();

            string query = "UPDATE Employee SET EmpName = '" + newName + "', Salary = " + newSalary + " WHERE EmpID = " + empId;
            SqlCommand cmd = new SqlCommand(query, con);
            int rows = cmd.ExecuteNonQuery();

            if (rows > 0)
                Console.WriteLine("Employee updated successfully.");
            else
                Console.WriteLine("Employee not found.");

            con.Close();

        }

        public void DeleteEmployee(int employeeId)
        {
            // delete from  employee table by id
            SqlConnection con = new SqlConnection("Integrated security=true;database=SQL_DAY_1;server=(localdb)\\MSSQLLocalDB");
            con.Open();

            SqlCommand cmd = new SqlCommand("delete from employee where EmpID = " + employeeId, con);

            int rowaffected = cmd.ExecuteNonQuery();
            if (rowaffected > 0)
            {
                Console.WriteLine("given employee id deleted successfully.");
            }
            else
            {
                Console.WriteLine("Given employee id is not there.");
            }

        }
        public void Showprocedure()
        {
            // display all records from employee table

            SqlConnection con = new SqlConnection("Integrated security=true;database=SQL_DAY_1;server=(localdb)\\MSSQLLocalDB");
            con.Open(); // creates a new connection

            // writes a command

            SqlCommand cmd = new SqlCommand("sp_getemp", con);

            SqlParameter p1 = new SqlParameter("@d", 10); // create a parameter
            SqlParameter p2 = new SqlParameter("@sal", 46000);
            cmd.Parameters.Add(p1);// attaching paramater to procedure
            cmd.Parameters.Add(p2);


            cmd.CommandType = CommandType.StoredProcedure;// represents type of command u are trying to execute
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read()) // run the loop only if record is found 
            {
                // it reads row by row

                Console.WriteLine($"{dr[0]}   {dr[1]}   {dr[2]}    {dr[3]}    {dr[4]}");

            }



            con.Close();

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



    }
}
