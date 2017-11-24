using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace UsersInformation
{
    public partial class Home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;
        }

        protected void btSubmit_Click(object sender, EventArgs e)
        {
            Page.Validate();
            if (Page.IsValid)
            {
                String newUser = getData();
                lbResult.Text = newUser;
                lstUsers.Items.Add(newUser);
                countUpdate();
                lbCount.Text = hiddenCountt.Value;
            }
        }

        private void countUpdate() {
            int count = Int32.Parse(hiddenCountt.Value.ToString());
            count++;
            hiddenCountt.Value = count.ToString();
        }
        /* this method gets all the data from user form
         * Note:
         * 
         * */
        private String getData()
        {
            string name = tbName.Text;
            string dob = tbDoB.Text;
            string email = tbEmail.Text;
            string province = ddlProvince.SelectedValue;

            return (name + "," + dob + "," + email + "," + province + ",");
        }
        private void clearForm()
        {
            tbName.Text = "";
            tbDoB.Text = "";
            tbEmail.Text = "";
            ddlCity.Items.Clear();
            ddlProvince.Items.Clear();
        }
        protected void ddlProvince_SelectedIndexChanged(object sender, EventArgs e)
        {
            string province = ddlProvince.SelectedValue;

            if (province.Equals("Quebec"))
            {
                ddlCity.Items.Clear();
                ddlCity.Items.Add("Montreal");
                ddlCity.Items.Add("Quebec city");
                ddlCity.Items.Add("Trois Rivier");
                ddlCity.Items.Add("Gatineau");


            }
            else if (province.Equals("Ontario"))
            {
                ddlCity.Items.Clear();
                ddlCity.Items.Add("Toronto");
                ddlCity.Items.Add("Ottawa");
            }
            else if (province.Equals("Alberta"))
            {
                ddlCity.Items.Clear();
                ddlCity.Items.Add("Calgary");
                ddlCity.Items.Add("Edomonton");
            }
            else
            {
                ddlCity.Items.Clear();
                ddlCity.Items.Add("Other");

            }
        }
    }
}