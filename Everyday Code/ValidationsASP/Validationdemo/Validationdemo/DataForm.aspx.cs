using System;

using System.Collections.Generic;

using System.Linq;

using System.Web;

using System.Web.UI;

using System.Web.UI.WebControls;

using System.Data;

using System.Data.SqlClient;

namespace Validationdemo

{

    public partial class DataForm : System.Web.UI.Page

    {

        protected void Page_Load(object sender, EventArgs e)

        {

            SqlConnection sqlConnection = null;

            sqlConnection = new SqlConnection("Integrated security=true;database=SQL_Day_1;server=(localdb)\\MSSQLLocalDB");

            sqlConnection.Open();

            SqlCommand cmd = new SqlCommand("select * from Employee", sqlConnection);

           
            GridView2.DataSource = cmd.ExecuteReader();
            GridView2.DataBind();
        }

    }

}
