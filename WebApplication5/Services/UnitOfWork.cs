using WebApplication5.Context;
using WebApplication5.Interfaces;

namespace WebApplication5.Services
{
    public class UnitOfWork(AppDbContext context) : IUnitOfWork
    {



        public ICourseReposiroty Courses { get; } = new CourseRiposiroty(context);
        public IBookReposiroty Books { get; } = new BookRiposiroty(context);
        public IBookCategoryReposiroty BookCategories { get; } = new BookCategoryRiposiroty(context);
        public IBookCategoryRelationsReposiroty bookCategoryRelations { get; } = new BookCategoryRelationsReposiroty(context);
        public ITeacherReposiroty Teachers { get; } = new TeacherRiposiroty(context);



        public int Complete()
        {
            return context.SaveChanges();
        }
    }
}
