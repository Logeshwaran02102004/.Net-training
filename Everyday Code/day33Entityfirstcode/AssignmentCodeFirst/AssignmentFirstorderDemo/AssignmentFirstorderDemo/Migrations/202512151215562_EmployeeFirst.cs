namespace AssignmentFirstorderDemo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class EmployeeFirst : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.EmployeeDeatails",
                c => new
                    {
                        EmpId = c.String(nullable: false, maxLength: 20, unicode: false),
                        EmpName = c.String(nullable: false, maxLength: 20, unicode: false),
                        Department = c.String(nullable: false, maxLength: 20, unicode: false),
                        Salary = c.Int(nullable: false),
                        YearOfJoining = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.EmpId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.EmployeeDeatails");
        }
    }
}
