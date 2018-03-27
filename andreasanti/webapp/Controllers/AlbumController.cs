using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Models;
using Businnes;
using Microsoft.Extensions.Logging;

namespace webapp.Controllers
{
    [Produces("application/json")]
    [Route("api/Album")]
    public class AlbumController : Controller
    {
    private readonly ILogger<AlbumController> _log;

    public AlbumController(ILogger<AlbumController> log)
    {
      _log = log;
    }

    // GET: api/Album
    [HttpGet]
        [Route("albums")]
        public async  Task<List<Album>> Get()
        {
            try
            {
              return await SiteManagerSingleton.SingletonInstance().GetAlbumdAsync();
             }
            catch (Exception e) {
              _log.LogError(e.StackTrace, "GetById({ID}) NOT FOUND");
              return null;
            }
        }

    // GET: api/Album/5
        [HttpGet("{id}", Name = "Get")]
        public  string Get(int id)
        {
            return "value";
        }
        
        // POST: api/Album
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }
        
        // PUT: api/Album/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }
        
        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
