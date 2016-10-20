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
using System.Data.SqlClient;

namespace NoTreal
{
    public partial class showApplications : Form
    {
        string value;
        bool isEnglishTestExist = false;
        public showApplications()
        {
            InitializeComponent();
        }

        private void lstBxApplication_SelectedIndexChanged(object sender, EventArgs e)
        {

            value = lstBxApplication.SelectedItem.ToString();
            String[] sArray = value.Split(' ');
            // validate whether english exist 
            showApplicationClass record = showApplicationClass.validateTest(sArray[0]);
            if (record.public_isEnglishNull == false)
                isEnglishTestExist = true;
            if (isEnglishTestExist == true)
            {
                List<showApplicationClass> records = showApplicationClass.getAll(sArray[0], sArray[1], sArray[2]);
                showApplicationClass oneProject = records[0];
                lblApplicationID.Text = sArray[0];
                lblQualificationID.Text = sArray[1];
                lblStatus.Text = sArray[2];
                lblFee.Text = Convert.ToString(oneProject.public_applicationFee);
                tbxApplicationDescription.Text = oneProject.public_applicationDescription;
                lblType.Text = oneProject.public_type;
                lblInstituteName.Text = oneProject.public_name;
                lblCountry.Text = oneProject.public_country;
                lblAdmittedDate.Text = Convert.ToString(oneProject.public_admittedDate);
                lblGraduationDate.Text = Convert.ToString(oneProject.public_graduationDate);
                lblProgramTitle.Text = oneProject.public_programTitle;
                lblGPA.Text = Convert.ToString(oneProject.public_gpa);
                tbxQualificationDescription.Text = oneProject.public_description;
                tbxApplicationDescription.Text = oneProject.public_applicationDescription;
                lblTestID.Text = oneProject.public_testID;
                lblTestName.Text = oneProject.public_testName;
                lblTestScore.Text = oneProject.public_testScore.ToString();
                lblTestDate.Text = oneProject.public_testDate.ToString();
                lblTestLocation.Text = oneProject.public_testLocation;
            }
            else
            {
                List<showApplicationClass> records = showApplicationClass.getAllWithoutTest(sArray[0], sArray[1], sArray[2]);
                showApplicationClass oneProject = records[0];
                lblApplicationID.Text = sArray[0];
                lblQualificationID.Text = sArray[1];
                lblStatus.Text = sArray[2];
                lblFee.Text = Convert.ToString(oneProject.public_applicationFee);
                tbxApplicationDescription.Text = oneProject.public_applicationDescription;
                lblType.Text = oneProject.public_type;
                lblInstituteName.Text = oneProject.public_name;
                lblCountry.Text = oneProject.public_country;
                lblAdmittedDate.Text = Convert.ToString(oneProject.public_admittedDate);
                lblGraduationDate.Text = Convert.ToString(oneProject.public_graduationDate);
                lblProgramTitle.Text = oneProject.public_programTitle;
                lblGPA.Text = Convert.ToString(oneProject.public_gpa);
                tbxQualificationDescription.Text = oneProject.public_description;
                tbxApplicationDescription.Text = oneProject.public_applicationDescription;
            }

        }

        private void gbxInformation_Enter(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void showApplications_Load(object sender, EventArgs e)
        {
            List<showApplicationClass> records = showApplicationClass.getRecordID();
            for (int i = 0; i < records.Count; i++)
            {
                showApplicationClass oneProject = records[i];
                value = oneProject.public_applicationID + " " +
                               oneProject.public_qualificationID + " " +
                               oneProject.public_status;
                // Add to ListBox to display
                lstBxApplication.Items.Add(value);
            }
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            String[] sArray = value.Split(' ');
            showApplicationClass newResult = new showApplicationClass(sArray[0], sArray[1], lblStatus.Text, Convert.ToDecimal(lblFee.Text), tbxApplicationDescription.Text);
            newResult.accept();
            //Refresh
            lstBxApplication.Items.Clear();
            List<showApplicationClass> records = showApplicationClass.getRecordID();
            for (int i = 0; i < records.Count; i++)
            {
                showApplicationClass oneProject = records[i];
                value = oneProject.public_applicationID + " " +
                               oneProject.public_qualificationID + " " +
                               oneProject.public_status;
                // Add to ListBox to display
                lstBxApplication.Items.Add(value);
            }
        }

        private void btnReject_Click(object sender, EventArgs e)
        {
            String[] sArray = value.Split(' ');
            showApplicationClass newResult = new showApplicationClass(sArray[0], sArray[1], lblStatus.Text, Convert.ToDecimal(lblFee.Text), tbxApplicationDescription.Text);
            newResult.reject();
            //Refresh
            lstBxApplication.Items.Clear();
            List<showApplicationClass> records = showApplicationClass.getRecordID();
            for (int i = 0; i < records.Count; i++)
            {
                showApplicationClass oneProject = records[i];
                value = oneProject.public_applicationID + " " +
                               oneProject.public_qualificationID + " " +
                               oneProject.public_status;
                // Add to ListBox to display
                lstBxApplication.Items.Add(value);
            }
        }

        private void btnForward_Click(object sender, EventArgs e)
        {
            //String[] sArray = value.Split(' ');
            //showApplicationClass newResult = new showApplicationClass(sArray[0], sArray[1], lblStatus.Text, Convert.ToDecimal(lblFee.Text), tbxApplicationDescription.Text);
            ////newResult.forward();
            ////Refresh
            //lstBxApplication.Items.Clear();
            //List<showApplicationClass> records = showApplicationClass.getRecordID();
            //for (int i = 0; i < records.Count; i++)
            //{
            //    showApplicationClass oneProject = records[i];
            //    value = oneProject.public_applicationID + " " +
            //                   oneProject.public_qualificationID + " " +
            //                   oneProject.public_status;
            //    // Add to ListBox to display
            //    lstBxApplication.Items.Add(value);
            //}
        }

    }
}
