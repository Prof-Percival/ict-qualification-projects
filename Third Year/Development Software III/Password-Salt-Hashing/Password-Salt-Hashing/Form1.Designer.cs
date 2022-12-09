
namespace Password_Salt_Hashing
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
            this.LblPassword = new System.Windows.Forms.Label();
            this.TxtPassword = new System.Windows.Forms.TextBox();
            this.LblSalt = new System.Windows.Forms.Label();
            this.TxtSalt = new System.Windows.Forms.TextBox();
            this.LblHash = new System.Windows.Forms.Label();
            this.TxtHash = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnGenerate = new System.Windows.Forms.Button();
            this.LblOldSalt = new System.Windows.Forms.Label();
            this.TxtOldSalt = new System.Windows.Forms.TextBox();
            this.LblHashNew = new System.Windows.Forms.Label();
            this.TxtHashNew = new System.Windows.Forms.TextBox();
            this.BtnReGenerate = new System.Windows.Forms.Button();
            this.BtnConfirm = new System.Windows.Forms.Button();
            this.LblNewPassword = new System.Windows.Forms.Label();
            this.TxtNewPassword = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // LblPassword
            // 
            this.LblPassword.AutoSize = true;
            this.LblPassword.Location = new System.Drawing.Point(103, 76);
            this.LblPassword.Name = "LblPassword";
            this.LblPassword.Size = new System.Drawing.Size(95, 25);
            this.LblPassword.TabIndex = 0;
            this.LblPassword.Text = "Password:";
            // 
            // TxtPassword
            // 
            this.TxtPassword.Location = new System.Drawing.Point(272, 73);
            this.TxtPassword.Name = "TxtPassword";
            this.TxtPassword.Size = new System.Drawing.Size(211, 33);
            this.TxtPassword.TabIndex = 0;
            // 
            // LblSalt
            // 
            this.LblSalt.AutoSize = true;
            this.LblSalt.Location = new System.Drawing.Point(15, 133);
            this.LblSalt.Name = "LblSalt";
            this.LblSalt.Size = new System.Drawing.Size(47, 25);
            this.LblSalt.TabIndex = 0;
            this.LblSalt.Text = "Salt:";
            // 
            // TxtSalt
            // 
            this.TxtSalt.Location = new System.Drawing.Point(184, 130);
            this.TxtSalt.Name = "TxtSalt";
            this.TxtSalt.Size = new System.Drawing.Size(299, 33);
            this.TxtSalt.TabIndex = 0;
            this.TxtSalt.TabStop = false;
            // 
            // LblHash
            // 
            this.LblHash.AutoSize = true;
            this.LblHash.Location = new System.Drawing.Point(15, 188);
            this.LblHash.Name = "LblHash";
            this.LblHash.Size = new System.Drawing.Size(163, 25);
            this.LblHash.TabIndex = 0;
            this.LblHash.Text = "Hashed Password:";
            // 
            // TxtHash
            // 
            this.TxtHash.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtHash.Location = new System.Drawing.Point(15, 216);
            this.TxtHash.Multiline = true;
            this.TxtHash.Name = "TxtHash";
            this.TxtHash.Size = new System.Drawing.Size(453, 136);
            this.TxtHash.TabIndex = 0;
            this.TxtHash.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(283, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(403, 40);
            this.label3.TabIndex = 0;
            this.label3.Text = "Password Salting && Hashing";
            // 
            // BtnGenerate
            // 
            this.BtnGenerate.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnGenerate.ForeColor = System.Drawing.Color.Black;
            this.BtnGenerate.Location = new System.Drawing.Point(210, 383);
            this.BtnGenerate.Name = "BtnGenerate";
            this.BtnGenerate.Size = new System.Drawing.Size(116, 37);
            this.BtnGenerate.TabIndex = 1;
            this.BtnGenerate.Text = "&Generate";
            this.BtnGenerate.UseVisualStyleBackColor = true;
            this.BtnGenerate.Click += new System.EventHandler(this.BtnGenerate_Click);
            // 
            // LblOldSalt
            // 
            this.LblOldSalt.AutoSize = true;
            this.LblOldSalt.Location = new System.Drawing.Point(505, 134);
            this.LblOldSalt.Name = "LblOldSalt";
            this.LblOldSalt.Size = new System.Drawing.Size(47, 25);
            this.LblOldSalt.TabIndex = 0;
            this.LblOldSalt.Text = "Salt:";
            // 
            // TxtOldSalt
            // 
            this.TxtOldSalt.Location = new System.Drawing.Point(674, 131);
            this.TxtOldSalt.Name = "TxtOldSalt";
            this.TxtOldSalt.Size = new System.Drawing.Size(276, 33);
            this.TxtOldSalt.TabIndex = 0;
            this.TxtOldSalt.TabStop = false;
            // 
            // LblHashNew
            // 
            this.LblHashNew.AutoSize = true;
            this.LblHashNew.Location = new System.Drawing.Point(505, 189);
            this.LblHashNew.Name = "LblHashNew";
            this.LblHashNew.Size = new System.Drawing.Size(206, 25);
            this.LblHashNew.TabIndex = 0;
            this.LblHashNew.Text = "Hashed New Password:";
            // 
            // TxtHashNew
            // 
            this.TxtHashNew.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtHashNew.Location = new System.Drawing.Point(505, 217);
            this.TxtHashNew.Multiline = true;
            this.TxtHashNew.Name = "TxtHashNew";
            this.TxtHashNew.Size = new System.Drawing.Size(449, 135);
            this.TxtHashNew.TabIndex = 0;
            this.TxtHashNew.TabStop = false;
            // 
            // BtnReGenerate
            // 
            this.BtnReGenerate.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnReGenerate.ForeColor = System.Drawing.Color.Black;
            this.BtnReGenerate.Location = new System.Drawing.Point(726, 383);
            this.BtnReGenerate.Name = "BtnReGenerate";
            this.BtnReGenerate.Size = new System.Drawing.Size(131, 37);
            this.BtnReGenerate.TabIndex = 0;
            this.BtnReGenerate.Text = "&Re-Generate";
            this.BtnReGenerate.UseVisualStyleBackColor = true;
            this.BtnReGenerate.Click += new System.EventHandler(this.BtnReGenerate_Click);
            // 
            // BtnConfirm
            // 
            this.BtnConfirm.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnConfirm.ForeColor = System.Drawing.Color.Black;
            this.BtnConfirm.Location = new System.Drawing.Point(436, 383);
            this.BtnConfirm.Name = "BtnConfirm";
            this.BtnConfirm.Size = new System.Drawing.Size(116, 37);
            this.BtnConfirm.TabIndex = 0;
            this.BtnConfirm.TabStop = false;
            this.BtnConfirm.Text = "&Confirm";
            this.BtnConfirm.UseVisualStyleBackColor = true;
            this.BtnConfirm.Click += new System.EventHandler(this.BtnConfirm_Click);
            // 
            // LblNewPassword
            // 
            this.LblNewPassword.AutoSize = true;
            this.LblNewPassword.Location = new System.Drawing.Point(505, 79);
            this.LblNewPassword.Name = "LblNewPassword";
            this.LblNewPassword.Size = new System.Drawing.Size(138, 25);
            this.LblNewPassword.TabIndex = 0;
            this.LblNewPassword.Text = "New Password:";
            // 
            // TxtNewPassword
            // 
            this.TxtNewPassword.Location = new System.Drawing.Point(674, 76);
            this.TxtNewPassword.Name = "TxtNewPassword";
            this.TxtNewPassword.Size = new System.Drawing.Size(211, 33);
            this.TxtNewPassword.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.ClientSize = new System.Drawing.Size(965, 435);
            this.Controls.Add(this.BtnReGenerate);
            this.Controls.Add(this.BtnConfirm);
            this.Controls.Add(this.BtnGenerate);
            this.Controls.Add(this.TxtHashNew);
            this.Controls.Add(this.TxtHash);
            this.Controls.Add(this.LblHashNew);
            this.Controls.Add(this.LblHash);
            this.Controls.Add(this.TxtOldSalt);
            this.Controls.Add(this.LblOldSalt);
            this.Controls.Add(this.TxtSalt);
            this.Controls.Add(this.LblSalt);
            this.Controls.Add(this.TxtNewPassword);
            this.Controls.Add(this.TxtPassword);
            this.Controls.Add(this.LblNewPassword);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.LblPassword);
            this.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Password Salt & Hashing";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblPassword;
        private System.Windows.Forms.TextBox TxtPassword;
        private System.Windows.Forms.Label LblSalt;
        private System.Windows.Forms.TextBox TxtSalt;
        private System.Windows.Forms.Label LblHash;
        private System.Windows.Forms.TextBox TxtHash;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtnGenerate;
        private System.Windows.Forms.Label LblOldSalt;
        private System.Windows.Forms.TextBox TxtOldSalt;
        private System.Windows.Forms.Label LblHashNew;
        private System.Windows.Forms.TextBox TxtHashNew;
        private System.Windows.Forms.Button BtnReGenerate;
        private System.Windows.Forms.Button BtnConfirm;
        private System.Windows.Forms.Label LblNewPassword;
        private System.Windows.Forms.TextBox TxtNewPassword;
    }
}

