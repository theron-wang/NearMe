using LocalBusinessDirectory.Data.Models;
using System.ComponentModel.DataAnnotations;

namespace LocalBusinessDirectory.Validation;
public class RegisterModel
{
    [Required]
    [Display(Name = "username")]
    public string? Username { get; set; }

    [Required]
    [Display(Name = "password")]
    [DataType(DataType.Password)]
    public string? Password { get; set; }

    [Required]
    [Display(Name = "email")]
    [EmailAddress]
    [DataType(DataType.EmailAddress)]
    public string? Email { get; set; }

    [Required]
    [Display(Name = "password confirmation")]
    [Compare(nameof(Password))]
    [DataType(DataType.Password)]
    public string? PasswordConfirmation { get; set; }

    [Required]
    [Display(Name = "pricing plan")]
    public PricingPlan PricingPlan { get; set; } = PricingPlan.None;
}
