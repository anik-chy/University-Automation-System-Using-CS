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
    public partial class UploadResult_tec : System.Web.UI.Page
    {
        Course_tblDAO course_tbldao = new Course_tblDAO();
        string course_id;
        String year,sem;

        protected void Page_Load(object sender, EventArgs e)
        {
            //course_id = Request.QueryString["course_id"];
            if (!IsPostBack)
            {

                course_id = Request.QueryString["course_id"];
                GetCountry();
                ddl_city.Items.Insert(0, "--Select--");

            }
            else
            {
                course_id = Request.QueryString["course_id"];
            }

        }
        private void GetCountry()
        {
            

      
                ddl_country.DataSource = course_tbldao.getYear(new Course_tblDTO(course_id,""));
                ddl_country.DataTextField = "year";
                ddl_country.DataValueField = "year";
                ddl_country.DataBind();
                ddl_country.Items.Insert(0, new ListItem("--Select--", "0"));
                ddl_country.SelectedIndex = 0;
            
        }

        protected void ddl_country_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            string get_countryname, countryname;
            countryname = ddl_country.SelectedItem.Text;
            get_countryname = ddl_country.SelectedValue.ToString();

                    ddl_city.DataSource = course_tbldao.getSem(new Course_tblDTO(course_id,""));
                    ddl_city.DataTextField = "semester";
                    ddl_city.DataValueField = "semester";
                    ddl_city.DataBind();
                    ddl_city.Items.Insert(0, new ListItem("--Select--", "0"));
                    ddl_city.SelectedIndex = 0;


        }
        /*
    protected void btn_display_Click(object sender, EventArgs e)
    {
        string display;
        display = " Your Country : " + ddl_country.SelectedItem.Text + "Your City : " + ddl_city.SelectedItem.Text + "";
        lbl_display.Text = display;
    }*/

    protected void ddl_stu_SelectedIndexChanged(object sender, EventArgs e)
    {

    }


    protected void ddl_city_SelectedIndexChanged(object sender, EventArgs e)
    {
        string get_countryname, countryname;
        countryname = ddl_city.SelectedItem.Text;
        get_countryname = ddl_city.SelectedValue.ToString();

        ddl_stu.DataSource = course_tbldao.getYearSem(new Course_tblDTO(ddl_country.SelectedValue.ToString(), ddl_city.SelectedValue.ToString(), course_id));
        ddl_stu.DataTextField = "student_id";
        ddl_stu.DataValueField = "student_id";
        ddl_stu.DataBind();
        ddl_stu.Items.Insert(0, new ListItem("--Select--", "0"));
        ddl_stu.SelectedIndex = 0;
    }
    protected void upload_btn_Click(object sender, EventArgs e)
    {
        int quiz = Convert.ToInt32(qn.Text);
        int att = Convert.ToInt32(an.Text);
        int final = Convert.ToInt32(fn.Text);
        int total = quiz + att + final;
        string gd = grade(total);
        string year = ddl_country.SelectedValue.ToString();
        string stu_id = ddl_stu.SelectedValue.ToString();
        string sem = ddl_city.SelectedValue.ToString();

        Result_tblDAO result_tbldao = new Result_tblDAO();
        result_tbldao.UploadResults(new Result_tblDTO(qn.Text,an.Text,fn.Text,total.ToString(),gd,year,stu_id,course_id,sem));

        qn.Text = "";
        an.Text = "";
        fn.Text = "";
        ddl_city.Items.Insert(0, "--Select--");
        ddl_city.Items.Insert(0, new ListItem("--Select--", "0"));
        ddl_stu.Items.Insert(0, new ListItem("--Select--", "0"));
        Response.Redirect("UploadResult_tec.aspx?course_id="+ course_id);
        
    }

    public string grade(int num){
	if(num>=80){
		return "A+";
	}
	if(num>=75){
		return "A";
	}
	if(num>=70){
		return "A-";
	}
	if(num>=65){
		return "B+";
	}
	if(num>=60){
		return "B";
	}
	if(num>=55){
		return "B-";
	}
	if(num>=50){
		return "C+";
	}
	if(num>=45){
		return "C";
	}
	if(num>=40){
		return "D";
	}
    else
        return "F";
}

    }
}