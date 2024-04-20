using COISALIBRARY.Context;
using COISALIBRARY.Interfaces;

namespace COISALIBRARY.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        public readonly CoisaDbContext _coisaDbContext;

        public UnitOfWork(CoisaDbContext coisaDbContext)
        {
            _coisaDbContext = coisaDbContext;
            itemRepository = new ItemsRepository(_coisaDbContext);
            orderRepository = new OrderRepository(_coisaDbContext);
            OrderitemsRepository= new OrderItemsRepository(_coisaDbContext);
            ProductCategory = new ProductCategoryRepository(_coisaDbContext);
            UserRepository = new UsersRepository(_coisaDbContext);
        }
        public I_itemRepository itemRepository { get; private set; }

        public IOrderRepository orderRepository { get; private set; }

        public IOderItemsRepository OrderitemsRepository { get; private set; }

        public IProductCategory ProductCategory { get; private set; }

        public IUserRepository UserRepository { get; private set; }

        public void Dispose()
        {
            _coisaDbContext.Dispose();
        }

        public int save()
        {
            return _coisaDbContext.SaveChanges();
        }
    }
}
