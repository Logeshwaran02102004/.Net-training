using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentADOdisconnect
{
    internal class Disconnect
    {
        DataSet ds = new DataSet();
        DataTable dt = new DataTable();
        DataTable dt2 = new DataTable();
        SqlDataAdapter da;
        SqlDataAdapter da1;
        public void showemployeeanddept()
        {
            SqlConnection con = new SqlConnection("Integrated security=true; database=SQL_DAY_1; server=(localdb)\\MSSQLLocalDB");
            da = new SqlDataAdapter("select * from Employee", con);
            da1 = new SqlDataAdapter("select * from Department", con);
            SqlCommandBuilder cmd = new SqlCommandBuilder(da);
            da.MissingSchemaAction = MissingSchemaAction.AddWithKey;
            da.Fill(ds, "emp");
            da1.Fill(ds, "dep");

            dt = ds.Tables["emp"];
            dt2 = ds.Tables["dep"];
            Console.WriteLine("employee +++++++++++++++++++++++++++");
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                Console.WriteLine(dt.Rows[i][0]);
                Console.WriteLine(dt.Rows[i][1]);
                Console.WriteLine(dt.Rows[i][2]);
                Console.WriteLine(dt.Rows[i][3]);
                Console.WriteLine(dt.Rows[i][4]);

            }

            Console.WriteLine("department ++++++++++++++++++++++++++++++++++++");

            for (int i = 0; i < dt2.Rows.Count; i++)
            {
                Console.WriteLine(dt2.Rows[i][0]);
                Console.WriteLine(dt2.Rows[i][1]);
            }

        }

        public void SortingtheEmployee()
        {
            DataView l = new DataView(dt);

            l.RowFilter = "salary > 47000 and Deptid = 10 and EmpName like 'm%'";
            l.Sort = "EmpName ASC";
            Console.WriteLine("sorted employees are ++++++++++++++++++++++");
            foreach (DataRowView item in l)
            {
                Console.WriteLine(item[0]);
                Console.WriteLine(item[1]);
                Console.WriteLine(item[2]);
                Console.WriteLine(item[3]);
                Console.WriteLine(item[4]);
            }
        }

        public void NumberofTables()
        {
            int numberoftables = ds.Tables.Count;
            Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++++++++");
            Console.WriteLine("Number of tables inside the Dataset : " + numberoftables);
        }

        public void DepartmentTableLoader()
        {
            SqlConnection con = new SqlConnection("Integrated security=true; database=SQL_DAY_1; server=(localdb)\\MSSQLLocalDB");
            DataTable dt = new DataTable();
            con.Open();

            SqlCommand cmd = new SqlCommand("SELECT * FROM Department", con);
            SqlDataReader dr = cmd.ExecuteReader();

            dt.Load(dr);

            dr.Close();

            Console.WriteLine("Employee Data : ");
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                Console.WriteLine(dt.Rows[i][0]);
                Console.WriteLine(dt.Rows[i][1]);
            }
        }

        public void MergingDataSets()
        {
            DataSet data1 = new DataSet();
            DataSet data2 = new DataSet();

            SqlConnection con = new SqlConnection("Integrated security=true; database=SQL_DAY_1; server=(localdb)\\MSSQLLocalDB");
            SqlDataAdapter daa1 = new SqlDataAdapter("select * from Customers", con);
            SqlDataAdapter daa2 = new SqlDataAdapter("select * from Orders", con);

            daa1.Fill(data1, "Customers");

            daa2.Fill(data2, "Orders");

            data1.Merge(data2);

            foreach (DataRow row in data1.Tables["Customers"].Rows)
            {
                Console.WriteLine($"{row[0]}  {row[1]} {row[2]} {row[3]} {row[4]}");
            }

            foreach (DataRow row in data1.Tables["Orders"].Rows)
            {
                Console.WriteLine($"{row[0]}  {row[1]}  {row[2]}  {row[3]} {row[4]} {row[5]}");
            }
        }


        public void ReadXMLDataSource()

        {

            DataSet ds = new DataSet();

            ds.ReadXml(@"C:\dotnet_training\Assignments\DisconnectedConsoleApp\DisconnectedConsoleApp\XMLFile1.xml");

            if (ds.Tables.Count > 0)

            {

                DataTable dt = ds.Tables[0];

                foreach (DataRow row in dt.Rows)

                {

                    Console.WriteLine($"{row["CUSTID"]}\t{row["CUSTNAME"]}\t{row["CUSTADDRESS"]}\t{row["PHONE"]}");

                }

            }

            else

            {

                Console.WriteLine("No data found in XML.");

            }

            Console.ReadLine();

        }

    }
}
