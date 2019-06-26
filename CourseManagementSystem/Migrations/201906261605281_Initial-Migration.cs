namespace CourseManagementSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Addresses",
                c => new
                    {
                        AddressId = c.Int(nullable: false),
                        Address1 = c.String(),
                        Address2 = c.String(),
                        City = c.String(),
                        State = c.String(),
                    })
                .PrimaryKey(t => t.AddressId)
                .ForeignKey("dbo.Students", t => t.AddressId)
                .Index(t => t.AddressId);
            
            CreateTable(
                "dbo.Students",
                c => new
                    {
                        StudentId = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                        StandardId = c.Int(),
                    })
                .PrimaryKey(t => t.StudentId)
                .ForeignKey("dbo.Standards", t => t.StandardId)
                .Index(t => t.StandardId);
            
            CreateTable(
                "dbo.Courses",
                c => new
                    {
                        CourseId = c.Int(nullable: false, identity: true),
                        CourseName = c.String(),
                        Location = c.String(),
                        TeacherId = c.Int(),
                    })
                .PrimaryKey(t => t.CourseId)
                .ForeignKey("dbo.Teachers", t => t.TeacherId)
                .Index(t => t.TeacherId);
            
            CreateTable(
                "dbo.Teachers",
                c => new
                    {
                        TeacherId = c.Int(nullable: false, identity: true),
                        TeacherName = c.String(),
                        StandardId = c.Int(),
                    })
                .PrimaryKey(t => t.TeacherId)
                .ForeignKey("dbo.Standards", t => t.StandardId)
                .Index(t => t.StandardId);
            
            CreateTable(
                "dbo.Standards",
                c => new
                    {
                        StandardId = c.Int(nullable: false, identity: true),
                        StandardName = c.String(),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.StandardId);
            
            CreateTable(
                "dbo.CourseStudents",
                c => new
                    {
                        Course_CourseId = c.Int(nullable: false),
                        Student_StudentId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Course_CourseId, t.Student_StudentId })
                .ForeignKey("dbo.Courses", t => t.Course_CourseId, cascadeDelete: true)
                .ForeignKey("dbo.Students", t => t.Student_StudentId, cascadeDelete: true)
                .Index(t => t.Course_CourseId)
                .Index(t => t.Student_StudentId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Addresses", "AddressId", "dbo.Students");
            DropForeignKey("dbo.Teachers", "StandardId", "dbo.Standards");
            DropForeignKey("dbo.Students", "StandardId", "dbo.Standards");
            DropForeignKey("dbo.Courses", "TeacherId", "dbo.Teachers");
            DropForeignKey("dbo.CourseStudents", "Student_StudentId", "dbo.Students");
            DropForeignKey("dbo.CourseStudents", "Course_CourseId", "dbo.Courses");
            DropIndex("dbo.CourseStudents", new[] { "Student_StudentId" });
            DropIndex("dbo.CourseStudents", new[] { "Course_CourseId" });
            DropIndex("dbo.Teachers", new[] { "StandardId" });
            DropIndex("dbo.Courses", new[] { "TeacherId" });
            DropIndex("dbo.Students", new[] { "StandardId" });
            DropIndex("dbo.Addresses", new[] { "AddressId" });
            DropTable("dbo.CourseStudents");
            DropTable("dbo.Standards");
            DropTable("dbo.Teachers");
            DropTable("dbo.Courses");
            DropTable("dbo.Students");
            DropTable("dbo.Addresses");
        }
    }
}
