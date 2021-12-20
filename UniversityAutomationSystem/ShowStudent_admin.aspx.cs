using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using UniversityAutomationSystem.DAO;

namespace UniversityAutomationSystem
{
    public partial class ShowStudent_admin : System.Web.UI.Page
    {
        Student_tblDAO student_tbldao = new Student_tblDAO();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                
                rptrstudent.DataSource = student_tbldao.getAllStudents().Tables[0];
                rptrstudent.DataBind();
            }

        }
        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/UploadResult_tec.aspx?course_id=" + ((LinkButton)sender).Text);
        }
        protected void LinkButton2_Click(object sender, EventArgs e)
        {
            student_tbldao.DeleteStudent(((LinkButton)sender).Text);
            Response.Redirect("~/ShowTeacher_admin.aspx");
        }
        
        protected void add_student_Click(object sender, EventArgs e)
        {
         
            Response.Redirect("AddStudent_admin.aspx");
        }
        protected void add_courses_Click(object sender, EventArgs e)
        {

            Response.Redirect("AddCourse_stu_admin.aspx");
        }
    }
}