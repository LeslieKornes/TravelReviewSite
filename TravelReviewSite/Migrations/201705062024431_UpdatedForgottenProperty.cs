namespace TravelReviewSite.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdatedForgottenProperty : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Reviews", "Title", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Reviews", "Title");
        }
    }
}
