using WebApplication5.Context;
using WebApplication5.Entity;
using WebApplication5.Interfaces;

namespace WebApplication5.Services
{
    public class BookCategoryRelationsReposiroty(AppDbContext _context) : GenericRepository<BookCategoryRelationBook>(_context), IBookCategoryRelationsReposiroty
    {
     
    }
}
