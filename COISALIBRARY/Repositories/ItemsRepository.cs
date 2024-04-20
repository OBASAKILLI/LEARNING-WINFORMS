using COISALIBRARY.Context;
using COISALIBRARY.Interfaces;
using COISALIBRARY.Models;

namespace COISALIBRARY.Repositories
{
    public class ItemsRepository : GenericRepository<Items>, I_itemRepository
    {
        public ItemsRepository(CoisaDbContext coisaDbContext) : base(coisaDbContext)
        {
        }
    }
}
