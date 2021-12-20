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
    public partial class LectureUpload : System.Web.UI.Page
    {
        DbHandeler obj = new DbHandeler();
        MySqlConnection con;
        protected void Page_Load(object sender, EventArgs e)
        {
            con = obj.getConnection();
        }
        protected void ButtonUpload_Click(object sender, EventArgs e)
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
                    FileUpload1.SaveAs(Server.MapPath("~/lectures/" + fname));
                    DateTime today = DateTime.Today;
                    string query;
                    query = "insert into lecture_tbl (topic, dateOfUpload, course_id, file_name) values ('" + TextBoxTopic.Text + "','"
                        + today + "','" + TextBoxCourseID.Text + "','" + fname + "')";
                    con.Open();
                    MySqlCommand cmd = new MySqlCommand(query, con);
                    if (cmd.ExecuteNonQuery() != 0)
                    {
                        Label4.Text = "File Upload Successful";
                        con.Close();
                    }
                    else
                    {
                        Label4.Text = "File Upload Faild";
                        con.Close();
                    }
                }
                else
                {
                    Label4.Text = "Only .doc, .docx and .pdf file is Allowed";
                }

            }
            else
            {
                Label4.Text = "Select the File";
            }
        }
    }
}