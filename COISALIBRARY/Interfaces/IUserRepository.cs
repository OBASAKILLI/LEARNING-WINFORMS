using COISALIBRARY.Models;
using COISALIBRARY.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COISALIBRARY.Interfaces
{
    public interface IUserRepository: IGenericRepository<Users>
    {
        Task <Users> Test(string id);
    }
}
