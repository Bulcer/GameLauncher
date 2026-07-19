using GameLauncher.DAL.Enums;

namespace GameLauncher.DAL.Entities;

public class Game
{
    public int Id { get; set; }
    public string Title { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public Pegi PegiRating { get; set; } = Pegi.Pegi3;
    public DateOnly ReleaseDate { get; set; }
    public ICollection<Library> Libraries { get; set; } = new List<Library>();
    public ICollection<Category> Categories { get; set; } = new List<Category>();
    public int StudioId { get; set; } 
    public Studio Studio { get; set; } = null!;
    public ICollection<Review> Reviews { get; set; } = new List<Review>();


}
