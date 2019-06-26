using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CourseManagementSystem.Models
{
    public class Course
    {
        public int CourseId { get; set; }
        public string CourseName { get; set; }
        public string Location { get; set; }

        public int? TeacherId { get; set; }
        public Teacher Teacher { get; set; }

        public ICollection<Student> Students { get; set; }
    }
}