namespace CodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class foo : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.Courses", name: "AuthorId", newName: "AuthId");
            RenameIndex(table: "dbo.Courses", name: "IX_AuthorId", newName: "IX_AuthId");
        }
        
        public override void Down()
        {
            RenameIndex(table: "dbo.Courses", name: "IX_AuthId", newName: "IX_AuthorId");
            RenameColumn(table: "dbo.Courses", name: "AuthId", newName: "AuthorId");
        }
    }
}
