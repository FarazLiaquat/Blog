using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Bog.Models;

namespace Bog.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Bog.Models.Comment>? Comment { get; set; }
        public DbSet<Bog.Models.Post>? Post { get; set; }
    }
}