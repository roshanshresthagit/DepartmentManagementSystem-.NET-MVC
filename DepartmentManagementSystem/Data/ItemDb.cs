using DepartmentManagementSystem.Models.Domain;
using Microsoft.EntityFrameworkCore;

namespace DepartmentManagementSystem.Data
{
    public class ItemDb : DbContext
    {
        public ItemDb(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Item> Items { get; set; }
        public DbSet<ApplicationUser> ApplicationUsers { get; set; }
    }
}
