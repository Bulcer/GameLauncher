using GameLauncher.DAL.Enums;

namespace GameLauncher.DAL.Entities;

public class Review
{
    public Score Score { get; set; }
    public string Comment { get; set; } = string.Empty;
    public DateTime CreatedAt { get; set; }
    public int UserId { get; set; }
    public User User { get; set; } = null!;
    public int GameId { get; set; }
    public Game Game { get; set; } = null!;
}
