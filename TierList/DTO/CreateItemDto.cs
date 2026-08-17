namespace TierList.DTO;
public class CreateItemDto
{
    public int Id { get; set; }
    public required string Name {get; set;}
    public string? ImageUrl{get; set;}
    public int TierContainerId{get; set;}
}