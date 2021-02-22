namespace CodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ApplyDefaultConventions : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Courses", "AuthorId", "dbo.Authors");
            DropIndex("dbo.Courses", new[] { "AuthorId" });
            RenameColumn(table: "dbo.Courses", name: "AuthorId", newName: "Author_Id");
            AlterColumn("dbo.Courses", "Description", c => c.String());
            AlterColumn("dbo.Courses", "Author_Id", c => c.Int());
            CreateIndex("dbo.Courses", "Author_Id");
            AddForeignKey("dbo.Courses", "Author_Id", "dbo.Authors", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Courses", "Author_Id", "dbo.Authors");
            DropIndex("dbo.Courses", new[] { "Author_Id" });
            AlterColumn("dbo.Courses", "Author_Id", c => c.Int(nullable: false));
            AlterColumn("dbo.Courses", "Description", c => c.String(nullable: false, maxLength: 255));
            RenameColumn(table: "dbo.Courses", name: "Author_Id", newName: "AuthorId");
            CreateIndex("dbo.Courses", "AuthorId");
            AddForeignKey("dbo.Courses", "AuthorId", "dbo.Authors", "Id", cascadeDelete: true);
        }
    }
}
