﻿// <auto-generated />
using GroceryApp.DataAccess.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace GroceryFinal.DataAccess.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240307081125_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("GroceryApp.Models.CustomerDetails", b =>
                {
                    b.Property<int>("CustomerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CustomerId"));

                    b.Property<string>("CustomerAddress")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CustomerAddress2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CustomerCity")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CustomerEmail")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CustomerName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CustomerPhone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CustomerState")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CustomerZipCode")
                        .HasColumnType("int");

                    b.HasKey("CustomerId");

                    b.ToTable("CustomerDetailsTable");
                });

            modelBuilder.Entity("GroceryFinal.Model.Product", b =>
                {
                    b.Property<int>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ProductId"));

                    b.Property<string>("ProductName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("PurchaseRate")
                        .HasColumnType("float");

                    b.Property<double>("PurchaseStock")
                        .HasColumnType("float");

                    b.Property<double>("Quantity")
                        .HasColumnType("float");

                    b.Property<double>("ReorderLevel")
                        .HasColumnType("float");

                    b.Property<double>("SellingRate")
                        .HasColumnType("float");

                    b.Property<double>("SellingStock")
                        .HasColumnType("float");

                    b.Property<double>("Stock")
                        .HasColumnType("float");

                    b.Property<int>("SupplierId")
                        .HasColumnType("int");

                    b.Property<int>("UOMId")
                        .HasColumnType("int");

                    b.HasKey("ProductId");

                    b.HasIndex("SupplierId");

                    b.HasIndex("UOMId");

                    b.ToTable("ProductTable");
                });

            modelBuilder.Entity("GroceryFinal.Model.Supplier", b =>
                {
                    b.Property<int>("SupplierId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SupplierId"));

                    b.Property<string>("SupplierAddress")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SupplierAddress2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SupplierCity")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SupplierEmail")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SupplierName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SupplierPhone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SupplierState")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SupplierZipCode")
                        .HasColumnType("int");

                    b.HasKey("SupplierId");

                    b.ToTable("SupplierTable");
                });

            modelBuilder.Entity("GroceryFinal.Model.UOM", b =>
                {
                    b.Property<int>("UOMId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UOMId"));

                    b.Property<string>("UOMName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UOMId");

                    b.ToTable("UOMTable");
                });

            modelBuilder.Entity("GroceryFinal.Model.Product", b =>
                {
                    b.HasOne("GroceryFinal.Model.Supplier", "Supplier")
                        .WithMany()
                        .HasForeignKey("SupplierId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("GroceryFinal.Model.UOM", "UOM")
                        .WithMany()
                        .HasForeignKey("UOMId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Supplier");

                    b.Navigation("UOM");
                });
#pragma warning restore 612, 618
        }
    }
}
