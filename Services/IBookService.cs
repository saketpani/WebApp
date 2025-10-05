using WebApp.Models;

namespace WebApp.Services
{
    public interface IBookService
    {
        List<Book> GetAllBooks();
    }
}