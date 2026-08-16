using TierList.Models;
namespace TierList.DTO;

public class CreateTierDTO
{
    public int Id { get; set; }
    public TierLevel Level{get;set;}
    public required string Description {get; set;}
    public int MaxItems {get;set;}
    public string Color { get; set; } = "";
    public int TierContainerId {get; set;}
}