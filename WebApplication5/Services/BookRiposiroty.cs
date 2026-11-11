using WebApplication5.Context;
using WebApplication5.Entity;
using WebApplication5.Interfaces;

namespace WebApplication5.Services
{
    public class BookRiposiroty(AppDbContext _context) : GenericRepository<Book>(_context), IBookReposiroty
    {
     
    }
}
