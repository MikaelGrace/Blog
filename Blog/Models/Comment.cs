namespace Blog.Models
{
    public class Comment
    {
        public int PostID { get; set; }
        public string Content { get; set; }
        public string Author { get; set; }
        public DateTime Created_at { get; set; }
        public DateTime Deleted_at { get; set; }
    }
}
