using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace Password_Salt_Hashing
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnGenerate_Click(object sender, EventArgs e)
        {
            string salt = CreateSalt(10);

            string hashedPassword = GenerateSHA256Hash(TxtPassword.Text, salt);

            TxtSalt.Text = salt;
            TxtHash.Text = hashedPassword;

        }

        private static string ByteArrayToHexString(byte[] ba)
        {
            StringBuilder hex = new StringBuilder(ba.Length * 2);
            foreach (byte b in ba)
                hex.AppendFormat("{0:x2}", b);
            return hex.ToString();
        }

        private string CreateSalt(int size)
        {
            var rng = new RNGCryptoServiceProvider();
            var buff = new byte[size];
            rng.GetBytes(buff);
            return Convert.ToBase64String(buff);
        }

        private string GenerateSHA256Hash(string input, string salt)
        {
            byte[] bytes = Encoding.UTF8.GetBytes(input + salt);
            SHA256Managed sha256hashstring = new SHA256Managed();
            byte[] hash = sha256hashstring.ComputeHash(bytes);

            return ByteArrayToHexString(hash);
        }

        private void BtnReGenerate_Click(object sender, EventArgs e)
        {
            string salt = TxtOldSalt.Text;

            string hashedPassword = GenerateSHA256Hash(TxtNewPassword.Text, salt);

            TxtOldSalt.Text = salt;
            TxtHashNew.Text = hashedPassword;
        }

        private void BtnConfirm_Click(object sender, EventArgs e)
        {
            if (TxtHash.Text.Equals(TxtHashNew.Text))
            {
                MessageBox.Show("Passwords Match", "Hashed Password", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Passwords Do Not Match", "Hashed Password", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
