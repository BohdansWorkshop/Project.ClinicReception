namespace Project.ClinicReception.DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Clients",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Cabinet = c.String(),
                        Phone = c.String(),
                        Age = c.Int(nullable: false),
                        Sex = c.Int(nullable: false),
                        CreateDate = c.DateTime(nullable: false),
                        EditedDate = c.DateTime(nullable: false),
                        Name = c.String(nullable: false, maxLength: 500),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Clients");
        }
    }
}
