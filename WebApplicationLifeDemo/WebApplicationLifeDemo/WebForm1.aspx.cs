using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplicationLifeDemo
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnURL_Click(object sender, EventArgs e)
        {
            Server.Transfer("~/WebForm2.aspx",false);
            lbOutcome.Text = "YOU HAVE DONE IT..YAY";
        }

        protected void btnURL0_Click(object sender, EventArgs e)
        {
            Server.Transfer("http://www.google.com");
        }

        protected void btnExecute_Click(object sender, EventArgs e)
        {
            Server.Execute("~/WebForm2.aspx");
            lbOutcome.Text = "YOU HAVE DONE IT..YAY";
        }
    }
}