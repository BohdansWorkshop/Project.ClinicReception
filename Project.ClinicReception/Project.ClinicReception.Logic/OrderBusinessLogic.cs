using System;
using System.Linq;
using Project.ClinicReception.DataAccess.Repositories;
using Project.ClinicReception.DbEntity;

namespace Project.ClinicReception.Logic
{
    public class OrderBusinessLogic : BaseBusinessLogic<Order, OrderRepository>
    {    
        public IQueryable<Order> GetOrderss()
        {
            return Repository.GetAll();
        }

        public void EditOrder(Order order)
        {
            Repository.Update(order);
        }

        public void DeleteOrder(Guid orderId)
        {
            var order = Repository.GetById(orderId);
            Repository.Delete(order);
        }

        public OrderBusinessLogic(OrderRepository repository) : base(repository)
        {
        }
    }
}