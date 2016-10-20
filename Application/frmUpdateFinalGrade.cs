using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using NoTreal.ClassDomain;

namespace NoTreal
{
    public partial class frmUpdateFinalGrade : Form
    {
        public frmUpdateFinalGrade()
        {
            InitializeComponent();
        }

        private void SearchResult(object sender, EventArgs e)
        {
            String sID = txbStdNo.Text;
            Result record = Result.get(sID);
            if (record != null)
            {
                txbProgram.Text = record.Program;
                cbbCourses.Text = record.Course;
                txbStatus.Text = record.Status;
                txbFinalG.Text = record.FinalGrade;
                txbFinalM.Text = Convert.ToString(record.FinalMark);
                txbExamM.Text = Convert.ToString(record.ExamMark);
                txbCourseM.Text = Convert.ToString(record.CourseMark);
            }
        }

        // I WANT TO RETURN THIS FINAL MARK TO THE CONSTRUCTOR IN RESULT.CS, SO LATER WHEN THE BUTTON SUBMIT IS CLICKED,
        // THIS VALUE WILL BE ADDED TO SQL DATABASE
        private void CalculateFinalMark(object sender, EventArgs e)
        {
            String sID = txbStdNo.Text;
            Result record = Result.get(sID);
            Decimal finalMark = 0;
            if (record != null)
            {
                finalMark = record.ExamMark + record.CourseMark;
                txbFinalM.Text = Convert.ToString(finalMark);
            }

        }

        // I WANT TO RETURN THIS FINAL GRADE TO TO THE CONSTRUCTOR IN RESULT.CS, SO LATER WHEN THE BUTTON SUBMIT IS CLICKED,
        // THIS VALUE WILL BE ADDED TO SQL DATABASE
        private void CalculateFinalGrade(object sender, EventArgs e)
        {
            String sID = txbStdNo.Text;
            Result record = Result.get(sID);
            if (record != null)
            {
                Decimal finalMark = record.ExamMark + record.CourseMark;
                if (finalMark < 50)
                    txbFinalG.Text = "FF";
                else if (finalMark < 65)
                    txbFinalG.Text = "P";
                else if (finalMark < 75)
                    txbFinalG.Text = "C";
                else if (finalMark < 85)
                    txbFinalG.Text = "D";
                else
                    txbFinalG.Text = "HD";
            }
        }

        //SINCE I CANNOT RETURN THE 2 ABOVE VALUES, I HAVE TOO TAKE VALUES FROM TEXTBOXES AND MANUALLY! :(
        private void UpdateResult(object sender, EventArgs e)
        {
            String sID = txbStdNo.Text;
            Decimal finalMark = Convert.ToDecimal(txbFinalM.Text);
            String finalGrade = txbFinalG.Text;
            Result newResult = new Result(sID, "A", "A", "Complete", finalGrade, finalMark, 1, 1);
            newResult.Save(); // Insert into database
        }

        private void frmUpdateFinalGrade_Load(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }


    }
}
