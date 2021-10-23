namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class INSERT_TABLE : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Admin",
                c => new
                    {
                        AdminId = c.String(nullable: false, maxLength: 128),
                        AdminName = c.String(nullable: false, maxLength: 100),
                        Password = c.String(nullable: false, maxLength: 100, unicode: false),
                        Phone = c.String(nullable: false, maxLength: 10, unicode: false),
                        DateOfBirth = c.DateTime(nullable: false),
                        Gender = c.String(nullable: false, maxLength: 5),
                        Adress = c.String(nullable: false, maxLength: 100),
                        Email = c.String(nullable: false, maxLength: 100, unicode: false),
                    })
                .PrimaryKey(t => t.AdminId);
            
            CreateTable(
                "dbo.Classes",
                c => new
                    {
                        StudentClass = c.String(nullable: false, maxLength: 128),
                        Quantity = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.StudentClass);
            
            CreateTable(
                "dbo.Students",
                c => new
                    {
                        StudentID = c.Int(nullable: false, identity: false),
                        StudentName = c.String(name: "Student Name", nullable: false, maxLength: 100),
                        DateOfBirth = c.DateTime(nullable: false),
                        Gender = c.String(nullable: false, maxLength: 5),
                        Address = c.String(nullable: false, maxLength: 100),
                        Email = c.String(nullable: false, maxLength: 100),
                        Class = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.StudentID)
                .ForeignKey("dbo.Classes", t => t.Class)
                .Index(t => t.Class);
            
            CreateTable(
                "dbo.Points",
                c => new
                    {
                        StudentID = c.Int(nullable: false),
                        SubjectID = c.String(nullable: false, maxLength: 128),
                        Point = c.Single(nullable: false),
                        Block = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.StudentID, t.SubjectID })
                .ForeignKey("dbo.Subjects", t => t.SubjectID)
                .ForeignKey("dbo.Students", t => t.StudentID)
                .Index(t => t.StudentID)
                .Index(t => t.SubjectID);
            
            CreateTable(
                "dbo.Subjects",
                c => new
                    {
                        SubjectID = c.String(nullable: false, maxLength: 128),
                        SubjectName = c.String(nullable: false, maxLength: 100),
                    })
                .PrimaryKey(t => t.SubjectID);
            
            CreateTable(
                "dbo.TeachClass",
                c => new
                    {
                        TeacherID = c.Int(nullable: false),
                        SubjectID = c.String(nullable: false, maxLength: 128),
                        StudentClass = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.TeacherID, t.SubjectID, t.StudentClass })
                .ForeignKey("dbo.Teachers", t => t.TeacherID)
                .ForeignKey("dbo.Subjects", t => t.SubjectID)
                .ForeignKey("dbo.Classes", t => t.StudentClass)
                .Index(t => t.TeacherID)
                .Index(t => t.SubjectID)
                .Index(t => t.StudentClass);
            
            CreateTable(
                "dbo.Teachers",
                c => new
                    {
                        TeacherID = c.Int(nullable: false, identity: false),
                        TeacherName = c.String(nullable: false, maxLength: 100),
                        DateOfBirth = c.DateTime(nullable: false),
                        Gender = c.String(nullable: false, maxLength: 5),
                        Address = c.String(nullable: false, maxLength: 100),
                        Email = c.String(nullable: false),
                        Phone = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.TeacherID);
            
            CreateTable(
                "dbo.TeacherAccount",
                c => new
                    {
                        TeacherID = c.Int(nullable: false),
                        Password = c.String(nullable: false, maxLength: 100),
                    })
                .PrimaryKey(t => t.TeacherID)
                .ForeignKey("dbo.Teachers", t => t.TeacherID)
                .Index(t => t.TeacherID);
            
            CreateTable(
                "dbo.StudentAccount",
                c => new
                    {
                        StudentID = c.Int(nullable: false),
                        Password = c.String(nullable: false, maxLength: 100),
                    })
                .PrimaryKey(t => t.StudentID)
                .ForeignKey("dbo.Students", t => t.StudentID)
                .Index(t => t.StudentID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.TeachClass", "StudentClass", "dbo.Classes");
            DropForeignKey("dbo.Students", "Class", "dbo.Classes");
            DropForeignKey("dbo.StudentAccount", "StudentID", "dbo.Students");
            DropForeignKey("dbo.Points", "StudentID", "dbo.Students");
            DropForeignKey("dbo.TeachClass", "SubjectID", "dbo.Subjects");
            DropForeignKey("dbo.TeacherAccount", "TeacherID", "dbo.Teachers");
            DropForeignKey("dbo.TeachClass", "TeacherID", "dbo.Teachers");
            DropForeignKey("dbo.Points", "SubjectID", "dbo.Subjects");
            DropIndex("dbo.StudentAccount", new[] { "StudentID" });
            DropIndex("dbo.TeacherAccount", new[] { "TeacherID" });
            DropIndex("dbo.TeachClass", new[] { "StudentClass" });
            DropIndex("dbo.TeachClass", new[] { "SubjectID" });
            DropIndex("dbo.TeachClass", new[] { "TeacherID" });
            DropIndex("dbo.Points", new[] { "SubjectID" });
            DropIndex("dbo.Points", new[] { "StudentID" });
            DropIndex("dbo.Students", new[] { "Class" });
            DropTable("dbo.StudentAccount");
            DropTable("dbo.TeacherAccount");
            DropTable("dbo.Teachers");
            DropTable("dbo.TeachClass");
            DropTable("dbo.Subjects");
            DropTable("dbo.Points");
            DropTable("dbo.Students");
            DropTable("dbo.Classes");
            DropTable("dbo.Admin");
        }
    }
}
