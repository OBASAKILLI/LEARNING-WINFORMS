using COISALIBRARY.Context;
using COISALIBRARY.Interfaces;
using COISALIBRARY.Models;

namespace COISALIBRARY.Repositories
{
    public class UsersRepository : GenericRepository<Users>, IUserRepository
    {
        public UsersRepository(CoisaDbContext coisaDbContext) : base(coisaDbContext)
        {
        }

        public async  Task<Users> Test(string id)
        {
            return _context.users.Find(id);
        }
    }
}
