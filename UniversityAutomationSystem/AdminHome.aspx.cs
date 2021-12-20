using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace UniversityAutomationSystem
{
    public partial class AdminHome : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void show_student_btn_click(object sender, EventArgs e)
        {
            //Response.Redirect("http://localhost:8012/austMain/index.html");
            Response.Redirect("ShowStudent_admin.aspx");

        }
        protected void show_teacher_btn_click(object sender, EventArgs e)
        {
            //Response.Redirect("http://localhost:8012/austMain/index.html");
            Response.Redirect("ShowTeacher_admin.aspx");

        }
        protected void approve_results_btn_click(object sender, EventArgs e)
        {
            //Response.Redirect("http://localhost:8012/austMain/index.html");
            Response.Redirect("ShowCourse_ar_admin.aspx");

        }
    }
}