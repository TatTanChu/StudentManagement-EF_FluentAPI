using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Core.Objects;
using System.Data.Entity.Infrastructure;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DTO.Model;

namespace DAL
{
    public class DAL_DbContext : DbContext 
    {
        //CREATE CONNECTION TO SQL SERVER : 
        public DAL_DbContext() : base("connString")
        {
            var ensureDLLIsCopied = System.Data.Entity.SqlServer.SqlProviderServices.Instance;
        }

        //CREATE TABLES IN VISUAL STUDIO :
        public virtual DbSet<DTO_Class> Classes { get; set; }
        public virtual DbSet<DTO_Student> Students { get; set; }
        public virtual DbSet<DTO_Subject> Subjects { get; set; }
        public virtual DbSet<DTO_Teacher> Teachers { get; set; }
        public virtual DbSet<DTO_Point> Points { get; set; }
        public virtual DbSet<DTO_TeachClass> TeachClasses { get; set; }
        public virtual DbSet<DTO_StudentAccount> StudentAcccounts { get; set; }
        public virtual DbSet<DTO_TeacherAccount> TeacherAccount { get; set; }
        public virtual DbSet<DTO_Admin> Admins { get; set; }

        //CREATE TABLE CONTENT : 
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            /*========================================================================================================================*/

            // CLASS TABLE : 
            modelBuilder.Entity<DTO_Class>().ToTable("Classes");
            modelBuilder.Entity<DTO_Class>().HasKey(c => c.StudentClass);
            modelBuilder.Entity<DTO_Class>().Property(c => c.Quantity).IsRequired();

            /*==========================================================================================================================*/

            // STUDENT TABLE : 
            modelBuilder.Entity<DTO_Student>().ToTable("Students");
            modelBuilder.Entity<DTO_Student>().HasKey(s => s.StudentID);
            modelBuilder.Entity<DTO_Student>().Property(s => s.StudentName).HasColumnName("Student Name").HasColumnType("NVARCHAR").HasMaxLength(100).IsRequired();
            modelBuilder.Entity<DTO_Student>().Property(s => s.Gender).HasColumnType("NVARCHAR").HasColumnName("Gender").HasMaxLength(5).IsRequired();
            modelBuilder.Entity<DTO_Student>().Property(s => s.DateOfBirth).HasColumnName("DateOfBirth").IsRequired();
            modelBuilder.Entity<DTO_Student>().Property(s => s.Address).HasColumnType("NVARCHAR").HasColumnName("Address").HasMaxLength(100).IsRequired();
            modelBuilder.Entity<DTO_Student>().Property(s => s.Email).HasColumnType("NVARCHAR").HasColumnName("Email").HasMaxLength(100).IsRequired();

            //RELATIONSHIP OF STUDENT TABLE : 
            // ONE TO MANY : (ONE CLASS HAS MANY STUDENTS) : 
            modelBuilder.Entity<DTO_Class>().HasMany(c => c.Students).WithRequired(s => s._Class).HasForeignKey(s => s.Class).WillCascadeOnDelete(false);

            /*==========================================================================================================================*/

            //TEACHER TABLE : 
            modelBuilder.Entity<DTO_Teacher>().ToTable("Teachers");
            modelBuilder.Entity<DTO_Teacher>().HasKey(t => t.TeacherID);
            modelBuilder.Entity<DTO_Teacher>().Property(t => t.TeacherName).HasMaxLength(100).IsRequired();
            modelBuilder.Entity<DTO_Teacher>().Property(t => t.Gender).HasMaxLength(5).IsRequired();
            modelBuilder.Entity<DTO_Teacher>().Property(t => t.DateOfBirth).IsRequired();
            modelBuilder.Entity<DTO_Teacher>().Property(t => t.Address).HasMaxLength(100).IsRequired();
            modelBuilder.Entity<DTO_Teacher>().Property(t => t.Phone).IsRequired();
            modelBuilder.Entity<DTO_Teacher>().Property(t => t.Email).IsRequired();

            /*==========================================================================================================================*/

            //SUBJECT TABLE : 
            modelBuilder.Entity<DTO_Subject>().ToTable("Subjects");
            modelBuilder.Entity<DTO_Subject>().HasKey(s => s.SubjectID);
            modelBuilder.Entity<DTO_Subject>().Property(s => s.SubjectName).HasMaxLength(100).IsRequired();

            /*==========================================================================================================================*/

