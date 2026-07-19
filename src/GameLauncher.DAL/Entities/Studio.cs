using GameLauncher.DAL.Enums;

namespace GameLauncher.DAL.Entities;

public class Studio
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public ICollection<Game> Games { get; set; } = new List<Game>();

}
