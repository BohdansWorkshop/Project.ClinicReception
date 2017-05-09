using System;
using System.Linq;
using Project.ClinicReception.DataAccess.Repositories;
using Project.ClinicReception.DbEntity;

namespace Project.ClinicReception.Logic
{
    public class ClientBusinessLogic : BaseBusinessLogic<Client, ClientRepository>
    {

        public IQueryable<Client> GetClients()
        {
            return Repository.GetAll();
        }

        public void EditClient(Client client)
        {
            Repository.Update(client);
        }

        public void DeleteClient(Guid clientId)
        {
            var client = Repository.GetById(clientId);
            Repository.Delete(client);
        }

        public ClientBusinessLogic(ClientRepository repository) : base(repository)
        {

        }
    }
}