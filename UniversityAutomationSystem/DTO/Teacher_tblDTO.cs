using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UniversityAutomationSystem.DTO
{
    public class Teacher_tblDTO
    {
        private string name, teacher_email, password, department_id;

        public Teacher_tblDTO(string teacher_email, string password)
        {
            this.teacher_email = teacher_email;
            this.password = password;
        }

        public Teacher_tblDTO(string teacher_email)
        {
            this.teacher_email = teacher_email;
        }

        public string TEACHER_EMAIL
        {
            get { return teacher_email; }
            set { teacher_email = value; }
        }
        public string PASSWORD
        {
            get { return password; }
            set { password = value; }
        }
    }
}