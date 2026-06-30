namespace Uppgift4.Models
{
    public class MovieModel
    {
        public int Id { get; set; }

        public required string Title { get; set; }

        public string? Year { get; set; }

        public bool Watched { get; set;}
    }
}