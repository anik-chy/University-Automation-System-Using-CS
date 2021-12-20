using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MySql.Data.MySqlClient;
using UniversityAutomationSystem.DTO;
using System.Data;

namespace UniversityAutomationSystem.DAO
{
    public class Teacher_tblDAO
    {
        DBConnect dbconnect = new DBConnect();

        private MySqlDataAdapter mysqlAdapter;
        private DataSet dataSet;

        public Teacher_tblDAO()
        {

        }

        public int GetLoginInfo(Teacher_tblDTO teacher_tbldto)
        {
            string query = "SELECT Count(*) FROM teacher_tbl WHERE email='" + teacher_tbldto.TEACHER_EMAIL + "' AND password='" + teacher_tbldto.PASSWORD + "'";
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

        public DataSet getSingleTeacher(Teacher_tblDTO teacher_tbldto)
        {

            string query = "SELECT * FROM teacher_tbl WHERE email='" + teacher_tbldto.TEACHER_EMAIL + "'";

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

        public DataSet getAllTeachers()
        {

            string query = "SELECT * FROM teacher_tbl";

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

        public void DeleteTeacher(string stu_id)
        {

            string query = "DELETE  FROM teacher_tbl where teacher_id = '" + stu_id + "'";

            if (dbconnect.OpenConnection() == true)
            {
                //create command and assign the query and connection from the constructor
                MySqlCommand cmd = new MySqlCommand(query, dbconnect.connection);

                //Execute command
                cmd.ExecuteNonQuery();

                //close connection
                dbconnect.CloseConnection();
            }

            string query2 = "DELETE  FROM teacher_takes where teacher_id = '" + stu_id + "'";

            if (dbconnect.OpenConnection() == true)
            {
                //create command and assign the query and connection from the constructor
                MySqlCommand cmd = new MySqlCommand(query2, dbconnect.connection);

                //Execute command
                cmd.ExecuteNonQuery();

                //close connection
                dbconnect.CloseConnection();
            }

        }

        public void AddTeacher(string name,string password,string email,string dep_id)
        {
            
            string query = "INSERT INTO teacher_tbl (name,password,email,department_id) VALUES('" + name + "','"
                                                            + password + "','"
                                                            + email + "','" 
                                                            + dep_id + "')";

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