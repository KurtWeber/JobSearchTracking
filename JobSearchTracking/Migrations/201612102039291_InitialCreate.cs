namespace JobSearchTracking.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Interviews",
                c => new
                    {
                        InterviewID = c.Int(nullable: false, identity: true),
                        IntervireDate = c.DateTime(nullable: false),
                        InterviewOutcome = c.String(),
                    })
                .PrimaryKey(t => t.InterviewID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Interviews");
        }
    }
}
