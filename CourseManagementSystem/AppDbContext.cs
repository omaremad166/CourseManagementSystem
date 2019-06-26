using CourseManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CourseManagementSystem
{
    public class AppDbContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Standard> Standards { get; set; }

        public AppDbContext()
        {

        }
    }
}