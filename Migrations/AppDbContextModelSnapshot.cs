﻿// <auto-generated />
using System;
using ArtShop3.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace ArtShop3.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityByDefaultColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 63)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("ArtShop3.Models.Art", b =>
                {
                    b.Property<int>("ArtId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .UseIdentityByDefaultColumn();

                    b.Property<int>("CategoryId")
                        .HasColumnType("integer");

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<string>("ImageThumbnailUrl")
                        .HasColumnType("text");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("text");

                    b.Property<bool>("InStock")
                        .HasColumnType("boolean");

                    b.Property<bool>("IsArtOfTheWeek")
                        .HasColumnType("boolean");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<decimal>("Price")
                        .HasColumnType("numeric");

                    b.HasKey("ArtId");

                    b.HasIndex("CategoryId");

                    b.ToTable("Arts");

                    b.HasData(
                        new
                        {
                            ArtId = 1,
                            CategoryId = 1,
                            Description = "Deep inside Photo",
                            ImageThumbnailUrl = "/images/2.jpg",
                            ImageUrl = "/images/1.jpg",
                            InStock = true,
                            IsArtOfTheWeek = true,
                            Name = "Kaneki Ken",
                            Price = 2000m
                        },
                        new
                        {
                            ArtId = 2,
                            CategoryId = 1,
                            Description = "Deep inside Photo2",
                            ImageThumbnailUrl = "/images/4.png",
                            ImageUrl = "/images/3.jpg",
                            InStock = true,
                            IsArtOfTheWeek = false,
                            Name = "Kaneki Ken2",
                            Price = 2000m
                        },
                        new
                        {
                            ArtId = 3,
                            CategoryId = 1,
                            Description = "Deep inside Photo3",
                            ImageThumbnailUrl = "/images/6.jpg",
                            ImageUrl = "/images/5.jpg",
                            InStock = false,
                            IsArtOfTheWeek = true,
                            Name = "Kaneki Ken3",
                            Price = 2000m
                        },
                        new
                        {
                            ArtId = 4,
                            CategoryId = 1,
                            Description = "Deep inside Photo",
                            ImageThumbnailUrl = "/images/8.jpg",
                            ImageUrl = "/images/7.jpg",
                            InStock = false,
                            IsArtOfTheWeek = false,
                            Name = "Kaneki Ken4",
                            Price = 2000m
                        },
                        new
                        {
                            ArtId = 5,
                            CategoryId = 2,
                            Description = "Deep inside Photo",
                            ImageThumbnailUrl = "/images/naruto2.jpg",
                            ImageUrl = "/images/naruto1.jpg",
                            InStock = false,
                            IsArtOfTheWeek = true,
                            Name = "Naruto",
                            Price = 2000m
                        },
                        new
                        {
                            ArtId = 6,
                            CategoryId = 2,
                            Description = "Deep inside Photo",
                            ImageThumbnailUrl = "/images/naruto4.jpg",
                            ImageUrl = "/images/naruto3.jpg",
                            InStock = true,
                            IsArtOfTheWeek = false,
                            Name = "Naruto2",
                            Price = 2000m
                        },
                        new
                        {
                            ArtId = 7,
                            CategoryId = 3,
                            Description = "Deep inside Photo",
                            ImageThumbnailUrl = "/images/kill2.jpg",
                            ImageUrl = "/images/kill1.png",
                            InStock = true,
                            IsArtOfTheWeek = true,
                            Name = "Killing Stalking",
                            Price = 2000m
                        },
                        new
                        {
                            ArtId = 8,
                            CategoryId = 3,
                            Description = "Deep inside Photo4",
                            ImageThumbnailUrl = "/images/kill4.jpg",
                            ImageUrl = "/images/kill3.jpg",
                            InStock = false,
                            IsArtOfTheWeek = false,
                            Name = "Killing Stalking2",
                            Price = 2000m
                        });
                });

            modelBuilder.Entity("ArtShop3.Models.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .UseIdentityByDefaultColumn();

                    b.Property<string>("CategoryName")
                        .HasColumnType("text");

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.HasKey("CategoryId");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            CategoryId = 1,
                            CategoryName = "Dead Inside Theme"
                        },
                        new
                        {
                            CategoryId = 2,
                            CategoryName = "Naruto Frames"
                        },
                        new
                        {
                            CategoryId = 3,
                            CategoryName = "Manga Frames"
                        });
                });

            modelBuilder.Entity("ArtShop3.Models.Order", b =>
                {
                    b.Property<int>("OrderId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .UseIdentityByDefaultColumn();

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.Property<DateTime>("OrderPlaced")
                        .HasColumnType("timestamp without time zone");

                    b.Property<decimal>("OrderTotal")
                        .HasColumnType("numeric");

                    b.HasKey("OrderId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("ArtShop3.Models.OrderDetail", b =>
                {
                    b.Property<int>("OrderDetailId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .UseIdentityByDefaultColumn();

                    b.Property<int>("Amount")
                        .HasColumnType("integer");

                    b.Property<int>("ArtId")
                        .HasColumnType("integer");

                    b.Property<int>("OrderId")
                        .HasColumnType("integer");

                    b.Property<decimal>("Price")
                        .HasColumnType("numeric");

                    b.HasKey("OrderDetailId");

                    b.HasIndex("ArtId");

                    b.HasIndex("OrderId");

                    b.ToTable("OrderDetails");
                });

            modelBuilder.Entity("ArtShop3.Models.ShoppingCartItem", b =>
                {
                    b.Property<int>("ShoppingCartItemId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .UseIdentityByDefaultColumn();

                    b.Property<int>("Amount")
                        .HasColumnType("integer");

                    b.Property<int?>("ArtId")
                        .HasColumnType("integer");

                    b.Property<string>("ShoppingCartId")
                        .HasColumnType("text");

                    b.HasKey("ShoppingCartItemId");

                    b.HasIndex("ArtId");

                    b.ToTable("ShoppingCartItems");
                });

            modelBuilder.Entity("ArtShop3.Models.Art", b =>
                {
                    b.HasOne("ArtShop3.Models.Category", "Category")
                        .WithMany("Arts")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("ArtShop3.Models.OrderDetail", b =>
                {
                    b.HasOne("ArtShop3.Models.Art", "Art")
                        .WithMany()
                        .HasForeignKey("ArtId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ArtShop3.Models.Order", "Order")
                        .WithMany("OrderDetails")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Art");

                    b.Navigation("Order");
                });

            modelBuilder.Entity("ArtShop3.Models.ShoppingCartItem", b =>
                {
                    b.HasOne("ArtShop3.Models.Art", "Art")
                        .WithMany()
                        .HasForeignKey("ArtId");

                    b.Navigation("Art");
                });

            modelBuilder.Entity("ArtShop3.Models.Category", b =>
                {
                    b.Navigation("Arts");
                });

            modelBuilder.Entity("ArtShop3.Models.Order", b =>
                {
                    b.Navigation("OrderDetails");
                });
#pragma warning restore 612, 618
        }
    }
}