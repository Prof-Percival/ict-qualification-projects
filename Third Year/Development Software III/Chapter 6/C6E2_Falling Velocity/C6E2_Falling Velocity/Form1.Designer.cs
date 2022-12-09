
namespace C6E2_Falling_Velocity
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
            this.TxtTime = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtDistance = new System.Windows.Forms.TextBox();
            this.BtnClear = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtVelocity = new System.Windows.Forms.TextBox();
            this.BtnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnCompute
            // 
            this.BtnCompute.Location = new System.Drawing.Point(126, 77);
            this.BtnCompute.Name = "BtnCompute";
            this.BtnCompute.Size = new System.Drawing.Size(85, 27);
            this.BtnCompute.TabIndex = 1;
            this.BtnCompute.Text = "Co&mpute";
            this.BtnCompute.UseVisualStyleBackColor = true;
            this.BtnCompute.Click += new System.EventHandler(this.BtnCompute_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(253, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Object Falling | Velocity & Distance";
            // 
            // TxtTime
            // 
            this.TxtTime.Location = new System.Drawing.Point(150, 41);
            this.TxtTime.Name = "TxtTime";
            this.TxtTime.Size = new System.Drawing.Size(74, 26);
            this.TxtTime.TabIndex = 0;
            this.TxtTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(100, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "Time";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(73, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 18);
            this.label3.TabIndex = 1;
            this.label3.Text = "Distance";
            // 
            // TxtDistance
            // 
            this.TxtDistance.BackColor = System.Drawing.SystemColors.Window;
            this.TxtDistance.Location = new System.Drawing.Point(150, 148);
            this.TxtDistance.Name = "TxtDistance";
            this.TxtDistance.ReadOnly = true;
            this.TxtDistance.Size = new System.Drawing.Size(115, 26);
            this.TxtDistance.TabIndex = 0;
            this.TxtDistance.TabStop = false;
            this.TxtDistance.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TxtDistance.TextChanged += new System.EventHandler(this.TxtDistance_TextChanged);
            // 
            // BtnClear
            // 
            this.BtnClear.Location = new System.Drawing.Point(12, 211);
            this.BtnClear.Name = "BtnClear";
            this.BtnClear.Size = new System.Drawing.Size(58, 27);
            this.BtnClear.TabIndex = 2;
            this.BtnClear.Text = "&Clear";
            this.BtnClear.UseVisualStyleBackColor = true;
            this.BtnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(79, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 18);
            this.label4.TabIndex = 0;
            this.label4.Text = "Velocity";
            // 
            // TxtVelocity
            // 
            this.TxtVelocity.BackColor = System.Drawing.SystemColors.Window;
            this.TxtVelocity.Location = new System.Drawing.Point(150, 110);
            this.TxtVelocity.Name = "TxtVelocity";
            this.TxtVelocity.ReadOnly = true;
            this.TxtVelocity.Size = new System.Drawing.Size(115, 26);
            this.TxtVelocity.TabIndex = 0;
            this.TxtVelocity.TabStop = false;
            this.TxtVelocity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // BtnExit
            // 
            this.BtnExit.Location = new System.Drawing.Point(289, 211);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(58, 27);
            this.BtnExit.TabIndex = 3;
            this.BtnExit.Text = "E&xit";
            this.BtnExit.UseVisualStyleBackColor = true;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(359, 250);
            this.Controls.Add(this.BtnExit);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxtVelocity);
            this.Controls.Add(this.BtnClear);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtDistance);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtTime);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnCompute);
            this.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Falling Velocity";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnCompute;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtTime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtDistance;
        private System.Windows.Forms.Button BtnClear;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtVelocity;
        private System.Windows.Forms.Button BtnExit;
    }
}

