using CodePulse.API.Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace CodePulse.API.Infrastructure.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        public DbSet<Blogpost> Blogposts { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}
