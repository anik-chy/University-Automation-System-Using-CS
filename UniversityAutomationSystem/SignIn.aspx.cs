using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using UniversityAutomationSystem.DAO;
using UniversityAutomationSystem.DTO;

namespace UniversityAutomationSystem
{
    public partial class SignIn : System.Web.UI.Page
    {
        Student_tblDAO student_tbldao = new Student_tblDAO();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void login_btn_Click(object sender, EventArgs e)
        {
            Teacher_tblDAO teacher_tbldao = new Teacher_tblDAO();
            if (RadioButton1.Checked == true)
            {
                //Label3.Text=RadioButton1.Text;
                int count = teacher_tbldao.GetLoginInfo(new Teacher_tblDTO(username.Text, password.Text));
                if (count == 1)
                {
                    Session["username"] = username.Text;
                    Response.Redirect("TeacherHome.aspx");
                    //Response.Write("LogIn SuccessFul");
                }

                /*
                DropDownList1.DataSource = customer_infodao.getAllChocolates();
                DropDownList1.DataTextField = "name";
                DropDownList1.DataValueField = "cus_id";
                DropDownList1.DataBind();
                DropDownList1.Items.Insert(0, "---Select---");*/
            }
            else if(RadioButton2.Checked == true)
            {
               // Label3.Text = RadioButton2.Text;
                int count = student_tbldao.GetLoginInfo(new Student_tblDTO(username.Text, password.Text));
                if (count == 1)
                {
                    Session["username"] = username.Text;
                    Response.Redirect("StudentHome.aspx");
                    //Response.Write("LogIn SuccessFul");
                }
            }
            else if (RadioButton3.Checked == true)
            {
                // Label3.Text = RadioButton2.Text;
                int count = student_tbldao.GetLoginInfoAdmin(username.Text, password.Text);
                if (count == 1)
                {
                    Session["username"] = username.Text;
                    Response.Redirect("AdminHome.aspx");
                    //Response.Write("LogIn SuccessFul");
                }
            }

            /*
             * DataTextField is what the user can see.
               DataValueField is what you can use for identify which one is selected from DropDownList.
             * */
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*String val = DropDownList1.SelectedValue;
            String text = DropDownList1.SelectedItem.Text;
            Label3.Text = val;*/
        }
    }
}