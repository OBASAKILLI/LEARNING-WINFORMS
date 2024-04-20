using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COISALIBRARY.Context
{
    public class CoisaDbContext:DbContext
    {
        public CoisaDbContext(DbContextOptions<CoisaDbContext>options):base(options)
        {

        }
        public DbSet<COISALIBRARY.Models.Items> items { get; set; }
        public DbSet<COISALIBRARY.Models.Orders> orders { get; set; }
        public DbSet<COISALIBRARY.Models.OrderItems> orderItems { get; set; }
        public DbSet<COISALIBRARY.Models.Product_Category> product_Categories { get; set; }
        public DbSet<COISALIBRARY.Models.Users> users { get; set; }
    }
}
