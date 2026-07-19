using GameLauncher.DAL.Enums;

namespace GameLauncher.DAL.Entities;

public class Category
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public ICollection<Game> Games { get; set; } = new List<Game>();
    public int? ParentCategoryId { get; set; } 
    public Category? ParentCategory { get; set; }
    public ICollection<Category> SubCategories { get; set; } = new List<Category>();

}
