using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C6E5_Joe_s_Automotive
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GrpOilandLube.Cursor = Cursors.Hand;
            GrpFlushes.Cursor = Cursors.Hand;
            GrpMisc.Cursor = Cursors.Hand;
            //GrpSummary.Cursor = Cursors.No;
        }

        private int hours = 0;
        private double parts = 0.0;

        private double TotalCharges()
        {
            return OilLubeCharges() + FlushCharges() + MiscCharges() + OtherCharges () + TaxCharges();
        } 


        private double TaxCharges()
        {
            if (double.TryParse(TxtParts.Text.Trim(), out double parts) && parts > 0.0)
            {
                return parts * (6.0 / 100);
            }
            else
            {
                return 0.0;
            }
        }


        private double OtherCharges()
        {
            double charges = 0.0;

            if (double.TryParse(TxtParts.Text.Trim(), out double parts))
            {
                this.parts = parts;
                charges += parts;
            }
            else if (TxtParts.Text.Trim().Equals(""))
            {
                //DO NOTHING
            }
            else
            {
                MessageBox.Show("Charges for Parts Must Be Numeric", "Parts", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TxtParts.Text = "";
                TxtParts.Focus();
                return 0;
            }

            if (int.TryParse(TxtHours.Text.Trim(), out int hours))
            {
                this.hours = hours;
                charges += (hours * 20);
            }
            else if (TxtHours.Text.Trim().Equals(""))
            {
                //DO NOTHING
            }
            else
            {
                MessageBox.Show("Labor Hours Must Be Numeric", "Labor Hours", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TxtHours.Text = "";
                TxtHours.Focus();
                TxtLabor.Text = "$0,00";
                //System.Environment.Exit(1);
                return 0;
            }

            return charges;
        }

        private short MiscCharges()
        {
            short charges = 0;

            if (ChkInspection.Checked)
            {
                charges += 15;
            }

            if (ChkReplaceMuffler.Checked)
            {
                charges += 100;
            }

            if (ChkTireRotation.Checked)
            {
                charges += 20;
            }

            return charges;
        }


        private short FlushCharges()
        {
            short charges = 0;

            if (ChkRadiatorFlush.Checked)
            {
                charges += 30;
            }

            if (ChkTransmissionFlush.Checked)
            {
                charges += 80;
            }

            return charges;
        }

        private short OilLubeCharges()
        {
            short charges = 0;

            if (ChkOilChange.Checked)
            {
                charges += 26;
            }

            if (ChkLubeJob.Checked)
            {
                charges += 18;
            }

            return charges;
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

        private void BtnClear_Click(object sender, EventArgs e)
        {
            switch (MessageBox.Show("Are You Sure You Want To Clear All?", "Clear", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                case DialogResult.Yes:
                    ClearOilLube();
                    ClearFlushes();
                    ClearMisc();
                    ClearOther();
                    ClearFees();
                    break;

                case DialogResult.No:
                    return;
            }
        }

        private void TxtHours_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(TxtHours.Text.Trim(), out int hours) && hours >= 0)
            {
                TxtLabor.Text = "$" + (hours * 20.0).ToString("N2");
            }
            else if (TxtHours.Text.Trim().Equals(""))
            {
                TxtLabor.Text = "";
            }
            else
            {
                TxtLabor.Text = "$0,00";
            }
        }

        private void ClearOilLube()
        {
            ChkLubeJob.Checked = false;
            ChkOilChange.Checked = false;
        }

        private void ClearFlushes()
        {
            ChkRadiatorFlush.Checked = false;
            ChkTransmissionFlush.Checked = false;
        }

        private void ClearMisc()
        {
            ChkInspection.Checked = false;
            ChkReplaceMuffler.Checked = false;
            ChkTireRotation.Checked = false;
        }

        private void ClearOther()
        {
            TxtParts.Text = "";
            TxtHours.Text = "";
            TxtLabor.Text = "";
        }

        private void ClearFees()
        {
            TxtServiceAndLabor.Text = "";
            TxtPartsSummary.Text = "";
            TxtTax.Text = "";
            TxtTotalFees.Text = "";
        }

        private void BtnCalculate_Click(object sender, EventArgs e)
        {
            TxtServiceAndLabor.Text = "$" + (OilLubeCharges() + FlushCharges() + MiscCharges() + OtherCharges() - parts).ToString("N2");
            TxtPartsSummary.Text = "$" + (OtherCharges() - (hours* 20)).ToString("N2");
            TxtTax.Text = "$" + (TaxCharges()).ToString("N2");
            TxtTotalFees.Text = "$" + (OilLubeCharges() + FlushCharges() + MiscCharges() + OtherCharges()).ToString("N2");
        }
    }
}
