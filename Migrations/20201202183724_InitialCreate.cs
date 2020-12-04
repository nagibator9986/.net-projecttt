using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace ArtShop3.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    CategoryId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    CategoryName = table.Column<string>(type: "text", nullable: true),
                    Description = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.CategoryId);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    OrderId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    Email = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    OrderTotal = table.Column<decimal>(type: "numeric", nullable: false),
                    OrderPlaced = table.Column<DateTime>(type: "timestamp without time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.OrderId);
                });

            migrationBuilder.CreateTable(
                name: "Arts",
                columns: table => new
                {
                    ArtId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: true),
                    Description = table.Column<string>(type: "text", nullable: true),
                    Price = table.Column<decimal>(type: "numeric", nullable: false),
                    ImageUrl = table.Column<string>(type: "text", nullable: true),
                    ImageThumbnailUrl = table.Column<string>(type: "text", nullable: true),
                    IsArtOfTheWeek = table.Column<bool>(type: "boolean", nullable: false),
                    InStock = table.Column<bool>(type: "boolean", nullable: false),
                    CategoryId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Arts", x => x.ArtId);
                    table.ForeignKey(
                        name: "FK_Arts_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "CategoryId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OrderDetails",
                columns: table => new
                {
                    OrderDetailId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    OrderId = table.Column<int>(type: "integer", nullable: false),
                    ArtId = table.Column<int>(type: "integer", nullable: false),
                    Amount = table.Column<int>(type: "integer", nullable: false),
                    Price = table.Column<decimal>(type: "numeric", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderDetails", x => x.OrderDetailId);
                    table.ForeignKey(
                        name: "FK_OrderDetails_Arts_ArtId",
                        column: x => x.ArtId,
                        principalTable: "Arts",
                        principalColumn: "ArtId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderDetails_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "OrderId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ShoppingCartItems",
                columns: table => new
                {
                    ShoppingCartItemId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ArtId = table.Column<int>(type: "integer", nullable: true),
                    Amount = table.Column<int>(type: "integer", nullable: false),
                    ShoppingCartId = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShoppingCartItems", x => x.ShoppingCartItemId);
                    table.ForeignKey(
                        name: "FK_ShoppingCartItems_Arts_ArtId",
                        column: x => x.ArtId,
                        principalTable: "Arts",
                        principalColumn: "ArtId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CategoryName", "Description" },
                values: new object[,]
                {
                    { 1, "Dead Inside Theme", null },
                    { 2, "Naruto Frames", null },
                    { 3, "Manga Frames", null }
                });

            migrationBuilder.InsertData(
                table: "Arts",
                columns: new[] { "ArtId", "CategoryId", "Description", "ImageThumbnailUrl", "ImageUrl", "InStock", "IsArtOfTheWeek", "Name", "Price" },
                values: new object[,]
                {
                    { 1, 1, "Deep inside Photo", "/images/2.jpg", "/images/1.jpg", true, true, "Kaneki Ken", 2000m },
                    { 2, 1, "Deep inside Photo2", "/images/4.png", "/images/3.jpg", true, false, "Kaneki Ken2", 2000m },
                    { 3, 1, "Deep inside Photo3", "/images/6.jpg", "/images/5.jpg", false, true, "Kaneki Ken3", 2000m },
                    { 4, 1, "Deep inside Photo", "/images/8.jpg", "/images/7.jpg", false, false, "Kaneki Ken4", 2000m },
                    { 5, 2, "Deep inside Photo", "/images/naruto2.jpg", "/images/naruto1.jpg", false, true, "Naruto", 2000m },
                    { 6, 2, "Deep inside Photo", "/images/naruto4.jpg", "/images/naruto3.jpg", true, false, "Naruto2", 2000m },
                    { 7, 3, "Deep inside Photo", "/images/kill2.jpg", "/images/kill1.png", true, true, "Killing Stalking", 2000m },
                    { 8, 3, "Deep inside Photo4", "/images/kill4.jpg", "/images/kill3.jpg", false, false, "Killing Stalking2", 2000m }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Arts_CategoryId",
                table: "Arts",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetails_ArtId",
                table: "OrderDetails",
                column: "ArtId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetails_OrderId",
                table: "OrderDetails",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_ShoppingCartItems_ArtId",
                table: "ShoppingCartItems",
                column: "ArtId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OrderDetails");

            migrationBuilder.DropTable(
                name: "ShoppingCartItems");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Arts");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
