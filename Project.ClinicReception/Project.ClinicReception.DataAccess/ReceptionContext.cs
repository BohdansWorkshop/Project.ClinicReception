using System.Data.Entity;
using Project.ClinicReception.DbEntity;

namespace Project.ClinicReception.DataAccess
{
    public class ReceptionContext : DbContext
    {
        public ReceptionContext() : base("ReceptionConnection")
        {
            this.Configuration.LazyLoadingEnabled = false;
            this.Configuration.ProxyCreationEnabled = false;
        }
        public DbSet<Client> Clients { get; set; }

        public DbSet<Doctor> Doctors { get; set; }

        public DbSet<Order> Orders { get; set; }

        public DbSet<AccountEntity> Accounts { get; set; }

    }
}