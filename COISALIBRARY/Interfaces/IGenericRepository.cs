using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COISALIBRARY.Interfaces
{
    public interface IGenericRepository<T> where T : class
    {
        Task Create(T entity);   //add new
        Task<IEnumerable<T>> GetAll(T entity);   //Get all
        Task<T> GetById(string Id);   //Get by Id
        Task Update(T entity);  //Update
        Task Remove(T entity);  //Remove
    }
}
