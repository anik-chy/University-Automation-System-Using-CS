using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using UniversityAutomationSystem.DAO;

namespace UniversityAutomationSystem
{
    public partial class ApproveResults_admin : System.Web.UI.Page
    {
        Result_tblDAO result_tbldao = new Result_tblDAO();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string course_id = Request.QueryString["course_id"];
                rptrstudent.DataSource = result_tbldao.getAllUnapprovedResults(course_id).Tables[0];
                rptrstudent.DataBind();
            }
        }
        protected void approve_btn_click(object sender, EventArgs e)
        {
            result_tbldao.ApproveResults();
            Response.Redirect("AdminHome.aspx");
        }
    }
}