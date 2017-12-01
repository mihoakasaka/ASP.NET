using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplicationLifeDemo
{
    public partial class ApplicationVariables : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnIncerment_Click(object sender, EventArgs e)
        {
            if (Application["click"] == null)
            {
                Application["click"] = 0;
            }
            Application["click"] = (int)Application["click"] + 1;
            tbCounter.Text = Application["click"].ToString();
        }
    }
}