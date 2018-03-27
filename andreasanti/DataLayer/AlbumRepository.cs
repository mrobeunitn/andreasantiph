using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Models;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace DataLayer
{
  public class AlbumRepository : IRepository<Album>
  {
    public Task<int> DeleteAsync(List<int> item)
    {
      throw new NotImplementedException();
    }

    public Task<int> InsertAsync(Album item)
    {
      throw new NotImplementedException();
    }

    public async Task<List<Album>> ReadAllAsync()
    {
      using (var dbmanager = new DbManager())
      {
        return await dbmanager.Albums.ToListAsync();
      }
    }

    public async Task<Album> ReadByIdAsync(int id)
    {
      using (var dbmanager = new DbManager())
      {
        try
        {
          return await dbmanager.Albums.FirstAsync(im => im.Id == id);
        }
        catch (Exception)
        {
          return null;
        }
        
      }

    }

    public Task<int> UpdateAsync(Album item)
    {
      throw new NotImplementedException();
    }

  }
}
