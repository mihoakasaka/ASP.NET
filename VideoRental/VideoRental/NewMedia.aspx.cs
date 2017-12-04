using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using VideoRental.Models;

namespace VideoRental
{
    public partial class NewMedia : System.Web.UI.Page
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
                string title = tbTitle.Text;
                string type = tbType.Text;
                int year =Convert.ToInt32( tbYear.Text);



                db.AddNewMedia(title, type, year);

            }
        }

    }
}