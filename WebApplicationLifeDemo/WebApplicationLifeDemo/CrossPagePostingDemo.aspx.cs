﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplicationLifeDemo
{
    public partial class CrossPagePostingDemo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            Server.Transfer("~/1MillionPrize.aspx");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {

        }
    }
}