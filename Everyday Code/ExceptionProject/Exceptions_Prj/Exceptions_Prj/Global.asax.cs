using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;

namespace Exceptions_Prj
{
    public class Global : System.Web.HttpApplication
    {

        protected void Application_Start(object sender, EventArgs e)
        {

        }

        protected void Session_Start(object sender, EventArgs e)
        {

        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {

        }

        protected void Application_AuthenticateRequest(object sender, EventArgs e)
        {

        }

        

        protected void Session_End(object sender, EventArgs e)
        {

        }

        protected void Application_End(object sender, EventArgs e)
        {

        }


        protected void Application_Error(object sender, EventArgs e)
        {
           
            Exception ex = Server.GetLastError();

            Server.ClearError();
            string errorDetails =
                "Date: " + DateTime.Now + Environment.NewLine +
                "Message: " + ex.Message + Environment.NewLine +
                "Source: " + ex.Source + Environment.NewLine +
                "StackTrace: " + ex.StackTrace + Environment.NewLine +
                "----------------------------------------" + Environment.NewLine;

            string path = Server.MapPath("~/Error.txt");

            File.AppendAllText(path, errorDetails);

            Server.Transfer("~/PageNotFound.aspx");
        }
    }
}