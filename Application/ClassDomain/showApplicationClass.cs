using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace NoTreal.ClassDomain
{
    class showApplicationClass
    {
        private string applicationID;
        private string qualificationID;
        private string status;
        private decimal applicationFee;
        private string applicationDescription;
        public String public_applicationID { get { return applicationID; } }
        public String public_qualificationID { get { return qualificationID; } }
        public String public_status { get { return status; } }
        public decimal public_applicationFee { get { return applicationFee; } }
        public String public_applicationDescription { get { return applicationDescription; } }

        private string type;
        private string name;
        private string country;
        private DateTime admittedDate;
        private DateTime graduationDate;
        private string programTitle;
        private decimal gpa;
        private string qualificationDescription;

        public String public_type { get { return type; } }
        public String public_name { get { return name; } }
        public String public_country { get { return country; } }
        public DateTime public_admittedDate { get { return admittedDate; } }
        public DateTime public_graduationDate { get { return graduationDate; } }
        public String public_programTitle { get { return programTitle; } }
        public Decimal public_gpa { get { return gpa; } }
        public String public_description { get { return qualificationDescription; } }

        private string testID;
        private string testName;
        private decimal testScore;
        private DateTime testDate;
        private string testLocation;
        private bool isEnglishNull;

        public String public_testID { get { return testID; } }
        public String public_testName { get { return testName; } }
        public Decimal public_testScore { get { return testScore; } }
        public DateTime public_testDate { get { return testDate; } }
        public string public_testLocation { get { return testLocation; } }
        public bool public_isEnglishNull { get { return isEnglishNull; } }

        // Constructor 
        public showApplicationClass(string applicationID, string qualificationID, string status, decimal applicationFee, string applicationDescription)
        {
            this.applicationID = applicationID;
            this.qualificationID = qualificationID;
            this.status = status;
            this.applicationFee = applicationFee;
            this.applicationDescription = applicationDescription;
        }
        public showApplicationClass(string applicationID, bool isEnglishNull)
        {
            this.applicationID = applicationID;
            this.isEnglishNull = isEnglishNull;
        }
        public showApplicationClass(string applicationID, string qualificationID, string status)
        {
            this.applicationID = applicationID;
            this.qualificationID = qualificationID;
            this.status = status;
        }
        public showApplicationClass(decimal applicationFee, string applicationDescription, string type, string name, string country, DateTime admittedDate, DateTime graduationDate, string programTitle, decimal gpa, string qualificationDescription, string testID, string testName, decimal testScore, DateTime testDate, string testLocation)
        {
            this.applicationFee = applicationFee;
            this.applicationDescription = applicationDescription;
            this.type = type;
            this.name = name;
            this.country = country;
            this.admittedDate = admittedDate;
            this.graduationDate = graduationDate;
            this.programTitle = programTitle;
            this.gpa = gpa;
            this.qualificationDescription = qualificationDescription;
            this.testID = testID;
            this.testName = testName;
            this.testScore = testScore;
            this.testDate = testDate;
            this.testLocation = testLocation;
        }
        public showApplicationClass(decimal applicationFee, string applicationDescription, string type, string name, string country, DateTime admittedDate, DateTime graduationDate, string programTitle, decimal gpa, string qualificationDescription)
        {
            this.applicationFee = applicationFee;
            this.applicationDescription = applicationDescription;
            this.type = type;
            this.name = name;
            this.country = country;
            this.admittedDate = admittedDate;
            this.graduationDate = graduationDate;
            this.programTitle = programTitle;
            this.gpa = gpa;
            this.qualificationDescription = qualificationDescription;
        }

        // Method
        public void accept()
        {
            String connStr = "data source=localhost;initial catalog=NoTreal;integrated security=true";
            SqlConnection dbConn = new SqlConnection(connStr);
            SqlCommand sqlStmt =
                new SqlCommand("UPDATE Application SET status = 'Accepted' WHERE ApplicationID = @p1", dbConn);
            sqlStmt.Parameters.Add(new SqlParameter("@p1", applicationID));
            Console.WriteLine(applicationID);
            SqlTransaction dbTran = null;
            try
            {
                dbConn.Open();
                dbTran = dbConn.BeginTransaction();
                sqlStmt.Transaction = dbTran;
                int rowAffected = sqlStmt.ExecuteNonQuery();
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
        public void reject()
        {
            String connStr = "data source=localhost;initial catalog=NoTreal;integrated security=true";
            SqlConnection dbConn = new SqlConnection(connStr);
            SqlCommand sqlStmt =
                new SqlCommand("UPDATE Application SET status = 'Rejected' WHERE ApplicationID = @p1", dbConn);
            sqlStmt.Parameters.Add(new SqlParameter("@p1", applicationID));
            Console.WriteLine(applicationID);
            SqlTransaction dbTran = null;
            try
            {
                dbConn.Open();
                dbTran = dbConn.BeginTransaction();
                sqlStmt.Transaction = dbTran;
                int rowAffected = sqlStmt.ExecuteNonQuery();
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

        //public void forward()
        //{
        //    String connStr = "data source=localhost;initial catalog=NoTreal;integrated security=true";
        //    SqlConnection dbConn = new SqlConnection(connStr);
        //    SqlCommand sqlStmt =
        //        new SqlCommand("UPDATE Application SET status = 'Accepted' WHERE ApplicationID = @p1", dbConn);
        //    sqlStmt.Parameters.Add(new SqlParameter("@p1", applicationID));
        //    Console.WriteLine(applicationID);
        //    SqlTransaction dbTran = null;
        //    try
        //    {
        //        dbConn.Open();
        //        dbTran = dbConn.BeginTransaction();
        //        sqlStmt.Transaction = dbTran;
        //        int rowAffected = sqlStmt.ExecuteNonQuery();
        //        dbTran.Commit();

        //    }
        //    catch (SqlException error)
        //    {
        //        dbTran.Rollback();
        //        MessageBox.Show(error.Message, "Error");
        //    }
        //    finally
        //    {
        //        if (dbConn != null)
        //            dbConn.Close();
        //    }
        //}
        public static List<showApplicationClass> getAllWithoutTest(string applicationID, string qualificationID, string status) //match: applicationID
        {
            List<showApplicationClass> recordList = new List<showApplicationClass>();
            // Connection string
            String connStr = "data source=localhost;initial catalog=NoTreal;integrated security=true";
            SqlConnection dbConn = new SqlConnection(connStr);
            SqlCommand sqlStmt = new SqlCommand("SELECT applicationfee, a.description, type, name, country, admittedDate, graduationDate, programTitle, gpa, q.description FROM Application a, AcademicQualification q e WHERE a.qualificationID=q.qualificationID and a.applicationID= '" + applicationID + "' and a.qualificationID = '" + qualificationID + "' and status = '" + status + "'",
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
                        Decimal applicationFee = reader.GetDecimal(0);
                        String applicationDescription = reader.GetString(1);
                        String type = reader.GetString(2);
                        String name = reader.GetString(3);
                        String country = reader.GetString(4);
                        DateTime admittedDate = reader.GetDateTime(5);
                        DateTime graduationDate = reader.GetDateTime(6);
                        String programTitle = reader.GetString(7);
                        Decimal gpa = reader.GetDecimal(8);
                        String qualificationDescription = reader.GetString(9);
                        // Create an object
                        showApplicationClass record = new showApplicationClass(applicationFee, applicationDescription, type, name, country, admittedDate, graduationDate, programTitle, gpa, qualificationDescription);
                        // Add to List<showApplicationClass>
                        recordList.Add(record);
                    }
                }
            }
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
        public static showApplicationClass validateTest(String applicationID)
        {
            showApplicationClass record = null;
            String connStr = "data source=localhost;initial catalog=NoTreal;integrated security=true";
            SqlConnection dbConn = new SqlConnection(connStr);
            SqlCommand sqlStmt =
                new SqlCommand("SELECT testID FROM englishTest WHERE applicationID = @papplicationID",
                                                dbConn);

            SqlParameter param = new SqlParameter("@papplicationID", applicationID);
            sqlStmt.Parameters.Add(param);
            SqlDataReader reader = null;
            try
            {
                dbConn.Open();
                reader = sqlStmt.ExecuteReader();
                bool isEnglishNull = false;
                if (reader.HasRows)
                {
                    reader.Read();
                    if (reader["testID"] == DBNull.Value)
                        isEnglishNull = true;
                    Console.WriteLine(isEnglishNull);
                    record = new showApplicationClass(applicationID, isEnglishNull);
                }
            }
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
            return record;
        }
        public static List<showApplicationClass> getRecordID()
        {
            List<showApplicationClass> recordList = new List<showApplicationClass>();
            // Connection string
            String connStr = "data source=localhost;initial catalog=NoTreal;integrated security=true";
            SqlConnection dbConn = new SqlConnection(connStr);
            SqlCommand sqlStmt = new SqlCommand("SELECT applicationID, qualificationID, status FROM Application",
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
                        String applicationID = reader.GetString(0);
                        String qualificationID = reader.GetString(1);
                        String status = reader.GetString(2);
                        // Create an object
                        showApplicationClass record = new showApplicationClass(applicationID, qualificationID, status);
                        // Add to List<showApplicationClass>
                        recordList.Add(record);
                    }
                }
            }
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
        public static List<showApplicationClass> getAll(string applicationID, string qualificationID, string status) //match: applicationID
        {
            List<showApplicationClass> recordList = new List<showApplicationClass>();
            // Connection string
            String connStr = "data source=localhost;initial catalog=NoTreal;integrated security=true";
            SqlConnection dbConn = new SqlConnection(connStr);
            SqlCommand sqlStmt = new SqlCommand("SELECT applicationfee, a.description, type, name, country, admittedDate, graduationDate, programTitle, gpa, q.description, testID, testName, testScore, testDate, testLocation FROM Application a, AcademicQualification q, EnglishTest e WHERE a.qualificationID=q.qualificationID and e.applicationID=a.applicationID and a.applicationID= '" + applicationID + "' and a.qualificationID = '" + qualificationID + "' and status = '" + status + "'",
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
                        Decimal applicationFee = reader.GetDecimal(0);
                        String applicationDescription = reader.GetString(1);
                        String type = reader.GetString(2);
                        String name = reader.GetString(3);
                        String country = reader.GetString(4);
                        DateTime admittedDate = reader.GetDateTime(5);
                        DateTime graduationDate = reader.GetDateTime(6);
                        String programTitle = reader.GetString(7);
                        Decimal gpa = reader.GetDecimal(8);
                        String qualificationDescription = reader.GetString(9);
                        String testID = reader.GetString(10);
                        String testName = reader.GetString(11);
                        Decimal testScore = reader.GetDecimal(12);
                        DateTime testDate = reader.GetDateTime(13);
                        String testLocation = reader.GetString(14);
                        // Create an object
                        showApplicationClass record = new showApplicationClass(applicationFee, applicationDescription, type, name, country, admittedDate, graduationDate, programTitle, gpa, qualificationDescription, testID, testName, testScore, testDate, testLocation);
                        // Add to List<showApplicationClass>
                        recordList.Add(record);
                    }
                }
            }
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
