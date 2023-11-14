using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BackendApp.Migrations
{
    /// <inheritdoc />
    public partial class PublicUserBasketRelation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Baskets_PublicUserId",
                table: "Baskets");

            migrationBuilder.DropColumn(
                name: "Quantity",
                table: "Baskets");

            migrationBuilder.AddColumn<int>(
                name: "BasketId",
                table: "PublicUsers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Quantity",
                table: "ProductBasket",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 6, 13, 52, 30, 800, DateTimeKind.Unspecified).AddTicks(5536), new TimeSpan(0, 2, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 6, 13, 52, 30, 800, DateTimeKind.Unspecified).AddTicks(5538), new TimeSpan(0, 2, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 6, 13, 52, 30, 800, DateTimeKind.Unspecified).AddTicks(5540), new TimeSpan(0, 2, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 6, 13, 52, 30, 800, DateTimeKind.Unspecified).AddTicks(5542), new TimeSpan(0, 2, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 6, 13, 52, 30, 800, DateTimeKind.Unspecified).AddTicks(5544), new TimeSpan(0, 2, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 6, 13, 52, 30, 800, DateTimeKind.Unspecified).AddTicks(5545), new TimeSpan(0, 2, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 6, 13, 52, 30, 800, DateTimeKind.Unspecified).AddTicks(5547), new TimeSpan(0, 2, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 6, 13, 52, 30, 800, DateTimeKind.Unspecified).AddTicks(5548), new TimeSpan(0, 2, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 6, 13, 52, 30, 800, DateTimeKind.Unspecified).AddTicks(5550), new TimeSpan(0, 2, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 6, 13, 52, 30, 800, DateTimeKind.Unspecified).AddTicks(5552), new TimeSpan(0, 2, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 6, 13, 52, 30, 800, DateTimeKind.Unspecified).AddTicks(5554), new TimeSpan(0, 2, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 6, 13, 52, 30, 800, DateTimeKind.Unspecified).AddTicks(5555), new TimeSpan(0, 2, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 6, 13, 52, 30, 800, DateTimeKind.Unspecified).AddTicks(5557), new TimeSpan(0, 2, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 6, 13, 52, 30, 800, DateTimeKind.Unspecified).AddTicks(5558), new TimeSpan(0, 2, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 6, 13, 52, 30, 800, DateTimeKind.Unspecified).AddTicks(5560), new TimeSpan(0, 2, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 6, 13, 52, 30, 800, DateTimeKind.Unspecified).AddTicks(5562), new TimeSpan(0, 2, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 6, 13, 52, 30, 800, DateTimeKind.Unspecified).AddTicks(5600), new TimeSpan(0, 2, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 6, 13, 52, 30, 800, DateTimeKind.Unspecified).AddTicks(5601), new TimeSpan(0, 2, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 6, 13, 52, 30, 800, DateTimeKind.Unspecified).AddTicks(5603), new TimeSpan(0, 2, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 6, 13, 52, 30, 800, DateTimeKind.Unspecified).AddTicks(5605), new TimeSpan(0, 2, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 6, 13, 52, 30, 800, DateTimeKind.Unspecified).AddTicks(5607), new TimeSpan(0, 2, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 6, 13, 52, 30, 800, DateTimeKind.Unspecified).AddTicks(5608), new TimeSpan(0, 2, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 6, 13, 52, 30, 800, DateTimeKind.Unspecified).AddTicks(5610), new TimeSpan(0, 2, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 6, 13, 52, 30, 800, DateTimeKind.Unspecified).AddTicks(5612), new TimeSpan(0, 2, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 6, 13, 52, 30, 800, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 2, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 6, 13, 52, 30, 800, DateTimeKind.Unspecified).AddTicks(5615), new TimeSpan(0, 2, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 6, 13, 52, 30, 800, DateTimeKind.Unspecified).AddTicks(5617), new TimeSpan(0, 2, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 6, 13, 52, 30, 800, DateTimeKind.Unspecified).AddTicks(5618), new TimeSpan(0, 2, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 6, 13, 52, 30, 800, DateTimeKind.Unspecified).AddTicks(5273), new TimeSpan(0, 2, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 6, 13, 52, 30, 800, DateTimeKind.Unspecified).AddTicks(5329), new TimeSpan(0, 2, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 6, 13, 52, 30, 800, DateTimeKind.Unspecified).AddTicks(5333), new TimeSpan(0, 2, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 6, 13, 52, 30, 800, DateTimeKind.Unspecified).AddTicks(5335), new TimeSpan(0, 2, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 6, 13, 52, 30, 800, DateTimeKind.Unspecified).AddTicks(5337), new TimeSpan(0, 2, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 6, 13, 52, 30, 800, DateTimeKind.Unspecified).AddTicks(5338), new TimeSpan(0, 2, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 6, 13, 52, 30, 800, DateTimeKind.Unspecified).AddTicks(5340), new TimeSpan(0, 2, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 6, 13, 52, 30, 800, DateTimeKind.Unspecified).AddTicks(5342), new TimeSpan(0, 2, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 6, 13, 52, 30, 800, DateTimeKind.Unspecified).AddTicks(5343), new TimeSpan(0, 2, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 6, 13, 52, 30, 800, DateTimeKind.Unspecified).AddTicks(5345), new TimeSpan(0, 2, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 6, 13, 52, 30, 800, DateTimeKind.Unspecified).AddTicks(5347), new TimeSpan(0, 2, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 6, 13, 52, 30, 800, DateTimeKind.Unspecified).AddTicks(5348), new TimeSpan(0, 2, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 6, 13, 52, 30, 800, DateTimeKind.Unspecified).AddTicks(5475), new TimeSpan(0, 2, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 6, 13, 52, 30, 800, DateTimeKind.Unspecified).AddTicks(5479), new TimeSpan(0, 2, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 6, 13, 52, 30, 800, DateTimeKind.Unspecified).AddTicks(5481), new TimeSpan(0, 2, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 6, 13, 52, 30, 800, DateTimeKind.Unspecified).AddTicks(5483), new TimeSpan(0, 2, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 6, 13, 52, 30, 800, DateTimeKind.Unspecified).AddTicks(5485), new TimeSpan(0, 2, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 6, 13, 52, 30, 800, DateTimeKind.Unspecified).AddTicks(5487), new TimeSpan(0, 2, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 6, 13, 52, 30, 800, DateTimeKind.Unspecified).AddTicks(5489), new TimeSpan(0, 2, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 6, 13, 52, 30, 800, DateTimeKind.Unspecified).AddTicks(5490), new TimeSpan(0, 2, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 6, 13, 52, 30, 800, DateTimeKind.Unspecified).AddTicks(5492), new TimeSpan(0, 2, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 6, 13, 52, 30, 800, DateTimeKind.Unspecified).AddTicks(5493), new TimeSpan(0, 2, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 6, 13, 52, 30, 800, DateTimeKind.Unspecified).AddTicks(5495), new TimeSpan(0, 2, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 6, 13, 52, 30, 800, DateTimeKind.Unspecified).AddTicks(5497), new TimeSpan(0, 2, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 6, 13, 52, 30, 800, DateTimeKind.Unspecified).AddTicks(5499), new TimeSpan(0, 2, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 6, 13, 52, 30, 800, DateTimeKind.Unspecified).AddTicks(5500), new TimeSpan(0, 2, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 6, 13, 52, 30, 800, DateTimeKind.Unspecified).AddTicks(5502), new TimeSpan(0, 2, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 6, 13, 52, 30, 800, DateTimeKind.Unspecified).AddTicks(5504), new TimeSpan(0, 2, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 6, 13, 52, 30, 800, DateTimeKind.Unspecified).AddTicks(5506), new TimeSpan(0, 2, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 6, 13, 52, 30, 800, DateTimeKind.Unspecified).AddTicks(5507), new TimeSpan(0, 2, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 6, 13, 52, 30, 800, DateTimeKind.Unspecified).AddTicks(5509), new TimeSpan(0, 2, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 6, 13, 52, 30, 800, DateTimeKind.Unspecified).AddTicks(5510), new TimeSpan(0, 2, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 6, 13, 52, 30, 800, DateTimeKind.Unspecified).AddTicks(5512), new TimeSpan(0, 2, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 6, 13, 52, 30, 800, DateTimeKind.Unspecified).AddTicks(5514), new TimeSpan(0, 2, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 6, 13, 52, 30, 800, DateTimeKind.Unspecified).AddTicks(5516), new TimeSpan(0, 2, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 6, 13, 52, 30, 800, DateTimeKind.Unspecified).AddTicks(5517), new TimeSpan(0, 2, 0, 0, 0)) });

            migrationBuilder.CreateIndex(
                name: "IX_Baskets_PublicUserId",
                table: "Baskets",
                column: "PublicUserId",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Baskets_PublicUserId",
                table: "Baskets");

            migrationBuilder.DropColumn(
                name: "BasketId",
                table: "PublicUsers");

            migrationBuilder.DropColumn(
                name: "Quantity",
                table: "ProductBasket");

            migrationBuilder.AddColumn<int>(
                name: "Quantity",
                table: "Baskets",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 10, 17, 16, 0, 50, 832, DateTimeKind.Unspecified).AddTicks(7996), new TimeSpan(0, 3, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 10, 17, 16, 0, 50, 832, DateTimeKind.Unspecified).AddTicks(7999), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 10, 17, 16, 0, 50, 832, DateTimeKind.Unspecified).AddTicks(8001), new TimeSpan(0, 3, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 10, 17, 16, 0, 50, 832, DateTimeKind.Unspecified).AddTicks(8003), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 10, 17, 16, 0, 50, 832, DateTimeKind.Unspecified).AddTicks(8005), new TimeSpan(0, 3, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 10, 17, 16, 0, 50, 832, DateTimeKind.Unspecified).AddTicks(8006), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 10, 17, 16, 0, 50, 832, DateTimeKind.Unspecified).AddTicks(8008), new TimeSpan(0, 3, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 10, 17, 16, 0, 50, 832, DateTimeKind.Unspecified).AddTicks(8010), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 10, 17, 16, 0, 50, 832, DateTimeKind.Unspecified).AddTicks(8012), new TimeSpan(0, 3, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 10, 17, 16, 0, 50, 832, DateTimeKind.Unspecified).AddTicks(8013), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 10, 17, 16, 0, 50, 832, DateTimeKind.Unspecified).AddTicks(8015), new TimeSpan(0, 3, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 10, 17, 16, 0, 50, 832, DateTimeKind.Unspecified).AddTicks(8017), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 10, 17, 16, 0, 50, 832, DateTimeKind.Unspecified).AddTicks(8019), new TimeSpan(0, 3, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 10, 17, 16, 0, 50, 832, DateTimeKind.Unspecified).AddTicks(8020), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 10, 17, 16, 0, 50, 832, DateTimeKind.Unspecified).AddTicks(8022), new TimeSpan(0, 3, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 10, 17, 16, 0, 50, 832, DateTimeKind.Unspecified).AddTicks(8024), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 10, 17, 16, 0, 50, 832, DateTimeKind.Unspecified).AddTicks(8026), new TimeSpan(0, 3, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 10, 17, 16, 0, 50, 832, DateTimeKind.Unspecified).AddTicks(8027), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 10, 17, 16, 0, 50, 832, DateTimeKind.Unspecified).AddTicks(8029), new TimeSpan(0, 3, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 10, 17, 16, 0, 50, 832, DateTimeKind.Unspecified).AddTicks(8031), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 10, 17, 16, 0, 50, 832, DateTimeKind.Unspecified).AddTicks(8033), new TimeSpan(0, 3, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 10, 17, 16, 0, 50, 832, DateTimeKind.Unspecified).AddTicks(8034), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 10, 17, 16, 0, 50, 832, DateTimeKind.Unspecified).AddTicks(8036), new TimeSpan(0, 3, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 10, 17, 16, 0, 50, 832, DateTimeKind.Unspecified).AddTicks(8038), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 10, 17, 16, 0, 50, 832, DateTimeKind.Unspecified).AddTicks(8040), new TimeSpan(0, 3, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 10, 17, 16, 0, 50, 832, DateTimeKind.Unspecified).AddTicks(8041), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 10, 17, 16, 0, 50, 832, DateTimeKind.Unspecified).AddTicks(8043), new TimeSpan(0, 3, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 10, 17, 16, 0, 50, 832, DateTimeKind.Unspecified).AddTicks(8045), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 10, 17, 16, 0, 50, 832, DateTimeKind.Unspecified).AddTicks(7703), new TimeSpan(0, 3, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 10, 17, 16, 0, 50, 832, DateTimeKind.Unspecified).AddTicks(7760), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 10, 17, 16, 0, 50, 832, DateTimeKind.Unspecified).AddTicks(7763), new TimeSpan(0, 3, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 10, 17, 16, 0, 50, 832, DateTimeKind.Unspecified).AddTicks(7765), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 10, 17, 16, 0, 50, 832, DateTimeKind.Unspecified).AddTicks(7767), new TimeSpan(0, 3, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 10, 17, 16, 0, 50, 832, DateTimeKind.Unspecified).AddTicks(7769), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 10, 17, 16, 0, 50, 832, DateTimeKind.Unspecified).AddTicks(7771), new TimeSpan(0, 3, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 10, 17, 16, 0, 50, 832, DateTimeKind.Unspecified).AddTicks(7772), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 10, 17, 16, 0, 50, 832, DateTimeKind.Unspecified).AddTicks(7774), new TimeSpan(0, 3, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 10, 17, 16, 0, 50, 832, DateTimeKind.Unspecified).AddTicks(7776), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 10, 17, 16, 0, 50, 832, DateTimeKind.Unspecified).AddTicks(7778), new TimeSpan(0, 3, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 10, 17, 16, 0, 50, 832, DateTimeKind.Unspecified).AddTicks(7779), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 10, 17, 16, 0, 50, 832, DateTimeKind.Unspecified).AddTicks(7893), new TimeSpan(0, 3, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 10, 17, 16, 0, 50, 832, DateTimeKind.Unspecified).AddTicks(7896), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 10, 17, 16, 0, 50, 832, DateTimeKind.Unspecified).AddTicks(7899), new TimeSpan(0, 3, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 10, 17, 16, 0, 50, 832, DateTimeKind.Unspecified).AddTicks(7900), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 10, 17, 16, 0, 50, 832, DateTimeKind.Unspecified).AddTicks(7903), new TimeSpan(0, 3, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 10, 17, 16, 0, 50, 832, DateTimeKind.Unspecified).AddTicks(7904), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 10, 17, 16, 0, 50, 832, DateTimeKind.Unspecified).AddTicks(7906), new TimeSpan(0, 3, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 10, 17, 16, 0, 50, 832, DateTimeKind.Unspecified).AddTicks(7908), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 10, 17, 16, 0, 50, 832, DateTimeKind.Unspecified).AddTicks(7910), new TimeSpan(0, 3, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 10, 17, 16, 0, 50, 832, DateTimeKind.Unspecified).AddTicks(7911), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 10, 17, 16, 0, 50, 832, DateTimeKind.Unspecified).AddTicks(7913), new TimeSpan(0, 3, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 10, 17, 16, 0, 50, 832, DateTimeKind.Unspecified).AddTicks(7915), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 10, 17, 16, 0, 50, 832, DateTimeKind.Unspecified).AddTicks(7917), new TimeSpan(0, 3, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 10, 17, 16, 0, 50, 832, DateTimeKind.Unspecified).AddTicks(7918), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 10, 17, 16, 0, 50, 832, DateTimeKind.Unspecified).AddTicks(7920), new TimeSpan(0, 3, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 10, 17, 16, 0, 50, 832, DateTimeKind.Unspecified).AddTicks(7922), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 10, 17, 16, 0, 50, 832, DateTimeKind.Unspecified).AddTicks(7924), new TimeSpan(0, 3, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 10, 17, 16, 0, 50, 832, DateTimeKind.Unspecified).AddTicks(7925), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 10, 17, 16, 0, 50, 832, DateTimeKind.Unspecified).AddTicks(7927), new TimeSpan(0, 3, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 10, 17, 16, 0, 50, 832, DateTimeKind.Unspecified).AddTicks(7929), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 10, 17, 16, 0, 50, 832, DateTimeKind.Unspecified).AddTicks(7931), new TimeSpan(0, 3, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 10, 17, 16, 0, 50, 832, DateTimeKind.Unspecified).AddTicks(7932), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 10, 17, 16, 0, 50, 832, DateTimeKind.Unspecified).AddTicks(7934), new TimeSpan(0, 3, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 10, 17, 16, 0, 50, 832, DateTimeKind.Unspecified).AddTicks(7936), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.CreateIndex(
                name: "IX_Baskets_PublicUserId",
                table: "Baskets",
                column: "PublicUserId");
        }
    }
}
