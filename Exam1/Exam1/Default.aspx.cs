using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Exam1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;
        }

        protected void btAdd_Click(object sender, EventArgs e)
        {
            //retrieve date from textbox and add to list box
            Page.Validate();
           if (IsValid)
            {
                string name = tbName.Text;
                string email = tbEmail.Text;
                string dob = tbDoB.Text;
                string className = ddlClass.SelectedValue;
                string grade = tbGrade.Text;
                string studentInfo = name + "," + email + "," + dob + "," + className;
                lstStudents.Items.Add(studentInfo);
                lstGrades.Items.Add(grade);


            }

            //compute average and display in label
            decimal total = 0;
           foreach(var g in lstGrades.Items) {

              decimal  grade = Convert.ToDecimal(g.ToString());
                total += grade;
            }
            decimal average = total / lstGrades.Items.Count;

            lbAverage.Text =String.Format("{0:.##}",average);

        }
    }
}