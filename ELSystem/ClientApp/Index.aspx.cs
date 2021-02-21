using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ClientApp
{
    public partial class Index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                TabService.TabServiceClient tabServiceClient = new TabService.TabServiceClient("BasicHttpBinding_ITabService");

                CourseService.CourseServiceClient courseServiceClient = new CourseService.CourseServiceClient("BasicHttpBinding_ICourseService");


                ListBox1.DataSource = courseServiceClient.GetAllCourseName().ToList();
                ListBox1.DataBind();

                ListBox2.DataSource = tabServiceClient.GetAllTabNames(courseServiceClient.GetCourseId(ListBox1.SelectedValue));
                
                ListBox2.DataBind();
                

            }
        }

        protected void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            TabService.TabServiceClient tabServiceClient = new TabService.TabServiceClient("BasicHttpBinding_ITabService");

            CourseService.CourseServiceClient courseServiceClient = new CourseService.CourseServiceClient("BasicHttpBinding_ICourseService");

            ListBox2.Items.Clear();
            ListBox2.DataSource = tabServiceClient.GetAllTabNames(courseServiceClient.GetCourseId(ListBox1.SelectedValue));

            ListBox2.DataBind();
           
        }

        protected void ListBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            TextBox1.Text = ListBox2.SelectedValue.ToString();

            string tabName = ListBox2.SelectedValue;
            string CourseName = ListBox1.SelectedValue;

            TabService.TabServiceClient tabServiceClient = new TabService.TabServiceClient("BasicHttpBinding_ITabService");
            CourseService.CourseServiceClient courseServiceClient = new CourseService.CourseServiceClient("BasicHttpBinding_ICourseService");

            int courseId = courseServiceClient.GetCourseId(CourseName);

            TextBox2.Text = tabServiceClient.GetFileContent(courseId, tabName);

            tabServiceClient.Close();
            courseServiceClient.Close();
        }

        
    }
}