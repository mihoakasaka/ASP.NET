using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplicationLifeDemo
{
    public partial class ResponseRedirectDemo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/SecondWebForm.aspx");
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DropDownList1.SelectedValue != null)
            {
                string url = "~/" + DropDownList1.SelectedValue + ".aspx";
                Response.Redirect(url);
            }
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            lboxNames.Items.Add(tbName.Text);
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            if(lboxNames.Items.Count < 5)
            {
                Label1.Text = "YOU NEED ATLEAST 5 CONTACTS";

            }
            else
                Response.Redirect("~/SecondWebForm.aspx");

        }
    }
}