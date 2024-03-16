using DepartmentManagementSystem.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace DepartmentManagementSystem.Data
{
    public class ItemDb : IdentityDbContext
    {
        public ItemDb(DbContextOptions options) : base(options)
        {
        }

        //public DbSet<Item> Items { get; set; }
        public DbSet<AppUser> ApplicationUsers { get; set; }
    }
}