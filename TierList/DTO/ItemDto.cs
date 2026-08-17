namespace TierList.DTO;

public class ItemDto
{
    public int Id { get; set; }
    public required string Name {get; set;}
    public string? ImageUrl{get; set;}
    public int? TierId {get; set;}
}