using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment1
{
    public partial class Form1 : Form
    {

        private decimal carPrice; //is the car price (decimal)
        private decimal rateInterest; //is the annual rate of interest (decimal)
        private int years; //is the length of the period, starting from Year 2 (integer);
        private decimal carPriceLoan; //is the value of the car price with loan (decimal)

        public Form1()
        {

            InitializeComponent();

        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {

            this.Close();

        }

            private void CalculateBtn_Click(object sender, EventArgs e)
            {

                try
                {

                    carPrice = decimal.Parse(carPriceTb.Text);
                    rateInterest = decimal.Parse(rateInterestTb.Text);
                    years = int.Parse(loanPeriodTb.Text);
                    carPriceLoan = 0;

                    double carPriceDouble = (double)carPrice;
                    double rateInterestDouble = (double)rateInterest;
                    double carPriceLoanDouble = (double)carPriceLoan;

                    carPriceLoanDouble = carPriceDouble * Math.Pow(1 + (rateInterestDouble / 100 / 365), (years * 365));
                    outputLabel.Text = "$" + carPriceLoanDouble.ToString("n2");

                }

                catch
                {

                    outputLabel.Text = "";
                    MessageBox.Show("Error while calculating the Car Loan Price" + Environment.NewLine +"Please check your input");

                }

            }

        private void ResetBtn_Click(object sender, EventArgs e)
        {

            carPriceTb.Text = "";
            rateInterestTb.Text = "";
            loanPeriodTb.Text = "";
            outputLabel.Text = "";
            carPrice = 0;
            years = 0;
            rateInterest = 0;
            carPriceLoan = 0;

        }

    }

}