using TierList.Models;

namespace TierList.DTO;

public class TierDto
{
    public int Id { get; set; }
    public required string Level { get; set; }
    public required string Description { get; set; }
    public int MaxItems { get; set; }
    public string Color { get; set; } = "";
}