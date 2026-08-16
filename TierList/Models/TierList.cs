namespace TierList.Models;

public class TierContainer
{
    public int Id {get; set;}
    public required string Name {get; set;}
    public List<Tier> Tiers {get; set;} = [];
    public List<Item> Items{get; set;}=[];
}
public class Tier
{
    public int Id { get; set; }
    public TierLevel Level{get;set;}
    public required string Description {get; set;}
    public int MaxItems {get;set;}
    public string Color { get; set; } = "";
    public int TierContainerId { get; set; }
    public TierContainer TierContainer { get; set; } = null!;
}

public class Item
{
    public int Id { get; set; }
    public required string Name {get; set;}
    public string? ImageUrl{get; set;}
   
    public int TierContainerId { get; set; }
    public TierContainer TierContainer { get; set; } = null!;
}

public enum TierLevel
{
    S,A,B,C,D,E,F
}