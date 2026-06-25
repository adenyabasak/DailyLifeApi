using Microsoft.AspNetCore.Mvc;
using DailyLifeApi.Data;
using DailyLifeApi.Models;

namespace DailyLifeApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class IdeaController : ControllerBase
    {
        private readonly AppDbContext _context;

        public IdeaController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_context.Ideas.ToList());
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var item = _context.Ideas.Find(id);
            if (item == null) return NotFound();

            return Ok(item);
        }

        [HttpPost]
        public IActionResult Create(Idea idea)
        {
            _context.Ideas.Add(idea);
            _context.SaveChanges();
            return Ok(idea);
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, Idea idea)
        {
            var item = _context.Ideas.Find(id);
            if (item == null) return NotFound();

            item.Title = idea.Title;
            item.Description = idea.Description;

            _context.SaveChanges();
            return Ok(item);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var item = _context.Ideas.Find(id);
            if (item == null) return NotFound();

            _context.Ideas.Remove(item);
            _context.SaveChanges();

            return Ok();
        }
    }
}