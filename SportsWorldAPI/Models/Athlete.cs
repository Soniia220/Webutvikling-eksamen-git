using SportsWorldAPI.Interfaces;

namespace SportsWorldAPI.Models;

public class Athlete : IAthlete
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Gender { get; set; } = string.Empty;
    public double Price { get; set; }
    public string Image { get; set; } = string.Empty;
    public bool PurchaseStatus { get; set; }
}