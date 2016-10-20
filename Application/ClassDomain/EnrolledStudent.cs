using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;
namespace NoTreal.ClassDomain
{
    class EnrolledStudent
    {
        private String studentID;
        private String courseCode;
        private String status;

        public String StudentID { get { return studentID; } }
        public String CourseCode { get { return courseCode; } }
        public String Status { get { return status; } }

        public EnrolledStudent(String studentID, String courseCode, String status)
        {
            this.studentID = studentID;
            this.courseCode = courseCode;
            this.status = status;
        }
        public void SaveData()
        {
            String connStr = "data source=localhost;initial catalog=UnKnown;integrated security=true";
            SqlConnection dbConn = new SqlConnection(connStr);
            SqlCommand sqlStat =
                 new SqlCommand("INSERT INTO CourseEnrolment VALUES (@pID,@pCourse,@pStatus)", dbConn);
            sqlStat.Parameters.Add(new SqlParameter("@pID", this.studentID));
            sqlStat.Parameters.Add(new SqlParameter("@pCourse", this.courseCode));
            sqlStat.Parameters.Add(new SqlParameter("@pStatus", this.status));
            SqlTransaction dbTran = null;
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
            }
            finally
            {
                if (dbConn != null)
                    dbConn.Close();
            }
        }



    }
}
