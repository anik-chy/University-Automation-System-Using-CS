using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MySql.Data.MySqlClient;
using UniversityAutomationSystem.DTO;
using System.Data;

namespace UniversityAutomationSystem.DAO
{
    public class Result_tblDAO
    {
         DBConnect dbconnect = new DBConnect();

        private MySqlDataAdapter mysqlAdapter;
        private DataSet dataSet;

        public Result_tblDAO()
        {

        }

        public DataSet getAllResults(Result_tblDTO result_tbldto)
        {
            string approved = "YES";
            string query = "SELECT * FROM result_tbl WHERE student_id='" + result_tbldto.STUDENT_ID + "' and approved ='" + approved + "'";

            if (dbconnect.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, dbconnect.connection);

                mysqlAdapter = new MySqlDataAdapter(cmd);
                dataSet = new DataSet();
                mysqlAdapter.Fill(dataSet);

                dbconnect.CloseConnection();

                return dataSet;
            }
            else
            {
                return dataSet;
            }
        }

        public DataSet getAllUnapprovedResults(string course_id)
        {
            string approved = "NO";
            string query = "SELECT * FROM result_tbl WHERE  approved ='" + approved + "' and course_id ='" + course_id + "' ";

            if (dbconnect.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, dbconnect.connection);

                mysqlAdapter = new MySqlDataAdapter(cmd);
                dataSet = new DataSet();
                mysqlAdapter.Fill(dataSet);

                dbconnect.CloseConnection();

                return dataSet;
            }
            else
            {
                return dataSet;
            }
        }

        public void UploadResults(Result_tblDTO result_tbldto)
        {
            string approve = "NO";
            string query = "INSERT INTO result_tbl (quiz_number,attendance_number,final,number,grade,year,student_id,course_id,approved,semester) VALUES('" + result_tbldto.QUIZ_NO + "','"
                                                            + result_tbldto.ATTENDENCE_NO + "','"
                                                            + result_tbldto.FINAL + "','"
                                                            + result_tbldto.NUMBER + "','"
                                                            + result_tbldto.GRADE + "','"
                                                            + result_tbldto.YEAR + "','"
                                                            + result_tbldto.STUDENT_ID + "','"
                                                            + result_tbldto.COURSE_ID + "','"
                                                            + approve + "','"
                                                            + result_tbldto.SEMESTER + "')";

            //open connection
            if (dbconnect.OpenConnection() == true)
            {
                //create command and assign the query and connection from the constructor
                MySqlCommand cmd = new MySqlCommand(query, dbconnect.connection);

                //Execute command
                cmd.ExecuteNonQuery();

                //close connection
                dbconnect.CloseConnection();
            }
        }

        public void ApproveResults()
        {
            string approve = "NO";
            string approved = "YES";
            string query = "Update result_tbl set approved ='" + approved + "' where approved ='" + approve + "' ";

            //open connection
            if (dbconnect.OpenConnection() == true)
            {
                //create command and assign the query and connection from the constructor
                MySqlCommand cmd = new MySqlCommand(query, dbconnect.connection);

                //Execute command
                cmd.ExecuteNonQuery();

                //close connection
                dbconnect.CloseConnection();
            }
        }
    }
}