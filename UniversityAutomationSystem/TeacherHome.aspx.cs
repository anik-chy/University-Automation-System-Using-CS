using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using UniversityAutomationSystem.DTO;
using UniversityAutomationSystem.DAO;

namespace UniversityAutomationSystem
{
    public partial class TeacherHome : System.Web.UI.Page
    {
        Teacher_tblDAO teacher_tbldao = new Teacher_tblDAO();

        protected void Page_Load(object sender, EventArgs e)
        {
            string user = (string)(Session["username"]);
            DataSet ds = teacher_tbldao.getSingleTeacher(new Teacher_tblDTO(user));
            string name = teacher_tbldao.getSingleTeacher(new Teacher_tblDTO(user)).Tables[0].Rows[0]["name"].ToString();
            hiname.InnerText = "U are Logged In, " + name;
        }

        protected void upload_result_btn_click(object sender, EventArgs e)
        {
            //Response.Redirect("http://localhost:8012/austMain/index.html");
            Response.Redirect("ShowCourse_tec.aspx");

        }
        protected void upload_lec_btn_click(object sender, EventArgs e)
        {
            //Response.Redirect("http://localhost:8012/austMain/index.html");
            Response.Redirect("LectureUpload.aspx");

        }

        protected void download_ass_btn_click(object sender, EventArgs e)
        {
            //Response.Redirect("http://localhost:8012/austMain/index.html");
            Response.Redirect("AssignmentsDownloads.aspx");

        }
    }
}