﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplicationLifeDemo
{
    public partial class StateVariable : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                tbCounter.Text = "0";
            }
        }

        protected void btnIncerment_Click(object sender, EventArgs e)
        {
            if(ViewState["click"] == null)
            {
                ViewState["click"] = 1;
            }
            tbCounter.Text = ViewState["click"].ToString();
            ViewState["click"] = (int)ViewState["click"] + 1;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

        }
    }
}