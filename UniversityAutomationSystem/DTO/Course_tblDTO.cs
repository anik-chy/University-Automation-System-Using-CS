using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UniversityAutomationSystem.DTO
{
    public class Course_tblDTO
    {
        private string email,course_id,year,sem;

        public Course_tblDTO(string email)
        {
            this.email = email;
        }

        public Course_tblDTO(string course_id,string s)
        {
            this.course_id = course_id;
        }

        public Course_tblDTO(string year, string sem,string course_id)
        {
            this.year = year;
            this.sem = sem;
            this.course_id = course_id;
        }


        public string EMAIL
        {
            get { return email; }
            set { email = value; }
        }

        public string COURSE_ID
        {
            get { return course_id; }
            set { course_id = value; }
        }

        public string YEAR
        {
            get { return year; }
            set { year = value; }
        }

        public string SEMESTER
        {
            get { return sem; }
            set { sem = value; }
        }
    }
}