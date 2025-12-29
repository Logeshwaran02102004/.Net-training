using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ElectricityBill
{
    public partial class AddBilling : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lblMessage.Text = "";
            lblBillAmount.Text = "";
        }

        protected void btnAddBill_Click(object sender, EventArgs e)
        {
            try
            {
                ElectricityBill ebill = new ElectricityBill();
                ebill.ConsumerNumber = txtConsumerNumber.Text.Trim();
                ebill.ConsumerName = txtConsumerName.Text.Trim();


                int units;
                if (!int.TryParse(txtUnitsConsumed.Text.Trim(), out units))
                {
                    lblMessage.Text = "Units must be a valid number";
                    return;
                }
                ebill.UnitsConsumed = units;

                ElectricityBoard board = new ElectricityBoard();
                board.CalculateBill(ebill);

                lblBillAmount.Text = $"Bill Amount: ₹{ebill.BillAmount}";

                board.AddBill(ebill);

                txtConsumerNumber.Text = "";
                txtConsumerName.Text = "";
                txtUnitsConsumed.Text = "";
            }
            catch (FormatException ex)
            {
                lblMessage.Text = ex.Message;
            }
            catch (Exception ex)
            {
                lblMessage.Text = "Error: " + ex.Message;
            }
        }
    }
}