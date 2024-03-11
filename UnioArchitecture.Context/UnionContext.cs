using Microsoft.EntityFrameworkCore;
using UnioArchitecture_.Domain;

namespace UnioArchitecture.Context
{
    public class UnionContext : DbContext
    {
        public UnionContext(DbContextOptions<UnionContext> options) : base(options)
        {

        }
        public DbSet<Product> products { get; set; }
        public DbSet<Category> categories { get; set; }
        public DbSet<Image> Images { get; set; }
    }
}