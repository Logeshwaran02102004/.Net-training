using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DropDownListdemo
{
    public partial class ProductDeatails : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }



        protected void ProductSelectingIndex(object sender, EventArgs e)
        {
            if (dropdownProducts.SelectedValue == "1")
                imgProduct.ImageUrl = "hodie.jpg";

            else if (dropdownProducts.SelectedValue == "2")
                imgProduct.ImageUrl = "sunglass.jpg";

            else if (dropdownProducts.SelectedValue == "3")
                imgProduct.ImageUrl = "tshirt.jpg";

            else
                imgProduct.ImageUrl = "";
        }

        protected void btnPrice_Click(object sender, EventArgs e)
        {
            if (dropdownProducts.SelectedValue == "1")
                lblPrice.Text = "Price: ₹1799";

            else if (dropdownProducts.SelectedValue == "2")
                lblPrice.Text = "Price: ₹2000";

            else if (dropdownProducts.SelectedValue == "3")
                lblPrice.Text = "Price: ₹499";

            else
                lblPrice.Text = "Please select a product in the drop down list ";
        }
    }
}