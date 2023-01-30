using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SchoolEnrollmentApi.Data;
using SchoolEnrollmentApi.Models;
using System.Reflection.Metadata;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SchoolEnrollmentApi.Controllers
{
    // api/Students
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        // DbContext DI
        private readonly StudentDbContext context;

        public StudentsController(StudentDbContext context)
        {
            this.context = context;
        }

        // GET: api/Students
        [HttpGet]
        //public IEnumerable<string> Get()
        public async Task<ActionResult<IEnumerable<Student>>> Get()
        {
            var students = await context.Student.ToListAsync();
            return students;
        }

        // GET api/Students/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Student>> Get(int? id)
        {         
            var result = await context.Student
                .Include(s => s.Enrollments)
                .FirstOrDefaultAsync(s => s.ID == id);

            if (result == null) {return NotFound();}

            return result;
        }

        // POST api/Students
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/Students/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/Students/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
