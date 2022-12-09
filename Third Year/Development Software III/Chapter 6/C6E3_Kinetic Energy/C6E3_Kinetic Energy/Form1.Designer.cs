
namespace C6E3_Kinetic_Energy
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
            this.TxtMass = new System.Windows.Forms.TextBox();
            this.TxtVelocity = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtKineticEnergy = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnClear = new System.Windows.Forms.Button();
            this.BtnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnCompute
            // 
            this.BtnCompute.Location = new System.Drawing.Point(109, 100);
            this.BtnCompute.Name = "BtnCompute";
            this.BtnCompute.Size = new System.Drawing.Size(91, 28);
            this.BtnCompute.TabIndex = 2;
            this.BtnCompute.Text = "Co&mpute";
            this.BtnCompute.UseVisualStyleBackColor = true;
            this.BtnCompute.Click += new System.EventHandler(this.BtnCompute_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mass(kg)";
            // 
            // TxtMass
            // 
            this.TxtMass.Location = new System.Drawing.Point(147, 22);
            this.TxtMass.Name = "TxtMass";
            this.TxtMass.Size = new System.Drawing.Size(100, 26);
            this.TxtMass.TabIndex = 0;
            this.TxtMass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TxtVelocity
            // 
            this.TxtVelocity.Location = new System.Drawing.Point(147, 59);
            this.TxtVelocity.Name = "TxtVelocity";
            this.TxtVelocity.Size = new System.Drawing.Size(100, 26);
            this.TxtVelocity.TabIndex = 1;
            this.TxtVelocity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "Velocity(m/s)";
            // 
            // TxtKineticEnergy
            // 
            this.TxtKineticEnergy.Location = new System.Drawing.Point(147, 152);
            this.TxtKineticEnergy.Name = "TxtKineticEnergy";
            this.TxtKineticEnergy.Size = new System.Drawing.Size(100, 26);
            this.TxtKineticEnergy.TabIndex = 0;
            this.TxtKineticEnergy.TabStop = false;
            this.TxtKineticEnergy.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 18);
            this.label3.TabIndex = 0;
            this.label3.Text = "Kinetic Energy";
            // 
            // BtnClear
            // 
            this.BtnClear.Location = new System.Drawing.Point(12, 210);
            this.BtnClear.Name = "BtnClear";
            this.BtnClear.Size = new System.Drawing.Size(54, 28);
            this.BtnClear.TabIndex = 3;
            this.BtnClear.Text = "&Clear";
            this.BtnClear.UseVisualStyleBackColor = true;
            this.BtnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // BtnExit
            // 
            this.BtnExit.Location = new System.Drawing.Point(275, 210);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(54, 28);
            this.BtnExit.TabIndex = 4;
            this.BtnExit.Text = "E&xit";
            this.BtnExit.UseVisualStyleBackColor = true;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(341, 250);
            this.Controls.Add(this.BtnExit);
            this.Controls.Add(this.BtnClear);
            this.Controls.Add(this.TxtKineticEnergy);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtVelocity);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtMass);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnCompute);
            this.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kinetic Energy";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnCompute;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtMass;
        private System.Windows.Forms.TextBox TxtVelocity;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtKineticEnergy;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtnClear;
        private System.Windows.Forms.Button BtnExit;
    }
}

