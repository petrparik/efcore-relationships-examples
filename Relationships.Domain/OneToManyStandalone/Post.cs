namespace Relationships.Domain.OneToManyStandalone
{
    public class Post
    {
        public int PostID { get; set; }
        public int CategoryID { get; set; }
        public Category Category { get; set; }
    }
}