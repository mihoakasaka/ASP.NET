using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplicationLifeDemo
{
    public partial class SessionVariables : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                tbCounter.Text = "0";
            }

        }

        protected void btnIncerment_Click(object sender, EventArgs e)
        {

            if (Session["click"] == null)
            {
                Session["click"] = 0;
            }
            Session["click"] = (int)Session["click"] + 1;
            tbCounter.Text = Session["click"].ToString();
            
        }
    }
}