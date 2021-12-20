using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using UniversityAutomationSystem.DTO;
using UniversityAutomationSystem.DAO;

namespace UniversityAutomationSystem
{
    public partial class ShowCourse_tec : System.Web.UI.Page
    {
        Course_tblDAO course_tbldao = new Course_tblDAO();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string user = (string)(Session["username"]);
                rptrcourse.DataSource = course_tbldao.getAllCourses(new Course_tblDTO(user)).Tables[0];
                rptrcourse.DataBind();
            }
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/UploadResult_tec.aspx?course_id=" + ((LinkButton)sender).Text);
        }
    }
}