using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CourseManagementSystem.Models
{
    public class Student
    {
        public int StudentId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public Address Address { get; set; }

        public int? StandardId { get; set; }
        public Standard Standard { get; set; }

        public ICollection<Course> Courses { get; set; }
    }
}