using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Webapp.Starter.Data.Entities;

namespace Webapp.Starter.Data
{
    public class StarterContext : DbContext
    {
        public StarterContext(DbContextOptions<StarterContext> options) : base(options)
        {
        }

        public virtual DbSet<Article> Articles { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Article>().HasData(
                new Article()
                {
                    ArticleId = 1,
                    Title = "Magical Tools all devs require",
                    Contents = "VS Code, Entity Framework etc",
                    CreatedDate = DateTime.Now.AddDays(-3),
                    AuthorId = "hanselman"
                },
                new Article()
                {
                    ArticleId = 2,
                    Title = "Dependency Injection in ASP.NET Core",
                    Contents = "Register into the service collection and inject into constructors.",
                    CreatedDate = DateTime.Now.AddDays(-3),
                    AuthorId = "davidfowler"
                },
                new Article()
                {
                    ArticleId = 3,
                    Title = "Structural logging to ELK",
                    Contents = "Using serilog to log into elastic search stack.",
                    CreatedDate = DateTime.Now.AddDays(-3),
                    AuthorId = "numbelhart"
                });
        }
    }
}
