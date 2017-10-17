using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;

namespace identity_web.db
{
    /// <summary>
    /// 设计时DbContext工厂
    /// </summary>
    public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<AppDbContext>
    {
        public AppDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<AppDbContext>();
            IConfigurationRoot configuration = new ConfigurationBuilder()
              .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
              .AddJsonFile("appsettings.json")
              .Build();
            var conn = configuration.GetConnectionString("‌​DefaultConnection");
            Console.WriteLine(conn);
            builder.UseSqlite(conn);
            return new AppDbContext(builder.Options);

        }
    }
}
