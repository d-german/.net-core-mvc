namespace HelloMVCWorld.Models;

public record Movie(string Title)
{
    public DateTime? ReleaseDate { get; init; }
}

