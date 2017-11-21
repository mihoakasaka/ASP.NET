using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PriceQuotation
{
    public partial class PriceQuotation : System.Web.UI.Page
    {
   
        protected void Page_Load(object sender, EventArgs e)
        {
            UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;
        }

        protected void btCalculate_Click(object sender, EventArgs e)
        {
            decimal salesPrice = Convert.ToDecimal(tbPrice.Text);
            decimal discountRate = Convert.ToDecimal(tbDiscount.Text);
            decimal discountPrice = salesPrice * discountRate / 100;
            decimal total = salesPrice - discountPrice;
            lbDiscount.Text = (discountPrice).ToString("c");
            lbTotal.Text = total.ToString("c");
        }
    }
}