using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C3E1_StudentsInformation
{
    public partial class FrmStudentsInformation : Form
    {
        public FrmStudentsInformation()
        {
            InitializeComponent();
        }

        private void BtnName_Click(object sender, EventArgs e)
        {
            if (!ValidateDetails())
            {
                return;
            }
            LblOutput.Text = string.Format("{0}", TxtName.Text);
        }

        private void BtnNameAge_Click(object sender, EventArgs e)
        {
            if (!ValidateDetails())
            {
                return;
            }
            LblOutput.Text = string.Format("{0} is {1} years old", TxtName.Text, TxtAge.Text);            
        }

        private void BtnNameStandard_Click(object sender, EventArgs e)
        {
            if (!ValidateDetails())
            {
                return;
            }
            LblOutput.Text = string.Format("{0} is in standard {1}", TxtName.Text, TxtStandard.Text);
        }

        private void BtnNameSchool_Click(object sender, EventArgs e)
        {
            if (!ValidateDetails())
            {
                return;
            }
            LblOutput.Text = string.Format("{0} goes to {1}, School", TxtName.Text, TxtSchoolName.Text);
        }

        private void BtnNameAgeStandard_Click(object sender, EventArgs e)
        {
            if (!ValidateDetails())
            {
                return;
            }
            LblOutput.Text = string.Format("{0}, {1} years, standard {2}", TxtName.Text, TxtAge.Text, TxtStandard.Text);
        }

        private void BtnAllDetails_Click(object sender, EventArgs e)
        {
            if (!ValidateDetails())
            {
                return;
            }
            LblOutput.Text = string.Format("{0}, {1} years, Standard {2}, from {3}", TxtName.Text, TxtAge.Text, TxtStandard.Text, TxtSchoolName.Text);
        }

        private bool ValidateDetails() 
        {
            //Validate Student Name
            if (TxtName.Text.Trim().Equals(""))
            {
                MessageBox.Show("Input Student\'s Name", "Student\'s Name", MessageBoxButtons.OK, MessageBoxIcon.Question);
                TxtName.Text = "";
                TxtName.Focus();
                return false;
            }

            //Validate Age
            if (TxtAge.Text.Trim().Equals(""))
            {
                MessageBox.Show("Input Age", "Age", MessageBoxButtons.OK, MessageBoxIcon.Question);
                TxtAge.Text = "";
                TxtAge.Focus();
                return false;
            }

            //Validate Standard
            if (TxtStandard.Text.Trim().Equals(""))
            {
                MessageBox.Show("Input Standard he / she is in ", "Standard", MessageBoxButtons.OK, MessageBoxIcon.Question);
                TxtStandard.Text = "";
                TxtStandard.Focus();
                return false;
            }

            //Validate School Name
            if (TxtSchoolName.Text.Trim().Equals(""))
            {
                MessageBox.Show("Input School Name", "School Name", MessageBoxButtons.OK, MessageBoxIcon.Question);
                TxtSchoolName.Text = "";
                TxtSchoolName.Focus();
                return false;
            }

            return true;
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            switch(MessageBox.Show("Are You Sure You Want To Clear All?", "Clear", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                case DialogResult.Yes:
                    TxtName.Text = "";
                    TxtAge.Text = "";
                    TxtStandard.Text = "";
                    TxtSchoolName.Text = "";
                    LblOutput.Text = "";
                    TxtName.Focus();
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
