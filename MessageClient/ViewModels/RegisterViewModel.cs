using System.ComponentModel.DataAnnotations;

namespace MessageClient.ViewModels
{
  public class RegisterViewModel
  {
    [Required]
    [Display(Name="User Name")]
    public string UserName { get; set; }

    [Required]
    [DataType(DataType.Password)]
    [Display(Name="Password")]
    public string Password { get; set; }

    [DataType(DataType.Password)]
    [Display(Name="Confirm Password")]
    [Compare("Password", ErrorMessage="The password and confirmation password do not match.")]
    public string ConfirmPassword { get; set; }

    public string ProfileIcon { get; set; }
  }
}