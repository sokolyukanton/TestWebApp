using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TestWebApp.Models;

namespace TestWebApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GroupsController : ControllerBase
    {
        private readonly DataContext _context;

        public GroupsController(DataContext context)
        {
            _context = context;
        }

        // GET api/groups/shallow
        [HttpGet("shallow")]
        public ActionResult<List<Student>> ListGroupsOnly()
        {
            return Ok(_context.Groups.ToList());
        }

        // GET api/groups
        [HttpGet]
        public ActionResult<List<Student>> ListGroupsWithStudents()
        {
            return Ok(_context.Groups.Include(g=>g.Students).ToList());
        }

        // GET api/groups/1
        [HttpGet("{id}")]
        public ActionResult<Group> Get(long id)
        {
            var item = _context.Groups.Find(id);
            if (item == null)
                return NotFound();
            return Ok(item);
        }

        // POST api/groups
        [HttpPost]
        public ActionResult Create(Group value)
        {
            _context.Groups.Add(value);
            _context.SaveChanges();
            return CreatedAtAction(nameof(Get), new { id = value.Id }, value);
        }

        // PUT api/groups/1
        [HttpPut("{id}")]
        public ActionResult Put(long id, Group value)
        {
            if (id != value.Id)
                return BadRequest();
            var item = _context.Groups.Find(id);
            if (item == null)
                return NotFound();
            _context.Entry(item).CurrentValues.SetValues(value);
            _context.SaveChanges();
            return Ok();
        }

        // DELETE api/groups/1
        [HttpDelete("{id}")]
        public ActionResult Delete(long id)
        {
            var item = _context.Groups.Find(id);
            if (item == null)
                return NotFound();
            _context.Remove(item);
            _context.SaveChanges();
            return Ok();
        }
    }
}