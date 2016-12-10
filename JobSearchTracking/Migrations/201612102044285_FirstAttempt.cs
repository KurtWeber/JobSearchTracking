namespace JobSearchTracking.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FirstAttempt : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Companies",
                c => new
                    {
                        CompanyID = c.Int(nullable: false, identity: true),
                        CompanyName = c.String(),
                        CompanyAddress = c.String(),
                        CompanyCity = c.String(),
                        CompanyState = c.String(),
                        CompanyZip = c.String(),
                        PositionID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.CompanyID)
                .ForeignKey("dbo.Positions", t => t.PositionID, cascadeDelete: true)
                .Index(t => t.PositionID);
            
            CreateTable(
                "dbo.Positions",
                c => new
                    {
                        PositionID = c.Int(nullable: false, identity: true),
                        PositionName = c.String(),
                        PositionDescription = c.String(),
                        ContactName = c.String(),
                        ContactPhone = c.String(),
                        ResumeSent = c.DateTime(nullable: false),
                        CompanyResponse = c.Boolean(nullable: false),
                        ResponseDescription = c.String(),
                        InterviewID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.PositionID)
                .ForeignKey("dbo.Interviews", t => t.InterviewID, cascadeDelete: true)
                .Index(t => t.InterviewID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Companies", "PositionID", "dbo.Positions");
            DropForeignKey("dbo.Positions", "InterviewID", "dbo.Interviews");
            DropIndex("dbo.Positions", new[] { "InterviewID" });
            DropIndex("dbo.Companies", new[] { "PositionID" });
            DropTable("dbo.Positions");
            DropTable("dbo.Companies");
        }
    }
}
