using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace WebAPIExample.Controllers
{
    public class ExampleAPIController : ApiController
    {
        public async Task<string> Post()
        {
            string returnValue = "OK";

            var formKeyValueData = await Request.Content.ReadAsFormDataAsync();

            string AuthorizedKey = formKeyValueData["AuthorizedKey"];

            return returnValue;
        }

        public string Get(string AuthorizedKey)
        {
            string returnValue = "OK";
            return returnValue;
        }
    }
}
