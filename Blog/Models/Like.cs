namespace Blog.Models
{
    public class Like
    {
        public int ID { get; set; }
        public int UserID { get; set; }
        public int PostID { get; set; }

        public static string GetTableName()
        {
            return "like";
        }
    }
}
