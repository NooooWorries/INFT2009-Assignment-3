using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NoTreal
{
    public partial class main : Form
    {
        private showApplications frmShowApplication;
        private applicationFrm frmApplication;
        private frmUpdateFinalGrade frmExam;
        private EnrolmentForm frmCourse;
        
        public main()
        {
            InitializeComponent();
        }

        private void btnShowApplication_Click(object sender, EventArgs e)
        {
            if (frmShowApplication == null)
                frmShowApplication = new showApplications();
           frmShowApplication.Show();
        }

        private void btnSubmitApplication_Click(object sender, EventArgs e)
        {
            if (frmApplication == null)
                frmApplication = new applicationFrm();
            frmApplication.Show();
        }

        private void main_Load(object sender, EventArgs e)
        {

        }

        private void btnExam_Click(object sender, EventArgs e)
        {
            if (frmExam == null)
                frmExam = new frmUpdateFinalGrade();
            frmExam.Show();
        }

        private void btnCourse_Click(object sender, EventArgs e)
        {
            if (frmCourse == null)
                frmCourse = new EnrolmentForm();
            frmCourse.Show();
        }
    }
}
