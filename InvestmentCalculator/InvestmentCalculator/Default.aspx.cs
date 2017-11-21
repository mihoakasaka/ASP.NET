using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace InvestmentCalculator
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            for (int i = 50; i <= 500; i += 50) {
                    ddlinvestment.Items.Add(i.ToString());

                }

        }

        protected void btCalculate_Click(object sender, EventArgs e)
        {
            if (IsValid)
            {
                int monthly = Convert.ToInt16(ddlinvestment.SelectedItem.Value);
                int years = Convert.ToInt16(tbYears.Text);
                decimal rate = Convert.ToDecimal(tbRate.Text);
                decimal value = CalculateValue(monthly, rate, years);

                lbValue.Text = value.ToString("c");
            }
        }
        protected decimal CalculateValue(int monthlyInvestment, decimal yearlyInterestRate,
int years)
        {
            int months = years * 12;
            decimal monthlyInterestRate = yearlyInterestRate / 12 / 100;
            decimal futureValue = 0;
            for (int i = 0; i < months; i++)
            {
                futureValue = (futureValue + monthlyInvestment) * (1 + monthlyInterestRate);
            }
            return futureValue;
        }

        protected void btReset_Click(object sender, EventArgs e)
        {
            tbRate.Text = "";
            tbYears.Text = "";
            lbValue.Text = "";
        }
    }
}