using LocalBusinessDirectory.Data.Models;
using LocalBusinessDirectory.Validation.Attributes;
using Microsoft.AspNetCore.Components.Forms;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace LocalBusinessDirectory.Validation;
public class NewBusinessModel
{
    [Required]
    [StringLength(100, MinimumLength = 5)]
    [Display(Name = "name")]
    public string? Name { get; set; }

    [Required]
    [StringLength(200, MinimumLength = 50)]
    [Display(Name = "description")]
    public string? Description { get; set; }

    [Required]
    [FileSize(10)]
    [FileType(".webp", ".jpg", ".png", ".gif")]
    [Display(Name = "cover image")]
    public IBrowserFile? Image { get; set; }

    [Required]
    [Display(Name = "category")]
    public int? CategoryId { get; set; }

    [Required]
    [Display(Name = "address number")]
    public string? AddressNumber { get; set; }

    [Required]
    [Display(Name = "street")]
    public string? AddressStreet { get; set; }

    [Display(Name = "suite")]
    public string? AddressSuite { get; set; }

    [Required]
    [Display(Name = "city")]
    public string? AddressCity { get; set; }

    [Required]
    [Display(Name = "state")]
    public string? AddressState { get; set; }

    [Required]
    [StringLength(5, MinimumLength = 5, ErrorMessage = "Zip code must be 5 characters long")]
    [Display(Name = "zip code")]
    public string? AddressZipCode { get; set; }
}
