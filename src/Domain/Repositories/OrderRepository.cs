


using C__RIWI.src.Domain.Entities;
using C__RIWI.src.Domain.Repositories.Abstract_Repositories;

namespace C__RIWI.src.Domain.Repositories
{
    public class OrderRepository : GenericRepository<Order>, IOrderRepository
    {
        public OrderRepository(AppDBContext context) : base(context)
        {
            
        }
    }
}