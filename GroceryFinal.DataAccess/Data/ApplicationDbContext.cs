using GroceryApp.Models;
using GroceryFinal.Model;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Reflection.Emit;

namespace GroceryApp.DataAccess.Data
{
    public class ApplicationDbContext : IdentityDbContext<IdentityUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<CustomerDetails> CustomerDetailsTable { get; set; }
        public DbSet<Supplier> SupplierTable { get; set; }
        public DbSet<Product> ProductTable { get; set; }
        public DbSet<UOM> UOMTable { get; set; }
        public DbSet<State> StateTable { get; set; }
        public DbSet<ApplicationUser> ApplicationUsers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<State>().HasData(
                new State { StateId = 1, StateName = "Andhra Pradesh" },
                new State { StateId = 2, StateName = "Arunachal Pradesh" },
                new State { StateId = 3, StateName = "Assam" },
                new State { StateId = 4, StateName = "Bihar" },
                new State { StateId = 5, StateName = "Chhattisgarh" },
                new State { StateId = 6, StateName = "Goa" },
                new State { StateId = 7, StateName = "Gujarat" },
                new State { StateId = 8, StateName = "Haryana" },
                new State { StateId = 9, StateName = "Himachal Pradesh" },
                new State { StateId = 10, StateName = "Jharkhand" },
                new State { StateId = 11, StateName = "Karnataka" },
                new State { StateId = 12, StateName = "Kerala" },
                new State { StateId = 13, StateName = "Madhya Pradesh" },
                new State { StateId = 14, StateName = "Maharashtra" },
                new State { StateId = 15, StateName = "Manipur" },
                new State { StateId = 16, StateName = "Meghalaya" },
                new State { StateId = 17, StateName = "Mizoram" },
                new State { StateId = 18, StateName = "Nagaland" },
                new State { StateId = 19, StateName = "Odisha" },
                new State { StateId = 20, StateName = "Punjab" },
                new State { StateId = 21, StateName = "Rajasthan" },
                new State { StateId = 22, StateName = "Sikkim" },
                new State { StateId = 23, StateName = "Tamil Nadu" },
                new State { StateId = 24, StateName = "Telangana" },
                new State { StateId = 25, StateName = "Tripura" },
                new State { StateId = 26, StateName = "Uttarakhand" },
                new State { StateId = 27, StateName = "Uttar Pradesh" },
                new State { StateId = 28, StateName = "West Bengal" },
                new State { StateId = 29, StateName = "Andaman and Nicobar Islands" },
                new State { StateId = 30, StateName = "Chandigarh" },
                new State { StateId = 31, StateName = "Dadra and Nagar Haveli and Daman and Diu" },
                new State { StateId = 32, StateName = "Delhi" },
                new State { StateId = 33, StateName = "Jammu and Kashmir" },
                new State { StateId = 34, StateName = "Ladakh" },
                new State { StateId = 35, StateName = "Lakshadweep" },
                new State { StateId = 36, StateName = "Puducherry" });
        }
    }
}