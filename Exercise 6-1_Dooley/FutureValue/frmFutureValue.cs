using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FutureValue
{
    public partial class frmFutureValue : Form
    {
        public frmFutureValue()
        {
            InitializeComponent();
        }
        //Kyle Dooley exercise 6-1 05/03/2022 
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            decimal monthlyInvestment = Convert.ToDecimal(txtMonthlyInvestment.Text);
            decimal yearlyInterestRate = Convert.ToDecimal(txtInterestRate.Text);
            int years = Convert.ToInt32(txtYears.Text);


            int months = years * 12;
            decimal monthlyInterestRate = yearlyInterestRate / 12 / 100;

            decimal futureValue = this.CalculateFutureValue(monthlyInvestment,
               monthlyInterestRate, months);
            txtFutureValue.Text = futureValue.ToString("c");
            txtMonthlyInvestment.Focus();
        }
            private decimal CalculateFutureValue(decimal monthlyInvestment,
                decimal monthlyInterestRate, int months)
        { 
            decimal futureValue = 0m;
            for (int i = 0; i < months; i++)
            {
                futureValue = (futureValue + monthlyInvestment)
                            * (1 + monthlyInterestRate);
            }
            return futureValue;

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Kyle Dooley exercise 6-1 05/03/2022 adding the ClearFutureValue feature
        private void ClearFutureValue(object sender, EventArgs e)
        {
            txtFutureValue.Text = "";
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
        //Kyle Dooley 05/03/2022 exrcise 6-2 coding the event
        private void frmFutureValue_DoubleClick(object sender, EventArgs e)
        {
            txtMonthlyInvestment.Text = "";
            txtInterestRate.Text = "";
            txtYears.Text = "";
            txtFutureValue.Text = "";
        }
       
        private void txtInterestRate_DoubleClick(object sender, EventArgs e)
        {
            txtInterestRate.Text = "12";
        }
        //Kyle Dooley 05/03/2022 exercise 6-2 generate years event
        private void txtYears_DoubleClick(object sender, EventArgs e)
        {
            txtYears.Text = "30";
        }
    }
}
