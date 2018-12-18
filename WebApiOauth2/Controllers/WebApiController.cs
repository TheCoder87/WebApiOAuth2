using System.Collections.Generic;
using System.Web.Http;

namespace WebApiOauth2.Controllers
{
    [Authorize]
    public class WebApiController : ApiController
    {
        // GET api/WebApi
        public IEnumerable<string> Get()
        {
            return new string[] { "Hello REST API", "I am Authorized" };
        }

        // GET api/WebApi/5
        public string Get(int id)
        {
            return "Hello Authorized API with ID = " + id;
        }

        // POST api/WebApi
        public void Post([FromBody]string value)
        {
        }

        // PUT api/WebApi/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/WebApi/5
        public void Delete(int id)
        {
        }
    }
}
