using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using UniversityAutomationSystem.DAO;

namespace UniversityAutomationSystem
{
    public partial class AddStudent_admin : System.Web.UI.Page
    {
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
            student_tbldao.AddStudent(sec.Text,ssec.Text,DropDownList1.SelectedValue.ToString(),email.Text,tc.Text,stu_id.Text,year.Text,sem.Text,password.Text,name.Text);
            Response.Redirect("ShowStudent_admin.aspx");
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*String val = DropDownList1.SelectedValue;
            String text = DropDownList1.SelectedItem.Text;
            Label3.Text = val;*/
        }
    }
}