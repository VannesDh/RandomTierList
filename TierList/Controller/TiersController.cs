using Microsoft.AspNetCore.Mvc;
using TierList.Data;
using TierList.DTO;
using TierList.Models;


namespace TierList.Controller;

[ApiController]
[Route("api/[controller]")]

public class TiersController : ControllerBase
{
    private readonly AppDbContext _appDbContext;

    public TiersController(AppDbContext appDbContext)
    {
        _appDbContext = appDbContext;
    }

    [HttpPost]
    public async Task<IActionResult> Create(CreateTierDTO tierDto)
    {
        Tier tier = new()
        {
            Level = tierDto.Level,
            Description = tierDto.Description,
            MaxItems = tierDto.MaxItems,
            Color = tierDto.Color,
            TierContainerId = tierDto.TierContainerId
        };

        _appDbContext.Tiers.Add(tier);

        await _appDbContext.SaveChangesAsync();

        return Ok(tier);
    }
}

