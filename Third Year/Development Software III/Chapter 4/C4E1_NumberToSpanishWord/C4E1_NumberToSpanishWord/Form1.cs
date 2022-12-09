using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C4E1_NumberToSpanishWord
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnConvert_Click(object sender, EventArgs e)
        {
            MessageBoxIcon errorIcon = MessageBoxIcon.Error;
            MessageBoxButtons okButton = MessageBoxButtons.OK;

            int number = 0;

            if (int.TryParse(TxtNumber.Text, out number))
            {
                string spanishVersion;

                switch (number)
                {
                    case 1:
                        spanishVersion = "uno";
                        break;
                    case 2:
                        spanishVersion = "dos";
                        break;
                    case 3:
                        spanishVersion = "tres";
                        break;
                    case 4:
                        spanishVersion = "cuatro";
                        break;
                    case 5:
                        spanishVersion = "cinco";
                        break;
                    case 6:
                        spanishVersion = "seis";
                        break;
                    case 7:
                        spanishVersion = "siete";
                        break;
                    case 8:
                        spanishVersion = "ocho";
                        break;
                    case 9:
                        spanishVersion = "nueve";
                        break;
                    case 10:
                        spanishVersion = "diez";
                        break;
                    default:
                        MessageBox.Show("Number Must Be Between 1 And 10", "Number Input", okButton, errorIcon);
                        TxtNumber.Clear();
                        TxtNumber.Focus();
                        return;
                }

                LblSpanishVersion.Text = spanishVersion;
            }
            else
            {
                MessageBox.Show("Input Must Be A Number Between 1 And 10", "Number Input", okButton, errorIcon);
                TxtNumber.Clear();
                TxtNumber.Focus();
            }
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            switch (MessageBox.Show("Are You Sure You Want To Clear All?", "Clear", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                case DialogResult.Yes:
                    TxtNumber.Text = "";
                    LblSpanishVersion.Text = "";
                    TxtNumber.Focus();
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
