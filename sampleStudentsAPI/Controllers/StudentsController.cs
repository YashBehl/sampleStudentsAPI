using Microsoft.AspNetCore.Mvc;
using sampleStudentsAPI.Data;

namespace sampleStudentsAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class StudentsController : Controller
    {
        private readonly StudentsAPIDbContext dbContext;

        public StudentsController(StudentsAPIDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        [HttpGet]
        public IActionResult getStudents()
        {
            return Ok(dbContext.Students.ToList());
        }

        /*[HttpPost]
        public IActionResult addContacts()
        {

        }*/
    }
}