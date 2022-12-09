
namespace Send_E_Mail
{
    partial class FrmSendEMail
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
            this.PanBody = new System.Windows.Forms.Panel();
            this.dgStudent = new System.Windows.Forms.DataGridView();
            this.BtnClear = new System.Windows.Forms.Button();
            this.BtnExit = new System.Windows.Forms.Button();
            this.BtnSend = new System.Windows.Forms.Button();
            this.TxtBody = new System.Windows.Forms.TextBox();
            this.TxtSubject = new System.Windows.Forms.TextBox();
            this.LblBody = new System.Windows.Forms.Label();
            this.LblSubject = new System.Windows.Forms.Label();
            this.TxtTo = new System.Windows.Forms.TextBox();
            this.LblTo = new System.Windows.Forms.Label();
            this.HtmlRTB = new Send_E_Mail.HtmlRichTextBox();
            this.PanBody.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgStudent)).BeginInit();
            this.SuspendLayout();
            // 
            // PanBody
            // 
            this.PanBody.Controls.Add(this.HtmlRTB);
            this.PanBody.Controls.Add(this.dgStudent);
            this.PanBody.Controls.Add(this.BtnClear);
            this.PanBody.Controls.Add(this.BtnExit);
            this.PanBody.Controls.Add(this.BtnSend);
            this.PanBody.Controls.Add(this.TxtBody);
            this.PanBody.Controls.Add(this.TxtSubject);
            this.PanBody.Controls.Add(this.LblBody);
            this.PanBody.Controls.Add(this.LblSubject);
            this.PanBody.Controls.Add(this.TxtTo);
            this.PanBody.Controls.Add(this.LblTo);
            this.PanBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanBody.Location = new System.Drawing.Point(0, 0);
            this.PanBody.Name = "PanBody";
            this.PanBody.Size = new System.Drawing.Size(919, 516);
            this.PanBody.TabIndex = 0;
            // 
            // dgStudent
            // 
            this.dgStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgStudent.Location = new System.Drawing.Point(44, 324);
            this.dgStudent.Name = "dgStudent";
            this.dgStudent.RowTemplate.Height = 25;
            this.dgStudent.Size = new System.Drawing.Size(430, 192);
            this.dgStudent.TabIndex = 0;
            // 
            // BtnClear
            // 
            this.BtnClear.Location = new System.Drawing.Point(8, 302);
            this.BtnClear.Name = "BtnClear";
            this.BtnClear.Size = new System.Drawing.Size(62, 33);
            this.BtnClear.TabIndex = 0;
            this.BtnClear.Text = "&Clear";
            this.BtnClear.UseVisualStyleBackColor = true;
            this.BtnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // BtnExit
            // 
            this.BtnExit.Location = new System.Drawing.Point(419, 298);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(52, 33);
            this.BtnExit.TabIndex = 0;
            this.BtnExit.Text = "E&xit";
            this.BtnExit.UseVisualStyleBackColor = true;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // BtnSend
            // 
            this.BtnSend.Location = new System.Drawing.Point(843, 9);
            this.BtnSend.Name = "BtnSend";
            this.BtnSend.Size = new System.Drawing.Size(64, 33);
            this.BtnSend.TabIndex = 0;
            this.BtnSend.Text = "&Send";
            this.BtnSend.UseVisualStyleBackColor = true;
            this.BtnSend.Click += new System.EventHandler(this.BtnSend_Click);
            // 
            // TxtBody
            // 
            this.TxtBody.Location = new System.Drawing.Point(81, 100);
            this.TxtBody.Multiline = true;
            this.TxtBody.Name = "TxtBody";
            this.TxtBody.Size = new System.Drawing.Size(390, 192);
            this.TxtBody.TabIndex = 0;
            // 
            // TxtSubject
            // 
            this.TxtSubject.Location = new System.Drawing.Point(81, 58);
            this.TxtSubject.Name = "TxtSubject";
            this.TxtSubject.Size = new System.Drawing.Size(256, 26);
            this.TxtSubject.TabIndex = 0;
            // 
            // LblBody
            // 
            this.LblBody.AutoSize = true;
            this.LblBody.Location = new System.Drawing.Point(26, 100);
            this.LblBody.Name = "LblBody";
            this.LblBody.Size = new System.Drawing.Size(49, 20);
            this.LblBody.TabIndex = 0;
            this.LblBody.Text = "Body:";
            // 
            // LblSubject
            // 
            this.LblSubject.AutoSize = true;
            this.LblSubject.Location = new System.Drawing.Point(8, 61);
            this.LblSubject.Name = "LblSubject";
            this.LblSubject.Size = new System.Drawing.Size(67, 20);
            this.LblSubject.TabIndex = 0;
            this.LblSubject.Text = "Subject:";
            // 
            // TxtTo
            // 
            this.TxtTo.Location = new System.Drawing.Point(81, 12);
            this.TxtTo.Name = "TxtTo";
            this.TxtTo.PlaceholderText = "someone@example.com";
            this.TxtTo.Size = new System.Drawing.Size(256, 26);
            this.TxtTo.TabIndex = 0;
            // 
            // LblTo
            // 
            this.LblTo.AutoSize = true;
            this.LblTo.Location = new System.Drawing.Point(44, 15);
            this.LblTo.Name = "LblTo";
            this.LblTo.Size = new System.Drawing.Size(31, 20);
            this.LblTo.TabIndex = 0;
            this.LblTo.Text = "To:";
            // 
            // HtmlRTB
            // 
            this.HtmlRTB.Location = new System.Drawing.Point(477, 97);
            this.HtmlRTB.Name = "HtmlRTB";
            this.HtmlRTB.Size = new System.Drawing.Size(430, 407);
            this.HtmlRTB.TabIndex = 0;
            this.HtmlRTB.TabStop = false;
            this.HtmlRTB.Text = "";
            // 
            // FrmSendEMail
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(919, 516);
            this.Controls.Add(this.PanBody);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "FrmSendEMail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Send E-Mail";
            this.Load += new System.EventHandler(this.FrmSendEMail_Load);
            this.PanBody.ResumeLayout(false);
            this.PanBody.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgStudent)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanBody;
        private System.Windows.Forms.TextBox TxtSubject;
        private System.Windows.Forms.Label LblSubject;
        private System.Windows.Forms.TextBox TxtTo;
        private System.Windows.Forms.Label LblTo;
        private System.Windows.Forms.Button BtnClear;
        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.Button BtnSend;
        private System.Windows.Forms.TextBox TxtBody;
        private System.Windows.Forms.Label LblBody;
        private System.Windows.Forms.DataGridView dgStudent;
        private HtmlRichTextBox HtmlRTB;
    }
}

