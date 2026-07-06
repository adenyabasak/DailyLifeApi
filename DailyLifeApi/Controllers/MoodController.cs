using Microsoft.AspNetCore.Mvc;
using DailyLifeApi.Data;
using DailyLifeApi.Models;

[ApiController]
[Route("api/[controller]")]
public class MoodController : ControllerBase
{
    private readonly AppDbContext _context;

    public MoodController(AppDbContext context)
    {
        _context = context;
    }

    [HttpGet]
    public IActionResult GetAll()
    {
        return Ok(_context.Moods.ToList());
    }

    [HttpPost]
    public IActionResult Create(Mood item)
    {
        _context.Moods.Add(item);
        _context.SaveChanges();
        return Ok(item);
    }

    [HttpPut("{id}")]
    public IActionResult Update(int id, Mood item)
    {
        var data = _context.Moods.Find(id);
        if (data == null) return NotFound();

        data.MoodType = item.MoodType;
        data.Date = item.Date;

        _context.SaveChanges();
        return Ok(data);
    }

    [HttpDelete("{id}")] // burası yorumms
    public IActionResult Delete(int id)
    {
        var data = _context.Moods.Find(id);
        if (data == null) return NotFound();

        _context.Moods.Remove(data);
        _context.SaveChanges();

        return Ok();
    }
}