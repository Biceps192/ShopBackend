using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BackendApp.Migrations
{
    /// <inheritdoc />
    public partial class DataForBrand : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Brands",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "ModifiedAt", "ModifiedBy", "Name" },
                values: new object[,]
                {
                    { 1, new DateTimeOffset(new DateTime(2023, 10, 3, 15, 59, 27, 276, DateTimeKind.Unspecified).AddTicks(5672), new TimeSpan(0, 3, 0, 0, 0)), 0, new DateTimeOffset(new DateTime(2023, 10, 3, 15, 59, 27, 276, DateTimeKind.Unspecified).AddTicks(5674), new TimeSpan(0, 3, 0, 0, 0)), null, "Apple" },
                    { 2, new DateTimeOffset(new DateTime(2023, 10, 3, 15, 59, 27, 276, DateTimeKind.Unspecified).AddTicks(5676), new TimeSpan(0, 3, 0, 0, 0)), 0, new DateTimeOffset(new DateTime(2023, 10, 3, 15, 59, 27, 276, DateTimeKind.Unspecified).AddTicks(5678), new TimeSpan(0, 3, 0, 0, 0)), null, "LG" },
                    { 3, new DateTimeOffset(new DateTime(2023, 10, 3, 15, 59, 27, 276, DateTimeKind.Unspecified).AddTicks(5680), new TimeSpan(0, 3, 0, 0, 0)), 0, new DateTimeOffset(new DateTime(2023, 10, 3, 15, 59, 27, 276, DateTimeKind.Unspecified).AddTicks(5682), new TimeSpan(0, 3, 0, 0, 0)), null, "Canon" },
                    { 4, new DateTimeOffset(new DateTime(2023, 10, 3, 15, 59, 27, 276, DateTimeKind.Unspecified).AddTicks(5684), new TimeSpan(0, 3, 0, 0, 0)), 0, new DateTimeOffset(new DateTime(2023, 10, 3, 15, 59, 27, 276, DateTimeKind.Unspecified).AddTicks(5685), new TimeSpan(0, 3, 0, 0, 0)), null, "Nikon" },
                    { 5, new DateTimeOffset(new DateTime(2023, 10, 3, 15, 59, 27, 276, DateTimeKind.Unspecified).AddTicks(5687), new TimeSpan(0, 3, 0, 0, 0)), 0, new DateTimeOffset(new DateTime(2023, 10, 3, 15, 59, 27, 276, DateTimeKind.Unspecified).AddTicks(5689), new TimeSpan(0, 3, 0, 0, 0)), null, "Google" },
                    { 6, new DateTimeOffset(new DateTime(2023, 10, 3, 15, 59, 27, 276, DateTimeKind.Unspecified).AddTicks(5691), new TimeSpan(0, 3, 0, 0, 0)), 0, new DateTimeOffset(new DateTime(2023, 10, 3, 15, 59, 27, 276, DateTimeKind.Unspecified).AddTicks(5692), new TimeSpan(0, 3, 0, 0, 0)), null, "Samsung" },
                    { 7, new DateTimeOffset(new DateTime(2023, 10, 3, 15, 59, 27, 276, DateTimeKind.Unspecified).AddTicks(5694), new TimeSpan(0, 3, 0, 0, 0)), 0, new DateTimeOffset(new DateTime(2023, 10, 3, 15, 59, 27, 276, DateTimeKind.Unspecified).AddTicks(5696), new TimeSpan(0, 3, 0, 0, 0)), null, "Nvidia" },
                    { 8, new DateTimeOffset(new DateTime(2023, 10, 3, 15, 59, 27, 276, DateTimeKind.Unspecified).AddTicks(5698), new TimeSpan(0, 3, 0, 0, 0)), 0, new DateTimeOffset(new DateTime(2023, 10, 3, 15, 59, 27, 276, DateTimeKind.Unspecified).AddTicks(5699), new TimeSpan(0, 3, 0, 0, 0)), null, "AMD" },
                    { 9, new DateTimeOffset(new DateTime(2023, 10, 3, 15, 59, 27, 276, DateTimeKind.Unspecified).AddTicks(5701), new TimeSpan(0, 3, 0, 0, 0)), 0, new DateTimeOffset(new DateTime(2023, 10, 3, 15, 59, 27, 276, DateTimeKind.Unspecified).AddTicks(5703), new TimeSpan(0, 3, 0, 0, 0)), null, "GIGABYTE" },
                    { 10, new DateTimeOffset(new DateTime(2023, 10, 3, 15, 59, 27, 276, DateTimeKind.Unspecified).AddTicks(5705), new TimeSpan(0, 3, 0, 0, 0)), 0, new DateTimeOffset(new DateTime(2023, 10, 3, 15, 59, 27, 276, DateTimeKind.Unspecified).AddTicks(5706), new TimeSpan(0, 3, 0, 0, 0)), null, "BenQ" },
                    { 11, new DateTimeOffset(new DateTime(2023, 10, 3, 15, 59, 27, 276, DateTimeKind.Unspecified).AddTicks(5708), new TimeSpan(0, 3, 0, 0, 0)), 0, new DateTimeOffset(new DateTime(2023, 10, 3, 15, 59, 27, 276, DateTimeKind.Unspecified).AddTicks(5710), new TimeSpan(0, 3, 0, 0, 0)), null, "Intel" },
                    { 12, new DateTimeOffset(new DateTime(2023, 10, 3, 15, 59, 27, 276, DateTimeKind.Unspecified).AddTicks(5713), new TimeSpan(0, 3, 0, 0, 0)), 0, new DateTimeOffset(new DateTime(2023, 10, 3, 15, 59, 27, 276, DateTimeKind.Unspecified).AddTicks(5715), new TimeSpan(0, 3, 0, 0, 0)), null, "Fujifilm" },
                    { 13, new DateTimeOffset(new DateTime(2023, 10, 3, 15, 59, 27, 276, DateTimeKind.Unspecified).AddTicks(5717), new TimeSpan(0, 3, 0, 0, 0)), 0, new DateTimeOffset(new DateTime(2023, 10, 3, 15, 59, 27, 276, DateTimeKind.Unspecified).AddTicks(5718), new TimeSpan(0, 3, 0, 0, 0)), null, "Philips" },
                    { 14, new DateTimeOffset(new DateTime(2023, 10, 3, 15, 59, 27, 276, DateTimeKind.Unspecified).AddTicks(5720), new TimeSpan(0, 3, 0, 0, 0)), 0, new DateTimeOffset(new DateTime(2023, 10, 3, 15, 59, 27, 276, DateTimeKind.Unspecified).AddTicks(5722), new TimeSpan(0, 3, 0, 0, 0)), null, "Panasonic" }
                });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 10, 3, 15, 59, 27, 276, DateTimeKind.Unspecified).AddTicks(5375), new TimeSpan(0, 3, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 10, 3, 15, 59, 27, 276, DateTimeKind.Unspecified).AddTicks(5428), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 10, 3, 15, 59, 27, 276, DateTimeKind.Unspecified).AddTicks(5432), new TimeSpan(0, 3, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 10, 3, 15, 59, 27, 276, DateTimeKind.Unspecified).AddTicks(5434), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 10, 3, 15, 59, 27, 276, DateTimeKind.Unspecified).AddTicks(5436), new TimeSpan(0, 3, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 10, 3, 15, 59, 27, 276, DateTimeKind.Unspecified).AddTicks(5437), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 10, 3, 15, 59, 27, 276, DateTimeKind.Unspecified).AddTicks(5439), new TimeSpan(0, 3, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 10, 3, 15, 59, 27, 276, DateTimeKind.Unspecified).AddTicks(5441), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 10, 3, 15, 59, 27, 276, DateTimeKind.Unspecified).AddTicks(5482), new TimeSpan(0, 3, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 10, 3, 15, 59, 27, 276, DateTimeKind.Unspecified).AddTicks(5484), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 10, 3, 15, 59, 27, 276, DateTimeKind.Unspecified).AddTicks(5487), new TimeSpan(0, 3, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 10, 3, 15, 59, 27, 276, DateTimeKind.Unspecified).AddTicks(5488), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 10, 3, 15, 59, 27, 276, DateTimeKind.Unspecified).AddTicks(5606), new TimeSpan(0, 3, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 10, 3, 15, 59, 27, 276, DateTimeKind.Unspecified).AddTicks(5610), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 10, 3, 15, 59, 27, 276, DateTimeKind.Unspecified).AddTicks(5614), new TimeSpan(0, 3, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 10, 3, 15, 59, 27, 276, DateTimeKind.Unspecified).AddTicks(5615), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 10, 3, 15, 59, 27, 276, DateTimeKind.Unspecified).AddTicks(5618), new TimeSpan(0, 3, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 10, 3, 15, 59, 27, 276, DateTimeKind.Unspecified).AddTicks(5619), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 10, 3, 15, 59, 27, 276, DateTimeKind.Unspecified).AddTicks(5621), new TimeSpan(0, 3, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 10, 3, 15, 59, 27, 276, DateTimeKind.Unspecified).AddTicks(5623), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 10, 3, 15, 59, 27, 276, DateTimeKind.Unspecified).AddTicks(5625), new TimeSpan(0, 3, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 10, 3, 15, 59, 27, 276, DateTimeKind.Unspecified).AddTicks(5627), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 10, 3, 15, 59, 27, 276, DateTimeKind.Unspecified).AddTicks(5629), new TimeSpan(0, 3, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 10, 3, 15, 59, 27, 276, DateTimeKind.Unspecified).AddTicks(5630), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 10, 3, 15, 59, 27, 276, DateTimeKind.Unspecified).AddTicks(5632), new TimeSpan(0, 3, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 10, 3, 15, 59, 27, 276, DateTimeKind.Unspecified).AddTicks(5634), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 10, 3, 15, 59, 27, 276, DateTimeKind.Unspecified).AddTicks(5636), new TimeSpan(0, 3, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 10, 3, 15, 59, 27, 276, DateTimeKind.Unspecified).AddTicks(5637), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 10, 3, 15, 59, 27, 276, DateTimeKind.Unspecified).AddTicks(5639), new TimeSpan(0, 3, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 10, 3, 15, 59, 27, 276, DateTimeKind.Unspecified).AddTicks(5641), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 10, 3, 15, 59, 27, 276, DateTimeKind.Unspecified).AddTicks(5643), new TimeSpan(0, 3, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 10, 3, 15, 59, 27, 276, DateTimeKind.Unspecified).AddTicks(5644), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 10, 3, 15, 59, 27, 276, DateTimeKind.Unspecified).AddTicks(5647), new TimeSpan(0, 3, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 10, 3, 15, 59, 27, 276, DateTimeKind.Unspecified).AddTicks(5648), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 10, 3, 15, 59, 27, 276, DateTimeKind.Unspecified).AddTicks(5650), new TimeSpan(0, 3, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 10, 3, 15, 59, 27, 276, DateTimeKind.Unspecified).AddTicks(5652), new TimeSpan(0, 3, 0, 0, 0)) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 9, 30, 13, 2, 31, 502, DateTimeKind.Unspecified).AddTicks(808), new TimeSpan(0, 3, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 9, 30, 13, 2, 31, 502, DateTimeKind.Unspecified).AddTicks(859), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 9, 30, 13, 2, 31, 502, DateTimeKind.Unspecified).AddTicks(863), new TimeSpan(0, 3, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 9, 30, 13, 2, 31, 502, DateTimeKind.Unspecified).AddTicks(864), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 9, 30, 13, 2, 31, 502, DateTimeKind.Unspecified).AddTicks(867), new TimeSpan(0, 3, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 9, 30, 13, 2, 31, 502, DateTimeKind.Unspecified).AddTicks(868), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 9, 30, 13, 2, 31, 502, DateTimeKind.Unspecified).AddTicks(870), new TimeSpan(0, 3, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 9, 30, 13, 2, 31, 502, DateTimeKind.Unspecified).AddTicks(872), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 9, 30, 13, 2, 31, 502, DateTimeKind.Unspecified).AddTicks(916), new TimeSpan(0, 3, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 9, 30, 13, 2, 31, 502, DateTimeKind.Unspecified).AddTicks(918), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 9, 30, 13, 2, 31, 502, DateTimeKind.Unspecified).AddTicks(921), new TimeSpan(0, 3, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 9, 30, 13, 2, 31, 502, DateTimeKind.Unspecified).AddTicks(922), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 9, 30, 13, 2, 31, 502, DateTimeKind.Unspecified).AddTicks(1037), new TimeSpan(0, 3, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 9, 30, 13, 2, 31, 502, DateTimeKind.Unspecified).AddTicks(1041), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 9, 30, 13, 2, 31, 502, DateTimeKind.Unspecified).AddTicks(1044), new TimeSpan(0, 3, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 9, 30, 13, 2, 31, 502, DateTimeKind.Unspecified).AddTicks(1045), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 9, 30, 13, 2, 31, 502, DateTimeKind.Unspecified).AddTicks(1047), new TimeSpan(0, 3, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 9, 30, 13, 2, 31, 502, DateTimeKind.Unspecified).AddTicks(1049), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 9, 30, 13, 2, 31, 502, DateTimeKind.Unspecified).AddTicks(1051), new TimeSpan(0, 3, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 9, 30, 13, 2, 31, 502, DateTimeKind.Unspecified).AddTicks(1052), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 9, 30, 13, 2, 31, 502, DateTimeKind.Unspecified).AddTicks(1054), new TimeSpan(0, 3, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 9, 30, 13, 2, 31, 502, DateTimeKind.Unspecified).AddTicks(1056), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 9, 30, 13, 2, 31, 502, DateTimeKind.Unspecified).AddTicks(1058), new TimeSpan(0, 3, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 9, 30, 13, 2, 31, 502, DateTimeKind.Unspecified).AddTicks(1060), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 9, 30, 13, 2, 31, 502, DateTimeKind.Unspecified).AddTicks(1062), new TimeSpan(0, 3, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 9, 30, 13, 2, 31, 502, DateTimeKind.Unspecified).AddTicks(1063), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 9, 30, 13, 2, 31, 502, DateTimeKind.Unspecified).AddTicks(1065), new TimeSpan(0, 3, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 9, 30, 13, 2, 31, 502, DateTimeKind.Unspecified).AddTicks(1067), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 9, 30, 13, 2, 31, 502, DateTimeKind.Unspecified).AddTicks(1069), new TimeSpan(0, 3, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 9, 30, 13, 2, 31, 502, DateTimeKind.Unspecified).AddTicks(1070), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 9, 30, 13, 2, 31, 502, DateTimeKind.Unspecified).AddTicks(1073), new TimeSpan(0, 3, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 9, 30, 13, 2, 31, 502, DateTimeKind.Unspecified).AddTicks(1075), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 9, 30, 13, 2, 31, 502, DateTimeKind.Unspecified).AddTicks(1077), new TimeSpan(0, 3, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 9, 30, 13, 2, 31, 502, DateTimeKind.Unspecified).AddTicks(1078), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 9, 30, 13, 2, 31, 502, DateTimeKind.Unspecified).AddTicks(1081), new TimeSpan(0, 3, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 9, 30, 13, 2, 31, 502, DateTimeKind.Unspecified).AddTicks(1082), new TimeSpan(0, 3, 0, 0, 0)) });
        }
    }
}
