namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class INSERT_STUDENT : DbMigration
    {
        public override void Up()
        {
            //CLASS 1 :
            Sql("INSERT INTO Students VALUES(19110111, 'Nguyen Van A', '20011212', 'Nam', 'TPHCM', '19110111@student', '01CLC')");
            Sql("INSERT INTO Students VALUES(19110112, 'Nguyen Van B', '20010115', 'Nam', 'TPHCM', '19110112@student', '01CLC')");
            Sql("INSERT INTO Students VALUES(19110113, 'Tran Thi A', '20010206', 'Nu', 'Ben Tre', '19110113@student', '01CLC')");
            Sql("INSERT INTO Students VALUES(19110114, 'Nguyen Van C', '20011214', 'Nam', 'Binh Dinh', '19110114@student', '01CLC')");
            Sql("INSERT INTO Students VALUES(19110115, 'Le Van A', '20010514', 'Nam', '	Dong Nai', '19110115@student', '01CLC')");
            Sql("INSERT INTO Students VALUES(19110116, 'Nguyen Van D', '20010312', 'Nam', 'Ben Tre', '19110116@student', '01CLC')");
            Sql("INSERT INTO Students VALUES(19110117, 'Tran Thi B', '20010807', 'Nu', 'Quang Ngai', '19110117@student', '01CLC')");
            Sql("INSERT INTO Students VALUES(19110118, 'Le Van C', '20010610', 'Nam', 'Ha Noi', '19110118@student', '01CLC')");

            //CLASS 2 : 
            Sql("INSERT INTO Students VALUES(19110119, 'Nguyen Van D', '20011212', 'Nam', 'TPHCM', '19110119@student', '02CLC')");
            Sql("INSERT INTO Students VALUES(19110120, 'Nguyen Van F', '20010115', 'Nam', 'TPHCM', '19110120@student', '02CLC')");
            Sql("INSERT INTO Students VALUES(19110121, 'Tran Thi H', '20010206', 'Nu', 'Ben Tre', '19110121@student', '02CLC')");
            Sql("INSERT INTO Students VALUES(19110122, 'Nguyen Van K', '20011214', 'Nam', 'Binh Dinh', '19110122@student', '02CLC')");
            Sql("INSERT INTO Students VALUES(19110123, 'Le Van T', '20010514', 'Nam', '	Dong Nai', '19110123@student', '02CLC')");
            Sql("INSERT INTO Students VALUES(19110124, 'Nguyen Van O', '20010312', 'Nam', 'Ben Tre', '19110124@student', '02CLC')");
            Sql("INSERT INTO Students VALUES(19110125, 'Tran Thi B', '20010807', 'Nu', 'Quang Ngai', '19110125@student', '02CLC')");
            Sql("INSERT INTO Students VALUES(19110126, 'Le Van C', '20010610', 'Nam', 'Ha Noi', '19110126@student', '02CLC')");

            //CLASS 3 : 
            Sql("INSERT INTO Students VALUES(19110127, 'Nguyen Van A', '20011212', 'Nam', 'TPHCM', '19110127@student', '03CLC')");
            Sql("INSERT INTO Students VALUES(19110128, 'Nguyen Van B', '20010115', 'Nam', 'TPHCM', '19110128@student', '03CLC')");
            Sql("INSERT INTO Students VALUES(19110129, 'Tran Thi A', '20010206', 'Nu', 'Ben Tre', '19110129@student', '03CLC')");
            Sql("INSERT INTO Students VALUES(19110130, 'Nguyen Van C', '20011214', 'Nam', 'Binh Dinh', '19110130@student', '03CLC')");
            Sql("INSERT INTO Students VALUES(19110131, 'Le Van A', '20010514', 'Nam', '	Dong Nai', '19110131@student', '03CLC')");
            Sql("INSERT INTO Students VALUES(19110132, 'Nguyen Van D', '20010312', 'Nam', 'Ben Tre', '19110132@student', '03CLC')");
            Sql("INSERT INTO Students VALUES(19110133, 'Tran Thi B', '20010807', 'Nu', 'Quang Ngai', '19110133@student', '03CLC')");
            Sql("INSERT INTO Students VALUES(19110134, 'Le Van C', '20010610', 'Nam', 'Ha Noi', '19110134@student', '03CLC')");

        }

        public override void Down()
        {
        }
    }
}
