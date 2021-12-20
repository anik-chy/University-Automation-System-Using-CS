using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UniversityAutomationSystem.DTO
{
    public class Result_tblDTO
    {
        private string quiz_number, attendence_number, final, number, grade, year, student_id, course_id, semester;

        public Result_tblDTO(string student_id)
        {
            this.student_id = student_id;
        }

        public Result_tblDTO(string qn, string an, string f, string n, string g, string y, string student_id,string ci,string sem)
        {
            this.student_id = student_id;
            this.quiz_number = qn;
            this.attendence_number = an;
            this.final = f;
            this.number = n;
            this.grade = g;
            this.year = y;
            this.course_id = ci;
            this.semester = sem;     
            
        }


        public string STUDENT_ID
        {
            get { return student_id; }
            set { student_id = value; }
        }
        public string QUIZ_NO
        {
            get { return quiz_number; }
            set { quiz_number = value; }
        }
        public string ATTENDENCE_NO
        {
            get { return attendence_number; }
            set { attendence_number = value; }
        }
        public string FINAL
        {
            get { return final; }
            set { final = value; }
        }
        public string NUMBER
        {
            get { return number; }
            set { number = value; }
        }
        public string GRADE
        {
            get { return grade; }
            set { grade = value; }
        }
        public string YEAR
        {
            get { return year; }
            set { year = value; }
        }
        public string COURSE_ID
        {
            get { return course_id; }
            set { course_id = value; }
        }
        public string SEMESTER
        {
            get { return semester; }
            set { semester = value; }
        }
    }
}