using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ElectricityBill
{
    public partial class ShowingTheBill : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btnFetch_Click(object sender, EventArgs e)
        {
            int n = Convert.ToInt32(txtN.Text);
            if (n > 0)
            {
                ElectricityBoard eb = new ElectricityBoard();
                List<ElectricityBill> bills = eb.GetLastNBills(n);

                GridView1.DataSource = bills;
                GridView1.DataBind();
            }
            else
            {

                Response.Write("<script>alert('Please enter a valid number');</script>");
            }
        }
    }
}