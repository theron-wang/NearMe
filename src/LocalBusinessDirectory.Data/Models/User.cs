namespace LocalBusinessDirectory.Data.Models;

#nullable disable
public class User
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
    public string PasswordHash { get; set; }
    public PricingPlan PricingPlan { get; set; }
#nullable enable
    public string? BusinessId { get; set; }
}
