using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Helpdesk_API_Integration.Controllers
{
    public class SundayWebAPI2Controller : ApiController
    {
        // GET: api/SundayWebAPI2
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/SundayWebAPI2/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/SundayWebAPI2
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/SundayWebAPI2/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/SundayWebAPI2/5
        public void Delete(int id)
        {
        }
    }
}
