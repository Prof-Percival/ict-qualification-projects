
namespace Bank
{
    partial class FrmBank
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
            this.PanMain = new System.Windows.Forms.Panel();
            this.PanBody = new System.Windows.Forms.Panel();
            this.grpTransactions = new System.Windows.Forms.GroupBox();
            this.TxtSpecifyAmount = new System.Windows.Forms.TextBox();
            this.BtnDeposit = new System.Windows.Forms.Button();
            this.BtnWithdraw = new System.Windows.Forms.Button();
            this.LblSpecifyAmount = new System.Windows.Forms.Label();
            this.grpCreateAccount = new System.Windows.Forms.GroupBox();
            this.PicUser = new System.Windows.Forms.PictureBox();
            this.BtnCreateAccount = new System.Windows.Forms.Button();
            this.TxtName = new System.Windows.Forms.TextBox();
            this.LblName = new System.Windows.Forms.Label();
            this.grpAccountDetails = new System.Windows.Forms.GroupBox();
            this.LblBalanceAmount = new System.Windows.Forms.Label();
            this.LblAccountNo = new System.Windows.Forms.Label();
            this.LblBalance = new System.Windows.Forms.Label();
            this.LblCustomerName = new System.Windows.Forms.Label();
            this.PanFooter = new System.Windows.Forms.Panel();
            this.PanHeader = new System.Windows.Forms.Panel();
            this.LblBankName = new System.Windows.Forms.Label();
            this.PicClose = new System.Windows.Forms.PictureBox();
            this.PanMain.SuspendLayout();
            this.PanBody.SuspendLayout();
            this.grpTransactions.SuspendLayout();
            this.grpCreateAccount.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicUser)).BeginInit();
            this.grpAccountDetails.SuspendLayout();
            this.PanHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicClose)).BeginInit();
            this.SuspendLayout();
            // 
            // PanMain
            // 
            this.PanMain.Controls.Add(this.PanBody);
            this.PanMain.Controls.Add(this.PanFooter);
            this.PanMain.Controls.Add(this.PanHeader);
            this.PanMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanMain.Location = new System.Drawing.Point(0, 0);
            this.PanMain.Name = "PanMain";
            this.PanMain.Size = new System.Drawing.Size(798, 480);
            this.PanMain.TabIndex = 0;
            // 
            // PanBody
            // 
            this.PanBody.Controls.Add(this.grpTransactions);
            this.PanBody.Controls.Add(this.grpCreateAccount);
            this.PanBody.Controls.Add(this.grpAccountDetails);
            this.PanBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanBody.Location = new System.Drawing.Point(0, 49);
            this.PanBody.Name = "PanBody";
            this.PanBody.Size = new System.Drawing.Size(798, 385);
            this.PanBody.TabIndex = 1;
            // 
            // grpTransactions
            // 
            this.grpTransactions.Controls.Add(this.TxtSpecifyAmount);
            this.grpTransactions.Controls.Add(this.BtnDeposit);
            this.grpTransactions.Controls.Add(this.BtnWithdraw);
            this.grpTransactions.Controls.Add(this.LblSpecifyAmount);
            this.grpTransactions.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.grpTransactions.ForeColor = System.Drawing.Color.White;
            this.grpTransactions.Location = new System.Drawing.Point(207, 200);
            this.grpTransactions.Name = "grpTransactions";
            this.grpTransactions.Size = new System.Drawing.Size(378, 156);
            this.grpTransactions.TabIndex = 0;
            this.grpTransactions.TabStop = false;
            this.grpTransactions.Text = "Transactions";
            // 
            // TxtSpecifyAmount
            // 
            this.TxtSpecifyAmount.Location = new System.Drawing.Point(107, 59);
            this.TxtSpecifyAmount.Name = "TxtSpecifyAmount";
            this.TxtSpecifyAmount.Size = new System.Drawing.Size(171, 29);
            this.TxtSpecifyAmount.TabIndex = 4;
            this.TxtSpecifyAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // BtnDeposit
            // 
            this.BtnDeposit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.BtnDeposit.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.BtnDeposit.Location = new System.Drawing.Point(22, 117);
            this.BtnDeposit.Name = "BtnDeposit";
            this.BtnDeposit.Size = new System.Drawing.Size(88, 32);
            this.BtnDeposit.TabIndex = 1;
            this.BtnDeposit.Text = "Deposit";
            this.BtnDeposit.UseVisualStyleBackColor = true;
            this.BtnDeposit.Click += new System.EventHandler(this.BtnDeposit_Click);
            // 
            // BtnWithdraw
            // 
            this.BtnWithdraw.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.BtnWithdraw.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.BtnWithdraw.Location = new System.Drawing.Point(263, 117);
            this.BtnWithdraw.Name = "BtnWithdraw";
            this.BtnWithdraw.Size = new System.Drawing.Size(108, 32);
            this.BtnWithdraw.TabIndex = 2;
            this.BtnWithdraw.Text = "Withdraw";
            this.BtnWithdraw.UseVisualStyleBackColor = true;
            this.BtnWithdraw.Click += new System.EventHandler(this.BtnWithdraw_Click);
            // 
            // LblSpecifyAmount
            // 
            this.LblSpecifyAmount.AutoSize = true;
            this.LblSpecifyAmount.Location = new System.Drawing.Point(121, 32);
            this.LblSpecifyAmount.Name = "LblSpecifyAmount";
            this.LblSpecifyAmount.Size = new System.Drawing.Size(142, 24);
            this.LblSpecifyAmount.TabIndex = 0;
            this.LblSpecifyAmount.Text = "Specify Amount";
            // 
            // grpCreateAccount
            // 
            this.grpCreateAccount.Controls.Add(this.PicUser);
            this.grpCreateAccount.Controls.Add(this.BtnCreateAccount);
            this.grpCreateAccount.Controls.Add(this.TxtName);
            this.grpCreateAccount.Controls.Add(this.LblName);
            this.grpCreateAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.grpCreateAccount.ForeColor = System.Drawing.Color.White;
            this.grpCreateAccount.Location = new System.Drawing.Point(51, 16);
            this.grpCreateAccount.Name = "grpCreateAccount";
            this.grpCreateAccount.Size = new System.Drawing.Size(331, 161);
            this.grpCreateAccount.TabIndex = 1;
            this.grpCreateAccount.TabStop = false;
            this.grpCreateAccount.Text = "Create Account";
            this.grpCreateAccount.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // PicUser
            // 
            this.PicUser.Image = global::Bank.Properties.Resources.User_Icon_Blue;
            this.PicUser.Location = new System.Drawing.Point(213, 28);
            this.PicUser.Name = "PicUser";
            this.PicUser.Size = new System.Drawing.Size(103, 98);
            this.PicUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicUser.TabIndex = 3;
            this.PicUser.TabStop = false;
            // 
            // BtnCreateAccount
            // 
            this.BtnCreateAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.BtnCreateAccount.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.BtnCreateAccount.Location = new System.Drawing.Point(56, 109);
            this.BtnCreateAccount.Name = "BtnCreateAccount";
            this.BtnCreateAccount.Size = new System.Drawing.Size(88, 32);
            this.BtnCreateAccount.TabIndex = 1;
            this.BtnCreateAccount.Text = "Create";
            this.BtnCreateAccount.UseVisualStyleBackColor = true;
            this.BtnCreateAccount.Click += new System.EventHandler(this.BtnCreateAccount_Click);
            // 
            // TxtName
            // 
            this.TxtName.Location = new System.Drawing.Point(19, 63);
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(171, 29);
            this.TxtName.TabIndex = 0;
            // 
            // LblName
            // 
            this.LblName.AutoSize = true;
            this.LblName.Location = new System.Drawing.Point(19, 36);
            this.LblName.Name = "LblName";
            this.LblName.Size = new System.Drawing.Size(61, 24);
            this.LblName.TabIndex = 0;
            this.LblName.Text = "Name";
            // 
            // grpAccountDetails
            // 
            this.grpAccountDetails.Controls.Add(this.LblBalanceAmount);
            this.grpAccountDetails.Controls.Add(this.LblAccountNo);
            this.grpAccountDetails.Controls.Add(this.LblBalance);
            this.grpAccountDetails.Controls.Add(this.LblCustomerName);
            this.grpAccountDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.grpAccountDetails.ForeColor = System.Drawing.Color.White;
            this.grpAccountDetails.Location = new System.Drawing.Point(423, 27);
            this.grpAccountDetails.Name = "grpAccountDetails";
            this.grpAccountDetails.Size = new System.Drawing.Size(364, 150);
            this.grpAccountDetails.TabIndex = 0;
            this.grpAccountDetails.TabStop = false;
            this.grpAccountDetails.Text = "Account Details";
            // 
            // LblBalanceAmount
            // 
            this.LblBalanceAmount.AutoSize = true;
            this.LblBalanceAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblBalanceAmount.Location = new System.Drawing.Point(160, 110);
            this.LblBalanceAmount.Name = "LblBalanceAmount";
            this.LblBalanceAmount.Size = new System.Drawing.Size(80, 29);
            this.LblBalanceAmount.TabIndex = 0;
            this.LblBalanceAmount.Text = "R0.00";
            this.LblBalanceAmount.Click += new System.EventHandler(this.label1_Click);
            // 
            // LblAccountNo
            // 
            this.LblAccountNo.AutoSize = true;
            this.LblAccountNo.Location = new System.Drawing.Point(22, 63);
            this.LblAccountNo.Name = "LblAccountNo";
            this.LblAccountNo.Size = new System.Drawing.Size(159, 24);
            this.LblAccountNo.TabIndex = 0;
            this.LblAccountNo.Text = "Account Number:";
            // 
            // LblBalance
            // 
            this.LblBalance.AutoSize = true;
            this.LblBalance.Location = new System.Drawing.Point(22, 91);
            this.LblBalance.Name = "LblBalance";
            this.LblBalance.Size = new System.Drawing.Size(78, 24);
            this.LblBalance.TabIndex = 0;
            this.LblBalance.Text = "Balance";
            this.LblBalance.Click += new System.EventHandler(this.LblBalance_Click);
            // 
            // LblCustomerName
            // 
            this.LblCustomerName.AutoSize = true;
            this.LblCustomerName.Location = new System.Drawing.Point(22, 34);
            this.LblCustomerName.Name = "LblCustomerName";
            this.LblCustomerName.Size = new System.Drawing.Size(152, 24);
            this.LblCustomerName.TabIndex = 0;
            this.LblCustomerName.Text = "Account Holder: ";
            // 
            // PanFooter
            // 
            this.PanFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PanFooter.Location = new System.Drawing.Point(0, 434);
            this.PanFooter.Name = "PanFooter";
            this.PanFooter.Size = new System.Drawing.Size(798, 46);
            this.PanFooter.TabIndex = 1;
            // 
            // PanHeader
            // 
            this.PanHeader.Controls.Add(this.LblBankName);
            this.PanHeader.Controls.Add(this.PicClose);
            this.PanHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanHeader.Location = new System.Drawing.Point(0, 0);
            this.PanHeader.Name = "PanHeader";
            this.PanHeader.Size = new System.Drawing.Size(798, 49);
            this.PanHeader.TabIndex = 0;
            // 
            // LblBankName
            // 
            this.LblBankName.AutoSize = true;
            this.LblBankName.Dock = System.Windows.Forms.DockStyle.Top;
            this.LblBankName.Font = new System.Drawing.Font("Georgia", 22F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.LblBankName.ForeColor = System.Drawing.Color.Orange;
            this.LblBankName.Location = new System.Drawing.Point(0, 0);
            this.LblBankName.Name = "LblBankName";
            this.LblBankName.Size = new System.Drawing.Size(195, 35);
            this.LblBankName.TabIndex = 0;
            this.LblBankName.Text = "Usurf Bank";
            // 
            // PicClose
            // 
            this.PicClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PicClose.Image = global::Bank.Properties.Resources.Cancel_Bright;
            this.PicClose.Location = new System.Drawing.Point(758, 10);
            this.PicClose.Name = "PicClose";
            this.PicClose.Size = new System.Drawing.Size(35, 28);
            this.PicClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PicClose.TabIndex = 0;
            this.PicClose.TabStop = false;
            this.PicClose.Click += new System.EventHandler(this.PicClose_Click);
            this.PicClose.MouseLeave += new System.EventHandler(this.PicClose_MouseLeave);
            this.PicClose.MouseHover += new System.EventHandler(this.PicClose_MouseHover);
            // 
            // FrmBank
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(798, 480);
            this.Controls.Add(this.PanMain);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "FrmBank";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bank";
            this.Load += new System.EventHandler(this.FrmBank_Load);
            this.PanMain.ResumeLayout(false);
            this.PanBody.ResumeLayout(false);
            this.grpTransactions.ResumeLayout(false);
            this.grpTransactions.PerformLayout();
            this.grpCreateAccount.ResumeLayout(false);
            this.grpCreateAccount.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicUser)).EndInit();
            this.grpAccountDetails.ResumeLayout(false);
            this.grpAccountDetails.PerformLayout();
            this.PanHeader.ResumeLayout(false);
            this.PanHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicClose)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanMain;
        private System.Windows.Forms.Panel PanBody;
        private System.Windows.Forms.Panel PanFooter;
        private System.Windows.Forms.Panel PanHeader;
        private System.Windows.Forms.PictureBox PicClose;
        private System.Windows.Forms.Label LblBankName;
        private System.Windows.Forms.GroupBox grpCreateAccount;
        private System.Windows.Forms.PictureBox PicUser;
        private System.Windows.Forms.Button BtnCreateAccount;
        private System.Windows.Forms.TextBox TxtName;
        private System.Windows.Forms.Label LblName;
        private System.Windows.Forms.GroupBox grpAccountDetails;
        private System.Windows.Forms.Label LblCustomerName;
        private System.Windows.Forms.Label LblBalance;
        private System.Windows.Forms.Label LblAccountNo;
        private System.Windows.Forms.Label LblBalanceAmount;
        private System.Windows.Forms.GroupBox grpTransactions;
        private System.Windows.Forms.Button BtnDeposit;
        private System.Windows.Forms.Button BtnWithdraw;
        private System.Windows.Forms.Label LblSpecifyAmount;
        private System.Windows.Forms.TextBox TxtSpecifyAmount;
    }
}

