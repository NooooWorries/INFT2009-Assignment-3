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
    public partial class englishtestFrm : Form
    {
        bool errorMatch = false;
        String applicationID = applicationFrm.applicationID;
        public englishtestFrm()
        {
            InitializeComponent();
        }

        private void englishtestFrm_Load(object sender, EventArgs e)
        {
            lblApplicationID.Text = "Your Application ID : " + applicationID;
        }

        private void btnSave(object sender, EventArgs e)
        {
            try
            {
                String id = tbxTestID.Text;
                String name = tbxName.Text;
                decimal score = Convert.ToDecimal(tbxScore.Text);
                DateTime attendDate = dateTimeTest.Value;
                string location = tbxLocation.Text;
                englishtestFrmClass newEnglishTest = new englishtestFrmClass(id,applicationFrm.applicationID, name, score, attendDate, location);
                newEnglishTest.Save();
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

        private void button4_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
