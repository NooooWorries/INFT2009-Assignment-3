using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace NoTreal.ClassDomain
{
    class qualificationFrmClass
    {
        private string qualificationID;
        private string type;
        private string name;
        private string country;
        private DateTime admittedDate;
        private DateTime graduationDate;
        private string programTitle;
        private decimal gpa;
        private string description;
        public String public_qualificationID { get { return qualificationID; } }
        public String public_type { get { return type; } }
        public String public_name { get { return name; } }
        public String public_country { get { return country; } }
        public DateTime public_admittedDate { get { return admittedDate; } }
        public DateTime public_graduationDate { get { return graduationDate; } }
        public String public_programTitle { get { return programTitle; } }
        public decimal public_gpa { get { return gpa; } }
        public String public_description { get { return description; } }

        // Constructure
        public qualificationFrmClass (string qualificationID, string type, string name, string country, DateTime admittedDate, DateTime graduationDate, string programTitle, decimal gpa, string description)
        {
            this.qualificationID = qualificationID;
            this.type = type;
            this.name = name;
            this.country = country;
            this.admittedDate = admittedDate;
            this.graduationDate = graduationDate;
            this.programTitle = programTitle;
            this.gpa = gpa;
            this.description = description;
        }
        // Class: qualificationFrlClass
        // A method to insert a english test record
        public void Save()
        {
            // Link to the database
            String connStr = "data source=localhost;initial catalog=NoTreal;integrated security=true";
            SqlConnection dbConn = new SqlConnection(connStr);
            // Sql statement: onsert value
            SqlCommand sqlStat =
                 new SqlCommand("INSERT INTO AcademicQualification VALUES (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9)", dbConn);
            // data list
            sqlStat.Parameters.Add(new SqlParameter("@p1", this.qualificationID));
            sqlStat.Parameters.Add(new SqlParameter("@p2", this.type));
            sqlStat.Parameters.Add(new SqlParameter("@p3", this.name));
            sqlStat.Parameters.Add(new SqlParameter("@p4", this.country));
            sqlStat.Parameters.Add(new SqlParameter("@p5", this.admittedDate));
            sqlStat.Parameters.Add(new SqlParameter("@p6", this.graduationDate));
            sqlStat.Parameters.Add(new SqlParameter("@p7", this.programTitle));
            sqlStat.Parameters.Add(new SqlParameter("@p8", this.gpa));
            sqlStat.Parameters.Add(new SqlParameter("@p9", this.description));
            SqlTransaction dbTran = null;
            // Try-catch, avoid program crash.
            // When program crash happened, a message box shows the error information and roll back to the last step.
            try
            {
                dbConn.Open();
                dbTran = dbConn.BeginTransaction();
                sqlStat.Transaction = dbTran;
                int rowAffected = sqlStat.ExecuteNonQuery();
                dbTran.Commit();

            }
            catch (SqlException error)
            {
                dbTran.Rollback();
                MessageBox.Show(error.Message, "Error");
            }
            finally
            {
                if (dbConn != null)
                    dbConn.Close();
            }
        }
    }
}
