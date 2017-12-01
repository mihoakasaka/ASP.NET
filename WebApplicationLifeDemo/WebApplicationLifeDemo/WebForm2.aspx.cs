using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Collections.Specialized;

namespace WebApplicationLifeDemo
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        //method 1
        /*
        protected void Page_Load(object sender, EventArgs e)
        {
            NameValueCollection previousCollection = Request.Form;
            lbName.Text = previousCollection["tbName"];
            lbEmail.Text = previousCollection["tbEmail"];
        }
        */
        //Method 2
        protected void Page_Load(object sender, EventArgs e)
        {
            Page previosPage = Page.PreviousPage;
            if (previosPage != null)
            {
                lbName.Text = ((TextBox)previosPage.FindControl("tbName")).Text;
                lbEmail.Text = ((TextBox)previosPage.FindControl("tbEmail")).Text;
            }
        }
    }
}