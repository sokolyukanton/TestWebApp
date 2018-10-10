using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TestWebApp.Models;

namespace TestWebApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        private readonly DataContext _context;

        public StudentsController(DataContext context)
        {
            _context = context;
        }

        // GET api/students
        [HttpGet]
        public ActionResult<List<Student>> ListStudents()
        {
            return Ok(_context.Students.ToList());
        }

        // GET api/students/1
        [HttpGet("{id}")]
        public ActionResult<Student> Get(long id)
        {
            var item =  _context.Students.Find(id);
            if (item == null)
                return NotFound();
            return Ok(item);
        }

        // POST api/students
        [HttpPost]
        public ActionResult Create(Student value)
        {
            _context.Students.Add(value);
            _context.SaveChanges();
            return CreatedAtAction(nameof(Get), new {id = value.Id}, value);
        }

        // PUT api/students/1
        [HttpPut("{id}")]
        public ActionResult Put(long id, Student value)
        {
            if (id != value.Id)
                return BadRequest();
            var item = _context.Students.Find(id);
            if (item == null)
                return NotFound();
            _context.Entry(item).CurrentValues.SetValues(value);
            _context.SaveChanges();
            return Ok();
        }

        // DELETE api/students/1
        [HttpDelete("{id}")]
        public ActionResult Delete(long id)
        {
            var item = _context.Students.Find(id);
            if (item == null)
                return NotFound();
            _context.Remove(item);
            _context.SaveChanges();
            return Ok();
        }
    }
}