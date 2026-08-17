namespace TierList.DTO;

public class TierContainerDto
{
    public int Id { get; set; }
    public required string Name { get; set; }
    public List<TierDto> Tiers { get; set; } = [];
    public List<ItemDto> Items {get; set; } = [];
}