
namespace C3E1_StudentsInformation
{
    partial class FrmStudentsInformation
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
            this.LblName = new System.Windows.Forms.Label();
            this.TxtName = new System.Windows.Forms.TextBox();
            this.BtnClear = new System.Windows.Forms.Button();
            this.BtnName = new System.Windows.Forms.Button();
            this.LblAge = new System.Windows.Forms.Label();
            this.LblStandard = new System.Windows.Forms.Label();
            this.LblOutput = new System.Windows.Forms.Label();
            this.TxtAge = new System.Windows.Forms.TextBox();
            this.TxtStandard = new System.Windows.Forms.TextBox();
            this.LblSchoolName = new System.Windows.Forms.Label();
            this.TxtSchoolName = new System.Windows.Forms.TextBox();
            this.BtnNameAge = new System.Windows.Forms.Button();
            this.BtnNameStandard = new System.Windows.Forms.Button();
            this.BtnNameAgeStandard = new System.Windows.Forms.Button();
            this.BtnAllDetails = new System.Windows.Forms.Button();
            this.BtnNameSchool = new System.Windows.Forms.Button();
            this.BtnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LblName
            // 
            this.LblName.AutoSize = true;
            this.LblName.Location = new System.Drawing.Point(205, 15);
            this.LblName.Name = "LblName";
            this.LblName.Size = new System.Drawing.Size(70, 25);
            this.LblName.TabIndex = 0;
            this.LblName.Text = "Name";
            // 
            // TxtName
            // 
            this.TxtName.Location = new System.Drawing.Point(284, 12);
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(211, 32);
            this.TxtName.TabIndex = 0;
            // 
            // BtnClear
            // 
            this.BtnClear.Location = new System.Drawing.Point(12, 342);
            this.BtnClear.Name = "BtnClear";
            this.BtnClear.Size = new System.Drawing.Size(73, 42);
            this.BtnClear.TabIndex = 10;
            this.BtnClear.Text = "&Clear";
            this.BtnClear.UseVisualStyleBackColor = true;
            this.BtnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // BtnName
            // 
            this.BtnName.Location = new System.Drawing.Point(129, 143);
            this.BtnName.Name = "BtnName";
            this.BtnName.Size = new System.Drawing.Size(78, 34);
            this.BtnName.TabIndex = 4;
            this.BtnName.Text = "Name";
            this.BtnName.UseVisualStyleBackColor = true;
            this.BtnName.Click += new System.EventHandler(this.BtnName_Click);
            // 
            // LblAge
            // 
            this.LblAge.AutoSize = true;
            this.LblAge.Location = new System.Drawing.Point(230, 58);
            this.LblAge.Name = "LblAge";
            this.LblAge.Size = new System.Drawing.Size(50, 25);
            this.LblAge.TabIndex = 0;
            this.LblAge.Text = "Age";
            // 
            // LblStandard
            // 
            this.LblStandard.AutoSize = true;
            this.LblStandard.Location = new System.Drawing.Point(339, 58);
            this.LblStandard.Name = "LblStandard";
            this.LblStandard.Size = new System.Drawing.Size(104, 25);
            this.LblStandard.TabIndex = 0;
            this.LblStandard.Text = "Standard";
            // 
            // LblOutput
            // 
            this.LblOutput.Font = new System.Drawing.Font("Verdana", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblOutput.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.LblOutput.Location = new System.Drawing.Point(12, 267);
            this.LblOutput.Name = "LblOutput";
            this.LblOutput.Size = new System.Drawing.Size(669, 36);
            this.LblOutput.TabIndex = 0;
            this.LblOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TxtAge
            // 
            this.TxtAge.Location = new System.Drawing.Point(284, 55);
            this.TxtAge.Name = "TxtAge";
            this.TxtAge.Size = new System.Drawing.Size(48, 32);
            this.TxtAge.TabIndex = 1;
            this.TxtAge.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TxtStandard
            // 
            this.TxtStandard.Location = new System.Drawing.Point(444, 55);
            this.TxtStandard.Name = "TxtStandard";
            this.TxtStandard.Size = new System.Drawing.Size(51, 32);
            this.TxtStandard.TabIndex = 2;
            this.TxtStandard.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LblSchoolName
            // 
            this.LblSchoolName.AutoSize = true;
            this.LblSchoolName.Location = new System.Drawing.Point(142, 102);
            this.LblSchoolName.Name = "LblSchoolName";
            this.LblSchoolName.Size = new System.Drawing.Size(144, 25);
            this.LblSchoolName.TabIndex = 0;
            this.LblSchoolName.Text = "School Name";
            // 
            // TxtSchoolName
            // 
            this.TxtSchoolName.Location = new System.Drawing.Point(284, 99);
            this.TxtSchoolName.Name = "TxtSchoolName";
            this.TxtSchoolName.Size = new System.Drawing.Size(211, 32);
            this.TxtSchoolName.TabIndex = 3;
            // 
            // BtnNameAge
            // 
            this.BtnNameAge.Location = new System.Drawing.Point(213, 143);
            this.BtnNameAge.Name = "BtnNameAge";
            this.BtnNameAge.Size = new System.Drawing.Size(131, 34);
            this.BtnNameAge.TabIndex = 5;
            this.BtnNameAge.Text = "Name&&Age";
            this.BtnNameAge.UseVisualStyleBackColor = true;
            this.BtnNameAge.Click += new System.EventHandler(this.BtnNameAge_Click);
            // 
            // BtnNameStandard
            // 
            this.BtnNameStandard.Location = new System.Drawing.Point(350, 143);
            this.BtnNameStandard.Name = "BtnNameStandard";
            this.BtnNameStandard.Size = new System.Drawing.Size(185, 34);
            this.BtnNameStandard.TabIndex = 6;
            this.BtnNameStandard.Text = "Name&&Standard";
            this.BtnNameStandard.UseVisualStyleBackColor = true;
            this.BtnNameStandard.Click += new System.EventHandler(this.BtnNameStandard_Click);
            // 
            // BtnNameAgeStandard
            // 
            this.BtnNameAgeStandard.Location = new System.Drawing.Point(299, 183);
            this.BtnNameAgeStandard.Name = "BtnNameAgeStandard";
            this.BtnNameAgeStandard.Size = new System.Drawing.Size(236, 34);
            this.BtnNameAgeStandard.TabIndex = 8;
            this.BtnNameAgeStandard.Text = "Name,Age&&Standard";
            this.BtnNameAgeStandard.UseVisualStyleBackColor = true;
            this.BtnNameAgeStandard.Click += new System.EventHandler(this.BtnNameAgeStandard_Click);
            // 
            // BtnAllDetails
            // 
            this.BtnAllDetails.Location = new System.Drawing.Point(268, 223);
            this.BtnAllDetails.Name = "BtnAllDetails";
            this.BtnAllDetails.Size = new System.Drawing.Size(131, 34);
            this.BtnAllDetails.TabIndex = 9;
            this.BtnAllDetails.Text = "All Details";
            this.BtnAllDetails.UseVisualStyleBackColor = true;
            this.BtnAllDetails.Click += new System.EventHandler(this.BtnAllDetails_Click);
            // 
            // BtnNameSchool
            // 
            this.BtnNameSchool.Location = new System.Drawing.Point(129, 183);
            this.BtnNameSchool.Name = "BtnNameSchool";
            this.BtnNameSchool.Size = new System.Drawing.Size(164, 34);
            this.BtnNameSchool.TabIndex = 7;
            this.BtnNameSchool.Text = "Name&&School";
            this.BtnNameSchool.UseVisualStyleBackColor = true;
            this.BtnNameSchool.Click += new System.EventHandler(this.BtnNameSchool_Click);
            // 
            // BtnExit
            // 
            this.BtnExit.Location = new System.Drawing.Point(608, 342);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(73, 42);
            this.BtnExit.TabIndex = 11;
            this.BtnExit.Text = "E&xit";
            this.BtnExit.UseVisualStyleBackColor = true;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // FrmStudentsInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(693, 390);
            this.Controls.Add(this.BtnExit);
            this.Controls.Add(this.BtnNameAgeStandard);
            this.Controls.Add(this.BtnAllDetails);
            this.Controls.Add(this.BtnNameSchool);
            this.Controls.Add(this.BtnNameStandard);
            this.Controls.Add(this.BtnNameAge);
            this.Controls.Add(this.TxtSchoolName);
            this.Controls.Add(this.LblSchoolName);
            this.Controls.Add(this.TxtStandard);
            this.Controls.Add(this.TxtAge);
            this.Controls.Add(this.LblOutput);
            this.Controls.Add(this.LblStandard);
            this.Controls.Add(this.LblAge);
            this.Controls.Add(this.BtnName);
            this.Controls.Add(this.BtnClear);
            this.Controls.Add(this.TxtName);
            this.Controls.Add(this.LblName);
            this.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.MaximizeBox = false;
            this.Name = "FrmStudentsInformation";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Student\'s Information";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblName;
        private System.Windows.Forms.TextBox TxtName;
        private System.Windows.Forms.Button BtnClear;
        private System.Windows.Forms.Button BtnName;
        private System.Windows.Forms.Label LblAge;
        private System.Windows.Forms.Label LblStandard;
        private System.Windows.Forms.Label LblOutput;
        private System.Windows.Forms.TextBox TxtAge;
        private System.Windows.Forms.TextBox TxtStandard;
        private System.Windows.Forms.Label LblSchoolName;
        private System.Windows.Forms.TextBox TxtSchoolName;
        private System.Windows.Forms.Button BtnNameAge;
        private System.Windows.Forms.Button BtnNameStandard;
        private System.Windows.Forms.Button BtnNameAgeStandard;
        private System.Windows.Forms.Button BtnAllDetails;
        private System.Windows.Forms.Button BtnNameSchool;
        private System.Windows.Forms.Button BtnExit;
    }
}

