using PoemCore.Api;
using PoemCore.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace PoemWeb.Controllers
{
    public class PoemController : ApiController
    {
       [HttpGet]
       public Poem WritePoem()
        {
            var pService = new PoemService();
            return pService.WritePoem();
        }
    }
}