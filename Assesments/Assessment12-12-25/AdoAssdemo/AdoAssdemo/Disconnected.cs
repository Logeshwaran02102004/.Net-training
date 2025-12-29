using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoAssdemo
{
    internal class Disconnected
    {
        DataSet ds = new DataSet();
        DataTable dt1 = new DataTable();
        DataTable dt2 = new DataTable();
        SqlDataAdapter da;
        SqlConnection con = new SqlConnection("Integrated security=true;database=Adodatabase;server=(localdb)\\MSSQLLocalDB");


        public void Loadstucouindataset()
        {
            SqlDataAdapter da1 = new SqlDataAdapter("select * from Students", con);
            SqlDataAdapter da2 = new SqlDataAdapter("select * from Courses", con);
            SqlCommandBuilder cmd = new SqlCommandBuilder(da1);
            da1.MissingSchemaAction = MissingSchemaAction.AddWithKey;
            da2.MissingSchemaAction = MissingSchemaAction.AddWithKey;


            da1.Fill(ds, "students");
            dt1 = ds.Tables["students"];

            da2.Fill(ds, "courses");
            dt2 = ds.Tables["courses"];

            Console.WriteLine("The Student Table is Printed Below");
            for (int i = 0; i < dt1.Rows.Count; i++)
            {
                Console.WriteLine(dt1.Rows[i][0]);
                Console.WriteLine(dt1.Rows[i][1]);
                Console.WriteLine(dt1.Rows[i][2]);
                Console.WriteLine(dt1.Rows[i][3]);
                Console.WriteLine(dt1.Rows[i][4]);
            }

            Console.WriteLine("The Courses Table is Printed Below");
            for (int i = 0; i < dt2.Rows.Count; i++)
            {
                Console.WriteLine(dt2.Rows[i][0]);
                Console.WriteLine(dt2.Rows[i][1]);
                Console.WriteLine(dt2.Rows[i][2]);
                Console.WriteLine(dt2.Rows[i][3]);
            }
        }


        public void UpdateCredits()
        {
            Console.WriteLine("Enter the Course Id : ");
            int courseid = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Enter the Credit To Update : ");
            int credits = Convert.ToInt16(Console.ReadLine());

            DataRow row = dt2.Rows.Find(courseid);

            row["Credits"] = credits;

            da = new SqlDataAdapter("select * from Courses", con);
            SqlCommandBuilder cb = new SqlCommandBuilder(da);

            da.Update(ds, "courses");

            Console.WriteLine("credits Updated");

        }


        public void InsertNewCourse()
        {
            Console.WriteLine("Enter the course id : ");
            int courseid = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the course name : ");
            string coursename = Console.ReadLine();
            Console.WriteLine("Enter the Credits : ");
            int credits = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the semester : ");
            string semester = Console.ReadLine();

            DataRow newRow = dt2.NewRow();

            newRow["courseid"] = courseid;
            newRow["coursename"] = coursename;
            newRow["credits"] = credits;
            newRow["semester"] = semester;

            dt2.Rows.Add(newRow);
            da = new SqlDataAdapter("select * from Courses", con);
            SqlCommandBuilder cb = new SqlCommandBuilder(da);
            da.Update(ds, "courses");

            Console.WriteLine("new course are updated ");
        }




        public void DeleteStudent()
        {
            Console.WriteLine("enter the id :  ");
            int sid = Convert.ToInt32(Console.ReadLine());

            DataRow row = dt1.Rows.Find(sid);

            row.Delete();

            SqlDataAdapter da1 = new SqlDataAdapter("select * from Students", con);
            SqlCommandBuilder cb = new SqlCommandBuilder(da1);

            da1.Update(ds, "Students");

            Console.WriteLine("student id is deleted");
        }


    }
}
