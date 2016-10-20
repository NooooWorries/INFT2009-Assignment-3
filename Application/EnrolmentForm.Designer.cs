namespace NoTreal
{
    partial class EnrolmentForm
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
            this.tbxStudentID = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lbCourseAdded = new System.Windows.Forms.ListBox();
            this.tbxRequirement = new System.Windows.Forms.TextBox();
            this.lbName = new System.Windows.Forms.ListBox();
            this.lbAvailableCourses = new System.Windows.Forms.ListBox();
            this.cbxSemester = new System.Windows.Forms.ComboBox();
            this.cbxType = new System.Windows.Forms.ComboBox();
            this.cmbProgram = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnDropCourse = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lblAvailableCourses = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSearchCourses = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblProgram = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbxStudentID
            // 
            this.tbxStudentID.Location = new System.Drawing.Point(342, 54);
            this.tbxStudentID.Margin = new System.Windows.Forms.Padding(4);
            this.tbxStudentID.Name = "tbxStudentID";
            this.tbxStudentID.Size = new System.Drawing.Size(180, 28);
            this.tbxStudentID.TabIndex = 51;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(165, 54);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(152, 18);
            this.label6.TabIndex = 50;
            this.label6.Text = "Enter Student ID";
            // 
            // lbCourseAdded
            // 
            this.lbCourseAdded.BackColor = System.Drawing.SystemColors.Control;
            this.lbCourseAdded.ColumnWidth = 100;
            this.lbCourseAdded.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCourseAdded.FormattingEnabled = true;
            this.lbCourseAdded.ItemHeight = 20;
            this.lbCourseAdded.Location = new System.Drawing.Point(322, 604);
            this.lbCourseAdded.Margin = new System.Windows.Forms.Padding(4);
            this.lbCourseAdded.Name = "lbCourseAdded";
            this.lbCourseAdded.Size = new System.Drawing.Size(308, 184);
            this.lbCourseAdded.TabIndex = 49;
            // 
            // tbxRequirement
            // 
            this.tbxRequirement.Location = new System.Drawing.Point(44, 604);
            this.tbxRequirement.Margin = new System.Windows.Forms.Padding(4);
            this.tbxRequirement.Multiline = true;
            this.tbxRequirement.Name = "tbxRequirement";
            this.tbxRequirement.Size = new System.Drawing.Size(268, 202);
            this.tbxRequirement.TabIndex = 48;
            // 
            // lbName
            // 
            this.lbName.BackColor = System.Drawing.SystemColors.Control;
            this.lbName.ColumnWidth = 100;
            this.lbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.FormattingEnabled = true;
            this.lbName.ItemHeight = 20;
            this.lbName.Location = new System.Drawing.Point(240, 337);
            this.lbName.Margin = new System.Windows.Forms.Padding(4);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(391, 184);
            this.lbName.TabIndex = 47;
            // 
            // lbAvailableCourses
            // 
            this.lbAvailableCourses.BackColor = System.Drawing.SystemColors.Control;
            this.lbAvailableCourses.ColumnWidth = 100;
            this.lbAvailableCourses.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAvailableCourses.FormattingEnabled = true;
            this.lbAvailableCourses.ItemHeight = 20;
            this.lbAvailableCourses.Location = new System.Drawing.Point(45, 337);
            this.lbAvailableCourses.Margin = new System.Windows.Forms.Padding(4);
            this.lbAvailableCourses.Name = "lbAvailableCourses";
            this.lbAvailableCourses.Size = new System.Drawing.Size(180, 184);
            this.lbAvailableCourses.TabIndex = 46;
            this.lbAvailableCourses.SelectedIndexChanged += new System.EventHandler(this.lbAvailableCourses_SelectedIndexChanged_1);
            // 
            // cbxSemester
            // 
            this.cbxSemester.BackColor = System.Drawing.SystemColors.Control;
            this.cbxSemester.FormattingEnabled = true;
            this.cbxSemester.Location = new System.Drawing.Point(342, 178);
            this.cbxSemester.Margin = new System.Windows.Forms.Padding(4);
            this.cbxSemester.Name = "cbxSemester";
            this.cbxSemester.Size = new System.Drawing.Size(180, 26);
            this.cbxSemester.TabIndex = 45;
            // 
            // cbxType
            // 
            this.cbxType.BackColor = System.Drawing.SystemColors.Control;
            this.cbxType.FormattingEnabled = true;
            this.cbxType.Location = new System.Drawing.Point(342, 139);
            this.cbxType.Margin = new System.Windows.Forms.Padding(4);
            this.cbxType.Name = "cbxType";
            this.cbxType.Size = new System.Drawing.Size(180, 26);
            this.cbxType.TabIndex = 44;
            // 
            // cmbProgram
            // 
            this.cmbProgram.BackColor = System.Drawing.SystemColors.Control;
            this.cmbProgram.FormattingEnabled = true;
            this.cmbProgram.Location = new System.Drawing.Point(342, 97);
            this.cmbProgram.Margin = new System.Windows.Forms.Padding(4);
            this.cmbProgram.Name = "cmbProgram";
            this.cmbProgram.Size = new System.Drawing.Size(180, 26);
            this.cmbProgram.TabIndex = 43;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(30, 32);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(322, 20);
            this.label5.TabIndex = 42;
            this.label5.Text = "NoTreal University Course Enrolment";
            // 
            // btnDropCourse
            // 
            this.btnDropCourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDropCourse.Location = new System.Drawing.Point(210, 834);
            this.btnDropCourse.Margin = new System.Windows.Forms.Padding(4);
            this.btnDropCourse.Name = "btnDropCourse";
            this.btnDropCourse.Size = new System.Drawing.Size(122, 46);
            this.btnDropCourse.TabIndex = 41;
            this.btnDropCourse.Text = "Drop ";
            this.btnDropCourse.UseVisualStyleBackColor = true;
            this.btnDropCourse.Click += new System.EventHandler(this.btnDropCourse_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(318, 561);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 20);
            this.label4.TabIndex = 40;
            this.label4.Text = "Course Added";
            // 
            // lblAvailableCourses
            // 
            this.lblAvailableCourses.AutoSize = true;
            this.lblAvailableCourses.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAvailableCourses.Location = new System.Drawing.Point(40, 261);
            this.lblAvailableCourses.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAvailableCourses.Name = "lblAvailableCourses";
            this.lblAvailableCourses.Size = new System.Drawing.Size(0, 20);
            this.lblAvailableCourses.TabIndex = 39;
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Location = new System.Drawing.Point(358, 834);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(4);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(124, 47);
            this.btnSubmit.TabIndex = 38;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(45, 834);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(128, 47);
            this.button2.TabIndex = 37;
            this.button2.Text = "Add ";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(516, 834);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 46);
            this.button1.TabIndex = 36;
            this.button1.Text = "Cancel";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(40, 561);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(181, 20);
            this.label3.TabIndex = 35;
            this.label3.Text = "Course Requirement";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(40, 298);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 20);
            this.label2.TabIndex = 34;
            this.label2.Text = "Available Courses";
            // 
            // btnSearchCourses
            // 
            this.btnSearchCourses.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchCourses.Location = new System.Drawing.Point(342, 234);
            this.btnSearchCourses.Margin = new System.Windows.Forms.Padding(4);
            this.btnSearchCourses.Name = "btnSearchCourses";
            this.btnSearchCourses.Size = new System.Drawing.Size(168, 44);
            this.btnSearchCourses.TabIndex = 33;
            this.btnSearchCourses.Text = "Search";
            this.btnSearchCourses.UseVisualStyleBackColor = true;
            this.btnSearchCourses.Click += new System.EventHandler(this.btnSearchCourses_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(188, 189);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 18);
            this.label1.TabIndex = 32;
            this.label1.Text = "Select Semester";
            // 
            // lblProgram
            // 
            this.lblProgram.AutoSize = true;
            this.lblProgram.Location = new System.Drawing.Point(165, 97);
            this.lblProgram.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProgram.Name = "lblProgram";
            this.lblProgram.Size = new System.Drawing.Size(170, 18);
            this.lblProgram.TabIndex = 31;
            this.lblProgram.Text = "Enter Your Program";
            // 
            // EnrolmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 903);
            this.Controls.Add(this.tbxStudentID);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lbCourseAdded);
            this.Controls.Add(this.tbxRequirement);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.lbAvailableCourses);
            this.Controls.Add(this.cbxSemester);
            this.Controls.Add(this.cbxType);
            this.Controls.Add(this.cmbProgram);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnDropCourse);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblAvailableCourses);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSearchCourses);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblProgram);
            this.Name = "EnrolmentForm";
            this.Text = "EnrolmentForm";
            this.Load += new System.EventHandler(this.EnrolmentForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxStudentID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox lbCourseAdded;
        private System.Windows.Forms.TextBox tbxRequirement;
        private System.Windows.Forms.ListBox lbName;
        private System.Windows.Forms.ListBox lbAvailableCourses;
        private System.Windows.Forms.ComboBox cbxSemester;
        private System.Windows.Forms.ComboBox cbxType;
        private System.Windows.Forms.ComboBox cmbProgram;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnDropCourse;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblAvailableCourses;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSearchCourses;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblProgram;
    }
}