using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TierList.Data;
using TierList.DTO;
using TierList.Models;

namespace TierList.Controller;


[ApiController]
[Route("api/[controller]")]
public class TierContainerController : ControllerBase
{
    private readonly AppDbContext _appDbContext;

    public TierContainerController(AppDbContext appDbContext)
    {
        _appDbContext = appDbContext;
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetById(int id)
    {
        var tierContainer = await _appDbContext.TierContainers
                            .Include(t => t.Tiers)
                            .FirstOrDefaultAsync(t => t.Id == id);

        if (tierContainer == null)
        {
            return NotFound();
        }
        var dto = new TierContainerDto
            {
                Id = tierContainer.Id,
                Name = tierContainer.Name,
                Tiers = tierContainer.Tiers.Select(tier => new TierDto
                {
                    Id = tier.Id,
                    Level = tier.Level,
                    Description = tier.Description,
                    MaxItems = tier.MaxItems,
                    Color = tier.Color
                }).ToList()
            };

        return Ok(dto);
    }

    [HttpPost]
    public async Task<IActionResult> Create(TierContainer tierContainer)
    {
        _appDbContext.TierContainers.Add(tierContainer);

        await _appDbContext.SaveChangesAsync();

        return Ok(tierContainer);
    }

}


