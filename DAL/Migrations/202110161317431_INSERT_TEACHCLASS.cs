namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class INSERT_TEACHCLASS : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO TeachClass VALUES(100001, 'MH01', '01CLC')");
            Sql("INSERT INTO TeachClass VALUES(100001, 'MH02', '02CLC')");
            Sql("INSERT INTO TeachClass VALUES(100001, 'MH03', '03CLC')");
            Sql("INSERT INTO TeachClass VALUES(100002, 'MH02', '01CLC')");
            Sql("INSERT INTO TeachClass VALUES(100003, 'MH03', '01CLC')");
            Sql("INSERT INTO TeachClass VALUES(100004, 'MH04', '01CLC')");
        }
        
        public override void Down()
        {
        }
    }
}
