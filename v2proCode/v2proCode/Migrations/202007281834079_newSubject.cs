namespace v2proCode.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class newSubject : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Subjects",
                c => new
                    {
                        SubjectID = c.Int(nullable: false, identity: true),
                        SubjectName = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.SubjectID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Subjects");
        }
    }
}
