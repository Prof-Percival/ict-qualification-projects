
namespace C6E5_Joe_s_Automotive
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
            this.GrpOilandLube = new System.Windows.Forms.GroupBox();
            this.ChkLubeJob = new System.Windows.Forms.CheckBox();
            this.ChkOilChange = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtParts = new System.Windows.Forms.TextBox();
            this.GrpFlushes = new System.Windows.Forms.GroupBox();
            this.ChkTransmissionFlush = new System.Windows.Forms.CheckBox();
            this.ChkRadiatorFlush = new System.Windows.Forms.CheckBox();
            this.GrpMisc = new System.Windows.Forms.GroupBox();
            this.ChkTireRotation = new System.Windows.Forms.CheckBox();
            this.ChkReplaceMuffler = new System.Windows.Forms.CheckBox();
            this.ChkInspection = new System.Windows.Forms.CheckBox();
            this.GrpPartsAndLabor = new System.Windows.Forms.GroupBox();
            this.TxtLabor = new System.Windows.Forms.TextBox();
            this.TxtHours = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.GrpSummary = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.TxtTotalFees = new System.Windows.Forms.TextBox();
            this.TxtTax = new System.Windows.Forms.TextBox();
            this.TxtPartsSummary = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtServiceAndLabor = new System.Windows.Forms.TextBox();
            this.BtnCalculate = new System.Windows.Forms.Button();
            this.BtnClear = new System.Windows.Forms.Button();
            this.BtnExit = new System.Windows.Forms.Button();
            this.GrpOilandLube.SuspendLayout();
            this.GrpFlushes.SuspendLayout();
            this.GrpMisc.SuspendLayout();
            this.GrpPartsAndLabor.SuspendLayout();
            this.GrpSummary.SuspendLayout();
            this.SuspendLayout();
            // 
            // GrpOilandLube
            // 
            this.GrpOilandLube.Controls.Add(this.ChkLubeJob);
            this.GrpOilandLube.Controls.Add(this.ChkOilChange);
            this.GrpOilandLube.Location = new System.Drawing.Point(12, 12);
            this.GrpOilandLube.Name = "GrpOilandLube";
            this.GrpOilandLube.Size = new System.Drawing.Size(228, 84);
            this.GrpOilandLube.TabIndex = 0;
            this.GrpOilandLube.TabStop = false;
            this.GrpOilandLube.Text = "Oil and Lube";
            // 
            // ChkLubeJob
            // 
            this.ChkLubeJob.AutoSize = true;
            this.ChkLubeJob.Location = new System.Drawing.Point(12, 50);
            this.ChkLubeJob.Name = "ChkLubeJob";
            this.ChkLubeJob.Size = new System.Drawing.Size(157, 21);
            this.ChkLubeJob.TabIndex = 1;
            this.ChkLubeJob.Text = "Lube Job ($18.00)";
            this.ChkLubeJob.UseVisualStyleBackColor = true;
            // 
            // ChkOilChange
            // 
            this.ChkOilChange.AutoSize = true;
            this.ChkOilChange.Location = new System.Drawing.Point(12, 23);
            this.ChkOilChange.Name = "ChkOilChange";
            this.ChkOilChange.Size = new System.Drawing.Size(169, 21);
            this.ChkOilChange.TabIndex = 0;
            this.ChkOilChange.Text = "Oil Change ($26.00)";
            this.ChkOilChange.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Parts";
            // 
            // TxtParts
            // 
            this.TxtParts.Location = new System.Drawing.Point(44, 40);
            this.TxtParts.Name = "TxtParts";
            this.TxtParts.Size = new System.Drawing.Size(71, 24);
            this.TxtParts.TabIndex = 7;
            this.TxtParts.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // GrpFlushes
            // 
            this.GrpFlushes.Controls.Add(this.ChkTransmissionFlush);
            this.GrpFlushes.Controls.Add(this.ChkRadiatorFlush);
            this.GrpFlushes.Location = new System.Drawing.Point(246, 12);
            this.GrpFlushes.Name = "GrpFlushes";
            this.GrpFlushes.Size = new System.Drawing.Size(244, 84);
            this.GrpFlushes.TabIndex = 0;
            this.GrpFlushes.TabStop = false;
            this.GrpFlushes.Text = "Flushes";
            // 
            // ChkTransmissionFlush
            // 
            this.ChkTransmissionFlush.AutoSize = true;
            this.ChkTransmissionFlush.Location = new System.Drawing.Point(12, 50);
            this.ChkTransmissionFlush.Name = "ChkTransmissionFlush";
            this.ChkTransmissionFlush.Size = new System.Drawing.Size(228, 21);
            this.ChkTransmissionFlush.TabIndex = 3;
            this.ChkTransmissionFlush.Text = "Transmission Flush ($80.00)";
            this.ChkTransmissionFlush.UseVisualStyleBackColor = true;
            // 
            // ChkRadiatorFlush
            // 
            this.ChkRadiatorFlush.AutoSize = true;
            this.ChkRadiatorFlush.Location = new System.Drawing.Point(12, 23);
            this.ChkRadiatorFlush.Name = "ChkRadiatorFlush";
            this.ChkRadiatorFlush.Size = new System.Drawing.Size(195, 21);
            this.ChkRadiatorFlush.TabIndex = 2;
            this.ChkRadiatorFlush.Text = "Radiator Flush ($30.00)";
            this.ChkRadiatorFlush.UseVisualStyleBackColor = true;
            // 
            // GrpMisc
            // 
            this.GrpMisc.Controls.Add(this.ChkTireRotation);
            this.GrpMisc.Controls.Add(this.ChkReplaceMuffler);
            this.GrpMisc.Controls.Add(this.ChkInspection);
            this.GrpMisc.Location = new System.Drawing.Point(12, 105);
            this.GrpMisc.Name = "GrpMisc";
            this.GrpMisc.Size = new System.Drawing.Size(228, 114);
            this.GrpMisc.TabIndex = 0;
            this.GrpMisc.TabStop = false;
            this.GrpMisc.Text = "Misc";
            // 
            // ChkTireRotation
            // 
            this.ChkTireRotation.AutoSize = true;
            this.ChkTireRotation.Location = new System.Drawing.Point(12, 77);
            this.ChkTireRotation.Name = "ChkTireRotation";
            this.ChkTireRotation.Size = new System.Drawing.Size(185, 21);
            this.ChkTireRotation.TabIndex = 6;
            this.ChkTireRotation.Text = "Tire Rotation ($20.00)";
            this.ChkTireRotation.UseVisualStyleBackColor = true;
            // 
            // ChkReplaceMuffler
            // 
            this.ChkReplaceMuffler.AutoSize = true;
            this.ChkReplaceMuffler.Location = new System.Drawing.Point(12, 50);
            this.ChkReplaceMuffler.Name = "ChkReplaceMuffler";
            this.ChkReplaceMuffler.Size = new System.Drawing.Size(208, 21);
            this.ChkReplaceMuffler.TabIndex = 5;
            this.ChkReplaceMuffler.Text = "Replace Muffler ($100.00)";
            this.ChkReplaceMuffler.UseVisualStyleBackColor = true;
            // 
            // ChkInspection
            // 
            this.ChkInspection.AutoSize = true;
            this.ChkInspection.Location = new System.Drawing.Point(12, 23);
            this.ChkInspection.Name = "ChkInspection";
            this.ChkInspection.Size = new System.Drawing.Size(167, 21);
            this.ChkInspection.TabIndex = 4;
            this.ChkInspection.Text = "Inspection ($15.00)";
            this.ChkInspection.UseVisualStyleBackColor = true;
            // 
            // GrpPartsAndLabor
            // 
            this.GrpPartsAndLabor.Controls.Add(this.TxtLabor);
            this.GrpPartsAndLabor.Controls.Add(this.TxtHours);
            this.GrpPartsAndLabor.Controls.Add(this.label3);
            this.GrpPartsAndLabor.Controls.Add(this.label2);
            this.GrpPartsAndLabor.Controls.Add(this.label1);
            this.GrpPartsAndLabor.Controls.Add(this.TxtParts);
            this.GrpPartsAndLabor.Location = new System.Drawing.Point(246, 105);
            this.GrpPartsAndLabor.Name = "GrpPartsAndLabor";
            this.GrpPartsAndLabor.Size = new System.Drawing.Size(244, 114);
            this.GrpPartsAndLabor.TabIndex = 0;
            this.GrpPartsAndLabor.TabStop = false;
            this.GrpPartsAndLabor.Text = "Parts and Labor";
            // 
            // TxtLabor
            // 
            this.TxtLabor.BackColor = System.Drawing.SystemColors.Window;
            this.TxtLabor.Location = new System.Drawing.Point(96, 77);
            this.TxtLabor.Name = "TxtLabor";
            this.TxtLabor.ReadOnly = true;
            this.TxtLabor.Size = new System.Drawing.Size(111, 24);
            this.TxtLabor.TabIndex = 0;
            this.TxtLabor.TabStop = false;
            this.TxtLabor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TxtHours
            // 
            this.TxtHours.Location = new System.Drawing.Point(147, 40);
            this.TxtHours.Name = "TxtHours";
            this.TxtHours.Size = new System.Drawing.Size(71, 24);
            this.TxtHours.TabIndex = 8;
            this.TxtHours.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TxtHours.TextChanged += new System.EventHandler(this.TxtHours_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Labor ($)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(157, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Hours";
            // 
            // GrpSummary
            // 
            this.GrpSummary.Controls.Add(this.label7);
            this.GrpSummary.Controls.Add(this.TxtTotalFees);
            this.GrpSummary.Controls.Add(this.TxtTax);
            this.GrpSummary.Controls.Add(this.TxtPartsSummary);
            this.GrpSummary.Controls.Add(this.label4);
            this.GrpSummary.Controls.Add(this.label5);
            this.GrpSummary.Controls.Add(this.label6);
            this.GrpSummary.Controls.Add(this.TxtServiceAndLabor);
            this.GrpSummary.Location = new System.Drawing.Point(12, 225);
            this.GrpSummary.Name = "GrpSummary";
            this.GrpSummary.Size = new System.Drawing.Size(478, 145);
            this.GrpSummary.TabIndex = 0;
            this.GrpSummary.TabStop = false;
            this.GrpSummary.Text = "Summary";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(64, 120);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 17);
            this.label7.TabIndex = 0;
            this.label7.Text = "Total Fees";
            // 
            // TxtTotalFees
            // 
            this.TxtTotalFees.BackColor = System.Drawing.SystemColors.Window;
            this.TxtTotalFees.Location = new System.Drawing.Point(148, 113);
            this.TxtTotalFees.Name = "TxtTotalFees";
            this.TxtTotalFees.ReadOnly = true;
            this.TxtTotalFees.Size = new System.Drawing.Size(142, 24);
            this.TxtTotalFees.TabIndex = 0;
            this.TxtTotalFees.TabStop = false;
            this.TxtTotalFees.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TxtTax
            // 
            this.TxtTax.BackColor = System.Drawing.SystemColors.Window;
            this.TxtTax.Location = new System.Drawing.Point(148, 83);
            this.TxtTax.Name = "TxtTax";
            this.TxtTax.ReadOnly = true;
            this.TxtTax.Size = new System.Drawing.Size(142, 24);
            this.TxtTax.TabIndex = 0;
            this.TxtTax.TabStop = false;
            this.TxtTax.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TxtPartsSummary
            // 
            this.TxtPartsSummary.Location = new System.Drawing.Point(148, 53);
            this.TxtPartsSummary.Name = "TxtPartsSummary";
            this.TxtPartsSummary.ReadOnly = true;
            this.TxtPartsSummary.Size = new System.Drawing.Size(142, 24);
            this.TxtPartsSummary.TabIndex = 0;
            this.TxtPartsSummary.TabStop = false;
            this.TxtPartsSummary.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Tax (on Parts)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(134, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Service and Labor";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(98, 56);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 17);
            this.label6.TabIndex = 0;
            this.label6.Text = "Parts";
            // 
            // TxtServiceAndLabor
            // 
            this.TxtServiceAndLabor.Location = new System.Drawing.Point(148, 23);
            this.TxtServiceAndLabor.Name = "TxtServiceAndLabor";
            this.TxtServiceAndLabor.ReadOnly = true;
            this.TxtServiceAndLabor.Size = new System.Drawing.Size(142, 24);
            this.TxtServiceAndLabor.TabIndex = 0;
            this.TxtServiceAndLabor.TabStop = false;
            this.TxtServiceAndLabor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // BtnCalculate
            // 
            this.BtnCalculate.Location = new System.Drawing.Point(213, 390);
            this.BtnCalculate.Name = "BtnCalculate";
            this.BtnCalculate.Size = new System.Drawing.Size(89, 24);
            this.BtnCalculate.TabIndex = 9;
            this.BtnCalculate.Text = "Ca&lculate";
            this.BtnCalculate.UseVisualStyleBackColor = true;
            this.BtnCalculate.Click += new System.EventHandler(this.BtnCalculate_Click);
            // 
            // BtnClear
            // 
            this.BtnClear.Location = new System.Drawing.Point(12, 390);
            this.BtnClear.Name = "BtnClear";
            this.BtnClear.Size = new System.Drawing.Size(54, 24);
            this.BtnClear.TabIndex = 10;
            this.BtnClear.Text = "&Clear";
            this.BtnClear.UseVisualStyleBackColor = true;
            this.BtnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // BtnExit
            // 
            this.BtnExit.Location = new System.Drawing.Point(432, 390);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(54, 24);
            this.BtnExit.TabIndex = 11;
            this.BtnExit.Text = "E&xit";
            this.BtnExit.UseVisualStyleBackColor = true;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(499, 423);
            this.Controls.Add(this.BtnExit);
            this.Controls.Add(this.BtnClear);
            this.Controls.Add(this.BtnCalculate);
            this.Controls.Add(this.GrpSummary);
            this.Controls.Add(this.GrpPartsAndLabor);
            this.Controls.Add(this.GrpMisc);
            this.Controls.Add(this.GrpFlushes);
            this.Controls.Add(this.GrpOilandLube);
            this.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Joe\'s Automotive";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.GrpOilandLube.ResumeLayout(false);
            this.GrpOilandLube.PerformLayout();
            this.GrpFlushes.ResumeLayout(false);
            this.GrpFlushes.PerformLayout();
            this.GrpMisc.ResumeLayout(false);
            this.GrpMisc.PerformLayout();
            this.GrpPartsAndLabor.ResumeLayout(false);
            this.GrpPartsAndLabor.PerformLayout();
            this.GrpSummary.ResumeLayout(false);
            this.GrpSummary.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GrpOilandLube;
        private System.Windows.Forms.CheckBox ChkLubeJob;
        private System.Windows.Forms.CheckBox ChkOilChange;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtParts;
        private System.Windows.Forms.GroupBox GrpFlushes;
        private System.Windows.Forms.CheckBox ChkTransmissionFlush;
        private System.Windows.Forms.CheckBox ChkRadiatorFlush;
        private System.Windows.Forms.GroupBox GrpMisc;
        private System.Windows.Forms.CheckBox ChkReplaceMuffler;
        private System.Windows.Forms.CheckBox ChkInspection;
        private System.Windows.Forms.CheckBox ChkTireRotation;
        private System.Windows.Forms.GroupBox GrpPartsAndLabor;
        private System.Windows.Forms.TextBox TxtLabor;
        private System.Windows.Forms.TextBox TxtHours;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox GrpSummary;
        private System.Windows.Forms.TextBox TxtTax;
        private System.Windows.Forms.TextBox TxtPartsSummary;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TxtServiceAndLabor;
        private System.Windows.Forms.TextBox TxtTotalFees;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button BtnCalculate;
        private System.Windows.Forms.Button BtnClear;
        private System.Windows.Forms.Button BtnExit;
    }
}

