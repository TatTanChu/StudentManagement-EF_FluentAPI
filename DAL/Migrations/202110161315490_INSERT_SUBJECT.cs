namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class INSERT_SUBJECT : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Subjects VALUES('MH01', 'Lap Trinh Window')");
            Sql("INSERT INTO Subjects VALUES('MH02', 'Lap Trinh Web')");
            Sql("INSERT INTO Subjects VALUES('MH03', 'Internet Van Vat (Iot)')");
            Sql("INSERT INTO Subjects VALUES('MH04', 'Nhap mon lap trinh')");
        }
        
        public override void Down()
        {
        }
    }
}
