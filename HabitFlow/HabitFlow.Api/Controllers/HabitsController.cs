using HabitFlow.Api.Database;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace HabitFlow.Api.Controllers;
[Route("api/[controller]")]
[ApiController]
public class HabitsController(ApplicationDbContext dbContext) : ControllerBase
{
    [HttpGet]
    public async Task<IActionResult> GetHabits()
    {
        var habits = await dbContext.Habits.ToListAsync();

        return Ok(habits);
    }
}
