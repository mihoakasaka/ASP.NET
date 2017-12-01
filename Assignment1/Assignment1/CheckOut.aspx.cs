using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Assignment1
{
    public partial class CheckOut : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;
        }



        protected void btCheckOut_Click(object sender, EventArgs e)
        {
            Page.Validate();
            if (IsValid)
            {
                string email = tbEmail.Text;
                string fname = tbFname.Text;
                string lname = tbLname.Text;
                string phone = tbPhone.Text;

                lbName.Text = "Name :" + fname + " " + lname;
                lbPhone.Text = "Phone :" + phone;
                lbEmail.Text = "Email :" + email;

                string address = tbAddress.Text;
                string city = tbCity.Text;
                string state = ddlState.SelectedValue;
                string zip = tbZip.Text;

                lbAddress.Text = "Address :" + address;
                lbCity.Text = "City :" + address;
                lbState.Text = "State :" + address;
                lbZip.Text = "Zip :" + address;

                if (cbAddress.Checked)
                {
                    tbSAddress.Enabled = false;
                    tbSCity.Enabled = false;
                    ddlSState.Enabled = false;
                    tbSZip.Enabled = false;
                    lbSAddress.Text = "Same As Billing Address";
                }
                else
                {
                    address = tbSAddress.Text;
                    city = tbSCity.Text;
                    state = ddlSState.SelectedValue;
                    zip = tbSZip.Text;

                    lbSAddress.Text = "Address :" + address;
                    lbSCity.Text = "City :" + address;
                    lbSState.Text = "State :" + address;
                    lbSZip.Text = "Zip :" + address;

                }

            }
        }

        protected void cbAddress_CheckedChanged(object sender, EventArgs e)
        {
            if (cbAddress.Checked)
            {
                tbSAddress.Enabled = false;
                tbCity.Enabled = false;
                ddlSState.Enabled = false;
                tbSZip.Enabled = false;
                
            }
            else {
                tbSAddress.Enabled = true;
                tbCity.Enabled = true;
                ddlSState.Enabled = true;
                tbSZip.Enabled = true;

            }
        }
    }
    }
