using COISALIBRARY.Context;
using COISALIBRARY.Interfaces;
using COISALIBRARY.Models;

namespace COISALIBRARY.Repositories
{
    public class OrderItemsRepository : GenericRepository<OrderItems>, IOderItemsRepository
    {
        public OrderItemsRepository(CoisaDbContext coisaDbContext) : base(coisaDbContext)
        {
        }
    }
}
