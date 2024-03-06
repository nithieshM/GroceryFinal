using GroceryApp.Models;
using GroceryFinal.Model;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Reflection.Emit;

namespace GroceryApp.DataAccess.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<CustomerDetails> CustomerDetailsTable { get; set; }
        public DbSet<Supplier> SupplierTable { get; set; }
        public DbSet<Product> ProductTable { get; set; }
        public DbSet<UOM> UOMTable { get; set; }
       
    }
}