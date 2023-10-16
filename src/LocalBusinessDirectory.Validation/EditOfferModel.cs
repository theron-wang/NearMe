using LocalBusinessDirectory.Data.Models;
using LocalBusinessDirectory.Validation.Attributes;
using Microsoft.AspNetCore.Components.Forms;
using System.ComponentModel.DataAnnotations;

namespace LocalBusinessDirectory.Validation;
public class EditOfferModel
{
    [Required]
    [StringLength(100, MinimumLength = 5)]
    [Display(Name = "name")]
    public string? Name { get; set; }

    [Required]
    [StringLength(1000, MinimumLength = 50)]
    [Display(Name = "description")]
    public string? Description { get; set; }

    [FileSize(3)]
    [FileType(".webp", ".jpg", ".png", ".gif")]
    [Display(Name = "cover image")]
    public IBrowserFile? Image { get; set; }

    [Display(Name = "offer type")]
    public OfferType Type { get; set; }

    [Required]
    [GreaterThan<double>(0)]
    public double Price { get; set; }
}
