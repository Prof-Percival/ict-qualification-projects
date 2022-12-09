using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bank.Properties;

namespace Bank
{
    public partial class FrmBank : Form
    {
        BankAccount account;
        public FrmBank()
        {
            InitializeComponent();
        }

        private void PicClose_Click(object sender, EventArgs e)
        {
            switch (MessageBox.Show("Are You Sure You Want To Exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                case DialogResult.Yes:
                    Application.Exit();
                    break;

                case DialogResult.No:
                    return;
            }
        }

        private void PicClose_MouseHover(object sender, EventArgs e)
        {
            PicClose.Image = Resources.Cancel_Dim;
        }

        private void PicClose_MouseLeave(object sender, EventArgs e)
        {
            PicClose.Image = Resources.Cancel_Bright;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void LblBalance_Click(object sender, EventArgs e)
        {

        }



        private void BtnCreateAccount_Click(object sender, EventArgs e)
        {
            account = new BankAccount();
            account.setName(TxtName.Text.Trim());
            account.createAccountNo();
            LblCustomerName.Text = "Account Holder: " + account.getName();
            LblAccountNo.Text = "Account Number: " + account.getAccountNo();

            BtnDeposit.Enabled = true;
            BtnWithdraw.Enabled = true;
        }

        private void BtnDeposit_Click(object sender, EventArgs e)
        {
            if (TxtSpecifyAmount.Text.Trim() == "")
            {
                MessageBox.Show("Input Deposit Amount", "Deposit", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
            else
            {
                account.deposit(double.Parse(TxtSpecifyAmount.Text.Trim()));
                LblBalanceAmount.Text = "R" + account.getBalance();
                MessageBox.Show("Deposit Successful", "Deposit", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void BtnWithdraw_Click(object sender, EventArgs e)
        {
           if (TxtSpecifyAmount.Text.Trim() == "")
            {
                MessageBox.Show("Input Withdrawal Amount", "Withdrawal", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
            else
            {
                if (account.getBalance() > double.Parse(TxtSpecifyAmount.Text.Trim()))
                {
                    account.withdraw(double.Parse(TxtSpecifyAmount.Text.Trim()));
                    LblBalanceAmount.Text = "R" + account.getBalance();
                    MessageBox.Show("Withdrawal Successful", "Withdrawal", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("Insufficient Funds", "Withdrawal", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void FrmBank_Load(object sender, EventArgs e)
        {
            BtnDeposit.Enabled = false;
            BtnWithdraw.Enabled = false;
        }
    }
}