            //POINT TABLE : 
            modelBuilder.Entity<DTO_Point>().ToTable("Points");
            modelBuilder.Entity<DTO_Point>().HasKey(p => new { p.StudentID, p.SubjectID });
            modelBuilder.Entity<DTO_Point>().Property(p => p.Point).IsRequired();
            modelBuilder.Entity<DTO_Point>().Property(p => p.Block).IsRequired();
            //RELATIONSHIP OF POINT TABLE : 
                //ONE TO MANY : (ONE STUDENT HAS MANY POINTS)
            modelBuilder.Entity<DTO_Student>().HasMany(s => s.Points).WithRequired(p => p.Student).HasForeignKey(p => p.StudentID).WillCascadeOnDelete(false);
                //ONE TO MANY : (ONE SUBJECT HAS MANY POINTS)
            modelBuilder.Entity<DTO_Subject>().HasMany(s => s.Points).WithRequired(p => p.Subject).HasForeignKey(p => p.SubjectID).WillCascadeOnDelete(false);

            /*==========================================================================================================================*/

            //TEACH CLASS TABLE : THE RESULT OF MANY TO MANY MAPPING 
            modelBuilder.Entity<DTO_TeachClass>().ToTable("TeachClass");
            modelBuilder.Entity<DTO_TeachClass>().HasKey(t => new { t.TeacherID, t.SubjectID, t.StudentClass });
                //ONE TO MANY : TEACHER 
            modelBuilder.Entity<DTO_Teacher>().HasMany(t => t.TeachClasses).WithRequired(teachClass => teachClass.Teacher).HasForeignKey(teachClass => teachClass.TeacherID).WillCascadeOnDelete(false);
                //ONE TO MANY : CLASS 
            modelBuilder.Entity<DTO_Class>().HasMany(c => c.TeachClasses).WithRequired(teachClass => teachClass.Class).HasForeignKey(teachClass => teachClass.StudentClass).WillCascadeOnDelete(false);
                //ONE TO MANY : SUBJECT
            modelBuilder.Entity<DTO_Subject>().HasMany(s => s.TeachClasses).WithRequired(teachClass => teachClass.Subject).HasForeignKey(teachClass => teachClass.SubjectID).WillCascadeOnDelete(false);

            /*==========================================================================================================================*/

            //STUDENT ACCOUNT TABLE : THE RESULT OF ONE TO ONE  
            modelBuilder.Entity<DTO_StudentAccount>().ToTable("StudentAccount");
            modelBuilder.Entity<DTO_StudentAccount>().HasKey(s => s.StudentID);
            modelBuilder.Entity<DTO_StudentAccount>().Property(s => s.Password).HasMaxLength(100).IsRequired();
                //ONE TO ONE : STUDENT 
            modelBuilder.Entity<DTO_Student>().HasOptional(s => s.StudentAccount).WithRequired(studentAcccount => studentAcccount.Student);

            /*==========================================================================================================================*/

            //TEACHER ACCOUNT TABLE : THE RESULT OF ONE TO ONE  
            modelBuilder.Entity<DTO_TeacherAccount>().ToTable("TeacherAccount");
            modelBuilder.Entity<DTO_TeacherAccount>().HasKey(t => t.TeacherID);
            modelBuilder.Entity<DTO_TeacherAccount>().Property(t => t.Password).HasMaxLength(100).IsRequired();
                //ONE TO ONE : TEACHER 
            modelBuilder.Entity<DTO_Teacher>().HasOptional(t => t.TeacherAccount).WithRequired(teacherAcccount => teacherAcccount.Teacher);
            
            /*==========================================================================================================================*/

            //ADMIN TABLE
            modelBuilder.Entity<DTO_Admin>().ToTable("Admin");
            modelBuilder.Entity<DTO_Admin>().HasKey(a => a.AdminId);
            modelBuilder.Entity<DTO_Admin>().Property(a => a.Password).HasColumnType("VARCHAR").HasColumnName("Password").HasMaxLength(100).IsRequired();
            modelBuilder.Entity<DTO_Admin>().Property(a => a.AdminName).HasColumnName("AdminName").HasColumnType("NVARCHAR").HasMaxLength(100).IsRequired();
            modelBuilder.Entity<DTO_Admin>().Property(a => a.Gender).HasColumnType("NVARCHAR").HasColumnName("Gender").HasMaxLength(5).IsRequired();
            modelBuilder.Entity<DTO_Admin>().Property(a => a.DateOfBirth).HasColumnName("DateOfBirth").IsRequired();
            modelBuilder.Entity<DTO_Admin>().Property(a => a.Phone).HasColumnType("VARCHAR").HasColumnName("Phone").HasMaxLength(10).IsRequired();
            modelBuilder.Entity<DTO_Admin>().Property(a => a.Email).HasColumnName("Email").HasColumnType("VARCHAR").HasMaxLength(100).IsRequired();
            modelBuilder.Entity<DTO_Admin>().Property(a => a.Address).HasColumnName("Adress").HasColumnType("NVARCHAR").HasMaxLength(100).IsRequired();

            /*==============================================================(STORE PROCEDURE)============================================================*/
            //CUD FOR STUDENT : 

            /*==============================================================(EXECUTE COMMAND)============================================================*/
        }
    }
}
