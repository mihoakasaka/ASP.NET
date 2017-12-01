using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplicationLifeDemo
{
    public partial class _1MillionPrize : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Page previos = Page.PreviousPage;

            if (previos != null && previos.IsCrossPagePostBack)
            {
                lbNote.Text = "You have won a million $";
            }
            else
                lbNote.Text = "You have reached this web page illaglly";

        }
    }
}