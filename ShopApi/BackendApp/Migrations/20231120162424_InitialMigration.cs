using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BackendApp.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Brands",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    CreatedBy = table.Column<int>(type: "int", nullable: false),
                    ModifiedAt = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    ModifiedBy = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Brands", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NameOfCategory = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: false),
                    CreatedAt = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    CreatedBy = table.Column<int>(type: "int", nullable: false),
                    ModifiedAt = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    ModifiedBy = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PublicUsers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    CreatedBy = table.Column<int>(type: "int", nullable: false),
                    ModifiedAt = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    ModifiedBy = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PublicUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Subcategories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    CreatedBy = table.Column<int>(type: "int", nullable: false),
                    ModifiedAt = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    ModifiedBy = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Subcategories", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Subcategories_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Baskets",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PublicUserId = table.Column<int>(type: "int", nullable: false),
                    DateAdded = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CreatedAt = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    CreatedBy = table.Column<int>(type: "int", nullable: false),
                    ModifiedAt = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    ModifiedBy = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Baskets", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Baskets_PublicUsers_PublicUserId",
                        column: x => x.PublicUserId,
                        principalTable: "PublicUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PublicUserId = table.Column<int>(type: "int", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Username = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PasswordHash = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    PasswordSalt = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    CreatedAt = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    CreatedBy = table.Column<int>(type: "int", nullable: false),
                    ModifiedAt = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    ModifiedBy = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Users_PublicUsers_PublicUserId",
                        column: x => x.PublicUserId,
                        principalTable: "PublicUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SubcategoryId = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    BrandId = table.Column<int>(type: "int", nullable: false),
                    Count = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    CreatedBy = table.Column<int>(type: "int", nullable: false),
                    ModifiedAt = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    ModifiedBy = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Products_Brands_BrandId",
                        column: x => x.BrandId,
                        principalTable: "Brands",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Products_Subcategories_SubcategoryId",
                        column: x => x.SubcategoryId,
                        principalTable: "Subcategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    BasketId = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CreatedAt = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    CreatedBy = table.Column<int>(type: "int", nullable: false),
                    ModifiedAt = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    ModifiedBy = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Orders_Baskets_BasketId",
                        column: x => x.BasketId,
                        principalTable: "Baskets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Favourites",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    DateAdded = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    CreatedAt = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    CreatedBy = table.Column<int>(type: "int", nullable: false),
                    ModifiedAt = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    ModifiedBy = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Favourites", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Favourites_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Favourites_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductBasket",
                columns: table => new
                {
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    BasketId = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductBasket", x => new { x.ProductId, x.BasketId });
                    table.ForeignKey(
                        name: "FK_ProductBasket_Baskets_BasketId",
                        column: x => x.BasketId,
                        principalTable: "Baskets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductBasket_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Brands",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "ModifiedAt", "ModifiedBy", "Name" },
                values: new object[,]
                {
                    { 1, new DateTimeOffset(new DateTime(2023, 11, 20, 18, 24, 24, 544, DateTimeKind.Unspecified).AddTicks(8905), new TimeSpan(0, 2, 0, 0, 0)), 0, new DateTimeOffset(new DateTime(2023, 11, 20, 18, 24, 24, 544, DateTimeKind.Unspecified).AddTicks(8907), new TimeSpan(0, 2, 0, 0, 0)), null, "Apple" },
                    { 2, new DateTimeOffset(new DateTime(2023, 11, 20, 18, 24, 24, 544, DateTimeKind.Unspecified).AddTicks(8911), new TimeSpan(0, 2, 0, 0, 0)), 0, new DateTimeOffset(new DateTime(2023, 11, 20, 18, 24, 24, 544, DateTimeKind.Unspecified).AddTicks(8912), new TimeSpan(0, 2, 0, 0, 0)), null, "LG" },
                    { 3, new DateTimeOffset(new DateTime(2023, 11, 20, 18, 24, 24, 544, DateTimeKind.Unspecified).AddTicks(8914), new TimeSpan(0, 2, 0, 0, 0)), 0, new DateTimeOffset(new DateTime(2023, 11, 20, 18, 24, 24, 544, DateTimeKind.Unspecified).AddTicks(8916), new TimeSpan(0, 2, 0, 0, 0)), null, "Canon" },
                    { 4, new DateTimeOffset(new DateTime(2023, 11, 20, 18, 24, 24, 544, DateTimeKind.Unspecified).AddTicks(8917), new TimeSpan(0, 2, 0, 0, 0)), 0, new DateTimeOffset(new DateTime(2023, 11, 20, 18, 24, 24, 544, DateTimeKind.Unspecified).AddTicks(8919), new TimeSpan(0, 2, 0, 0, 0)), null, "Nikon" },
                    { 5, new DateTimeOffset(new DateTime(2023, 11, 20, 18, 24, 24, 544, DateTimeKind.Unspecified).AddTicks(8921), new TimeSpan(0, 2, 0, 0, 0)), 0, new DateTimeOffset(new DateTime(2023, 11, 20, 18, 24, 24, 544, DateTimeKind.Unspecified).AddTicks(8922), new TimeSpan(0, 2, 0, 0, 0)), null, "Google" },
                    { 6, new DateTimeOffset(new DateTime(2023, 11, 20, 18, 24, 24, 544, DateTimeKind.Unspecified).AddTicks(8924), new TimeSpan(0, 2, 0, 0, 0)), 0, new DateTimeOffset(new DateTime(2023, 11, 20, 18, 24, 24, 544, DateTimeKind.Unspecified).AddTicks(8926), new TimeSpan(0, 2, 0, 0, 0)), null, "Samsung" },
                    { 7, new DateTimeOffset(new DateTime(2023, 11, 20, 18, 24, 24, 544, DateTimeKind.Unspecified).AddTicks(8928), new TimeSpan(0, 2, 0, 0, 0)), 0, new DateTimeOffset(new DateTime(2023, 11, 20, 18, 24, 24, 544, DateTimeKind.Unspecified).AddTicks(8929), new TimeSpan(0, 2, 0, 0, 0)), null, "Nvidia" },
                    { 8, new DateTimeOffset(new DateTime(2023, 11, 20, 18, 24, 24, 544, DateTimeKind.Unspecified).AddTicks(8932), new TimeSpan(0, 2, 0, 0, 0)), 0, new DateTimeOffset(new DateTime(2023, 11, 20, 18, 24, 24, 544, DateTimeKind.Unspecified).AddTicks(8933), new TimeSpan(0, 2, 0, 0, 0)), null, "AMD" },
                    { 9, new DateTimeOffset(new DateTime(2023, 11, 20, 18, 24, 24, 544, DateTimeKind.Unspecified).AddTicks(8935), new TimeSpan(0, 2, 0, 0, 0)), 0, new DateTimeOffset(new DateTime(2023, 11, 20, 18, 24, 24, 544, DateTimeKind.Unspecified).AddTicks(8936), new TimeSpan(0, 2, 0, 0, 0)), null, "GIGABYTE" },
                    { 10, new DateTimeOffset(new DateTime(2023, 11, 20, 18, 24, 24, 544, DateTimeKind.Unspecified).AddTicks(8938), new TimeSpan(0, 2, 0, 0, 0)), 0, new DateTimeOffset(new DateTime(2023, 11, 20, 18, 24, 24, 544, DateTimeKind.Unspecified).AddTicks(8940), new TimeSpan(0, 2, 0, 0, 0)), null, "BenQ" },
                    { 11, new DateTimeOffset(new DateTime(2023, 11, 20, 18, 24, 24, 544, DateTimeKind.Unspecified).AddTicks(8942), new TimeSpan(0, 2, 0, 0, 0)), 0, new DateTimeOffset(new DateTime(2023, 11, 20, 18, 24, 24, 544, DateTimeKind.Unspecified).AddTicks(8943), new TimeSpan(0, 2, 0, 0, 0)), null, "Intel" },
                    { 12, new DateTimeOffset(new DateTime(2023, 11, 20, 18, 24, 24, 544, DateTimeKind.Unspecified).AddTicks(8945), new TimeSpan(0, 2, 0, 0, 0)), 0, new DateTimeOffset(new DateTime(2023, 11, 20, 18, 24, 24, 544, DateTimeKind.Unspecified).AddTicks(8946), new TimeSpan(0, 2, 0, 0, 0)), null, "Fujifilm" },
                    { 13, new DateTimeOffset(new DateTime(2023, 11, 20, 18, 24, 24, 544, DateTimeKind.Unspecified).AddTicks(8948), new TimeSpan(0, 2, 0, 0, 0)), 0, new DateTimeOffset(new DateTime(2023, 11, 20, 18, 24, 24, 544, DateTimeKind.Unspecified).AddTicks(8950), new TimeSpan(0, 2, 0, 0, 0)), null, "Philips" },
                    { 14, new DateTimeOffset(new DateTime(2023, 11, 20, 18, 24, 24, 544, DateTimeKind.Unspecified).AddTicks(8952), new TimeSpan(0, 2, 0, 0, 0)), 0, new DateTimeOffset(new DateTime(2023, 11, 20, 18, 24, 24, 544, DateTimeKind.Unspecified).AddTicks(8953), new TimeSpan(0, 2, 0, 0, 0)), null, "Panasonic" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "ModifiedAt", "ModifiedBy", "NameOfCategory" },
                values: new object[,]
                {
                    { 1, new DateTimeOffset(new DateTime(2023, 11, 20, 18, 24, 24, 544, DateTimeKind.Unspecified).AddTicks(8643), new TimeSpan(0, 2, 0, 0, 0)), 0, new DateTimeOffset(new DateTime(2023, 11, 20, 18, 24, 24, 544, DateTimeKind.Unspecified).AddTicks(8700), new TimeSpan(0, 2, 0, 0, 0)), null, "Laptops, Tablets & PCs" },
                    { 2, new DateTimeOffset(new DateTime(2023, 11, 20, 18, 24, 24, 544, DateTimeKind.Unspecified).AddTicks(8705), new TimeSpan(0, 2, 0, 0, 0)), 0, new DateTimeOffset(new DateTime(2023, 11, 20, 18, 24, 24, 544, DateTimeKind.Unspecified).AddTicks(8707), new TimeSpan(0, 2, 0, 0, 0)), null, "Computer & Office" },
                    { 3, new DateTimeOffset(new DateTime(2023, 11, 20, 18, 24, 24, 544, DateTimeKind.Unspecified).AddTicks(8709), new TimeSpan(0, 2, 0, 0, 0)), 0, new DateTimeOffset(new DateTime(2023, 11, 20, 18, 24, 24, 544, DateTimeKind.Unspecified).AddTicks(8710), new TimeSpan(0, 2, 0, 0, 0)), null, "Hardware & Components" },
                    { 4, new DateTimeOffset(new DateTime(2023, 11, 20, 18, 24, 24, 544, DateTimeKind.Unspecified).AddTicks(8712), new TimeSpan(0, 2, 0, 0, 0)), 0, new DateTimeOffset(new DateTime(2023, 11, 20, 18, 24, 24, 544, DateTimeKind.Unspecified).AddTicks(8714), new TimeSpan(0, 2, 0, 0, 0)), null, "Smartphones, Radio & GPS" },
                    { 5, new DateTimeOffset(new DateTime(2023, 11, 20, 18, 24, 24, 544, DateTimeKind.Unspecified).AddTicks(8716), new TimeSpan(0, 2, 0, 0, 0)), 0, new DateTimeOffset(new DateTime(2023, 11, 20, 18, 24, 24, 544, DateTimeKind.Unspecified).AddTicks(8717), new TimeSpan(0, 2, 0, 0, 0)), null, "Photo / Video" },
                    { 6, new DateTimeOffset(new DateTime(2023, 11, 20, 18, 24, 24, 544, DateTimeKind.Unspecified).AddTicks(8719), new TimeSpan(0, 2, 0, 0, 0)), 0, new DateTimeOffset(new DateTime(2023, 11, 20, 18, 24, 24, 544, DateTimeKind.Unspecified).AddTicks(8721), new TimeSpan(0, 2, 0, 0, 0)), null, "TV / HiFi / Video" }
                });

            migrationBuilder.InsertData(
                table: "Subcategories",
                columns: new[] { "Id", "CategoryId", "CreatedAt", "CreatedBy", "ModifiedAt", "ModifiedBy", "Name" },
                values: new object[,]
                {
                    { 1, 1, new DateTimeOffset(new DateTime(2023, 11, 20, 18, 24, 24, 544, DateTimeKind.Unspecified).AddTicks(8841), new TimeSpan(0, 2, 0, 0, 0)), 0, new DateTimeOffset(new DateTime(2023, 11, 20, 18, 24, 24, 544, DateTimeKind.Unspecified).AddTicks(8845), new TimeSpan(0, 2, 0, 0, 0)), null, "Laptops / Notebooks" },
                    { 2, 1, new DateTimeOffset(new DateTime(2023, 11, 20, 18, 24, 24, 544, DateTimeKind.Unspecified).AddTicks(8848), new TimeSpan(0, 2, 0, 0, 0)), 0, new DateTimeOffset(new DateTime(2023, 11, 20, 18, 24, 24, 544, DateTimeKind.Unspecified).AddTicks(8849), new TimeSpan(0, 2, 0, 0, 0)), null, "Apple MacBook" },
                    { 3, 2, new DateTimeOffset(new DateTime(2023, 11, 20, 18, 24, 24, 544, DateTimeKind.Unspecified).AddTicks(8852), new TimeSpan(0, 2, 0, 0, 0)), 0, new DateTimeOffset(new DateTime(2023, 11, 20, 18, 24, 24, 544, DateTimeKind.Unspecified).AddTicks(8853), new TimeSpan(0, 2, 0, 0, 0)), null, "Monitors" },
                    { 4, 2, new DateTimeOffset(new DateTime(2023, 11, 20, 18, 24, 24, 544, DateTimeKind.Unspecified).AddTicks(8855), new TimeSpan(0, 2, 0, 0, 0)), 0, new DateTimeOffset(new DateTime(2023, 11, 20, 18, 24, 24, 544, DateTimeKind.Unspecified).AddTicks(8857), new TimeSpan(0, 2, 0, 0, 0)), null, "All-in-One Printers" },
                    { 5, 3, new DateTimeOffset(new DateTime(2023, 11, 20, 18, 24, 24, 544, DateTimeKind.Unspecified).AddTicks(8859), new TimeSpan(0, 2, 0, 0, 0)), 0, new DateTimeOffset(new DateTime(2023, 11, 20, 18, 24, 24, 544, DateTimeKind.Unspecified).AddTicks(8860), new TimeSpan(0, 2, 0, 0, 0)), null, "Processors (CPUs)" },
                    { 6, 3, new DateTimeOffset(new DateTime(2023, 11, 20, 18, 24, 24, 544, DateTimeKind.Unspecified).AddTicks(8862), new TimeSpan(0, 2, 0, 0, 0)), 0, new DateTimeOffset(new DateTime(2023, 11, 20, 18, 24, 24, 544, DateTimeKind.Unspecified).AddTicks(8864), new TimeSpan(0, 2, 0, 0, 0)), null, "AMD Graphics cards" },
                    { 7, 4, new DateTimeOffset(new DateTime(2023, 11, 20, 18, 24, 24, 544, DateTimeKind.Unspecified).AddTicks(8866), new TimeSpan(0, 2, 0, 0, 0)), 0, new DateTimeOffset(new DateTime(2023, 11, 20, 18, 24, 24, 544, DateTimeKind.Unspecified).AddTicks(8867), new TimeSpan(0, 2, 0, 0, 0)), null, "Smartphones & Cell Phones" },
                    { 8, 4, new DateTimeOffset(new DateTime(2023, 11, 20, 18, 24, 24, 544, DateTimeKind.Unspecified).AddTicks(8870), new TimeSpan(0, 2, 0, 0, 0)), 0, new DateTimeOffset(new DateTime(2023, 11, 20, 18, 24, 24, 544, DateTimeKind.Unspecified).AddTicks(8871), new TimeSpan(0, 2, 0, 0, 0)), null, "Apple iPhones" },
                    { 9, 5, new DateTimeOffset(new DateTime(2023, 11, 20, 18, 24, 24, 544, DateTimeKind.Unspecified).AddTicks(8873), new TimeSpan(0, 2, 0, 0, 0)), 0, new DateTimeOffset(new DateTime(2023, 11, 20, 18, 24, 24, 544, DateTimeKind.Unspecified).AddTicks(8875), new TimeSpan(0, 2, 0, 0, 0)), null, "Digital Cameras" },
                    { 10, 5, new DateTimeOffset(new DateTime(2023, 11, 20, 18, 24, 24, 544, DateTimeKind.Unspecified).AddTicks(8877), new TimeSpan(0, 2, 0, 0, 0)), 0, new DateTimeOffset(new DateTime(2023, 11, 20, 18, 24, 24, 544, DateTimeKind.Unspecified).AddTicks(8878), new TimeSpan(0, 2, 0, 0, 0)), null, "Instant Cameras" },
                    { 11, 6, new DateTimeOffset(new DateTime(2023, 11, 20, 18, 24, 24, 544, DateTimeKind.Unspecified).AddTicks(8880), new TimeSpan(0, 2, 0, 0, 0)), 0, new DateTimeOffset(new DateTime(2023, 11, 20, 18, 24, 24, 544, DateTimeKind.Unspecified).AddTicks(8882), new TimeSpan(0, 2, 0, 0, 0)), null, "LED TV / LCD TV" },
                    { 12, 6, new DateTimeOffset(new DateTime(2023, 11, 20, 18, 24, 24, 544, DateTimeKind.Unspecified).AddTicks(8884), new TimeSpan(0, 2, 0, 0, 0)), 0, new DateTimeOffset(new DateTime(2023, 11, 20, 18, 24, 24, 544, DateTimeKind.Unspecified).AddTicks(8885), new TimeSpan(0, 2, 0, 0, 0)), null, "OLED TV" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Baskets_PublicUserId",
                table: "Baskets",
                column: "PublicUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Favourites_ProductId",
                table: "Favourites",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Favourites_UserId",
                table: "Favourites",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_BasketId",
                table: "Orders",
                column: "BasketId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductBasket_BasketId",
                table: "ProductBasket",
                column: "BasketId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_BrandId",
                table: "Products",
                column: "BrandId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_SubcategoryId",
                table: "Products",
                column: "SubcategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_PublicUsers_Email",
                table: "PublicUsers",
                column: "Email",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Subcategories_CategoryId",
                table: "Subcategories",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_PublicUserId",
                table: "Users",
                column: "PublicUserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Favourites");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "ProductBasket");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Baskets");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "PublicUsers");

            migrationBuilder.DropTable(
                name: "Brands");

            migrationBuilder.DropTable(
                name: "Subcategories");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
