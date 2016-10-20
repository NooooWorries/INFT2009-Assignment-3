using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NoTreal.ClassDomain;

namespace NoTreal
{
    public partial class EnrolmentForm : Form
    {
        public EnrolmentForm()
        {
            InitializeComponent();
        }

        private void tbxStudentID_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbxRequirement_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbName_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lbAvailableCourses_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbProgram_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnSearchCourses_Click(object sender, EventArgs e)
        {
            String progCode = cmbProgram.GetItemText(cmbProgram.SelectedItem);
            String semCode = cbxSemester.GetItemText(cbxSemester.SelectedItem);
            String type = cbxType.GetItemText(cbxType.SelectedItem);
            List<Enrolment> offerlist = Enrolment.getCourses(progCode, semCode, type);
            for (int i = 0; i < offerlist.Count; i++)
            {
                Enrolment offer = offerlist[i];
                String value = offer.Code;
                lbAvailableCourses.Items.Add(value);
                lbName.Items.Add(offer.Name);
            }
        }

        private void lbAvailableCourses_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            String courseCode = lbAvailableCourses.SelectedIndex.ToString();
            Enrolment courseToEnrol = Enrolment.ShowReq(courseCode);
            //tbxRequirement.Text = courseToEnrol.Requirement.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            String courseCode = lbAvailableCourses.SelectedItem.ToString();
            lbCourseAdded.Items.Add(courseCode);

        }

        private void btnDropCourse_Click(object sender, EventArgs e)
        {
            String courseCode = lbAvailableCourses.SelectedItem.ToString();
            lbCourseAdded.Items.Remove(courseCode);
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            String StudentID = tbxStudentID.Text.ToString();
            String CourseCode = lbCourseAdded.Items.ToString();
            EnrolledStudent newEnrolment = new EnrolledStudent(StudentID, CourseCode, "Processing");
            newEnrolment.SaveData();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void EnrolmentForm_Load(object sender, EventArgs e)
        {

        }
    }
}
