using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplicationLifeDemo
{
    public partial class StronglyTypedReferencesTarget : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            StronglyTypedReferencesMain previosPage = (StronglyTypedReferencesMain)Page.PreviousPage;
            if (previosPage != null)
            {
                lbName.Text = previosPage.name;
                lbEmail.Text = previosPage.email;
            }
        }


    }
}