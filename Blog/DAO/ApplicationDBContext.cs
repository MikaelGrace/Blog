using Blog.Models;
using Microsoft.EntityFrameworkCore;

namespace Blog.DAO
{
    public class ApplicationDBContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Like> Likes { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connect = "Server=localhost;Database=blogs_db;Uid=root;Pwd=Mysql2024;";
            optionsBuilder.UseMySql(connect, ServerVersion.AutoDetect(connect));
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<User>().ToTable(User.GetTableName());
            modelBuilder.Entity<Post>().ToTable(Post.GetTableName());
            modelBuilder.Entity<Comment>().ToTable(Comment.GetTableName());
            modelBuilder.Entity<Like>().ToTable(Like.GetTableName());
        }
    }
}
