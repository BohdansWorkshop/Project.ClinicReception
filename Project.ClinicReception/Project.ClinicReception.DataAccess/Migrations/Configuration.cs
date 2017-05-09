namespace Project.ClinicReception.DataAccess.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Project.ClinicReception.DataAccess.ReceptionContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(Project.ClinicReception.DataAccess.ReceptionContext context)
        {
             
        }
    }
}
