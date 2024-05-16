namespace Blog.Models
{
    public class Post
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime Created_at { get; set; }
        public DateTime Published_at { get; set; }
        public DateTime Deleted_at { get; set; }
    }
}
