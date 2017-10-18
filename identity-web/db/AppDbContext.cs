
using Microsoft.EntityFrameworkCore;
using System;
using identity_web.db.domain;
using Microsoft.AspNetCore.Identity;

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
        /// 用户声明
        /// </summary>
        public DbSet<TyUserClaim> UserClaims { get; set; }

        /// <summary>
        /// 用户登录
        /// </summary>
        public DbSet<TyUserLogin> UserLogins { get; set; }
        /// <summary>
        /// 用户令牌
        /// </summary>
        public DbSet<TyUserToken> UserToken { get; set; }

        /// <summary>
        /// 角色声明
        /// </summary>
        public DbSet<TyRoleClaim> RoleClaim { get; set; }

        /// <summary>
        /// 用户角色
        /// </summary>
        public DbSet<TyUserRole> UserRole { get; set; }

        /// <summary>
        /// 认证错误码
        /// </summary>
        ///public DbSet<IdentityError> IdentityErrors { get; set; }


        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="options"></param>
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {

        }
        /// <summary>
        /// 上下文配置
        /// </summary>
        /// <param name="optionsBuilder"></param>
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
        }

        /// <summary>
        /// 模型配置
        /// </summary>
        /// <param name="modelBuilder"></param>
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Post>().HasKey(e=>e.Id);
            modelBuilder.Entity<Blog>().HasKey(e=>e.Id);
            modelBuilder.Entity<TyUser>().HasKey(e=>e.Id);
            modelBuilder.Entity<TyUserRole>().HasKey(e=>e.Id);
            modelBuilder.Entity<TyUserLogin>().HasKey(e=>e.Id);
            modelBuilder.Entity<TyRole>().HasKey(e=>e.Id);
            modelBuilder.Entity<TyRoleClaim>().HasKey(e=>e.Id);
            modelBuilder.Entity<TyUserClaim>().HasKey(e=>e.Id);

            modelBuilder.Entity<Post>().HasOne(e => e.Blog).WithMany(e => e.Posts).HasForeignKey(e => e.BlogId);
                                 
            base.OnModelCreating(modelBuilder);
        }
    }
}