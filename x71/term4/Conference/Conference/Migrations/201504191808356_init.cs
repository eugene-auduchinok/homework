namespace Conference.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Speeches", "UserId", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Speeches", "UserId");
        }
    }
}
