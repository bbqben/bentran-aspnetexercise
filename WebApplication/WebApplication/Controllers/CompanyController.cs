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
    [RoutePrefix("api/companies")]
    public class CompanyController : ApiController
    {

        [Route]
        [HttpGet]
        public IHttpActionResult GetAllCompanies()
        {
            var db = new mytestdbEntities();

            var companies = db.Companies.Where(xx => true);

            return ResponseMessage(Request.CreateResponse(HttpStatusCode.OK, companies));
        }

        [Route]
        [HttpPost]
        public IHttpActionResult AddCompany([FromBody]  )
        {
            var db = new mytestdbEntities();

            var companies = db.Companies.Where(xx => true);

            return ResponseMessage(Request.CreateResponse(HttpStatusCode.OK, companies));
        }

    }


}
