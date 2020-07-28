namespace v2proCode.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class newAssessment : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Assessments",
                c => new
                    {
                        AssessmentID = c.Int(nullable: false, identity: true),
                        Grade = c.String(nullable: false),
                        StartTime = c.DateTime(nullable: false),
                        EndTime = c.DateTime(nullable: false),
                        AssessmentDate = c.DateTime(nullable: false),
                        AssessmentVenue = c.String(nullable: false),
                        Term = c.String(nullable: false),
                        Type = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.AssessmentID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Assessments");
        }
    }
}
