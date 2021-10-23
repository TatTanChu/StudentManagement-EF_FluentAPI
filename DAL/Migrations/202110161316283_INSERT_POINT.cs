namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class INSERT_POINT : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Points VALUES(19110111, 'MH01', 0, 0)");
            Sql("INSERT INTO Points VALUES(19110112, 'MH01', 0, 0)");
            Sql("INSERT INTO Points VALUES(19110113, 'MH01', 0, 0)");
            Sql("INSERT INTO Points VALUES(19110114, 'MH01', 0, 0)");
            Sql("INSERT INTO Points VALUES(19110115, 'MH01', 0, 0)");
            Sql("INSERT INTO Points VALUES(19110116, 'MH01', 0, 0)");
            Sql("INSERT INTO Points VALUES(19110117, 'MH01', 0, 0)");
            Sql("INSERT INTO Points VALUES(19110118, 'MH01', 0, 0)");

            Sql("INSERT INTO Points VALUES(19110111, 'MH02', 0, 0)");
            Sql("INSERT INTO Points VALUES(19110112, 'MH02', 0, 0)");
            Sql("INSERT INTO Points VALUES(19110113, 'MH02', 0, 0)");
            Sql("INSERT INTO Points VALUES(19110114, 'MH02', 0, 0)");
            Sql("INSERT INTO Points VALUES(19110115, 'MH02', 0, 0)");
            Sql("INSERT INTO Points VALUES(19110116, 'MH02', 0, 0)");
            Sql("INSERT INTO Points VALUES(19110117, 'MH02', 0, 0)");
            Sql("INSERT INTO Points VALUES(19110118, 'MH02', 0, 0)");

            Sql("INSERT INTO Points VALUES(19110111, 'MH03', 0, 0)");
            Sql("INSERT INTO Points VALUES(19110112, 'MH03', 0, 0)");
            Sql("INSERT INTO Points VALUES(19110113, 'MH03', 0, 0)");
            Sql("INSERT INTO Points VALUES(19110114, 'MH03', 0, 0)");
            Sql("INSERT INTO Points VALUES(19110115, 'MH03', 0, 0)");
            Sql("INSERT INTO Points VALUES(19110116, 'MH03', 0, 0)");
            Sql("INSERT INTO Points VALUES(19110117, 'MH03', 0, 0)");
            Sql("INSERT INTO Points VALUES(19110118, 'MH03', 0, 0)");

            Sql("INSERT INTO Points VALUES(19110111, 'MH04', 0, 0)");
            Sql("INSERT INTO Points VALUES(19110112, 'MH04', 0, 0)");
            Sql("INSERT INTO Points VALUES(19110113, 'MH04', 0, 0)");
            Sql("INSERT INTO Points VALUES(19110114, 'MH04', 0, 0)");
            Sql("INSERT INTO Points VALUES(19110115, 'MH04', 0, 0)");
            Sql("INSERT INTO Points VALUES(19110116, 'MH04', 0, 0)");
            Sql("INSERT INTO Points VALUES(19110117, 'MH04', 0, 0)");
            Sql("INSERT INTO Points VALUES(19110118, 'MH04', 0, 0)");
        }
        
        public override void Down()
        {
        }
    }
}
