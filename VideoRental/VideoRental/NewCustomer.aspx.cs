using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using VideoRental.Models;

namespace VideoRental
{
    public partial class NewCustomer : System.Web.UI.Page
    {
        VideoRentalRepository db = new VideoRentalRepository();
        protected void Page_Load(object sender, EventArgs e)
        {
            UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;
        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            Page.Validate();
            if (IsValid)
            {
                string fname = tbFName.Text;
                string lname = tbLName.Text;
                string address = tbAddress.Text;
                string phone = tbPhone.Text;

                Customer cust = new Customer
                {
                   
                    FirstName = fname,
                    LastName = lname,
                    Address = address,
                    Phone = phone
                };

                db.AddCustomer( fname, lname, address, phone);
                Response.Redirect("~/Default.aspx");
            }
        }

        }
    }
