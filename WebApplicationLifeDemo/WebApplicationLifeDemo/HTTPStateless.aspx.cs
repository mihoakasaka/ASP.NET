using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplicationLifeDemo
{
    public partial class HTTPStateless : System.Web.UI.Page
    {
        public int numbeofClicks = 0; 
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                tbCounter.Text = "0";
            }
        }

        protected void btnIncerment_Click(object sender, EventArgs e)
        {
            numbeofClicks++;
            tbCounter.Text = numbeofClicks.ToString();
        }
    }
}