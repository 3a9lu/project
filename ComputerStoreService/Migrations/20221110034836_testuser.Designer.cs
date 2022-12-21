﻿// <auto-generated />
using BmxShopService;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ComputerStoreService.Migrations
{
    [DbContext(typeof(ShopContext))]
    [Migration("20221110034836_testuser")]
    partial class testuser
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.10");

            modelBuilder.Entity("BmxShopService.Models.Categories", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("categoryName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("id");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("BmxShopService.Models.Deliveries", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("deliveryDate")
                        .HasColumnType("INTEGER");

                    b.Property<int>("productCount")
                        .HasColumnType("INTEGER");

                    b.Property<int>("productsId")
                        .HasColumnType("INTEGER");

                    b.HasKey("id");

                    b.HasIndex("productsId");

                    b.ToTable("Deliveries");
                });

            modelBuilder.Entity("BmxShopService.Models.Manufacturers", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("manufacturerName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Manufacturers");
                });

            modelBuilder.Entity("BmxShopService.Models.OrderItems", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("orderId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("productCount")
                        .HasColumnType("INTEGER");

                    b.Property<int>("productId")
                        .HasColumnType("INTEGER");

                    b.HasKey("id");

                    b.HasIndex("orderId");

                    b.HasIndex("productId");

                    b.ToTable("OrderItems");
                });

            modelBuilder.Entity("BmxShopService.Models.Orders", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("customerAdress")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("customerNumber")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("purchaseDate")
                        .HasColumnType("INTEGER");

                    b.HasKey("id");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("BmxShopService.Models.Products", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("ManufacturerId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("categoryId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("productDescription")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("productName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<float>("productPrice")
                        .HasColumnType("REAL");

                    b.HasKey("id");

                    b.HasIndex("ManufacturerId");

                    b.HasIndex("categoryId");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("BmxShopService.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("User");
                });

            modelBuilder.Entity("BmxShopService.Models.UserLogin", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Login")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Role")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("UserId");

                    b.ToTable("UserLogin");
                });

            modelBuilder.Entity("BmxShopService.Models.Deliveries", b =>
                {
                    b.HasOne("BmxShopService.Models.Products", "products")
                        .WithMany("deliveries")
                        .HasForeignKey("productsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("products");
                });

            modelBuilder.Entity("BmxShopService.Models.OrderItems", b =>
                {
                    b.HasOne("BmxShopService.Models.Orders", "order")
                        .WithMany("orderItems")
                        .HasForeignKey("orderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BmxShopService.Models.Products", "product")
                        .WithMany("orderItems")
                        .HasForeignKey("productId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("order");

                    b.Navigation("product");
                });

            modelBuilder.Entity("BmxShopService.Models.Products", b =>
                {
                    b.HasOne("BmxShopService.Models.Manufacturers", "manufacturer")
                        .WithMany("products")
                        .HasForeignKey("ManufacturerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BmxShopService.Models.Categories", "category")
                        .WithMany("products")
                        .HasForeignKey("categoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("category");

                    b.Navigation("manufacturer");
                });

            modelBuilder.Entity("BmxShopService.Models.UserLogin", b =>
                {
                    b.HasOne("BmxShopService.Models.User", "User")
                        .WithOne("userLogin")
                        .HasForeignKey("BmxShopService.Models.UserLogin", "UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("BmxShopService.Models.Categories", b =>
                {
                    b.Navigation("products");
                });

            modelBuilder.Entity("BmxShopService.Models.Manufacturers", b =>
                {
                    b.Navigation("products");
                });

            modelBuilder.Entity("BmxShopService.Models.Orders", b =>
                {
                    b.Navigation("orderItems");
                });

            modelBuilder.Entity("BmxShopService.Models.Products", b =>
                {
                    b.Navigation("deliveries");

                    b.Navigation("orderItems");
                });

            modelBuilder.Entity("BmxShopService.Models.User", b =>
                {
                    b.Navigation("userLogin")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
