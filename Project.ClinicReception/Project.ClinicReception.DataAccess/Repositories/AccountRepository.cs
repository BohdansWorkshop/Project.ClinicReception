using System;
using Project.ClinicReception.DbEntity;

namespace Project.ClinicReception.DataAccess.Repositories
{
    public class AccountRepository : BaseRepository<AccountEntity>
    {
        public AccountRepository(ReceptionContext context) : base(context)
        {
        }
    }
}