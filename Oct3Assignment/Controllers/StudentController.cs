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
    /// <summary>
    /// The Student Controller
    /// </summary>
    public class StudentController : ApiController
    {
        private StudentContext context;
        public StudentController()
        {
            context = new StudentContext();
        }

        [HttpGet]
        [Route("api/PStudent/")]
        public IEnumerable<PStudent> Get()
        {
            return context.PStudents.ToList();
        }

        [HttpPost]
        [Route("api/PStudent/")]
        public IHttpActionResult PostNewStudent(PStudent student)
            {
                 if (!ModelState.IsValid)
                    return BadRequest("Invalid data.");
                     context.PStudents.Add(student);
                     context.SaveChanges();
                return Ok();
              }
    } 
        //[HttpPost]
        //public IHttpActionResult Post(PStudent member)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return BadRequest(ModelState);
        //    }

        //    context.PStudents.Add(member);
        //    context.SaveChanges();

        //}


    }

