using WebApplication5.Context;
using WebApplication5.Entity;
using WebApplication5.Interfaces;

namespace WebApplication5.Services
{
    public class CourseRiposiroty(AppDbContext _context) : GenericRepository<Course>(_context), ICourseReposiroty
    {
     
    }
}
