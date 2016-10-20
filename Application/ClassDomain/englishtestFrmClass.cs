using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace NoTreal.ClassDomain
{
    class englishtestFrmClass
    {
        private string testID;
        private string applicationID;
        private string testName;
        private decimal testScore;
        private DateTime testDate;
        private string testLocation;

        public String public_testID { get { return testID; } }
        public String public_applicationID { get { return applicationID; } }
        public String public_testName { get { return testName; } }
        public decimal public_testScore { get { return testScore; } }
        public DateTime public_testDate { get { return testDate; } }
        public String public_testLocation { get { return testLocation; } }

        // Constructor
        public englishtestFrmClass(string testID, string applicationID, string testName, decimal testScore, DateTime testDate, string testLocation)
        { 
            this.testID = testID;
            this.applicationID = applicationID;
            this.testName = testName;
            this.testScore = testScore;
            this.testDate = testDate;
            this.testLocation = testLocation;
        }
        // Class: englishtestFrmClass
        // A method to insert a english test record
        public void Save()
        {
            // Link to the database
            String connStr = "data source=localhost;initial catalog=NoTreal;integrated security=true";
            SqlConnection dbConn = new SqlConnection(connStr);
            // Insert value (SQL statement)
            SqlCommand sqlStat =
                 new SqlCommand("INSERT INTO EnglishTest VALUES (@p1,@p2,@p3,@p4,@p5,@p6)", dbConn);
            // Data list
            sqlStat.Parameters.Add(new SqlParameter("@p1", this.testID));
            sqlStat.Parameters.Add(new SqlParameter("@p2", this.applicationID));
            sqlStat.Parameters.Add(new SqlParameter("@p3", this.testName));
            sqlStat.Parameters.Add(new SqlParameter("@p4", this.testScore));
            sqlStat.Parameters.Add(new SqlParameter("@p5", this.testDate));
            sqlStat.Parameters.Add(new SqlParameter("@p6", this.testLocation));
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
                MessageBox.Show(error.Message,"Error");
            }
            finally
            {
                if (dbConn != null)
                    dbConn.Close();
            }
        }
    }
}
