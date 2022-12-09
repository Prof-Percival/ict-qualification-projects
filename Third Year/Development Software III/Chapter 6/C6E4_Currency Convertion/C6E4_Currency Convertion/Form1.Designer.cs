
namespace C6E4_Currency_Convertion
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.BtnJPYtoUSD = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtAmount = new System.Windows.Forms.TextBox();
            this.TxtUSD = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnEURtoUSD = new System.Windows.Forms.Button();
            this.BtnClear = new System.Windows.Forms.Button();
            this.BtnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnJPYtoUSD
            // 
            this.BtnJPYtoUSD.Location = new System.Drawing.Point(64, 57);
            this.BtnJPYtoUSD.Name = "BtnJPYtoUSD";
            this.BtnJPYtoUSD.Size = new System.Drawing.Size(95, 25);
            this.BtnJPYtoUSD.TabIndex = 1;
            this.BtnJPYtoUSD.Text = "&JPY to USD";
            this.BtnJPYtoUSD.UseVisualStyleBackColor = true;
            this.BtnJPYtoUSD.Click += new System.EventHandler(this.BtnJPYtoUSD_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(71, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Amount";
            // 
            // TxtAmount
            // 
            this.TxtAmount.Location = new System.Drawing.Point(145, 16);
            this.TxtAmount.Name = "TxtAmount";
            this.TxtAmount.Size = new System.Drawing.Size(122, 24);
            this.TxtAmount.TabIndex = 0;
            this.TxtAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TxtUSD
            // 
            this.TxtUSD.Location = new System.Drawing.Point(145, 103);
            this.TxtUSD.Name = "TxtUSD";
            this.TxtUSD.Size = new System.Drawing.Size(122, 24);
            this.TxtUSD.TabIndex = 0;
            this.TxtUSD.TabStop = false;
            this.TxtUSD.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Amount In USD";
            // 
            // BtnEURtoUSD
            // 
            this.BtnEURtoUSD.Location = new System.Drawing.Point(165, 57);
            this.BtnEURtoUSD.Name = "BtnEURtoUSD";
            this.BtnEURtoUSD.Size = new System.Drawing.Size(102, 25);
            this.BtnEURtoUSD.TabIndex = 2;
            this.BtnEURtoUSD.Text = "&EUR to USD";
            this.BtnEURtoUSD.UseVisualStyleBackColor = true;
            this.BtnEURtoUSD.Click += new System.EventHandler(this.BtnEURtoUSD_Click);
            // 
            // BtnClear
            // 
            this.BtnClear.Location = new System.Drawing.Point(20, 153);
            this.BtnClear.Name = "BtnClear";
            this.BtnClear.Size = new System.Drawing.Size(52, 25);
            this.BtnClear.TabIndex = 3;
            this.BtnClear.Text = "&Clear";
            this.BtnClear.UseVisualStyleBackColor = true;
            this.BtnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // BtnExit
            // 
            this.BtnExit.Location = new System.Drawing.Point(260, 153);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(52, 25);
            this.BtnExit.TabIndex = 4;
            this.BtnExit.Text = "E&xit";
            this.BtnExit.UseVisualStyleBackColor = true;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(319, 184);
            this.Controls.Add(this.BtnExit);
            this.Controls.Add(this.BtnClear);
            this.Controls.Add(this.BtnEURtoUSD);
            this.Controls.Add(this.TxtUSD);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtAmount);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnJPYtoUSD);
            this.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Converting Yen and Euros to U.S. Dollars";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnJPYtoUSD;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtAmount;
        private System.Windows.Forms.TextBox TxtUSD;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtnEURtoUSD;
        private System.Windows.Forms.Button BtnClear;
        private System.Windows.Forms.Button BtnExit;
    }
}

