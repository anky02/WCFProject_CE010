using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;
using System.IO;
using System.Reflection;

namespace ELSystem
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "TabService" in both code and config file together.
    public class TabService : ITabService
    {
        void ITabService.Create(Tab tab)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["ELS"].ToString();
            SqlConnection con;

            using (con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "insert into Tab(TabName,TabUrl,CourseId) values(@tabname,@taburl,@curid)";

                SqlParameter p1 = new SqlParameter("@tabname", tab.TabName);
                SqlParameter p2 = new SqlParameter("@taburl", tab.TabUrl);
                SqlParameter p3 = new SqlParameter("@curid", tab.CurId);


                cmd.Parameters.Add(p1);
                cmd.Parameters.Add(p2);
                cmd.Parameters.Add(p3);

                con.Open();

                int i = cmd.ExecuteNonQuery();

                con.Close();
            }
        }

        bool ITabService.Delete(int CurId)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["ELS"].ToString();
            SqlConnection con;

            using (con = new SqlConnection(connectionString))
            {
                int i = 0;
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "delete from Tab where CourseId=@curid";

                SqlParameter p1 = new SqlParameter("@curid", CurId);

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

        DataSet ITabService.GetAllTab(int CurId)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["ELS"].ToString();
            SqlConnection con;

            using (con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "select * from Tab";


                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();

                con.Open();
                da.Fill(ds);
                con.Close();
                return ds;
            }
        }

        List<string> ITabService.GetAllTabNames(int CurId)
        {
            List<string> courseName = new List<string>();
            string connectionString = ConfigurationManager.ConnectionStrings["ELS"].ToString();
            SqlConnection con;

            using (con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "select TabName from Tab where CourseId=@courseid";

                SqlParameter p1 = new SqlParameter("@courseid",CurId);
                cmd.Parameters.Add(p1);


                SqlDataReader rdr;

                con.Open();
                rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    courseName.Add(rdr.GetString(0));
                }

                con.Close();
                return courseName;
            }
        }

        string ITabService.GetFileContent(int CourseId , string TabName)
        {

            string connectionString = ConfigurationManager.ConnectionStrings["ELS"].ToString();
            SqlConnection con;
            string s="",path=null;
            using (con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "select TabUrl from Tab where TabName=@tabname AND CourseId=@CourseId";
                
                SqlParameter p1 = new SqlParameter("@tabname",TabName);
                SqlParameter p2 = new SqlParameter("@CourseId",CourseId);
                
                cmd.Parameters.Add(p1);
                cmd.Parameters.Add(p2);

                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                
                if(dr.Read())
                {
                    path = dr.GetString(0);
                }

                string dir = "D:/ELSystem/ELSystem/";
                if (path!=null)
                {
                    var Stream = new FileStream(dir+path, FileMode.Open, FileAccess.Read);
                    using (var streamReader = new StreamReader(Stream, Encoding.UTF8))
                    {
                        string temp;
                        while ((temp = streamReader.ReadLine()) !=null)
                        { 
                            s = s + temp + "\n";
                        }
                        
                    }
                }    
                con.Close();
                return s;
            }
            
        }

        Tab ITabService.Read(int TabId)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["ELS"].ToString();
            SqlConnection con;

            using (con = new SqlConnection(connectionString))
            {
                Tab tab = new Tab();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "select * from Tab where Id=@Id";

                SqlParameter p1 = new SqlParameter("@Id", TabId);

                cmd.Parameters.Add(p1);



                con.Open();

                SqlDataReader rdr = cmd.ExecuteReader();
                if (rdr.Read())
                {
                    
                    tab.TabId = rdr.GetInt32(0);
                    tab.TabName = rdr.GetString(1);
                    tab.TabUrl = rdr.GetString(2);

                }
                con.Close();
                return tab;
            }
        }

        bool ITabService.Update(Tab tab)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["ELS"].ToString();
            SqlConnection con;

            using (con = new SqlConnection(connectionString))
            {
                int i = 0;
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "update Tab set TabName=@TabName,TabUrl=@tabUrl where Id=@Id";

                SqlParameter p1 = new SqlParameter("@TabName", tab.TabName);
                SqlParameter p2 = new SqlParameter("@tabUrl", tab.TabUrl);
                SqlParameter p3 = new SqlParameter("@Id",tab.TabId);

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
