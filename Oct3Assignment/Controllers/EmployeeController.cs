using Oct3Assignment.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace Oct3Assignment.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]

    public class EmployeeController : ApiController
    {
        StudentContext db = new StudentContext();

        //get employees
        //get:Employee
        public IHttpActionResult Get()
        {
            var res = db.MEmployees.ToList();
            return Ok(res);
        }
        //post:Employee
        public IHttpActionResult Post(MEmployee value)
        {
            db.MEmployees.Add(value);
            db.SaveChanges();
            return Ok("Ok");
        } 

        

       

       
    }
}
