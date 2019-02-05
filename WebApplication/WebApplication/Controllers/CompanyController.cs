using WebApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Diagnostics;

namespace WebApplication.Controllers
{
    [RoutePrefix("company")]
    public class CompanyController : ApiController
    {

        [Route]
        [HttpGet]
        public IHttpActionResult GetAllCompanies()
        {
            var db = new mytestdbEntities();

            var yada = db.Companies.Where(xx => true);

            foreach(var item in yada)
            {
                Debug.WriteLine(item.Name);
            }

            return ResponseMessage(Request.CreateResponse(HttpStatusCode.OK, yada));
        }

    }


}
