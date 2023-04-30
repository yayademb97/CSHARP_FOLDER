#pragma warning disable CS8618
using System.ComponentModel.DataAnnotations;
namespace Dojo_Survey.Models;

public class Survey
{
    [Required(ErrorMessage = "Name is required ❌❌❌")]
    [Range(minimum: 3, maximum: 10, ErrorMessage = "User Name must between 1 and 10 😡😡😡")]
    public string YourName { get; set; }
    [Required(ErrorMessage = "Deje Location is required ❌❌❌")]
    public string DojoLocation { get; set; }
    [Required(ErrorMessage = "Favorite Language is required ❌❌❌")]

    public string FavLanguage { get; set; }
    [Required(ErrorMessage = "Comment is required ❌❌❌")]
    [Range(minimum: 5, maximum:100, ErrorMessage = "Comment must between 5 and 100")]
    public string Comment { get; set; }

}