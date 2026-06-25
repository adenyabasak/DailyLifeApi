using Microsoft.AspNetCore.Mvc;
using DailyLifeApi.Data;
using DailyLifeApi.Models;

[ApiController]
[Route("api/[controller]")]
public class ShoppingItemController : ControllerBase
{
    private readonly AppDbContext _context;

    public ShoppingItemController(AppDbContext context)
    {
        _context = context;
    }

    [HttpGet]
    public IActionResult GetAll()
    {
        return Ok(_context.ShoppingItems.ToList());
    }

    [HttpPost]
    public IActionResult Create(ShoppingItem item)
    {
        _context.ShoppingItems.Add(item);
        _context.SaveChanges();
        return Ok(item);
    }

    [HttpPut("{id}")]
    public IActionResult Update(int id, ShoppingItem item)
    {
        var data = _context.ShoppingItems.Find(id);
        if (data == null) return NotFound();

        data.Name = item.Name;
        data.IsBought = item.IsBought;

        _context.SaveChanges();
        return Ok(data);
    }

    [HttpDelete("{id}")]
    public IActionResult Delete(int id)
    {
        var data = _context.ShoppingItems.Find(id);
        if (data == null) return NotFound();

        _context.ShoppingItems.Remove(data);
        _context.SaveChanges();

        return Ok();
    }
}