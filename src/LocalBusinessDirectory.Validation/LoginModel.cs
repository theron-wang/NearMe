using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace LocalBusinessDirectory.Validation;
public class LoginModel
{
    [Required]
    [DisplayName("username")]
    public string? Username { get; set; }

    [Required]
    [DisplayName("password")]
    [DataType(DataType.Password)]
    public string? Password { get; set; }

    public bool RememberMe { get; set; } = true;
}
