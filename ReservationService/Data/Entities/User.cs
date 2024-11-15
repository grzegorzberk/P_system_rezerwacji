using System.ComponentModel.DataAnnotations;

namespace ReservationService.Data.Entities;

public class User
{
    public int Id { get; set; }

    [Required]
    [MaxLength(50)]
    public string Name { get; set; } = null!;
    [Required]
    [EmailAddress]
    public string Email { get; set; } = null!;
    [Required]
    [MinLength(6)]
    public string PasswordHash { get; set; } = null!;
    public string Role { get; set; } = "User";
}
