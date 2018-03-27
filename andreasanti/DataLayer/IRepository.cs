using System.Collections.Generic;
using System.Threading.Tasks;

namespace DataLayer
{
  public interface IRepository<T> where T : class
  {
    //create, read, update, and delete
    Task<int> InsertAsync(T item);

    Task<T>ReadByIdAsync(int id);

    Task<List<T>> ReadAllAsync();

    Task<int> UpdateAsync(T item);

    Task<int> DeleteAsync(List<int> item);


  }
}
