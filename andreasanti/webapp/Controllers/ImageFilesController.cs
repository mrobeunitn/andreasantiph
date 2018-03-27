using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Net.Http;
using System.IO;
using Businnes;
using System.Net.Http.Headers;
using Serilog;
using Microsoft.Extensions.Logging;

namespace webapp.Controllers
{
  [Route("api/[controller]")]
  public class ImageFilesController : Controller
  {
    // GET: api/values
    readonly ILogger<ImageFilesController> _log;

    public ImageFilesController(ILogger<ImageFilesController> log)
    {
      _log = log;
    }


    [HttpGet]
    public IEnumerable<string> Get()
    {
      return null;
    }


    /*public ImageFilesController(IHostingEnvironment hostingEnvironment)
    {
      _hostingEnvironment = hostingEnvironment;
      string webRootPath = _hostingEnvironment.WebRootPath;
      var stream = System.IO.File.OpenRead($"{webRootPath}/res/{ album.Path}/{image.Path}");
    }*/

    // GET api/values/5
    [Route("image")]
    [HttpGet("{id}")]
    public async Task<IActionResult> Get(int id)
    {
      try
      {
        var image = await SiteManagerSingleton.SingletonInstance().GetImageByIdAsync(id);
        var album = await SiteManagerSingleton.SingletonInstance().GetAlbumByIdAsync(image.AlbumId);
        /**
         * temporary solution
         * */
         album.Path.Replace(@"\",@"/");
        var stream = System.IO.File.OpenRead($"{Directory.GetCurrentDirectory()}/{album.Path}/{image.Path}");
        _log.LogInformation("Immagine richiesta");
        return File(stream, "image/jpg");
      }
      catch (Exception e) {
        _log.LogError(e.StackTrace);
        throw e;
      }
    }
    // POST api/values
    [HttpPost]
    public void Post([FromBody]string value)
    {
    }

    // PUT api/values/5
    [HttpPut("{id}")]
    public void Put(int id, [FromBody]string value)
    {
    }

    // DELETE api/values/5
    [HttpDelete("{id}")]
    public void Delete(int id)
    {
    }
  }
}
