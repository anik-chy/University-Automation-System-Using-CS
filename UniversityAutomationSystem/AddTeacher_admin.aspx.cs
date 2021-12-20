using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using UniversityAutomationSystem.DAO;

namespace UniversityAutomationSystem
{
    public partial class AddTeacher_admin : System.Web.UI.Page
    {
        Teacher_tblDAO teacher_tbldao = new Teacher_tblDAO();
        Student_tblDAO student_tbldao = new Student_tblDAO();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                DropDownList1.DataSource = student_tbldao.getallDep();
                DropDownList1.DataTextField = "department_id";
                DropDownList1.DataValueField = "department_id";
                DropDownList1.DataBind();
                DropDownList1.Items.Insert(0, "---Select---");
            }
        }
        protected void add_btn_Click(object sender, EventArgs e)
        {
            teacher_tbldao.AddTeacher(name.Text, password.Text,email.Text, DropDownList1.SelectedValue.ToString() );
            Response.Redirect("ShowTeacher_admin.aspx");
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}