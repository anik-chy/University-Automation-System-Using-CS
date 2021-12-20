using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using UniversityAutomationSystem.DAO;

namespace UniversityAutomationSystem
{
    public partial class AddCourse_stu_admin : System.Web.UI.Page
    {
        Student_tblDAO student_tbldao = new Student_tblDAO();
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

                DropDownList2.DataSource = student_tbldao.getAllStudents();
                DropDownList2.DataTextField = "student_id";
                DropDownList2.DataValueField = "student_id";
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
            course_tbldao.AddtoStudent_takes(DropDownList2.SelectedValue.ToString(), DropDownList1.SelectedValue.ToString(),year.Text,sem.Text);
            Response.Redirect("AddCourse_stu_admin.aspx");
        }
    }
}