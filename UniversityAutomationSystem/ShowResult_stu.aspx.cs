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
    public partial class ShowResult_stu : System.Web.UI.Page
    {
        Result_tblDAO result_tbldao = new Result_tblDAO();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string user = (string)(Session["username"]);
                rptrResults.DataSource = result_tbldao.getAllResults(new Result_tblDTO(user)).Tables[0];
                rptrResults.DataBind();
            }
        }
    }
}