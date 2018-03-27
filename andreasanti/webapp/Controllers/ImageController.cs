using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Models;
using Businnes;
using Microsoft.Extensions.Logging;

namespace webapp.Controllers
{
  [Route("api/[controller]")]
  public class ImageController : Controller { 

    readonly ILogger<ImageController> _log;

    public ImageController(ILogger<ImageController> log)
    {
      _log = log;
    }
    // GET api/values

    [Route("index")]
    [HttpGet]
    public async Task<List<Image>> Get()
    {
      try
      {
        _log.LogInformation("ImageController get a request");
        return await SiteManagerSingleton.SingletonInstance().GetIndexImagesAsync();
      }
      catch (Exception e) {
        _log.LogError(e.StackTrace);
        return null;
      }
    }

    // GET api/values/5
    [HttpGet("{id}")]
    [Route("imagebyalbum")]
    public async Task<List<Image>> Get(int id)
    {
      try
      {
        return await SiteManagerSingleton.SingletonInstance().GetImageByAlbumId(id);
      }
      catch(Exception e) {
        _log.LogError(e.StackTrace);
        return null;
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
