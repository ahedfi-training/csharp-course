namespace CodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RenameTitleColumnToNameIntoCourseTable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Courses", "Name", c => c.String());
            Sql("UPDATE dbo.Courses SET NAME = TITLE");
            DropColumn("dbo.Courses", "Title");
            //RenameColumn("dbo.Courses", "Title", "Name");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Courses", "Title", c => c.String());
            Sql("UPDATE dbo.Courses SET TITLE= NAME");
            DropColumn("dbo.Courses", "Name");
            //RenameColumn("dbo.Courses", "Name", "Title");
        }
    }
}
