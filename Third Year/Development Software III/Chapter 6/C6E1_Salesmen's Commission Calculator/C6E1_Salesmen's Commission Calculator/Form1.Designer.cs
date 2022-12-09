
namespace C6E1_Salesmen_s_Commission_Calculator
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
            this.BtnCompute = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtRevenueSale = new System.Windows.Forms.TextBox();
            this.TxtRateCommission = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnClear = new System.Windows.Forms.Button();
            this.BtnExit = new System.Windows.Forms.Button();
            this.TxtCommissionEarned = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnCompute
            // 
            this.BtnCompute.Location = new System.Drawing.Point(203, 105);
            this.BtnCompute.Name = "BtnCompute";
            this.BtnCompute.Size = new System.Drawing.Size(90, 26);
            this.BtnCompute.TabIndex = 2;
            this.BtnCompute.Text = "Co&mpute";
            this.BtnCompute.UseVisualStyleBackColor = true;
            this.BtnCompute.Click += new System.EventHandler(this.BtnCompute_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Salesman\'s Revenue Sale";
            // 
            // TxtRevenueSale
            // 
            this.TxtRevenueSale.Location = new System.Drawing.Point(250, 27);
            this.TxtRevenueSale.Name = "TxtRevenueSale";
            this.TxtRevenueSale.Size = new System.Drawing.Size(100, 27);
            this.TxtRevenueSale.TabIndex = 0;
            this.TxtRevenueSale.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TxtRateCommission
            // 
            this.TxtRateCommission.Location = new System.Drawing.Point(250, 70);
            this.TxtRateCommission.Name = "TxtRateCommission";
            this.TxtRateCommission.Size = new System.Drawing.Size(100, 27);
            this.TxtRateCommission.TabIndex = 1;
            this.TxtRateCommission.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(71, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(173, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "Rate of Commission";
            // 
            // BtnClear
            // 
            this.BtnClear.Location = new System.Drawing.Point(7, 186);
            this.BtnClear.Name = "BtnClear";
            this.BtnClear.Size = new System.Drawing.Size(60, 23);
            this.BtnClear.TabIndex = 3;
            this.BtnClear.Text = "&Clear";
            this.BtnClear.UseVisualStyleBackColor = true;
            this.BtnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // BtnExit
            // 
            this.BtnExit.Location = new System.Drawing.Point(316, 186);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(60, 23);
            this.BtnExit.TabIndex = 4;
            this.BtnExit.Text = "E&xit";
            this.BtnExit.UseVisualStyleBackColor = true;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // TxtCommissionEarned
            // 
            this.TxtCommissionEarned.Location = new System.Drawing.Point(250, 138);
            this.TxtCommissionEarned.Name = "TxtCommissionEarned";
            this.TxtCommissionEarned.Size = new System.Drawing.Size(100, 27);
            this.TxtCommissionEarned.TabIndex = 0;
            this.TxtCommissionEarned.TabStop = false;
            this.TxtCommissionEarned.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(71, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(169, 18);
            this.label3.TabIndex = 0;
            this.label3.Text = "Commission Earned";
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(384, 217);
            this.Controls.Add(this.TxtCommissionEarned);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BtnExit);
            this.Controls.Add(this.BtnClear);
            this.Controls.Add(this.TxtRateCommission);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtRevenueSale);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnCompute);
            this.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Salesmen\'s Commision Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnCompute;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtRevenueSale;
        private System.Windows.Forms.TextBox TxtRateCommission;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnClear;
        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.TextBox TxtCommissionEarned;
        private System.Windows.Forms.Label label3;
    }
}

