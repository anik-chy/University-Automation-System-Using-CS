using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace UniversityAutomationSystem
{
    public partial class Master1 : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void signout_btn_Click(object sender, EventArgs e)
        {
            Session["username"] = null;
            Response.Redirect("SignIn.aspx");
        }
    }
}