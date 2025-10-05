namespace WebApp.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int YearOfPublication { get; set; }
        public string AuthorName { get; set; }
    }
}