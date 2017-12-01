using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplicationLifeDemo
{
    public partial class ASPControlValues : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnIncerment_Click(object sender, EventArgs e)
        {
            int counter = Int32.Parse(tbCounter.Text);
            counter++;
            tbCounter.Text = counter.ToString();
        }
    }
}