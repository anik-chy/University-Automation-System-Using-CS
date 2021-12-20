using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UniversityAutomationSystem.DTO
{
    public class Student_tblDTO
    {

        private string name, email, password,student_id;

        public Student_tblDTO(string student_id, string password)
        {
            this.student_id = student_id;
            this.password = password;
        }

        public Student_tblDTO(string student_id)
        {
            this.student_id = student_id;
        }

        public string STUDENT_ID
        {
            get { return student_id; }
            set { student_id = value; }
        }
        public string PASSWORD
        {
            get { return password; }
            set { password = value; }
        }
    }
}