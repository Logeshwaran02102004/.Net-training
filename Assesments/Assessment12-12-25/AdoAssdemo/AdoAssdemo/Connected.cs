using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoAssdemo
{
    internal class Connected
    {
        public void DisplayAllcourses()
        {
            SqlConnection con = new SqlConnection("Integrated security=true;database=Adodatabase;server=(localdb)\\MSSQLLocalDB");
            con.Open();
            SqlCommand cmd = new SqlCommand("select courseid, coursename, credits, semester from Courses", con);
            SqlDataReader dr = cmd.ExecuteReader();
            Console.WriteLine("The couses list is given below");
            while (dr.Read())  
            {

                Console.WriteLine($"CourseID: {dr[0]}   CourseName: {dr[1]}   Credits: {dr[2]}    Semester: {dr[3]}  ");

            }
            con.Close();

        }


        public void Addnewstudent()
        {

            Console.WriteLine("enter fullname: ");
            string name = Console.ReadLine();

            Console.WriteLine("enter your email : ");
            string email = Console.ReadLine();

            Console.WriteLine("enter department : ");
            string department = Console.ReadLine();

            Console.WriteLine("enter year of study : ");
            int year = Convert.ToInt32(Console.ReadLine());

            SqlConnection con = new SqlConnection("Integrated security=true;database=Adodatabase;server=(localdb)\\MSSQLLocalDB");

            con.Open();

            string query = "insert into students (fullname, email, department, yearofstudy) " +
                           "values ( @name, @email, @department, @year)";

            SqlCommand cmd = new SqlCommand(query, con);

           
            cmd.Parameters.AddWithValue("@name", name);
            cmd.Parameters.AddWithValue("@email", email);
            cmd.Parameters.AddWithValue("@department", department);
            cmd.Parameters.AddWithValue("@year", year);

            int rows = cmd.ExecuteNonQuery();
            Console.WriteLine("Total Records Inserted: " + rows);

        }


        public void SearchByDept()
        {
            Console.WriteLine("Enter the Department : ");
            string department = Console.ReadLine();

            SqlConnection con = new SqlConnection("Integrated security=true;database=Adodatabase;server=(localdb)\\MSSQLLocalDB");

            con.Open();
            string query = "select studentid, fullname from Students where department = @dept";
            SqlCommand cmd = new SqlCommand(query, con);

            cmd.Parameters.AddWithValue("dept", department);

            SqlDataReader dr = cmd.ExecuteReader();
            Console.WriteLine($"The {department} students are given below");
            while (dr.Read())
            {
                Console.WriteLine($"StudentId: {dr[0]}   StudentName: {dr[1]} ");
            }
            con.Close();
        }


        public void searchByStudentId()
        {
            Console.WriteLine("Enter the StudentId : ");
            int id = Convert.ToInt32(Console.ReadLine());

            SqlConnection con = new SqlConnection("Integrated security=true;database=Adodatabase;server=(localdb)\\MSSQLLocalDB");
            con.Open();

            string query = "select c.coursename, c.credits, e.enrolldate, e.grade from Enrollments e inner join Courses c on e.courseid = c.courseid where e.studentid = @StudentId";
            SqlCommand cmd = new SqlCommand(query, con);

            cmd.Parameters.AddWithValue("@StudentId", id);
            SqlDataReader dr = cmd.ExecuteReader();
            Console.WriteLine($"The studentID {id} deatails are listed below ");
            while (dr.Read())
            {
                Console.WriteLine($"Coursename: {dr[0]}   Credits: {dr[1]}   EnrollDate: {dr[2]}   Grade: {dr[3]} ");
            }

            con.Close();
        }


        public void UpdateGrade()
        {
            Console.WriteLine("Enter The StudentId : ");
            int id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Student Grade : ");
            string grade = Console.ReadLine();

            SqlConnection con = new SqlConnection("Integrated security=true;database=Adodatabase;server=(localdb)\\MSSQLLocalDB");
            con.Open();

            string query = "update Enrollments set grade = @gde where studentid = @stuid";

            SqlCommand cmd = new SqlCommand(query, con);

            cmd.Parameters.AddWithValue("@stuid", id);
            cmd.Parameters.AddWithValue("@gde", grade);

            int rows = cmd.ExecuteNonQuery();
            Console.WriteLine("The records inserted are: " + rows);

            con.Close();
        }


        public void procedure()
        {
            Console.WriteLine("Enter which Semester : ");
            string sem = Console.ReadLine();
            SqlConnection con = new SqlConnection("Integrated security=true;database=Adodatabase;server=(localdb)\\MSSQLLocalDB");

            con.Open();
            SqlCommand cmd = new SqlCommand("sp_GetCoursesBySemester", con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter p1 = new SqlParameter("@Semester", sem);
            cmd.Parameters.Add(p1);

            SqlDataReader dr = cmd.ExecuteReader();
            Console.WriteLine("Course details by semester sre given below: ");
            while (dr.Read())
            {
                Console.WriteLine($"{dr[0]}\t{dr[1]}\t{dr[2]}");
            }
            con.Close();

        }
    }
}
