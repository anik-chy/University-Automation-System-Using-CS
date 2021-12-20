using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using UniversityAutomationSystem.DAO;

namespace UniversityAutomationSystem
{
    public partial class ShowTeacher_admin : System.Web.UI.Page
    {
        Teacher_tblDAO teacher_tbldao = new Teacher_tblDAO();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {

                rptrstudent.DataSource = teacher_tbldao.getAllTeachers().Tables[0];
                rptrstudent.DataBind();
            }
        }
        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/UploadResult_tec.aspx?course_id=" + ((LinkButton)sender).Text);
        }
        protected void LinkButton2_Click(object sender, EventArgs e)
        {
            teacher_tbldao.DeleteTeacher(((LinkButton)sender).Text);
            Response.Redirect("~/ShowStudent_admin.aspx");
        }

        protected void add_student_Click(object sender, EventArgs e)
        {

            Response.Redirect("AddTeacher_admin.aspx");
        }
        protected void add_courses_Click(object sender, EventArgs e)
        {

            Response.Redirect("AddCourse_tec_admin.aspx");
        }
    }
}