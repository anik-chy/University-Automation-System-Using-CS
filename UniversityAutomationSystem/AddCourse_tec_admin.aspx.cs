using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using UniversityAutomationSystem.DAO;

namespace UniversityAutomationSystem
{
    public partial class AddCourse_tec_admin : System.Web.UI.Page
    {
        Teacher_tblDAO teacher_tbldao = new Teacher_tblDAO();
        Course_tblDAO course_tbldao = new Course_tblDAO();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                DropDownList1.DataSource = course_tbldao.getallCourse();
                DropDownList1.DataTextField = "course_id";
                DropDownList1.DataValueField = "course_id";
                DropDownList1.DataBind();
                DropDownList1.Items.Insert(0, "---Select---");

                DropDownList2.DataSource = teacher_tbldao.getAllTeachers();
                DropDownList2.DataTextField = "teacher_id";
                DropDownList2.DataValueField = "teacher_id";
                DropDownList2.DataBind();
                DropDownList2.Items.Insert(0, "---Select---");
            }
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void DropDownList2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void add_btn_Click(object sender, EventArgs e)
        {
            course_tbldao.AddtoTeacher_takes(DropDownList2.SelectedValue.ToString(), DropDownList1.SelectedValue.ToString(), year.Text, sem.Text);
            Response.Redirect("AddCourse_tec_admin.aspx");
        }
    }
}