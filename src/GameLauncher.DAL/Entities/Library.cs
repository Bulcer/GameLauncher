using GameLauncher.DAL.Enums;

namespace GameLauncher.DAL.Entities;

public class Library
{
    public int Id { get; set; }

    public ICollection<Game> Games { get; set; } = new List<Game>();
    public int UserId { get; set; } 
    public User User { get; set; } = null!;
}
