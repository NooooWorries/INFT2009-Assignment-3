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
    public partial class applicationFrm : Form
    {
        Random r = new Random();
        public static string applicationID;
        List <string> programNameArray = new List<string> ();
        List<int> priorityArray = new List<int>();
        private qualificationFrm frmQualification;
        private englishtestFrm frmEnglish;
        bool addMatch = false;
        bool qualificationMatch = false;
        bool errorMatch = false;
        public applicationFrm()
        {
            InitializeComponent();
        }


        private void applicationFrm_Load(object sender, EventArgs e)
        {
            int number = r.Next(100000, 999999);
            applicationID = "UG" + number.ToString();
            lblApplicationID.Text = "Your Application ID : " + applicationID;
            // Get program list
            List<applicationFrmClass> record = applicationFrmClass.getList();
            for (int i = 0; i < record.Count; i++)
            {
                applicationFrmClass oneProject = record[i];
                String value = oneProject.public_name;
                // Add to combo box
                cbxChoice1.Items.Add(value);
                cbxChoice2.Items.Add(value);
                cbxChoice3.Items.Add(value);
                cbxChoice4.Items.Add(value);
                cbxChoice5.Items.Add(value);
            }
        }

        private void radioFirstLanguageYes_CheckedChanged(object sender, EventArgs e)
        {
            if (radioFirstLanguageYes.Checked)
            {
                lblTestHistory.Visible = false;
                panelTest.Visible = false;
                lblProvide.Visible = false;
                btnProvide.Visible = false;
            }
        }

        private void lblProvide_Click(object sender, EventArgs e)
        {

        }

        private void radioFirstLanguageNo_CheckedChanged(object sender, EventArgs e)
        {
            if (radioFirstLanguageNo.Checked)
            {
                lblTestHistory.Visible = true;
                panelTest.Visible = true;
            }
        }

        private void radioTestYes_CheckedChanged(object sender, EventArgs e)
        {
            if (radioTestYes.Checked)
                {
                    lblProvide.Visible = true;
                    btnProvide.Visible = true; 
                }
        }

        private void radioTestNo_CheckedChanged(object sender, EventArgs e)
        {
            if (radioTestNo.Checked)
            {
                lblProvide.Visible = false;
                btnProvide.Visible = false;
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (addMatch == false && qualificationMatch == true)
            {
                submit();
                Close();
            }
            if (qualificationMatch == false)
                MessageBox.Show("Plse submit academic qualification", "Error");
            else
            {
                MessageBox.Show("Submission complete", "Congratulations!");
                Close();
            }
        }
        private void submit()
        {
            try
            {
                // Save application information
                applicationFrmClass projApplication = new applicationFrmClass(applicationID, qualificationFrm.qualificationID, "processing", 90, tbxSelfDescription.Text);
                projApplication.Save();
                // Save program choice
                int validProgram = programCount();
                for (int i = 0; i < validProgram; i++)
                {
                    String progName = programNameArray[i];
                    Int32 priority = priorityArray[i];
                    List<applicationFrmClass> records = applicationFrmClass.getList();
                    string programCode = null;
                    for (int j = 0; j < records.Count; j++)
                    {
                        applicationFrmClass oneProject = records[j];
                        if (oneProject.public_name == progName)
                            programCode = oneProject.public_programCode;
                    }
                    applicationFrmClass newProject = new applicationFrmClass(applicationID, programCode, priority);
                    newProject.SaveSelection();
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, "Program Error");
                errorMatch = true;
            }
            finally
            {
                if (errorMatch == false && addMatch == false)
                {
                    MessageBox.Show("Submission complete", "Congratulations");
                }
            }
        }
        private int programCount()
        {
            int count = 0;
            if (cbxChoice1.SelectedIndex != 0 && upDown1.Value != 0)
            {
                count++;
                programNameArray.Add(cbxChoice1.Text);
                priorityArray.Add(Convert.ToInt32(upDown1.Value));
                
            }
            if (cbxChoice2.SelectedIndex != 0 && upDown2.Value != 0)
            {
                count++;
                programNameArray.Add(cbxChoice2.Text);
                priorityArray.Add(Convert.ToInt32(upDown2.Value));
            }
            if (cbxChoice3.SelectedIndex != 0 && upDown3.Value != 0)
            {
                count++;
                programNameArray.Add(cbxChoice3.Text);
                priorityArray.Add(Convert.ToInt32(upDown3.Value));
            }
            if (cbxChoice4.SelectedIndex != 0 && upDown4.Value != 0)
            {
                count++;
                programNameArray.Add(cbxChoice4.Text);
                priorityArray.Add(Convert.ToInt32(upDown4.Value));
            }
                
            if (cbxChoice5.SelectedIndex != 0 && upDown5.Value != 0)
            {
                count++;
                programNameArray.Add(cbxChoice5.Text);
                priorityArray.Add(Convert.ToInt32(upDown5.Value));
            }
                
            return count;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            qualificationMatch = true;
            if (frmQualification == null)
                frmQualification = new qualificationFrm();
            frmQualification.Show();
        }

        private void btnProvide_Click(object sender, EventArgs e)
        {
            addMatch = true;
            submit();
            if (frmEnglish == null)
                frmEnglish = new englishtestFrm();
            frmEnglish.Show();
        }

       

    }
}
