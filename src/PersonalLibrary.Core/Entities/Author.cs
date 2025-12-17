namespace PersonalLibrary.Core.Entities;

public class Author
{
    public int Id { get; set; }
    public string FirstNaame { get; set; }
    public string LastName { get; set; }
    public string? Biography { get; set; }
    public int? BirthYear { get; set; }

    public ICollection<Book> Books { get; set; } = new List<Book>();
}