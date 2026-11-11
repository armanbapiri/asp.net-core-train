using WebApplication5.Services;

namespace WebApplication5.Interfaces
{
    public interface IUnitOfWork
    {
        public ICourseReposiroty Courses { get; }
        public IBookReposiroty Books { get; }
        public IBookCategoryReposiroty BookCategories { get; }
        public IBookCategoryRelationsReposiroty bookCategoryRelations { get; }
        public ITeacherReposiroty Teachers { get; }

        int Complete();
    }
}
