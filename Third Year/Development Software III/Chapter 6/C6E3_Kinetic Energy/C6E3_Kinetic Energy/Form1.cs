using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C6E3_Kinetic_Energy
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            switch (MessageBox.Show("Are You Sure You Want To Clear All?", "Clear", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                case DialogResult.Yes:
                    TxtMass.Text = "";
                    TxtVelocity.Text = "";
                    TxtKineticEnergy.Text = "";
                    TxtMass.Focus();
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

        private void BtnCompute_Click(object sender, EventArgs e)
        {
            if (double.TryParse(TxtMass.Text.Trim(), out double mass))
            {
                if (double.TryParse(TxtVelocity.Text.Trim(), out double velocity))
                {
                    double kineticEnergy = KineticEnergy(mass, velocity);

                    TxtKineticEnergy.Text = Convert.ToString(Math.Round(kineticEnergy, 2)) + "J";
                }
                else
                {
                    MessageBox.Show("Object's Velocity Must Be Numeric", "Object Velocity", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    TxtVelocity.Text = "";
                    TxtVelocity.Focus();
                    return;
                }
            }
            else
            {
                MessageBox.Show("Object's Mass Must Be Numeric", "Object Mass", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TxtMass.Text = "";
                TxtMass.Focus();
                return;
            }
        }

        private double KineticEnergy(double mass, double velocity)
        {
            return 1.0 / 2 * mass * Math.Pow(velocity, 2);
        }
    }
}
