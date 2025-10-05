using WebApp.Models;

namespace WebApp.Services
{
    public class BookService : IBookService
    {
        private readonly IImageProvider _imageProvider;

        public BookService(IImageProvider imageProvider)
        {
            _imageProvider = imageProvider;
        }

        public List<Book> GetAllBooks()
        {
            return new List<Book>
            {
                new Book { Id = 1, Title = "The Great Gatsby", Description = "A classic American novel about the Jazz Age", YearOfPublication = 1925, AuthorName = "F. Scott Fitzgerald", ImageUrl = _imageProvider.GetImageUrl("Sample1.jpg") },
                new Book { Id = 2, Title = "1984", Description = "A dystopian social science fiction novel", YearOfPublication = 1949, AuthorName = "George Orwell", ImageUrl = _imageProvider.GetImageUrl("Sample2.jpg") },
                new Book { Id = 3, Title = "Pride and Prejudice", Description = "A romantic novel of manners", YearOfPublication = 1813, AuthorName = "Jane Austen", ImageUrl = _imageProvider.GetImageUrl("Sample1.jpg") },
                new Book { Id = 4, Title = "The Catcher in the Rye", Description = "A controversial novel about teenage rebellion", YearOfPublication = 1951, AuthorName = "J.D. Salinger", ImageUrl = _imageProvider.GetImageUrl("Sample2.jpg") },
                new Book { Id = 5, Title = "The Lord of the Rings", Description = "An epic high fantasy novel", YearOfPublication = 1954, AuthorName = "J.R.R. Tolkien", ImageUrl = _imageProvider.GetImageUrl("Sample1.jpg") },
                new Book { Id = 6, Title = "The Hobbit", Description = "A fantasy novel and prelude to The Lord of the Rings", YearOfPublication = 1937, AuthorName = "J.R.R. Tolkien", ImageUrl = _imageProvider.GetImageUrl("Sample2.jpg") },
                new Book { Id = 7, Title = "Fahrenheit 451", Description = "A dystopian novel about book burning", YearOfPublication = 1953, AuthorName = "Ray Bradbury", ImageUrl = _imageProvider.GetImageUrl("Sample1.jpg") }
            };
        }
    }
}