namespace PersonalLibrary.Core.Entities;

public class Book
{
    public int Id { get; set; }
    public string Title { get; set; } = string.Empty;
    public string? ISBN { get; set; }
    public int? PublishedYear { get; set; }
    public int? PageCount { get; set; }
    public Genre Genre { set; get; }
    public ReadingStatus ReadingStatus { get; set; }
    public DateTime DateAdded { get; set; }
    public DateTime? DateFinished { get; set; }
    public int? Rating { get; set; }
    public string? Notes { get; set; }

    public int AuthorId { get; set; }
    public Author Author { get; set; }
}