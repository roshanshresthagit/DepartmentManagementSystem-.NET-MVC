using DepartmentManagementSystem.Models;
using DepartmentManagementSystem.Models.Domain;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace DepartmentManagementSystem.Data
{
    public class ItemDb : IdentityDbContext
    {
        public ItemDb(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Item> Items { get; set; }
        public DbSet<ApplicationUser> ApplicationUsers { get; set; }
    }
}