﻿using Microsoft.EntityFrameworkCore;
using mytown.Models;
using Stripe.Climate;

namespace mytown.Models
{
    namespace mytown.DataAccess
    {
        public class AppDbContext : DbContext
        {
            public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

            public DbSet<User> Users { get; set; }
            public DbSet<Registration> Registrations { get; set; } // Pluralized name
            public DbSet<BusinessRegister> BusinessRegisters { get; set; } // Pluralized name
            public DbSet<businessprofile> BusinessProfiles { get; set; }
            public DbSet<businessservices> BusinessServices { get; set; }
            public DbSet<businesscategoriescs> BusinessCategories { get; set; }
            public DbSet<product_sub_categories> product_sub_categories { get; set; }
            public DbSet<services_sub_categories> services_sub_categories { get; set; }
            public DbSet<products> products { get; set; }
            public DbSet<services> services { get; set; }
            public DbSet<shopperregister> ShopperRegisters { get; set; }
            public DbSet<ShopperVerification> ShopperVerification { get; set; }
            public DbSet<subcategoryimages_busregid> Subcategoryimages_Busregids { get; set; }
            public IEnumerable<object> businessprofile { get; internal set; }

            public DbSet<addtocart> addtocart { get; set; }
            public DbSet<order> Orders { get; set; }

            public DbSet<orderdetails> OrderDetails { get; set; }
            public DbSet<Payments> Payments { get; set; }
            protected override void OnModelCreating(ModelBuilder modelBuilder)
            {
                base.OnModelCreating(modelBuilder);

                // Define precision and scale for the decimal fields in the products table
                modelBuilder.Entity<products>(entity =>
                {
                    entity.Property(e => e.product_cost)
                          .HasPrecision(18, 2);  // precision = 18, scale = 2

                    entity.Property(e => e.product_length)
                          .HasPrecision(18, 2);

                    entity.Property(e => e.product_width)
                          .HasPrecision(18, 2);

                    entity.Property(e => e.product_weight)
                          .HasPrecision(18, 2);

                    entity.Property(e => e.product_quantity)
                          .HasPrecision(18, 2);
                });

                // Optionally, you can add similar configuration for other models
                modelBuilder.Entity<services>(entity =>
                {
                    entity.Property(e => e.service_cost)
                          .HasPrecision(18, 2); // Define precision for service_cost
                });
                modelBuilder.Entity<subcategoryimages_busregid>().ToTable("subcategoryimages_Busregids");
            }
        }
            
        
    }
}
