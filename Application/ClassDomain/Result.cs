using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;

namespace NoTreal.ClassDomain
{
    class Result
    {
        private static String CONN_STR = "";
        private String sID;
        private String program;
        private String course;
        private String status;
        private String finalGrade;
        private decimal finalMark;
        private decimal examMark;
        private decimal courseMark;

        public String SID { get { return sID; } }
        public String Program { get { return program; } }
        public String Course { get { return course; } }
        public String Status { get { return status; } }
        public String FinalGrade { get { return finalGrade; } }
        public decimal FinalMark { get { return finalMark; } }
        public decimal ExamMark { get { return examMark; } }
        public decimal CourseMark { get { return courseMark; } }

        //Constructor
        public Result(String sID, String program, String course, String status,
                      String finalGrade, decimal finalMark, decimal examMark, decimal courseMark)
        {
            this.sID = sID;
            this.program = program;
            this.course = course;
            this.status = status;
            this.finalGrade = finalGrade;
            this.finalMark = finalMark;
            this.examMark = examMark;
            this.courseMark = courseMark;
        }

        //A method to update a student's academic result record
        public void Save()
        {
            String connStr = "data source=localhost;initial catalog=NoTreal;integrated security=true";
            SqlConnection dbConn = new SqlConnection(connStr);
            SqlCommand sqlStmt =
                new SqlCommand("UPDATE AcademicResult SET status=@status, finalMark=@finalMark, finalGrade=@finalGrade WHERE studentID = @sID",
                                                dbConn);
            SqlParameter param = new SqlParameter("@sID", sID);
            sqlStmt.Parameters.Add(param);
            sqlStmt.Parameters.Add(new SqlParameter("@status", this.status));
            sqlStmt.Parameters.Add(new SqlParameter("@finalMark", this.finalMark));
            sqlStmt.Parameters.Add(new SqlParameter("@finalGrade", this.finalGrade));
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
            }
            finally
            {
                if (dbConn != null)
                    dbConn.Close();
            }
        }

        //A method to query one student's academic result record based on student ID 
        //- HOW CAN I GET AND DISPLAY STUDENT'S NAME (from CurrentStudent) ? :(
        public static Result get(String sID)
        {
            Result record = null;
            String connStr = "data source=localhost;initial catalog=NoTreal;integrated security=true";
            SqlConnection dbConn = new SqlConnection(connStr);
            SqlCommand sqlStmt =
                new SqlCommand("SELECT * FROM AcademicResult WHERE studentID = @sID",
                                                dbConn);

            SqlParameter param = new SqlParameter("@sID", sID);
            sqlStmt.Parameters.Add(param);
            SqlDataReader reader = null;
            try
            {
                dbConn.Open();
                reader = sqlStmt.ExecuteReader();
                if (reader.HasRows)
                {
                    reader.Read();
                    String program = reader.GetString(1);
                    String course = reader.GetString(2);
                    String status = reader.GetString(3);
                    String finalGrade = reader.GetString(4);
                    decimal finalMark = reader.GetDecimal(5);
                    decimal examMark = reader.GetDecimal(6);
                    decimal courseMark = reader.GetDecimal(7);
                    record = new Result(sID, program, course, status, finalGrade, finalMark, examMark, courseMark);
                }
            }
            catch (SqlException e)
            {
                //Don't leave it empty
            }
            finally
            {
            }
            return record;
        }

    }

}
