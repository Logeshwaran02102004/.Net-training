namespace FirstcodeDemo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.IPLs",
                c => new
                    {
                        TeamId = c.Int(nullable: false, identity: true),
                        TeamName = c.String(),
                        Captain = c.String(),
                        State = c.String(),
                    })
                .PrimaryKey(t => t.TeamId);
            
            CreateTable(
                "dbo.StudentsTable",
                c => new
                    {
                        Sid = c.Int(nullable: false),
                        SName = c.String(nullable: false, maxLength: 20, unicode: false),
                        DOB = c.DateTime(nullable: false),
                        Class = c.Int(nullable: false),
                        SEmail = c.String(maxLength: 50, unicode: false),
                    })
                .PrimaryKey(t => t.Sid);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.StudentsTable");
            DropTable("dbo.IPLs");
        }
    }
}
