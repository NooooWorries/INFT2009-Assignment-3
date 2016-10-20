namespace NoTreal
{
    partial class main
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
            this.btnShowApplication = new System.Windows.Forms.Button();
            this.btnSubmitApplication = new System.Windows.Forms.Button();
            this.btnExam = new System.Windows.Forms.Button();
            this.btnCourse = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnShowApplication
            // 
            this.btnShowApplication.Location = new System.Drawing.Point(256, 70);
            this.btnShowApplication.Name = "btnShowApplication";
            this.btnShowApplication.Size = new System.Drawing.Size(168, 54);
            this.btnShowApplication.TabIndex = 2;
            this.btnShowApplication.Text = "Show Application";
            this.btnShowApplication.UseVisualStyleBackColor = true;
            this.btnShowApplication.Click += new System.EventHandler(this.btnShowApplication_Click);
            // 
            // btnSubmitApplication
            // 
            this.btnSubmitApplication.Location = new System.Drawing.Point(25, 70);
            this.btnSubmitApplication.Name = "btnSubmitApplication";
            this.btnSubmitApplication.Size = new System.Drawing.Size(168, 54);
            this.btnSubmitApplication.TabIndex = 3;
            this.btnSubmitApplication.Text = "Application";
            this.btnSubmitApplication.UseVisualStyleBackColor = true;
            this.btnSubmitApplication.Click += new System.EventHandler(this.btnSubmitApplication_Click);
            // 
            // btnExam
            // 
            this.btnExam.Location = new System.Drawing.Point(256, 156);
            this.btnExam.Name = "btnExam";
            this.btnExam.Size = new System.Drawing.Size(168, 54);
            this.btnExam.TabIndex = 4;
            this.btnExam.Text = "Update exam result";
            this.btnExam.UseVisualStyleBackColor = true;
            this.btnExam.Click += new System.EventHandler(this.btnExam_Click);
            // 
            // btnCourse
            // 
            this.btnCourse.Location = new System.Drawing.Point(25, 156);
            this.btnCourse.Name = "btnCourse";
            this.btnCourse.Size = new System.Drawing.Size(168, 54);
            this.btnCourse.TabIndex = 5;
            this.btnCourse.Text = "Course Enrolment";
            this.btnCourse.UseVisualStyleBackColor = true;
            this.btnCourse.Click += new System.EventHandler(this.btnCourse_Click);
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 283);
            this.Controls.Add(this.btnCourse);
            this.Controls.Add(this.btnExam);
            this.Controls.Add(this.btnSubmitApplication);
            this.Controls.Add(this.btnShowApplication);
            this.Name = "main";
            this.Text = "main";
            this.Load += new System.EventHandler(this.main_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnShowApplication;
        private System.Windows.Forms.Button btnSubmitApplication;
        private System.Windows.Forms.Button btnExam;
        private System.Windows.Forms.Button btnCourse;
    }
}