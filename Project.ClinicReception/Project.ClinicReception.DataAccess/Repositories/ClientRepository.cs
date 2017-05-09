using System;
using System.Linq;
using Project.ClinicReception.DbEntity;

namespace Project.ClinicReception.DataAccess.Repositories
{
   public class ClientRepository : BaseRepository<Client>
    {
       public ClientRepository(ReceptionContext context) : base(context)
       {
       }
    }
}