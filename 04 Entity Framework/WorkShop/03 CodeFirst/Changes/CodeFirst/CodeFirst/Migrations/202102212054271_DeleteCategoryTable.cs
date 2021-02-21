namespace CodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DeleteCategoryTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                 "dbo._Categories",
                 c => new
                 {
                     Id = c.Int(nullable: false, identity: true),
                     Name = c.String(),
                 })
                 .PrimaryKey(t => t.Id);

            Sql("INSERT INTO _CATEGORIES (NAME) SELECT NAME FROM CATEGORIES");

            DropTable("dbo.Categories");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);

            Sql("INSERT INTO CATEGORIES  (NAME) SELECT NAME FROM _CATEGORIES");

            DropTable("dbo._CATEGORIES");

        }
    }
}
