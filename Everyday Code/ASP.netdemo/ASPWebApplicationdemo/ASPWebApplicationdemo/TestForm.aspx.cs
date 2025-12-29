using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASPWebApplicationdemo
{
    public partial class TestForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (ViewState["uname"]!=null && ViewState["upass"]!=null)
            {
                lblmsg.Text = $"Your name  is :{ViewState["uname"]} and your password is: {ViewState["upass"]}";
            }
            else
            {
                lblmsg.Text = "User not available";
            }



        }
    }
}