namespace Project.ClinicReception.DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Clients : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AccountEntities",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Login = c.String(),
                        Password = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Doctors",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Age = c.Int(nullable: false),
                        Sex = c.Int(nullable: false),
                        Qualification = c.Int(nullable: false),
                        Phone = c.String(),
                        Graphic = c.String(),
                        CreateDate = c.DateTime(nullable: false),
                        EditedDate = c.DateTime(nullable: false),
                        Name = c.String(nullable: false, maxLength: 500),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Orders",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Cabinet = c.String(nullable: false),
                        Price = c.Double(nullable: false),
                        Time = c.String(),
                        CreateDate = c.DateTime(nullable: false),
                        EditedDate = c.DateTime(nullable: false),
                        ClientOrder_Id = c.Guid(nullable: false),
                        DoctorOrder_Id = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Clients", t => t.ClientOrder_Id, cascadeDelete: true)
                .ForeignKey("dbo.Doctors", t => t.DoctorOrder_Id, cascadeDelete: true)
                .Index(t => t.ClientOrder_Id)
                .Index(t => t.DoctorOrder_Id);
            
            AlterColumn("dbo.Clients", "Phone", c => c.String(maxLength: 500));
        }
        
        public override void Down()
        {
            AddColumn("dbo.Clients", "Price", c => c.Double(nullable: false));
            AddColumn("dbo.Clients", "Destination", c => c.Int(nullable: false));
            AddColumn("dbo.Clients", "Cabinet", c => c.String());
            DropForeignKey("dbo.Orders", "DoctorOrder_Id", "dbo.Doctors");
            DropForeignKey("dbo.Orders", "ClientOrder_Id", "dbo.Clients");
            DropIndex("dbo.Orders", new[] { "DoctorOrder_Id" });
            DropIndex("dbo.Orders", new[] { "ClientOrder_Id" });
            AlterColumn("dbo.Clients", "Phone", c => c.String());
            DropTable("dbo.Orders");
            DropTable("dbo.Doctors");
            DropTable("dbo.AccountEntities");
        }
    }
}
