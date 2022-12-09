
namespace C4E1_NumberToSpanishWord
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.BtnConvert = new System.Windows.Forms.Button();
            this.LblNumber = new System.Windows.Forms.Label();
            this.TxtNumber = new System.Windows.Forms.TextBox();
            this.BtnExit = new System.Windows.Forms.Button();
            this.BtnClear = new System.Windows.Forms.Button();
            this.LblSpanish = new System.Windows.Forms.Label();
            this.LblSpanishVersion = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnConvert
            // 
            this.BtnConvert.Location = new System.Drawing.Point(141, 69);
            this.BtnConvert.Name = "BtnConvert";
            this.BtnConvert.Size = new System.Drawing.Size(93, 36);
            this.BtnConvert.TabIndex = 1;
            this.BtnConvert.Text = "C&onvert";
            this.BtnConvert.UseVisualStyleBackColor = true;
            this.BtnConvert.Click += new System.EventHandler(this.BtnConvert_Click);
            // 
            // LblNumber
            // 
            this.LblNumber.AutoSize = true;
            this.LblNumber.Location = new System.Drawing.Point(32, 27);
            this.LblNumber.Name = "LblNumber";
            this.LblNumber.Size = new System.Drawing.Size(169, 23);
            this.LblNumber.TabIndex = 0;
            this.LblNumber.Text = "Number (1 - 10)";
            // 
            // TxtNumber
            // 
            this.TxtNumber.Location = new System.Drawing.Point(207, 24);
            this.TxtNumber.Name = "TxtNumber";
            this.TxtNumber.Size = new System.Drawing.Size(100, 29);
            this.TxtNumber.TabIndex = 0;
            this.TxtNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // BtnExit
            // 
            this.BtnExit.Location = new System.Drawing.Point(281, 175);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(75, 33);
            this.BtnExit.TabIndex = 3;
            this.BtnExit.Text = "E&xit";
            this.BtnExit.UseVisualStyleBackColor = true;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // BtnClear
            // 
            this.BtnClear.Location = new System.Drawing.Point(16, 175);
            this.BtnClear.Name = "BtnClear";
            this.BtnClear.Size = new System.Drawing.Size(75, 33);
            this.BtnClear.TabIndex = 2;
            this.BtnClear.Text = "&Clear";
            this.BtnClear.UseVisualStyleBackColor = true;
            this.BtnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // LblSpanish
            // 
            this.LblSpanish.AutoSize = true;
            this.LblSpanish.Location = new System.Drawing.Point(32, 125);
            this.LblSpanish.Name = "LblSpanish";
            this.LblSpanish.Size = new System.Drawing.Size(173, 23);
            this.LblSpanish.TabIndex = 0;
            this.LblSpanish.Text = "Spanish Version:";
            // 
            // LblSpanishVersion
            // 
            this.LblSpanishVersion.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblSpanishVersion.ForeColor = System.Drawing.Color.DodgerBlue;
            this.LblSpanishVersion.Location = new System.Drawing.Point(211, 116);
            this.LblSpanishVersion.Name = "LblSpanishVersion";
            this.LblSpanishVersion.Size = new System.Drawing.Size(109, 38);
            this.LblSpanishVersion.TabIndex = 0;
            this.LblSpanishVersion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(362, 222);
            this.Controls.Add(this.LblSpanishVersion);
            this.Controls.Add(this.LblSpanish);
            this.Controls.Add(this.BtnClear);
            this.Controls.Add(this.BtnExit);
            this.Controls.Add(this.TxtNumber);
            this.Controls.Add(this.LblNumber);
            this.Controls.Add(this.BtnConvert);
            this.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Spanish Version Number Converter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnConvert;
        private System.Windows.Forms.Label LblNumber;
        private System.Windows.Forms.TextBox TxtNumber;
        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.Button BtnClear;
        private System.Windows.Forms.Label LblSpanish;
        private System.Windows.Forms.Label LblSpanishVersion;
    }
}

