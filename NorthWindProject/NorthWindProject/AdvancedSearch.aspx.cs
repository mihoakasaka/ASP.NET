using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace NorthWindProject
{
    public partial class AdvancedSearch : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            gvCustomer.SelectRow(-1);
        }

        protected void btSearch_Click(object sender, EventArgs e)
        {
            searchResult.SelectCommand = "SELECT * FROM [Customers] WHERE ([" + ddlField.SelectedValue + "]=@CustomerID)";
        }
    }
}