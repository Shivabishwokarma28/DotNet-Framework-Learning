using _34_WebAPI_CRUD.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace _34_WebAPI_CRUD.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentAPIController : ControllerBase
    {
        private readonly SchoolManagementContext dbcontext;

        public StudentAPIController(SchoolManagementContext dbcontext)
        {
            this.dbcontext = dbcontext;
        }
        [HttpGet]
        public async Task<ActionResult<List<Student>>> GetStudents()
        {
            var data = await dbcontext.Students.ToListAsync();
            return Ok(data);
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<Student>> GetStudentById(int id)
        {
            var student = await dbcontext.Students.FindAsync(id);
            if(student==null)
            {
                return NotFound();
            }
            return student;
        }
        [HttpPost]
        public async Task<ActionResult<Student>> Create(Student std)
        {
             await dbcontext.Students.AddAsync(std);
            await dbcontext.SaveChangesAsync();
            return Ok(std);  
        }
        [HttpPut("{id}")]
        public async Task<ActionResult<Student>> Update(int id,Student std)
        {
            if (id!=std.Id) 
            {
                return BadRequest();
            }
            dbcontext.Entry(std).State = EntityState.Modified;
            //dbcontext.Students.Update(std);
            await dbcontext.SaveChangesAsync();
            return Ok(std);
        }
        [HttpDelete("{id}")]
        public async Task<ActionResult<Student>> Delete(int id)
        {
            var std = await dbcontext.Students.FindAsync(id);
            if(std==null)
            {
                return NotFound(); 
            }
            dbcontext.Students.Remove(std);
            await dbcontext.SaveChangesAsync();
            return Ok(); 
            
        }
    }
}
