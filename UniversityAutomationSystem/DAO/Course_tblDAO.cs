using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MySql.Data.MySqlClient;
using UniversityAutomationSystem.DTO;
using System.Data;

namespace UniversityAutomationSystem.DAO
{
    public class Course_tblDAO
    {
        DBConnect dbconnect = new DBConnect();

        private MySqlDataAdapter mysqlAdapter;
        private DataSet dataSet;

        public Course_tblDAO()
        {

        }

        public DataSet getAllCourses(Course_tblDTO course_tbldto)
        {

            string query = "SELECT * FROM teacher_takes,course_tbl,teacher_tbl WHERE teacher_tbl.teacher_id=teacher_takes.teacher_id and teacher_takes.course_id=course_tbl.course_id and teacher_tbl.email='" + course_tbldto.EMAIL + "'";

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

        public DataSet getYearSem(Course_tblDTO course_tbldto)
        {

            string query = "select  * from student_takes WHERE course_id ='" + course_tbldto.COURSE_ID + "' and year ='" + course_tbldto.YEAR + "' and semester ='" + course_tbldto.SEMESTER + "'";
            //string query = "SELECT * from student_takes GROUP BY year";

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

        public DataSet getYear(Course_tblDTO course_tbldto)
        {

            //string query = "select distinct on year * from student_takes WHERE course_id ='" + course_tbldto.COURSE_ID + "'";
            string query = "SELECT * from student_takes GROUP BY year";

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

        public DataSet getSem(Course_tblDTO course_tbldto)
        {

            //string query = "select distinct on year * from student_takes WHERE course_id ='" + course_tbldto.COURSE_ID + "'";
            string query = "SELECT * from student_takes GROUP BY semester";

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

        public DataSet getStuId(Course_tblDTO course_tbldto)
        {

            string query = "SELECT * FROM student_takes WHERE year ='" + course_tbldto.YEAR + "' and semester ='" + course_tbldto.SEMESTER + "' and course_id ='" + course_tbldto.COURSE_ID + "'";

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

        public DataSet getallCourse()
        {

            string query = "SELECT * FROM course_tbl";

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

        public void AddtoStudent_takes(string stu_id, string course_id,string year,string sem)
        {

            string query = "INSERT INTO student_takes (student_id,course_id,year,semester) VALUES('" + stu_id + "','"
                                                            + course_id + "','"
                                                            + year + "','"
                                                           
                                                            + sem + "')";

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
        public void AddtoTeacher_takes(string stu_id, string course_id, string year, string sem)
        {

            string query = "INSERT INTO Teacher_takes (teacher_id,course_id,year,semester) VALUES('" + stu_id + "','"
                                                            + course_id + "','"
                                                            + year + "','"

                                                            + sem + "')";

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