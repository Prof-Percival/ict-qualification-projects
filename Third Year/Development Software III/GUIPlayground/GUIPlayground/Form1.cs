using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace GUIPlayground
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Greetings", "Hello World!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            try
            {
                int num = Convert.ToInt32(TxtName.Text);
                lblOutput.Text = num + "";
            }
            catch (Exception expObj)
            {
                MessageBox.Show("String was an Input: " + expObj.Message);
            }

            double number;

            if (double.TryParse(TxtNumber.Text, out number))
            {
                MessageBox.Show("Try-Parse Successful!\nNumber is: " + number);
            }
            else
            {
                MessageBox.Show("Try-Parse Unsuccessful!\nNumber is: " + number);
            }

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnCreateFile_Click(object sender, EventArgs e)
        {
            StreamWriter outputFile, file2;

            outputFile = File.CreateText("courses.txt");

            string fileName = TxtName.Text;

            file2 = File.AppendText(@"C:\Users\wwwpe\Desktop\" + fileName + ".txt");

            outputFile.WriteLine("Development Software III");
            outputFile.WriteLine("Technical Programming II");
            outputFile.WriteLine("Computer Architecture III");
            outputFile.WriteLine("Information Systems III");

            for (int i = 1; i <= 10; i++)
            {
                /*
                file2.WriteLine("Development Software III");
                file2.WriteLine("Technical Programming II");
                file2.WriteLine("Computer Architecture III");
                file2.WriteLine("Information Systems III\n");
            */

                file2.WriteLine("{0} + {0} = {1}", i, (i + i));
            }

            file2.Close();

            outputFile.Close();
        }

        private void BtnRead_Click(object sender, EventArgs e)
        {
            //Variable to hold Value
            string intExpression;

            //StreamReader reference
            StreamReader inputFile;

            //Open File
            inputFile = File.OpenText("AppendedList.txt");

            //Process File
            intExpression = inputFile.ReadLine();

            MessageBox.Show(intExpression);
        }

        private void BtnWriteFile_Click(object sender, EventArgs e)
        {
            StreamWriter outputFile;
            string fileName;

            if (openFile.ShowDialog() == DialogResult.OK)
            {
                fileName = openFile.FileName;
                outputFile = File.CreateText(fileName);
                TxtWriteTo.Text = fileName;
                MessageBox.Show("File Selected Successfully!", "File");
            }
            else
            {
                MessageBox.Show("File Was Not Selected!", "File");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}