using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;
namespace UniversityAutomationSystem
{
    public partial class LectureDownload : System.Web.UI.Page
    {
        DbHandeler obj = new DbHandeler();
        MySqlConnection con;
        MySqlDataReader dr;

        protected void Page_Load(object sender, EventArgs e)
        {
            con = obj.getConnection();
        }
        private void GridDisplayFiles()
        {
            con.Open();
            string query = "Select course_id, student_id, dateOfSubmission, file_name from assignments_tbl where course_id= '" + TextBoxCourseID.Text + "';";
            MySqlCommand cmd = new MySqlCommand(query, con);
            dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                GridView1.DataSource = dr;
                GridView1.DataBind();
                con.Close();
            }
            else
            {
                Label2.Text = "Nothing is available";
                con.Close();
            }

        }
        protected void ButtonGO_Click(object sender, EventArgs e)
        {
            GridDisplayFiles();
        }
    }
}