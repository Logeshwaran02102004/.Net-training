using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASPWebApplicationdemo
{
    public partial class CookieSource : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnStore_Click(object sender, EventArgs e)
        {
            HttpCookie cookie = new HttpCookie("MyCookie");
            cookie["uname"]=txtusername.Text;//uname is cookie key 
            cookie["upass"] = txtpass.Text;




        }

        protected void BtnRedirect_Click(object sender, EventArgs e)
        {

        }
    }
}