using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MySql.Data.MySqlClient;
using UniversityAutomationSystem.DTO;
using System.Data;

namespace UniversityAutomationSystem.DAO
{
    public class Student_tblDAO
    {
        DBConnect dbconnect = new DBConnect();

        private MySqlDataAdapter mysqlAdapter;
        private DataSet dataSet;

        public Student_tblDAO()
        {

        }

        public int GetLoginInfo(Student_tblDTO student_tbldto)
        {
            string query = "SELECT Count(*) FROM student_tbl WHERE student_id='" + student_tbldto.STUDENT_ID + "' AND password='" + student_tbldto.PASSWORD + "'";
            int count = -1;

            if (dbconnect.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, dbconnect.connection);
                count = int.Parse(cmd.ExecuteScalar() + "");

                dbconnect.CloseConnection();

                return count;
            }
            else
            {
                return count;
            }
        }

        public int GetLoginInfoAdmin(string username,string password)
        {
            string query = "SELECT Count(*) FROM admin_tbl WHERE admin_id='" + username + "' AND password='" + password + "'";
            int count = -1;

            if (dbconnect.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, dbconnect.connection);
                count = int.Parse(cmd.ExecuteScalar() + "");

                dbconnect.CloseConnection();

                return count;
            }
            else
            {
                return count;
            }
        }

        public DataSet getSingleStudent(Student_tblDTO student_tbldto)
        {

            string query = "SELECT * FROM student_tbl WHERE student_id='" + student_tbldto.STUDENT_ID + "'";

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

        public DataSet getAllStudents()
        {

            string query = "SELECT * FROM student_tbl";

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

        public void DeleteStudent(string stu_id)
        {

            string query = "DELETE  FROM student_tbl where student_id = '" + stu_id + "'";

            if (dbconnect.OpenConnection() == true)
            {
                //create command and assign the query and connection from the constructor
                MySqlCommand cmd = new MySqlCommand(query, dbconnect.connection);

                //Execute command
                cmd.ExecuteNonQuery();

                //close connection
                dbconnect.CloseConnection();
            }

            string query2 = "DELETE  FROM student_takes where student_id = '" + stu_id + "'";

            if (dbconnect.OpenConnection() == true)
            {
                //create command and assign the query and connection from the constructor
                MySqlCommand cmd = new MySqlCommand(query2, dbconnect.connection);

                //Execute command
                cmd.ExecuteNonQuery();

                //close connection
                dbconnect.CloseConnection();
            }

            string query3 = "DELETE  FROM result_tbl where student_id = '" + stu_id + "'";

            if (dbconnect.OpenConnection() == true)
            {
                //create command and assign the query and connection from the constructor
                MySqlCommand cmd = new MySqlCommand(query3, dbconnect.connection);

                //Execute command
                cmd.ExecuteNonQuery();

                //close connection
                dbconnect.CloseConnection();
            }

        }

        public DataSet getallDep()
        {

            string query = "SELECT * FROM department_tbl";

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

        public void AddStudent(string s,string ss,string dep_id,string email,string tc,string stu_id,string year,string sem,string password,string name)
        {
            
            string query = "INSERT INTO student_tbl (sec,sub_sec,department_id,email,total_credit,student_id,year,semester,password,name) VALUES('" + s + "','"
                                                            + ss + "','"
                                                            + dep_id + "','"
                                                            + email + "','"
                                                            + tc + "','"
                                                            + stu_id + "','"
                                                            + year + "','"
                                                            + sem + "','"
                                                            + password + "','"
                                                            + name + "')";

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