﻿// <auto-generated />
using System;
using ArtShop3.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ArtShop3.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20200430151104_ShoppingCartAdded")]
    partial class ShoppingCartAdded
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ArtShop3.Models.Art", b =>
                {
                    b.Property<int>("ArtId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("varchar(2000)");

                    b.Property<string>("ImageThumbnailUrl")
                        .HasColumnType("varchar(2000)");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("varchar(2000)");

                    b.Property<bool>("InStock")
                        .HasColumnType("boolean");

                    b.Property<bool>("IsArtOfTheWeek")
                        .HasColumnType("boolean");

                    b.Property<string>("Name")
                        .HasColumnType("varchar(2000)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

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
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CategoryName")
                        .HasColumnType("varchar(2000)");

                    b.Property<string>("Description")
                        .HasColumnType("varchar(2000)");

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

            modelBuilder.Entity("ArtShop3.Models.ShoppingCartItem", b =>
                {
                    b.Property<int>("timestamp")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Amount")
                        .HasColumnType("int");

                    b.Property<int?>("ArtId")
                        .HasColumnType("int");

                    b.Property<string>("ShoppingCartId")
                        .HasColumnType("varchar(2000)");

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
                });

            modelBuilder.Entity("ArtShop3.Models.ShoppingCartItem", b =>
                {
                    b.HasOne("ArtShop3.Models.Art", "Art")
                        .WithMany()
                        .HasForeignKey("ArtId");
                });
#pragma warning restore 612, 618
        }
    }
}
