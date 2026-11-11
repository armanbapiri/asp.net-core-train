namespace WebApplication5.Entity
{
    public class BookCategory : Entity
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public virtual List<BookCategoryRelationBook> Books { get; set; }
    }
}
