namespace Blog.Models
{
    public class Post
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime Created_at { get; set; }
        public DateTime Published_at { get; set; }
        public DateTime Deleted_at { get; set; }

        public static string GetTableName()
        {
            return "post";
        }
    }
}
