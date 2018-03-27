using System;
using System.Linq;
using System.Collections.Generic;
using Models;
using DataLayer;
using System.Threading.Tasks;

namespace Businnes
{
  public class SiteManagerSingleton
  {
    private static readonly Lazy<SiteManagerSingleton> _instance = new Lazy<SiteManagerSingleton>(() => new SiteManagerSingleton());

    private SiteManagerSingleton()
    {
      using (var dbmanager = new DbManager())
      {
       // dbmanager.InsertData();
      }
    }


    public static SiteManagerSingleton SingletonInstance()
    {
      
        return _instance.Value;
    }

    public async Task<List<Image>> GetIndexImagesAsync()
    {
      var userepository = new ImageRepository();

      return await userepository.ReadAllAsync();

    }

    public async Task<Image> GetImageByIdAsync(int id)
    {
      var imagerepository = new ImageRepository();
      return await imagerepository.ReadByIdAsync(id);
    }

    public async Task<Album> GetAlbumByIdAsync(int id)
    {
      var albumrepository = new AlbumRepository();
      return await albumrepository.ReadByIdAsync(id);
    }

    public async Task<List<Album>> GetAlbumdAsync()
    {
      var albumrepository = new AlbumRepository();
      return await albumrepository.ReadAllAsync();
    }

    public async Task<List<Image>> GetImageByAlbumId(int albumid)
    {
      var imagerepo = new ImageRepository();
      return await imagerepo.ReadByAlbumIdAsync(albumid);
    }
  }
}
