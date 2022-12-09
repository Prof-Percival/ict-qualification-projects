using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C6E1_Salesmen_s_Commission_Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnCompute_Click(object sender, EventArgs e)
        {
            if (double.TryParse(TxtRevenueSale.Text.Trim(), out double revenueSale))
            {
                if (double.TryParse(TxtRateCommission.Text.Trim(), out double commissionRate))
                {
                    TxtCommissionEarned.Text = "R" + CalculateCommission(revenueSale, commissionRate).ToString("N2");
                }
                else
                {
                    MessageBox.Show("Rate of Commission Must Be Numeric", "Rate Commission", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    TxtRateCommission.Text = "";
                    TxtRateCommission.Focus();
                    return;
                }
                
            }
            else
            {
                MessageBox.Show("Salesman's Revenue Sale Must Be Numeric", "Salesman's Revenue Sale", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TxtRevenueSale.Text = "";
                TxtRevenueSale.Focus();
                return;
            }
        }

        private int CalculateCommission(double revenue, double rate)
        {
            if (revenue >= 100000)
            {
                int commission = 0;

                if (rate == 5)
                {
                    commission = 5000;
                }

                if (rate == 8)
                {
                    commission = 8000;
                }

                return commission;
            }
            else
            {
                return 0;
            }
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            switch (MessageBox.Show("Are You Sure You Want To Clear All?", "Clear", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                case DialogResult.Yes:
                    TxtRevenueSale.Text = "";
                    TxtRateCommission.Text = "";
                    TxtCommissionEarned.Text = "";
                    TxtRevenueSale.Focus();
                    break;

                case DialogResult.No:
                    return;
            }
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            switch (MessageBox.Show("Are You Sure You Want To Exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                case DialogResult.Yes:
                    this.Close();
                    break;

                case DialogResult.No:
                    return;
            }
        }
    }
}
