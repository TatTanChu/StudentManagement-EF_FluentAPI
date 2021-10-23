namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class INSERT_ADMIN : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Admin VALUES('tatchu', 'Tất Tân Chu', '123', '0368372526', '20010901', 'Nam', 'TPHCM', 'tatchu6878@gmail.com')");
        }
        
        public override void Down()
        {
        }
    }
}
