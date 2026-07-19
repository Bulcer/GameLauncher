using GameLauncher.DAL.Enums;

namespace GameLauncher.DAL.Entities;

public class User
{
    public int Id { get; set; }
    public string FirstName { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;
    public string Username { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public Library Library { get; set; } = null!;
    public ICollection<Review> Reviews { get; set; } = new List<Review>();


}
