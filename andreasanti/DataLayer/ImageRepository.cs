using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Models;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace DataLayer
{
  public class ImageRepository : IRepository<Image>
  {
    public Task<int> DeleteAsync(List<int> item)
    {
      throw new NotImplementedException();
    }

    public Task<int> InsertAsync(Image item)
    {
      throw new NotImplementedException();
    }

    public async  Task<List<Image>> ReadAllAsync()
    {
      using (var dbcontext = new DbManager())
      {
        try
        {
          return await dbcontext.Images.Where(image => image.IsHomeImage == true).ToListAsync();
        }
        catch (Exception)
        {
          return null;
        }

      }
    }

    public async  Task<Image> ReadByIdAsync(int id)
    {
      using (var dbmanager = new DbManager())
      {
        try
        {
          return await dbmanager.Images.FirstAsync(im => im.Id == id);
        }
        catch (Exception)
        {
          return null;
        }
      }
    }

    public async Task<List<Image>> ReadByAlbumIdAsync(int albumid)
    {
      using (var dbmanager = new DbManager())
      {
        try
        {
          return await dbmanager.Images.Where(im => im.AlbumId == albumid).ToListAsync();
        }catch (Exception)
        {
          return null;
        }
      }
    }

    public Task<int> UpdateAsync(Image item)
    {
      throw new NotImplementedException();
    }
  }
}
