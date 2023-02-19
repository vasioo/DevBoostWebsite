using Microsoft.AspNetCore.Mvc;
using DevBoost.Models;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using Microsoft.Data.SqlClient;
using System.Web.Http;
using System.Net;
using DevBoost.Data;

namespace DevBoost.Controllers
{
    public class ExerciseController : ApiController
    {
        public HttpResponseMessage Get()
        {
            List<Exercise> exerciseList = new List<Exercise>();
            using (DBModel dc = new DBModel())
            {
                exerciseList = dc.Exercise.OrderBy(a => a.Name).ToList();
                HttpResponseMessage response;
                response = Request.CreateResponse(HttpStatusCode.OK, exerciseList);
                return response;
            }
        }
    }
}
