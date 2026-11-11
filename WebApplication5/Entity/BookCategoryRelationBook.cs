
namespace WebApplication5.Entity
{
    public class BookCategoryRelationBook : Entity
    {
        public int BookId { get; set; }
        public virtual Book Book { get; set; }
        public int CategoryBookId { get; set; }
        public virtual BookCategory BookCategory { get; set; }
    }
}
