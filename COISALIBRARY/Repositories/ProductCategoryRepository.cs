using COISALIBRARY.Context;
using COISALIBRARY.Interfaces;
using COISALIBRARY.Models;

namespace COISALIBRARY.Repositories
{
    public class ProductCategoryRepository : GenericRepository<Product_Category>, IProductCategory
    {
        public ProductCategoryRepository(CoisaDbContext coisaDbContext) : base(coisaDbContext)
        {
        }
    }
}
