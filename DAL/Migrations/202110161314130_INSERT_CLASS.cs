namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class INSERT_CLASS : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO dbo.Classes VALUES ('01CLC', 40)");
            Sql("INSERT INTO dbo.CLasses VALUES ('02CLC', 45)");
            Sql("INSERT INTO dbo.Classes VALUES ('03CLC', 40)");
        }
        
        public override void Down()
        {
        }
    }
}
