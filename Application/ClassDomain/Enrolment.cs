using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;

namespace NoTreal.ClassDomain
{
    class Enrolment
    {
        private String progCode;
        private String semCode;
        private String type;
        private String code;

        private String name;
        private String requirement;


        //properties
        public String ProgCode { get { return progCode; } }
        public String SemCode { get { return semCode; } }
        public String Type { get { return type; } }
        public String Code { get { return code; } }
        public String Name { get { return name; } }
        public String Requirement { get { return requirement; } }


        //public String StudentID { get { return studentID; } }
        //Constructor
        public Enrolment(String progCode, String semCode, String type, String code, String name)
        {
            this.progCode = progCode;
            this.semCode = semCode;
            this.type = type;
            this.code = code;
            this.name = name;
            //this.requirement = requirement;
        }

        public Enrolment(String code, String requirement)
        {
            this.code = code;
            this.requirement = requirement;
        }



        //method 
        public static Enrolment ShowReq(String code)
        {
            Enrolment req = null;
            String connStr = "data source= LocalHost;Initial Catalog=Unknown;  integrated security = true";
            SqlConnection dbConn = new SqlConnection(connStr);
            SqlCommand sqlStmt = new SqlCommand("SELECT  code, requirement FROM CourseOffer, Course WHERE Course.courseCode = CourseOffer.code AND  @code = code", dbConn);
            SqlParameter parameter = new SqlParameter("@code", code);
            sqlStmt.Parameters.Add(parameter);
            SqlDataReader reader = null;
            try
            {
                dbConn.Open();
                reader = sqlStmt.ExecuteReader();
                if (reader.HasRows)
                {
                    reader.Read();
                    String requirement = reader.GetString(0);
                    req = new Enrolment(code, requirement);
                }
            }
            catch (SqlException e)
            {
            }
            finally
            {
            }
            return req;
        }

        public static List<Enrolment> getCourses(String program, String semester, String Ptype)
        {

            List<Enrolment> offerList = new List<Enrolment>();
            String connStr = "data source= LocalHost;Initial Catalog=Unknown;  integrated security = true";
            SqlConnection dbConn = new SqlConnection(connStr);
            SqlCommand sqlStmt = new SqlCommand("SELECT  progCode, semCode, type, code, name FROM CourseOffer, Course WHERE Course.courseCode = CourseOffer.code AND  @pCode = progCode AND @type=type AND @sCode= semCode", dbConn);
            SqlParameter parameter = new SqlParameter("@pCode", program);
            SqlParameter parameter2 = new SqlParameter("@sCode", semester);
            SqlParameter parameter3 = new SqlParameter("@type", Ptype);
            sqlStmt.Parameters.Add(parameter);
            sqlStmt.Parameters.Add(parameter3);
            sqlStmt.Parameters.Add(parameter2);
            SqlDataReader reader = null;
            try
            {
                dbConn.Open();
                reader = sqlStmt.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        reader.Read();
                        String progCode = reader.GetString(0);
                        String semCode = reader.GetString(1);
                        String type = reader.GetString(2);
                        String code = reader.GetString(3);
                        String name = reader.GetString(4);
                        Enrolment course = new Enrolment(progCode, semCode, type, code, name);
                        offerList.Add(course);
                    }
                }
            }
            catch (SqlException error)
            {
                Console.WriteLine(error.Message);
            }
            finally
            {
                if (reader != null)
                    reader.Close();
                if (dbConn != null)
                    dbConn.Close();
            }
            return offerList;
        }


    }
}
