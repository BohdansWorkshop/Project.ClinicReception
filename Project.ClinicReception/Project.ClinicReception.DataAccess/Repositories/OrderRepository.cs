using Project.ClinicReception.DbEntity;

namespace Project.ClinicReception.DataAccess.Repositories
{
    public class OrderRepository : BaseRepository<Order>
    {
        public OrderRepository(ReceptionContext context) : base(context)
        {
        }
    }
}