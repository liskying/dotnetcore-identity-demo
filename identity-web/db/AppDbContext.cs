
using Microsoft.EntityFrameworkCore;
using System;
using identity_web.db.domain;

namespace identity_web.db
{
    /// <summary>
    /// Db上下文
    /// </summary>
    public class AppDbContext : DbContext
    {
        /// <summary>
        /// 博客
        /// </summary>
        public DbSet<Blog> Blogs { get; set; }
        /// <summary>
        /// 评论
        /// </summary>
        public DbSet<Post> Posts { get; set; }
        /// <summary>
        /// 用户
        /// </summary>
        public DbSet<TyUser> Users { get; set; }
        /// <summary>
        /// 角色
        /// </summary>
        public DbSet<TyRole> Roles { get; set; }

        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="options"></param>
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Post>().HasOne(e => e.Blog).WithMany(e => e.Posts).HasForeignKey(e => e.BlogId);
            base.OnModelCreating(modelBuilder);
        }
    }
}