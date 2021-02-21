namespace CodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateCategoriesTable : DbMigration
    {
        public override void Up()
        {
            Sql("Insert into Categories (Name) Values ('Web Programming')");
            Sql("Insert into Categories (Name) Values ('Design')");
        }
        
        public override void Down()
        {
        }
    }
}
