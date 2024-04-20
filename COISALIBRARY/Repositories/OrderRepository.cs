using COISALIBRARY.Context;
using COISALIBRARY.Interfaces;
using COISALIBRARY.Models;

namespace COISALIBRARY.Repositories
{
    public class OrderRepository : GenericRepository<Orders>, IOrderRepository
    {
        public OrderRepository(CoisaDbContext coisaDbContext) : base(coisaDbContext)
        {
        }
    }
}
