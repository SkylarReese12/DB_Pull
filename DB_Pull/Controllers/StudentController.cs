using DB_Pull.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace DB_Pull.Controllers
{
    public class StudentController : ApiController
    {
        public HttpResponseMessage Get()
        {
            List<Student> studentList = new List<Student>();
            using (QuestEntities qe = new QuestEntities())
            {
                studentList = qe.Students.OrderBy(a => a.FIRST_NAME).ToList();
                HttpResponseMessage response;
                response = Request.CreateResponse(HttpStatusCode.OK, studentList);
                return response;
            }
        }
    }
}
