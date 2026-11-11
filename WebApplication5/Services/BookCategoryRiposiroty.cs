using WebApplication5.Context;
using WebApplication5.Entity;
using WebApplication5.Interfaces;

namespace WebApplication5.Services
{
    public class BookCategoryRiposiroty(AppDbContext _context) : GenericRepository<BookCategory>(_context), IBookCategoryReposiroty
    {
     
    }
}
