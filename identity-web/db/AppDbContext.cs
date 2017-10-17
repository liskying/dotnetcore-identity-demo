
using Microsoft.EntityFrameworkCore;
using System;
using identity_web.db.domain;

namespace identity_web.db
{
    /// <summary>
    /// DB������
    /// </summary>
    public class AppDbContext : DbContext
    {
        /// <summary>
        /// ����
        /// </summary>
        public DbSet<Blog> Blogs { get; set; }
        /// <summary>
        /// ����
        /// </summary>
        public DbSet<Post> Posts { get; set; }
        /// <summary>
        /// �û�
        /// </summary>
        public DbSet<TyUser> Users { get; set; }
        /// <summary>
        /// ��ɫ
        /// </summary>
        public DbSet<TyRole> Roles { get; set; }

        /// <summary>
        /// ���캯��
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