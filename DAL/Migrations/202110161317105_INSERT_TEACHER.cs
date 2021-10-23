namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class INSERT_TEACHER : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Teachers VALUES(100001, 'Dinh Cong A', '19700215', 'Nam', 'TPHCM', '100001@teacher', 0123456789)");
            Sql("INSERT INTO Teachers VALUES(100002, 'Dinh Cong B', '19740331', 'Nam', 'TPHCM', '100002@teacher', 0159357258)");
            Sql("INSERT INTO Teachers VALUES(100003, 'Nguyen Thi Kim A', '19710515', 'Nu', 'TPHCM', '100003@teacher', 0951753456)");
            Sql("INSERT INTO Teachers VALUES(100004, 'Dinh Cong C', '19691102', 'Nam', 'TPHCM', '100004@teacher', 0123789852)");
        }

        public override void Down()
        {
        }
    }
}
