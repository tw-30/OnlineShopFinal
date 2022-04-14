﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using OnlineShop.Models;

namespace OnlineShop.Migrations
{
    [DbContext(typeof(ShopContext))]
    partial class ShopContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("OnlineShop.Models.Category", b =>
                {
                    b.Property<int>("CategoryID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CategoryID");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            CategoryID = 1,
                            Name = "Laptops"
                        },
                        new
                        {
                            CategoryID = 2,
                            Name = "Computers"
                        },
                        new
                        {
                            CategoryID = 3,
                            Name = "Mobile Phones"
                        });
                });

            modelBuilder.Entity("OnlineShop.Models.Product", b =>
                {
                    b.Property<int>("ProductID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CategoryID")
                        .HasColumnType("int");

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("ProductID");

                    b.HasIndex("CategoryID");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            ProductID = 1,
                            CategoryID = 1,
                            Code = "MacPro",
                            Name = "Macbook Pro ",
                            Price = 999m
                        },
                        new
                        {
                            ProductID = 2,
                            CategoryID = 1,
                            Code = "Omen16T",
                            Name = "Omen by HP Laptop 16t-b100",
                            Price = 1099.99m
                        },
                        new
                        {
                            ProductID = 3,
                            CategoryID = 1,
                            Code = "Victus16T",
                            Name = "Victus by HP 16T-d100",
                            Price = 849.99m
                        },
                        new
                        {
                            ProductID = 4,
                            CategoryID = 1,
                            Code = "GalaxyBook",
                            Name = "Samsung Galaxy Book Pro 360",
                            Price = 999m
                        },
                        new
                        {
                            ProductID = 5,
                            CategoryID = 1,
                            Code = "Inspiron3511",
                            Name = "Dell Inspiron 3511",
                            Price = 439.99m
                        },
                        new
                        {
                            ProductID = 6,
                            CategoryID = 1,
                            Code = "VivoBook",
                            Name = "Asus Vivobook",
                            Price = 319.99m
                        },
                        new
                        {
                            ProductID = 7,
                            CategoryID = 2,
                            Code = "EnvyPC",
                            Name = "HP Envy Desktop",
                            Price = 689.99m
                        },
                        new
                        {
                            ProductID = 8,
                            CategoryID = 2,
                            Code = "Vengance",
                            Name = "Corsair Vengance a7200",
                            Price = 1999.99m
                        },
                        new
                        {
                            ProductID = 9,
                            CategoryID = 3,
                            Code = "Iphone13Pro",
                            Name = "Iphone 13 Pro",
                            Price = 999.99m
                        },
                        new
                        {
                            ProductID = 10,
                            CategoryID = 3,
                            Code = "GalaxyS22",
                            Name = "Samsung Galaxy S22 Ultra",
                            Price = 399.99m
                        });
                });

            modelBuilder.Entity("OnlineShop.Models.Product", b =>
                {
                    b.HasOne("OnlineShop.Models.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
