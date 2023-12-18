using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
namespace ALSAFA.Models
{
    public class MyStoreDB :IdentityDbContext
    {
        public MyStoreDB(DbContextOptions<MyStoreDB>options):base(options)
        {
            
        }
        
        public DbSet<Category> Categories { get; set; }
        public DbSet<SubCategory> SubCategories { get; set; }
        public DbSet<item> items { get; set; }

        //comment
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }
}
