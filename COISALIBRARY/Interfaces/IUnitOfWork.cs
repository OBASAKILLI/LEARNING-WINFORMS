using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COISALIBRARY.Interfaces
{
    public interface IUnitOfWork : IDisposable

    {
        I_itemRepository itemRepository { get; }
        IOrderRepository orderRepository { get; }
        IOderItemsRepository OrderitemsRepository { get; }
        IProductCategory ProductCategory { get; }
        IUserRepository UserRepository { get; }
        int save();
    }
}
