using Microsoft.AspNetCore.Mvc;
using DailyLifeApi.Data;
using DailyLifeApi.Models;

[ApiController]
[Route("api/[controller]")]
public class WaterTrackingController : ControllerBase
{
    private readonly AppDbContext _context;

    public WaterTrackingController(AppDbContext context)
    {
        _context = context;
    }

    [HttpGet]
    public IActionResult GetAll()
    {
        return Ok(_context.WaterTrackings.ToList());
    }

    [HttpPost]
    public IActionResult Create(WaterTracking item)
    {
        _context.WaterTrackings.Add(item);
        _context.SaveChanges();
        return Ok(item);
    }

    [HttpPut("{id}")]
    public IActionResult Update(int id, WaterTracking item)
    {
        var data = _context.WaterTrackings.Find(id);
        if (data == null) return NotFound();

        data.Amount = item.Amount;
        data.Date = item.Date;

        _context.SaveChanges();
        return Ok(data);
    }

    [HttpDelete("{id}")]
    public IActionResult Delete(int id)
    {
        var data = _context.WaterTrackings.Find(id);
        if (data == null) return NotFound();

        _context.WaterTrackings.Remove(data);
        _context.SaveChanges();

        return Ok();
    }
}