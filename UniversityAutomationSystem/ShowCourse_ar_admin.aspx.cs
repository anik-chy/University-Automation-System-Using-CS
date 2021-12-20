using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using UniversityAutomationSystem.DAO;

namespace UniversityAutomationSystem
{
    public partial class ShowCourse_ar_admin : System.Web.UI.Page
    {
        Course_tblDAO course_tbldao = new Course_tblDAO();
        protected void Page_Load(object sender, EventArgs e)
        {
            
            if (!IsPostBack)
            {
                
                rptrstudent.DataSource = course_tbldao.getallCourse().Tables[0];
                rptrstudent.DataBind();
            }
        }
        protected void LinkButton2_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/ApproveResults_admin.aspx?course_id=" + ((LinkButton)sender).Text);
        }
    }
}