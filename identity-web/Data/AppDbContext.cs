using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using identity_web.Models;
using identity_web.Data.Domain;

namespace identity_web.Data
{
    /// <summary>
    /// DB上下文
    /// </summary>
    public class AppDbContext : IdentityDbContext<TyUser, TyRole, string, TyUserClaim, TyUserRole, TyUserLogin, TyRoleClaim, TyUserToken>
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
        /// 用户令牌
        /// </summary>
        public DbSet<TyUserToken> UserToken { get; set; }


        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="options"></param>
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        /// <summary>
        /// 模型配置
        /// </summary>
        /// <param name="modelBuilder"></param>
        protected override void OnModelCreating(ModelBuilder builder)
        {
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);

            base.OnModelCreating(builder);
            
            
            builder.Entity<Post>().HasKey(e => e.Id);
            builder.Entity<Blog>().HasKey(e => e.Id);
            builder.Entity<TyUser>().HasKey(e => e.Id);
            builder.Entity<TyUserLogin>().HasKey(e => e.Id);
            builder.Entity<TyRole>().HasKey(e => e.Id);
            builder.Entity<TyRoleClaim>().HasKey(e => e.Id);
            builder.Entity<TyUserClaim>().HasKey(e => e.Id);
            builder.Entity<TyUserToken>().HasKey(e => e.Id);


            builder.Entity<Post>().Property(e=>e.Id).HasMaxLength(36);
            builder.Entity<Blog>().Property(e=>e.Id).HasMaxLength(36);
            builder.Entity<TyUser>().Property(e=>e.Id).HasMaxLength(36);
            builder.Entity<TyUserLogin>().Property(e=>e.Id).HasMaxLength(36);
            builder.Entity<TyRole>().Property(e=>e.Id).HasMaxLength(36);
            builder.Entity<TyRoleClaim>().Property(e=>e.Id).HasMaxLength(36);
            builder.Entity<TyUserClaim>().Property(e=>e.Id).HasMaxLength(36);
            builder.Entity<TyUserToken>().Property(e=>e.Id).HasMaxLength(36);

            builder.Entity<Post>().HasOne(e => e.Blog).WithMany(e => e.Posts).HasForeignKey(e => e.BlogId);

        }
    }
}
