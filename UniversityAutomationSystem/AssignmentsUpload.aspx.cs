using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using MySql.Data.MySqlClient;


namespace UniversityAutomationSystem
{
    public partial class AssignmentsUpload : System.Web.UI.Page
    {
        DbHandeler obj = new DbHandeler();
        MySqlConnection con;

        protected void Page_Load(object sender, EventArgs e)
        {
            con = obj.getConnection();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (FileUpload1.HasFile)
            {
                string fname = FileUpload1.PostedFile.FileName;
                string extension = Path.GetExtension(fname);
                int flag = 0;
                switch (extension.ToLower())
                {
                    case ".doc":
                    case ".docx":
                    case ".pdf":
                        flag = 1;
                        break;
                    default:
                        flag = 0;
                        break;

                }
                if (flag == 1)
                {
                    FileUpload1.SaveAs(Server.MapPath("~/assignments/" + fname));
                    DateTime today = DateTime.Today;
                    string query;
                    query = "insert into assignments_tbl (course_id, student_id, dateOfSubmission, file_name) values ('" + TextBoxCourseID.Text + "','" + TextBoxRoll.Text + "','"
                        + today + "','" + fname + "')";
                    con.Open();
                    MySqlCommand cmd = new MySqlCommand(query, con);
                    if (cmd.ExecuteNonQuery() != 0)
                    {
                        Label3.Text = "File Upload Successful";
                        con.Close();
                    }
                    else
                    {
                        Label3.Text = "File Upload Faild";
                        con.Close();
                    }
                }
                else
                {
                    Label3.Text = "Only .doc, .docx and .pdf file is Allowed";
                }

            }
            else
            {
                Label3.Text = "Select the File";
            }
        }
    }
}