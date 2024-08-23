using EcomFinal_usingaspDotNetCoreMvc.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace EcomFinal_usingaspDotNetCoreMvc.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
        public DbSet<User> Users { get; set; }
        public DbSet<Product> Products { get; set; }


    }
}
