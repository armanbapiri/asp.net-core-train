using Microsoft.EntityFrameworkCore;
using WebApplication5.Entity;



namespace WebApplication5.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {

        }


        public DbSet<Course> Courses { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Address> Addresses { get; set; }

        public DbSet<Book> Books { get; set; }
        public DbSet<BookCategory> BookCategories { get; set; }
        public  DbSet<BookCategoryRelationBook> BookCategoryRelations { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {


            modelBuilder.Entity<Teacher>()
                .HasMany(t => t.courses)
                .WithOne(c => c.Teacher)
                .HasForeignKey(c => c.TeacherId);



            modelBuilder.Entity<Course>()
                .HasOne(c => c.Teacher)
                .WithMany(t => t.courses)
                .HasForeignKey(c => c.TeacherId);

            modelBuilder.Entity<Student>()
                .HasOne(s => s.Address)
                .WithOne(a => a.Student)
                .HasForeignKey<Address>(a => a.StudentId);

            modelBuilder.Entity<BookCategoryRelationBook>()
                .HasKey(bcrb => new { bcrb.BookId, bcrb.CategoryBookId });

            modelBuilder.Entity<BookCategoryRelationBook>()
                .HasOne(bcrb => bcrb.Book)
                .WithMany(b => b.Categories)
                .HasForeignKey(b => b.BookId);


            modelBuilder.Entity<BookCategoryRelationBook>()
               .HasOne(bcrb => bcrb.BookCategory)
               .WithMany(b => b.Books)
               .HasForeignKey(b => b.CategoryBookId);


            base.OnModelCreating(modelBuilder);
        }
    }
}
