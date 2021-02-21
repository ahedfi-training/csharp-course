namespace CodeFirstWithExistingDB.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class foo : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Courses", "Level");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Courses", "Level", c => c.Byte(nullable: false));
        }
    }
}
