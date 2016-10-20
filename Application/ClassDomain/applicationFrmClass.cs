using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace NoTreal.ClassDomain
{
    class applicationFrmClass
    {
        // Variable
        private string applicationID;
        private string qualificationID;
        private string status;
        private decimal applicationFee;
        private string applicationDescription;
        private string programCode;
        private int priority;
        private string name;
        private string programDescription;
        // Attributes
        public String public_applicationID { get { return applicationID; } }
        public String public_qualificationID { get { return qualificationID; } }
        public String public_status { get { return status; } }
        public Decimal public_applicationFee { get { return applicationFee; } }
        public String public_applicationDescription { get { return applicationDescription; } }
        public String public_programCode { get { return programCode; } }
        public String public_name { get { return name; } }
        public String public_programDescription { get { return programDescription; } }
        
        // Constructor

        public applicationFrmClass (string name, string programCode)
        {
            this.name = name;
            this.programCode = programCode;
        }

        public applicationFrmClass (string applicationID, string programCode, int priority)
        {
            this.applicationID = applicationID;
            this.programCode = programCode;
            this.priority = priority;
        }
        public applicationFrmClass (string applicationID,string qualificationID, string status, decimal applicationFee, string applicationDescription)
        {
            this.applicationID = applicationID;
            this.qualificationID = qualificationID;
            this.status = status;
            this.applicationFee = applicationFee;
            this.applicationDescription = applicationDescription ;
        }

        // Class: aplicationFrmClass
        // A method to insert an application record
        public void Save()
        {
            // Link to the database
            String connStr = "data source=localhost;initial catalog=NoTreal;integrated security=true";
            SqlConnection dbConn = new SqlConnection(connStr);
            // Save application data
            SqlCommand sqlStat =
                 new SqlCommand("INSERT INTO Application VALUES (@p1,@p2,@p3,@p4,@p5)", dbConn);
            // Application data list
            sqlStat.Parameters.Add(new SqlParameter("@p1", this.applicationID));
            sqlStat.Parameters.Add(new SqlParameter("@p2", this.qualificationID));
            sqlStat.Parameters.Add(new SqlParameter("@p3", this.status));
            sqlStat.Parameters.Add(new SqlParameter("@p4", this.applicationFee));
            sqlStat.Parameters.Add(new SqlParameter("@p5", this.applicationDescription));
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

        // A method to search the entry requirements
        public static applicationFrmClass getRequirement(String name)
        {
            // Link to the database
            applicationFrmClass record = null;
            String connStr = "data source=localhost;initial catalog=NoTreal;integrated security=true";
            SqlConnection dbConn = new SqlConnection(connStr);
            SqlCommand sqlStmt =
                new SqlCommand("SELECT name,description FROM Program WHERE name = @pName",
                                                dbConn);

            SqlParameter param = new SqlParameter("@pName", name);
            sqlStmt.Parameters.Add(param);
            SqlDataReader reader = null;
            try
            {
                dbConn.Open();
                reader = sqlStmt.ExecuteReader();
                if (reader.HasRows)
                {
                    reader.Read();
                    String programDescription = reader.GetString(1);
                    record = new applicationFrmClass(name,programDescription);
                }
            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message, "Error");
            }
            finally
            {
                if (dbConn != null)
                    dbConn.Close();
            }
            Console.WriteLine(record);
            return record;
        }

        // Class: applicationFrmClass
        // A method to save the program selection
        public void SaveSelection()
        {
            // Link to the database
            String connStr = "data source=localhost;initial catalog=NoTreal;integrated security=true";
            SqlConnection dbConn = new SqlConnection(connStr);
            // Insert values into the database
            SqlCommand sqlStat =
                 new SqlCommand("INSERT INTO ProgramChoice VALUES (@p1,@p2,@p3)", dbConn);
            // Selection data list
            sqlStat.Parameters.Add(new SqlParameter("@p1", applicationFrm .applicationID ));
            sqlStat.Parameters.Add(new SqlParameter("@p2", this.programCode));
            sqlStat.Parameters.Add(new SqlParameter("@p3", this.priority));
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
        // Class:applicationFrmClass
        // A method to get the program list
        public static List<applicationFrmClass > getList()
        {
            List<applicationFrmClass> recordList = new List<applicationFrmClass>();
            // Connection string
            String connStr = "data source=localhost;initial catalog=NoTreal;integrated security=true";
            SqlConnection dbConn = new SqlConnection(connStr);
            SqlCommand sqlStmt = new SqlCommand("SELECT name,programCode FROM program",
                                                dbConn);
            SqlDataReader reader = null;
            try
            {
                dbConn.Open();  // Attempt to connect to database
                reader = sqlStmt.ExecuteReader();
                if (reader.HasRows)
                {
                    // Need a loop to process all the rows inside reader
                    while (reader.Read())
                    {
                        // Now process one row
                        String name = reader.GetString(0);
                        String programCode = reader.GetString(1);
                        // Create an object
                        applicationFrmClass record = new applicationFrmClass(name, programCode);
                        recordList.Add(record);
                    }
                }
            }
            // Try-catch, avoid program crash.
            // When program crash happened, a message box shows the error information and roll back to the last step.
            catch (SqlException error)
            {
                MessageBox.Show(error.Message, "Error");
            }
            finally
            {
                if (reader != null)
                    reader.Close();
                if (dbConn != null)
                    dbConn.Close();
            }
            return recordList;
        }
    }
}
