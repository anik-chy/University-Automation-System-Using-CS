using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using UniversityAutomationSystem.DAO;
using UniversityAutomationSystem.DTO;
using System.Data;

namespace UniversityAutomationSystem
{
    public partial class StudentHome : System.Web.UI.Page
    {
        Student_tblDAO student_tbldao = new Student_tblDAO();

        protected void Page_Load(object sender, EventArgs e)
        {
            string user= (string)(Session["username"]);
            DataSet ds = student_tbldao.getSingleStudent(new Student_tblDTO(user));
            string name = student_tbldao.getSingleStudent(new Student_tblDTO(user)).Tables[0].Rows[0]["name"].ToString();
            hiname.InnerText = "U are Logged In, " + name;
        }
        protected void show_result_btn_click(object sender, EventArgs e)
        {
            //Response.Redirect("http://localhost:8012/austMain/index.html");
            Response.Redirect("ShowResult_stu.aspx");

        }
        protected void upload_ass_btn_click(object sender, EventArgs e)
        {
            //Response.Redirect("http://localhost:8012/austMain/index.html");
            Response.Redirect("AssignmentsUpload.aspx");

        }
        protected void download_lec_btn_click(object sender, EventArgs e)
        {
            //Response.Redirect("http://localhost:8012/austMain/index.html");
            Response.Redirect("LectureDownload.aspx");

        }
    }
}