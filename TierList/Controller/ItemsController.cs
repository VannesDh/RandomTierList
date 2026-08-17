using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TierList.Data;
using TierList.DTO;
using TierList.Models;


namespace TierList.Controller;

[ApiController]
[Route("api/[controller]")]

public class ItemsController : ControllerBase
{
    private readonly AppDbContext _appDbContext;

    public ItemsController(AppDbContext appDbContext)
    {
        _appDbContext = appDbContext;
    }
    [HttpPost]
    public async Task<IActionResult> create(CreateItemDto createItemDto)
    {
        _appDbContext.Items.Add(new Item
        {
            Name = createItemDto.Name,
            ImageUrl = createItemDto.ImageUrl,
            TierContainerId = createItemDto.TierContainerId
        });

        await _appDbContext.SaveChangesAsync();

        return Ok(createItemDto);
    }


}
