namespace Boilerplate.Repository.Models;

public class Post
{
    public Guid Id { get; set; }
    
    // ReSharper disable once EntityFramework.ModelValidation.UnlimitedStringLength
    public string Title { get; set; } = "";
    
    // ReSharper disable once EntityFramework.ModelValidation.UnlimitedStringLength
    public string Content { get; set; } = "";
    
    public DateTime CreatedAt { get; set; }
    
    public DateTime UpdatedAt { get; set; }
}