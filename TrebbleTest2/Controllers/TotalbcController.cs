using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Web.Http;


namespace TrebbleTest2.Controllers
{
    public class TotalbcController : ApiController
    {
     
        // GET api/values/5
        public HttpResponseMessage Get()
        {

            var response = new HttpResponseMessage(HttpStatusCode.OK);
            response.Content = new StringContent(ConfigurationManager.AppSettings["CirculatingSupply"].ToString());
            response.Content.Headers.ContentType = new MediaTypeHeaderValue("text/plain");
            return response;
            
        }
       
    }
}
