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
    public partial class qualificationFrm : Form
    {
        string type;
        bool errorMatch = false;
        Random r = new Random();
        public static string qualificationID;
        public qualificationFrm()
        {
            InitializeComponent();
        }

        private void qualificationFrm_Load(object sender, EventArgs e)
        {
            int number = r.Next(100, 999);
            qualificationID = "Q" + number.ToString();
            lblQualificationID.Text = "Your Qualification ID : " + qualificationID;
            
        }


        private void cbxType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxType.SelectedIndex== 1)
            {
                tbxCountry.ReadOnly = false;
                tbxCountry.Text = "";
                type = "International";
            }
            if (cbxType.SelectedIndex == 0)
            {
                tbxCountry.ReadOnly = true;
                tbxCountry.Text = "Australia";
                type = "Local";
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                String name = tbxName.Text;
                String country = tbxCountry.Text;
                DateTime admittedDate = dateTimeAdmitted.Value;
                DateTime graduationDate = dateTimeGraduation.Value;
                String programTitle = tbxProgram.Text;
                Decimal gpa = Convert.ToDecimal(tbxGPA.Text);
                String description = tbxDescription.Text;
                qualificationFrmClass newQualification = new qualificationFrmClass(qualificationID, type, name, country, admittedDate, graduationDate, programTitle, gpa, description);
                newQualification.Save();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, "Program Error");
                errorMatch = true;
            }
            finally
            {
                if (errorMatch == false)
                {
                    MessageBox.Show("Submission complete", "Congratulations");
                    Close();
                }
                else
                    MessageBox.Show("Submision incomplete, please try again.", "Fail to submit");
            }            
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
