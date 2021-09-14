using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace apiProject.Controllers
{
    public class StudentController : ApiController
    {
        // GET api/<controller>
        [Route("api/student/names")]
        public IEnumerable<string> Get()
        {
            return new string[] { "student1", "student2" };
        }
    }
}