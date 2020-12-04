﻿// <auto-generated />
using ArtShop3.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ArtShop3.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20200429210255_InitialMigration")]
    partial class InitialMigration
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
                });

            modelBuilder.Entity("ArtShop3.Models.Art", b =>
                {
                    b.HasOne("ArtShop3.Models.Category", "Category")
                        .WithMany("Arts")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}