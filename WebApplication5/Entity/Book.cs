namespace WebApplication5.Entity
{
    public class Book : Entity
    {
        public string Title { get; set; }
        public string PageCount { get; set; }

        public string AutherName { get; set; }
        public virtual List<BookCategoryRelationBook> Categories { get; set; }
    }
}
