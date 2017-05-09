using System.Linq;
using Project.ClinicReception.DataAccess.Repositories;
using Project.ClinicReception.DbEntity;

namespace Project.ClinicReception.Logic
{
    public class AccountBusinessLogic : BaseBusinessLogic<AccountEntity, AccountRepository>
    {
        public IQueryable<AccountEntity> FindAccount(string login, string password)
        {
            return Repository.FindByLoginAndPass(login, password);
        }

        public AccountBusinessLogic(AccountRepository repository) : base(repository)
        {
        }
    }
}