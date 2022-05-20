using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Dotnet48JsonTest.Controllers
{
    public class TestController : ApiController
    {
        public IHttpActionResult Post([FromBody] TestInput input)
        {
            var result = new
            {
                Input = input,
                Message = "Success"
            };

            return Ok(result);
        }
    }
}
