using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplicationLifeDemo
{
    public partial class StronglyTypedReferencesMain : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnURL_Click(object sender, EventArgs e)
        {
            Server.Transfer("~/StronglyTypedReferencesTarget.aspx");
        }

        public string name
        {
            get
            {
                return tbName.Text;
            }
        }

        public string email
        {
            get
            {
                return tbEmail.Text;
            }
        }
    }
}