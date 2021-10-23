namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class INSERT_TEACHER_ACCOUNT : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO TeacherAccount VALUES(100001, '123')");
            Sql("INSERT INTO TeacherAccount VALUES(100002, '123')");
            Sql("INSERT INTO TeacherAccount VALUES(100003, '123')");
            Sql("INSERT INTO TeacherAccount VALUES(100004, '123')");
        }
        
        public override void Down()
        {
        }
    }
}
