
namespace GUIPlayground
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
            this.btnShow = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.TxtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblOutput = new System.Windows.Forms.Label();
            this.lblEntered = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtNumber = new System.Windows.Forms.TextBox();
            this.BtnCreateFile = new System.Windows.Forms.Button();
            this.BtnRead = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtWriteTo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtReadFrom = new System.Windows.Forms.TextBox();
            this.BtnSelectRead = new System.Windows.Forms.Button();
            this.BtnWriteAppend = new System.Windows.Forms.Button();
            this.BtnSelectWrite = new System.Windows.Forms.Button();
            this.TxtWriteText = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.BtnReadText = new System.Windows.Forms.Button();
            this.LstOutput = new System.Windows.Forms.ListBox();
            this.openFile = new System.Windows.Forms.OpenFileDialog();
            this.saveFile = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // btnShow
            // 
            this.btnShow.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnShow.Location = new System.Drawing.Point(155, 103);
            this.btnShow.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(91, 29);
            this.btnShow.TabIndex = 2;
            this.btnShow.Text = "&Show Message";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnExit.Location = new System.Drawing.Point(348, 202);
            this.btnExit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(63, 29);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // TxtName
            // 
            this.TxtName.Location = new System.Drawing.Point(129, 42);
            this.TxtName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(151, 23);
            this.TxtName.TabIndex = 1;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(18, 44);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(96, 15);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Enter Your Name";
            // 
            // lblOutput
            // 
            this.lblOutput.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblOutput.Location = new System.Drawing.Point(129, 70);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(150, 23);
            this.lblOutput.TabIndex = 0;
            this.lblOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblEntered
            // 
            this.lblEntered.AutoSize = true;
            this.lblEntered.Location = new System.Drawing.Point(46, 77);
            this.lblEntered.Name = "lblEntered";
            this.lblEntered.Size = new System.Drawing.Size(70, 15);
            this.lblEntered.TabIndex = 0;
            this.lblEntered.Text = "You Entered";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Enter Number";
            // 
            // TxtNumber
            // 
            this.TxtNumber.Location = new System.Drawing.Point(129, 9);
            this.TxtNumber.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtNumber.Name = "TxtNumber";
            this.TxtNumber.Size = new System.Drawing.Size(151, 23);
            this.TxtNumber.TabIndex = 0;
            // 
            // BtnCreateFile
            // 
            this.BtnCreateFile.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnCreateFile.Location = new System.Drawing.Point(32, 164);
            this.BtnCreateFile.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnCreateFile.Name = "BtnCreateFile";
            this.BtnCreateFile.Size = new System.Drawing.Size(91, 29);
            this.BtnCreateFile.TabIndex = 0;
            this.BtnCreateFile.TabStop = false;
            this.BtnCreateFile.Text = "Write";
            this.BtnCreateFile.UseVisualStyleBackColor = true;
            this.BtnCreateFile.Click += new System.EventHandler(this.BtnCreateFile_Click);
            // 
            // BtnRead
            // 
            this.BtnRead.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnRead.Location = new System.Drawing.Point(155, 164);
            this.BtnRead.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnRead.Name = "BtnRead";
            this.BtnRead.Size = new System.Drawing.Size(91, 29);
            this.BtnRead.TabIndex = 4;
            this.BtnRead.TabStop = false;
            this.BtnRead.Text = "Read";
            this.BtnRead.UseVisualStyleBackColor = true;
            this.BtnRead.Click += new System.EventHandler(this.BtnRead_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(348, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "Write To";
            // 
            // TxtWriteTo
            // 
            this.TxtWriteTo.Location = new System.Drawing.Point(410, 9);
            this.TxtWriteTo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtWriteTo.Name = "TxtWriteTo";
            this.TxtWriteTo.Size = new System.Drawing.Size(151, 23);
            this.TxtWriteTo.TabIndex = 5;
            this.TxtWriteTo.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(334, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Read From";
            // 
            // TxtReadFrom
            // 
            this.TxtReadFrom.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.TxtReadFrom.Location = new System.Drawing.Point(410, 42);
            this.TxtReadFrom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtReadFrom.Name = "TxtReadFrom";
            this.TxtReadFrom.ReadOnly = true;
            this.TxtReadFrom.Size = new System.Drawing.Size(151, 23);
            this.TxtReadFrom.TabIndex = 7;
            this.TxtReadFrom.TabStop = false;
            // 
            // BtnSelectRead
            // 
            this.BtnSelectRead.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnSelectRead.Location = new System.Drawing.Point(576, 40);
            this.BtnSelectRead.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnSelectRead.Name = "BtnSelectRead";
            this.BtnSelectRead.Size = new System.Drawing.Size(102, 28);
            this.BtnSelectRead.TabIndex = 11;
            this.BtnSelectRead.TabStop = false;
            this.BtnSelectRead.Text = "Select File";
            this.BtnSelectRead.UseVisualStyleBackColor = true;
            // 
            // BtnWriteAppend
            // 
            this.BtnWriteAppend.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnWriteAppend.Location = new System.Drawing.Point(357, 103);
            this.BtnWriteAppend.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnWriteAppend.Name = "BtnWriteAppend";
            this.BtnWriteAppend.Size = new System.Drawing.Size(144, 29);
            this.BtnWriteAppend.TabIndex = 9;
            this.BtnWriteAppend.TabStop = false;
            this.BtnWriteAppend.Text = "Write / Append";
            this.BtnWriteAppend.UseVisualStyleBackColor = true;
            // 
            // BtnSelectWrite
            // 
            this.BtnSelectWrite.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnSelectWrite.Location = new System.Drawing.Point(576, 5);
            this.BtnSelectWrite.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnSelectWrite.Name = "BtnSelectWrite";
            this.BtnSelectWrite.Size = new System.Drawing.Size(102, 29);
            this.BtnSelectWrite.TabIndex = 10;
            this.BtnSelectWrite.Text = "Select File";
            this.BtnSelectWrite.UseVisualStyleBackColor = true;
            this.BtnSelectWrite.Click += new System.EventHandler(this.BtnWriteFile_Click);
            // 
            // TxtWriteText
            // 
            this.TxtWriteText.Location = new System.Drawing.Point(410, 74);
            this.TxtWriteText.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtWriteText.Name = "TxtWriteText";
            this.TxtWriteText.Size = new System.Drawing.Size(151, 23);
            this.TxtWriteText.TabIndex = 12;
            this.TxtWriteText.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(321, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 15);
            this.label4.TabIndex = 13;
            this.label4.Text = "Text To Write";
            // 
            // BtnReadText
            // 
            this.BtnReadText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnReadText.Location = new System.Drawing.Point(525, 103);
            this.BtnReadText.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnReadText.Name = "BtnReadText";
            this.BtnReadText.Size = new System.Drawing.Size(123, 29);
            this.BtnReadText.TabIndex = 14;
            this.BtnReadText.TabStop = false;
            this.BtnReadText.Text = "Read Text";
            this.BtnReadText.UseVisualStyleBackColor = true;
            // 
            // LstOutput
            // 
            this.LstOutput.FormattingEnabled = true;
            this.LstOutput.ItemHeight = 15;
            this.LstOutput.Location = new System.Drawing.Point(722, 14);
            this.LstOutput.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LstOutput.Name = "LstOutput";
            this.LstOutput.Size = new System.Drawing.Size(242, 214);
            this.LstOutput.TabIndex = 15;
            this.LstOutput.TabStop = false;
            // 
            // openFile
            // 
            this.openFile.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AcceptButton = this.btnShow;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(1012, 243);
            this.Controls.Add(this.LstOutput);
            this.Controls.Add(this.BtnReadText);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxtWriteText);
            this.Controls.Add(this.BtnSelectRead);
            this.Controls.Add(this.BtnWriteAppend);
            this.Controls.Add(this.BtnSelectWrite);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtWriteTo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtReadFrom);
            this.Controls.Add(this.BtnRead);
            this.Controls.Add(this.BtnCreateFile);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtNumber);
            this.Controls.Add(this.lblEntered);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.TxtName);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnShow);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "My First Program";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox TxtName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblOutput;
        private System.Windows.Forms.Label lblEntered;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtNumber;
        private System.Windows.Forms.Button BtnCreateFile;
        private System.Windows.Forms.Button BtnRead;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtWriteTo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtReadFrom;
        private System.Windows.Forms.Button BtnSelectRead;
        private System.Windows.Forms.Button BtnWriteAppend;
        private System.Windows.Forms.Button BtnSelectWrite;
        private System.Windows.Forms.TextBox TxtWriteText;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BtnReadText;
        private System.Windows.Forms.ListBox LstOutput;
        private System.Windows.Forms.OpenFileDialog openFile;
        private System.Windows.Forms.SaveFileDialog saveFile;
    }
}

