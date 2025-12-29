using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DropDownListdemo
{
    public partial class Validation : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void FamilyNamedifference(object source, ServerValidateEventArgs args)
        {
            args.IsValid = !string.Equals(txtName.Text.Trim(), txtFamilyName.Text.Trim(), StringComparison.OrdinalIgnoreCase);
        }

        protected void AddressLength(object source, ServerValidateEventArgs args)
        {
            args.IsValid = args.Value.Trim().Length >= 2;
        }

        protected void CityValidation(object source, ServerValidateEventArgs args)
        {
            args.IsValid = args.Value.Trim().Length >= 2;
        }

        protected void btnCheck_Click(object sender, EventArgs e)
        {
            {
                if (Page.IsValid)
                    lblMsg.Text = "validation successful!";
                else
                    lblMsg.Text = "validation unsuccessful";
            }
        }
    }
}
   