using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Configuration;
using System.Data.SqlClient;

namespace ELSystem
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class CourseService : ICourseService
    {
        void ICourseService.Create(Course course)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["ELS"].ToString();
            SqlConnection con;

            using (con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "insert into Course(CourseName,NumberOfTab) values(@name,@numoftabs)";

                SqlParameter p1 = new SqlParameter("@name", course.CurName);
                SqlParameter p2 = new SqlParameter("@numoftabs", course.NumberofTab);


                cmd.Parameters.Add(p1);
                cmd.Parameters.Add(p2);


                con.Open();

                int i = cmd.ExecuteNonQuery();

                con.Close();
            }


        }

        bool ICourseService.Delete(int CurId)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["ELS"].ToString();
            SqlConnection con;

            using (con = new SqlConnection(connectionString))
            {
                int i = 0;
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "delete from Course where Id=@Id";

                SqlParameter p1 = new SqlParameter("@Id", CurId);

                cmd.Parameters.Add(p1);
                
                con.Open();

                i = cmd.ExecuteNonQuery();
                con.Close();
                if (i > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        DataSet ICourseService.GetAllCourse()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["ELS"].ToString();
            SqlConnection con;

            using (con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "select * from Course";


                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();

                con.Open();
                da.Fill(ds);
                con.Close();
                return ds;
            }
        }

        List<string> ICourseService.GetAllCourseName()
        {
            List<string> courseName = new List<string>();
            string connectionString = ConfigurationManager.ConnectionStrings["ELS"].ToString();
            SqlConnection con;

            using (con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "select CourseName from Course";

                SqlDataReader rdr;

                con.Open();
                rdr = cmd.ExecuteReader();

                while(rdr.Read())
                {
                    courseName.Add(rdr.GetString(0));
                }

                con.Close();
                return courseName;
            }
        }

        int ICourseService.GetCourseId(string coursename)
        {
            int courseId = 1 ;
            string connectionString = ConfigurationManager.ConnectionStrings["ELS"].ToString();
            SqlConnection con;

            using (con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "select Id from Course where CourseName=@coursename";

                SqlParameter p1 = new SqlParameter("@coursename",coursename);
                cmd.Parameters.Add(p1);

                SqlDataReader rdr;

                con.Open();
                rdr = cmd.ExecuteReader();

                if(rdr.Read())
                {
                    courseId = rdr.GetInt32(0);
                }

                con.Close();
                return courseId;
            }
        }

        Course ICourseService.Read(int CurId)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["ELS"].ToString();
            SqlConnection con;

            using (con = new SqlConnection(connectionString))
            {
                Course course = new Course();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "select * from Course where Id=@Id";

                SqlParameter p1 = new SqlParameter("@Id",CurId);

                cmd.Parameters.Add(p1);


                
                con.Open();

                SqlDataReader rdr = cmd.ExecuteReader();
                if(rdr.Read())
                {
                    course.Id = rdr.GetInt32(0);
                    course.CurName = rdr.GetString(1);
                    course.NumberofTab = rdr.GetInt32(2);
                }
                con.Close();
                return course;
            }
        }

        bool ICourseService.Update(Course elearnSystem)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["ELS"].ToString();
            SqlConnection con;

            using (con = new SqlConnection(connectionString))
            {
                int i = 0;
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "update Course set CourseName=@CourseName,NumberOfTab=@NumTab where Id=@Id";

                SqlParameter p1 = new SqlParameter("@CourseName", elearnSystem.CurName);
                SqlParameter p2 = new SqlParameter("@NumTab", elearnSystem.NumberofTab);
                SqlParameter p3 = new SqlParameter("@Id", elearnSystem.Id);

                cmd.Parameters.Add(p1);
                cmd.Parameters.Add(p2);
                cmd.Parameters.Add(p3);


                con.Open();

                i = cmd.ExecuteNonQuery();
                con.Close();
                if (i > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
    }
}
