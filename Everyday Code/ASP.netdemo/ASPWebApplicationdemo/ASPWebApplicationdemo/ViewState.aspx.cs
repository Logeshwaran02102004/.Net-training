using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASPWebApplicationdemo
{
    public partial class ViewState : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnStore_Click(object sender, EventArgs e)
        {
            ViewState["uname"]=txtusername.Text;
            ViewState["upass"]=txtpass.Text;
            txtusername.Text = "";
            txtpass.Text = string.Empty;

        }

        protected void BtnLoad_Click(object sender, EventArgs e)
        {
            //lblmessage.Text = "Your user name is: " + ViewState["uname"].ToString() 
            //    + "your password is:" + ViewState["upass"].ToString();

            //string u, v;
            //u = ViewState["uname"].ToString();
            //v =  ViewState["upass"].ToString();

            //lblmessage.Text = "your name is: " + u + " " + "your pass is: " + v;

            Response.Redirect("TestForm.aspx");



        }
    }
}