using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CourseManagementSystem.Models
{
    public class Teacher
    {
        public int TeacherId { get; set; }
        public string TeacherName { get; set; }

        public int? StandardId { get; set; }
        public Standard Standard { get; set; }

        public ICollection<Course> Courses { get; set; }
    }
}