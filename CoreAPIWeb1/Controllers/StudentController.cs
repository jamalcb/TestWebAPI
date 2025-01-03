using CoreAPIWeb1.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CoreAPIWeb1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    
    public class StudentController : ControllerBase
    {
        private readonly StudentContext _context;
        public StudentController(StudentContext context)
        { 
          _context = context;
        }
        [HttpGet]
        public async Task<ActionResult <List<Student>>> GetStd()
        {
            var stdList = await _context.Students.ToListAsync();
            return Ok(stdList);
        }
        [HttpGet("{id}")]
        public async Task<ActionResult <Student>> GetStd(int id)
        {
            var std = await _context.Students.Where(m=>m.StudentId==id).FirstOrDefaultAsync();
            return Ok(std);

        }
        [HttpPost]
        public async Task<ActionResult> CreateStudent(Student student)
        {
            var crt= await _context.Students.AddAsync(student);
            await _context.SaveChangesAsync();
            return Ok(crt);
        }

        [HttpPut]
        public async Task<ActionResult> EditStudent(int StdId,Student student)
        {
            if(StdId!=student.StudentId)
            {
                return BadRequest();

            }
           _context.Entry(student).State=EntityState.Modified;
            _context.SaveChangesAsync();
            return Ok(student);
        }
    }
}
