using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DataProjectDemo
{
    public partial class DataForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            SqlConnection con = null;
            con = new SqlConnection("Data source=(localdb)\\MSSQLLocalDB; initial catalog=SQL_DAY_1;" +
                "trusted_connection=true;");
            con.Open();

            SqlCommand cmd = new SqlCommand("select * from Employee", con);
            GridView1.DataSource = cmd.ExecuteReader();
            GridView1.DataBind();

        }
    }
}