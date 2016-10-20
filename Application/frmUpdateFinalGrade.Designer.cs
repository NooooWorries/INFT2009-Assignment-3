namespace NoTreal
{
    partial class frmUpdateFinalGrade
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
            this.btnCalculateG = new System.Windows.Forms.Button();
            this.txbStatus = new System.Windows.Forms.TextBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnCalculateM = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.txbFinalG = new System.Windows.Forms.TextBox();
            this.lblFinalG = new System.Windows.Forms.Label();
            this.cbbCourses = new System.Windows.Forms.ComboBox();
            this.txbFinalM = new System.Windows.Forms.TextBox();
            this.txbExamM = new System.Windows.Forms.TextBox();
            this.txbCourseM = new System.Windows.Forms.TextBox();
            this.txbProgram = new System.Windows.Forms.TextBox();
            this.lblFinalM = new System.Windows.Forms.Label();
            this.lblExamM = new System.Windows.Forms.Label();
            this.lblCourseM = new System.Windows.Forms.Label();
            this.lblStdCourses = new System.Windows.Forms.Label();
            this.lblStdProgram = new System.Windows.Forms.Label();
            this.lblPageTitle = new System.Windows.Forms.Label();
            this.txbStdName = new System.Windows.Forms.TextBox();
            this.lblStdName = new System.Windows.Forms.Label();
            this.lblStdNo = new System.Windows.Forms.Label();
            this.txbStdNo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnCalculateG
            // 
            this.btnCalculateG.Location = new System.Drawing.Point(316, 467);
            this.btnCalculateG.Margin = new System.Windows.Forms.Padding(2);
            this.btnCalculateG.Name = "btnCalculateG";
            this.btnCalculateG.Size = new System.Drawing.Size(99, 28);
            this.btnCalculateG.TabIndex = 67;
            this.btnCalculateG.Text = "Calculate";
            this.btnCalculateG.UseVisualStyleBackColor = true;
            this.btnCalculateG.Click += new System.EventHandler(this.CalculateFinalGrade);
            // 
            // txbStatus
            // 
            this.txbStatus.Location = new System.Drawing.Point(205, 294);
            this.txbStatus.Margin = new System.Windows.Forms.Padding(2);
            this.txbStatus.Name = "txbStatus";
            this.txbStatus.Size = new System.Drawing.Size(210, 28);
            this.txbStatus.TabIndex = 66;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(11, 294);
            this.lblStatus.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(134, 18);
            this.lblStatus.TabIndex = 65;
            this.lblStatus.Text = "Result Status:";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(316, 131);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(99, 28);
            this.btnSearch.TabIndex = 64;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.SearchResult);
            // 
            // btnCalculateM
            // 
            this.btnCalculateM.Location = new System.Drawing.Point(316, 420);
            this.btnCalculateM.Margin = new System.Windows.Forms.Padding(2);
            this.btnCalculateM.Name = "btnCalculateM";
            this.btnCalculateM.Size = new System.Drawing.Size(99, 28);
            this.btnCalculateM.TabIndex = 63;
            this.btnCalculateM.Text = "Calculate";
            this.btnCalculateM.UseVisualStyleBackColor = true;
            this.btnCalculateM.Click += new System.EventHandler(this.CalculateFinalMark);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(272, 554);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(119, 49);
            this.btnCancel.TabIndex = 62;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(58, 554);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(119, 49);
            this.btnUpdate.TabIndex = 61;
            this.btnUpdate.Text = "Update Result";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.UpdateResult);
            // 
            // txbFinalG
            // 
            this.txbFinalG.Location = new System.Drawing.Point(203, 464);
            this.txbFinalG.Margin = new System.Windows.Forms.Padding(2);
            this.txbFinalG.Name = "txbFinalG";
            this.txbFinalG.Size = new System.Drawing.Size(100, 28);
            this.txbFinalG.TabIndex = 60;
            // 
            // lblFinalG
            // 
            this.lblFinalG.AutoSize = true;
            this.lblFinalG.Location = new System.Drawing.Point(11, 467);
            this.lblFinalG.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFinalG.Name = "lblFinalG";
            this.lblFinalG.Size = new System.Drawing.Size(116, 18);
            this.lblFinalG.TabIndex = 59;
            this.lblFinalG.Text = "Final Grade:";
            // 
            // cbbCourses
            // 
            this.cbbCourses.FormattingEnabled = true;
            this.cbbCourses.Location = new System.Drawing.Point(205, 251);
            this.cbbCourses.Margin = new System.Windows.Forms.Padding(2);
            this.cbbCourses.Name = "cbbCourses";
            this.cbbCourses.Size = new System.Drawing.Size(210, 26);
            this.cbbCourses.TabIndex = 58;
            // 
            // txbFinalM
            // 
            this.txbFinalM.Location = new System.Drawing.Point(205, 420);
            this.txbFinalM.Margin = new System.Windows.Forms.Padding(2);
            this.txbFinalM.Name = "txbFinalM";
            this.txbFinalM.Size = new System.Drawing.Size(98, 28);
            this.txbFinalM.TabIndex = 57;
            // 
            // txbExamM
            // 
            this.txbExamM.Location = new System.Drawing.Point(205, 377);
            this.txbExamM.Margin = new System.Windows.Forms.Padding(2);
            this.txbExamM.Name = "txbExamM";
            this.txbExamM.Size = new System.Drawing.Size(210, 28);
            this.txbExamM.TabIndex = 56;
            // 
            // txbCourseM
            // 
            this.txbCourseM.Location = new System.Drawing.Point(205, 336);
            this.txbCourseM.Margin = new System.Windows.Forms.Padding(2);
            this.txbCourseM.Name = "txbCourseM";
            this.txbCourseM.Size = new System.Drawing.Size(210, 28);
            this.txbCourseM.TabIndex = 55;
            // 
            // txbProgram
            // 
            this.txbProgram.Location = new System.Drawing.Point(205, 212);
            this.txbProgram.Margin = new System.Windows.Forms.Padding(2);
            this.txbProgram.Name = "txbProgram";
            this.txbProgram.Size = new System.Drawing.Size(210, 28);
            this.txbProgram.TabIndex = 54;
            // 
            // lblFinalM
            // 
            this.lblFinalM.AutoSize = true;
            this.lblFinalM.Location = new System.Drawing.Point(11, 420);
            this.lblFinalM.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFinalM.Name = "lblFinalM";
            this.lblFinalM.Size = new System.Drawing.Size(107, 18);
            this.lblFinalM.TabIndex = 53;
            this.lblFinalM.Text = "Final Mark:";
            // 
            // lblExamM
            // 
            this.lblExamM.AutoSize = true;
            this.lblExamM.Location = new System.Drawing.Point(11, 377);
            this.lblExamM.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblExamM.Name = "lblExamM";
            this.lblExamM.Size = new System.Drawing.Size(98, 18);
            this.lblExamM.TabIndex = 52;
            this.lblExamM.Text = "Exam Mark:";
            // 
            // lblCourseM
            // 
            this.lblCourseM.AutoSize = true;
            this.lblCourseM.Location = new System.Drawing.Point(11, 336);
            this.lblCourseM.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCourseM.Name = "lblCourseM";
            this.lblCourseM.Size = new System.Drawing.Size(116, 18);
            this.lblCourseM.TabIndex = 51;
            this.lblCourseM.Text = "Course Mark:";
            // 
            // lblStdCourses
            // 
            this.lblStdCourses.AutoSize = true;
            this.lblStdCourses.Location = new System.Drawing.Point(11, 251);
            this.lblStdCourses.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStdCourses.Name = "lblStdCourses";
            this.lblStdCourses.Size = new System.Drawing.Size(152, 18);
            this.lblStdCourses.TabIndex = 50;
            this.lblStdCourses.Text = "Current Courses:";
            // 
            // lblStdProgram
            // 
            this.lblStdProgram.AutoSize = true;
            this.lblStdProgram.Location = new System.Drawing.Point(11, 212);
            this.lblStdProgram.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStdProgram.Name = "lblStdProgram";
            this.lblStdProgram.Size = new System.Drawing.Size(80, 18);
            this.lblStdProgram.TabIndex = 49;
            this.lblStdProgram.Text = "Program:";
            this.lblStdProgram.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblPageTitle
            // 
            this.lblPageTitle.AutoSize = true;
            this.lblPageTitle.Location = new System.Drawing.Point(90, 36);
            this.lblPageTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPageTitle.Name = "lblPageTitle";
            this.lblPageTitle.Size = new System.Drawing.Size(260, 18);
            this.lblPageTitle.TabIndex = 48;
            this.lblPageTitle.Text = "UPDATE STUDENT\'S FINAL GRADE";
            // 
            // txbStdName
            // 
            this.txbStdName.Location = new System.Drawing.Point(205, 174);
            this.txbStdName.Margin = new System.Windows.Forms.Padding(2);
            this.txbStdName.Name = "txbStdName";
            this.txbStdName.Size = new System.Drawing.Size(210, 28);
            this.txbStdName.TabIndex = 47;
            // 
            // lblStdName
            // 
            this.lblStdName.AutoSize = true;
            this.lblStdName.Location = new System.Drawing.Point(11, 174);
            this.lblStdName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStdName.Name = "lblStdName";
            this.lblStdName.Size = new System.Drawing.Size(125, 18);
            this.lblStdName.TabIndex = 46;
            this.lblStdName.Text = "Student Name:";
            // 
            // lblStdNo
            // 
            this.lblStdNo.AutoSize = true;
            this.lblStdNo.Location = new System.Drawing.Point(11, 90);
            this.lblStdNo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStdNo.Name = "lblStdNo";
            this.lblStdNo.Size = new System.Drawing.Size(260, 18);
            this.lblStdNo.TabIndex = 45;
            this.lblStdNo.Text = "Please enter student number:";
            // 
            // txbStdNo
            // 
            this.txbStdNo.Location = new System.Drawing.Point(315, 87);
            this.txbStdNo.Margin = new System.Windows.Forms.Padding(2);
            this.txbStdNo.Name = "txbStdNo";
            this.txbStdNo.Size = new System.Drawing.Size(100, 28);
            this.txbStdNo.TabIndex = 44;
            // 
            // frmUpdateFinalGrade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 629);
            this.Controls.Add(this.btnCalculateG);
            this.Controls.Add(this.txbStatus);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnCalculateM);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.txbFinalG);
            this.Controls.Add(this.lblFinalG);
            this.Controls.Add(this.cbbCourses);
            this.Controls.Add(this.txbFinalM);
            this.Controls.Add(this.txbExamM);
            this.Controls.Add(this.txbCourseM);
            this.Controls.Add(this.txbProgram);
            this.Controls.Add(this.lblFinalM);
            this.Controls.Add(this.lblExamM);
            this.Controls.Add(this.lblCourseM);
            this.Controls.Add(this.lblStdCourses);
            this.Controls.Add(this.lblStdProgram);
            this.Controls.Add(this.lblPageTitle);
            this.Controls.Add(this.txbStdName);
            this.Controls.Add(this.lblStdName);
            this.Controls.Add(this.lblStdNo);
            this.Controls.Add(this.txbStdNo);
            this.Name = "frmUpdateFinalGrade";
            this.Text = "Update final grade";
            this.Load += new System.EventHandler(this.frmUpdateFinalGrade_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCalculateG;
        private System.Windows.Forms.TextBox txbStatus;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnCalculateM;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox txbFinalG;
        private System.Windows.Forms.Label lblFinalG;
        private System.Windows.Forms.ComboBox cbbCourses;
        private System.Windows.Forms.TextBox txbFinalM;
        private System.Windows.Forms.TextBox txbExamM;
        private System.Windows.Forms.TextBox txbCourseM;
        private System.Windows.Forms.TextBox txbProgram;
        private System.Windows.Forms.Label lblFinalM;
        private System.Windows.Forms.Label lblExamM;
        private System.Windows.Forms.Label lblCourseM;
        private System.Windows.Forms.Label lblStdCourses;
        private System.Windows.Forms.Label lblStdProgram;
        private System.Windows.Forms.Label lblPageTitle;
        private System.Windows.Forms.TextBox txbStdName;
        private System.Windows.Forms.Label lblStdName;
        private System.Windows.Forms.Label lblStdNo;
        private System.Windows.Forms.TextBox txbStdNo;
    }
}