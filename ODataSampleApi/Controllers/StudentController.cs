using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.OData.Query;
using Microsoft.AspNetCore.OData.Routing.Controllers;
using ODataSampleApi.Data;
using ODataSampleApi.Domain;

namespace ODataSampleApi.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class StudentController : ODataController
    {
        private readonly SchoolDBContext _context;

        public StudentController(SchoolDBContext context)
        {
            _context = context;
        }

        [EnableQuery]
        [HttpGet]
        public ActionResult<IEnumerable<Student>> GetStudents()
        {
            return Ok(_context.Students);
        }
    }
}
