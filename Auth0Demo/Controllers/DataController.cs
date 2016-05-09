using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Auth0Demo.Controllers
{
    public class DataController : ApiController
    {
        [HttpGet]
        [Route("api/data/public")]
        public string GetPublic()
        {
            return "This is a Public string";
        }

        [Authorize(Roles = "admin")]
        [HttpGet]
        [Route("api/data/private")]
        public string GetPrivate()
        {
            return "This is a ** PRIVATE ** string";
        }
    }
}
