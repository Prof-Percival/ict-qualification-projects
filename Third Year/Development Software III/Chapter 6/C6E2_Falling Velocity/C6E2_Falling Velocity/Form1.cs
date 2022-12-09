using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C6E2_Falling_Velocity
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

        private void TxtDistance_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnCompute_Click(object sender, EventArgs e)
        {
            if (int.TryParse(TxtTime.Text.Trim(), out int sec))
            {
                double velocity = FallingVelocity(sec);

                double distance = velocity / sec;

                TxtVelocity.Text = velocity + "m/s";

                TxtDistance.Text = Convert.ToString(distance) + "m";
            }
            else
            {
                MessageBox.Show("Time Must Be Numeric (Seconds)", "Time", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TxtTime.Text = "";
                TxtTime.Focus();
                return;
            }
        }

        private double FallingVelocity(int time)
        {
            return 9.8 * time;
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            switch (MessageBox.Show("Are You Sure You Want To Clear All?", "Clear", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                case DialogResult.Yes:
                    TxtTime.Text = "";
                    TxtVelocity.Text = "";
                    TxtDistance.Text = "";
                    TxtTime.Focus();
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
