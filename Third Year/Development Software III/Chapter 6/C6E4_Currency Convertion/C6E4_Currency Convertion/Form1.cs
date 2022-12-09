using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C6E4_Currency_Convertion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            switch (MessageBox.Show("Are You Sure You Want To Clear All?", "Clear", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                case DialogResult.Yes:
                    TxtAmount.Text = "";
                    TxtUSD.Text = "";
                    TxtAmount.Focus();
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

        private void BtnJPYtoUSD_Click(object sender, EventArgs e)
        {
            if (double.TryParse(TxtAmount.Text.Trim(), out double amount))
            {
                TxtUSD.Text = Math.Round(YenToUSD(amount), 2) + " USD";
            }
            else
            {
                MessageBox.Show("Amount Must Be Numeric", "Amount", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TxtAmount.Text = "";
                TxtAmount.Focus();
                return;
            }
        }

        private double YenToUSD(double currency)
        {
            return currency * 0.0098;
        }

        private double EuroToUSD(double currency)
        {
            return currency * 1.37;
        }

        private void BtnEURtoUSD_Click(object sender, EventArgs e)
        {
            if (double.TryParse(TxtAmount.Text.Trim(), out double amount))
            {
                TxtUSD.Text = Math.Round(EuroToUSD(amount), 2) + " USD";
            }
            else
            {
                MessageBox.Show("Amount Must Be Numeric", "Amount", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TxtAmount.Text = "";
                TxtAmount.Focus();
                return;
            }
        }
    }
}
