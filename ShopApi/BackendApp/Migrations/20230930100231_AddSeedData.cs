using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BackendApp.Migrations
{
    /// <inheritdoc />
    public partial class AddSeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "ModifiedAt", "ModifiedBy", "NameOfCategory" },
                values: new object[,]
                {
                    { 1, new DateTimeOffset(new DateTime(2023, 9, 30, 13, 2, 31, 502, DateTimeKind.Unspecified).AddTicks(808), new TimeSpan(0, 3, 0, 0, 0)), 0, new DateTimeOffset(new DateTime(2023, 9, 30, 13, 2, 31, 502, DateTimeKind.Unspecified).AddTicks(859), new TimeSpan(0, 3, 0, 0, 0)), null, "Laptops, Tablets & PCs" },
                    { 2, new DateTimeOffset(new DateTime(2023, 9, 30, 13, 2, 31, 502, DateTimeKind.Unspecified).AddTicks(863), new TimeSpan(0, 3, 0, 0, 0)), 0, new DateTimeOffset(new DateTime(2023, 9, 30, 13, 2, 31, 502, DateTimeKind.Unspecified).AddTicks(864), new TimeSpan(0, 3, 0, 0, 0)), null, "Computer & Office" },
                    { 3, new DateTimeOffset(new DateTime(2023, 9, 30, 13, 2, 31, 502, DateTimeKind.Unspecified).AddTicks(867), new TimeSpan(0, 3, 0, 0, 0)), 0, new DateTimeOffset(new DateTime(2023, 9, 30, 13, 2, 31, 502, DateTimeKind.Unspecified).AddTicks(868), new TimeSpan(0, 3, 0, 0, 0)), null, "Hardware & Components" },
                    { 4, new DateTimeOffset(new DateTime(2023, 9, 30, 13, 2, 31, 502, DateTimeKind.Unspecified).AddTicks(870), new TimeSpan(0, 3, 0, 0, 0)), 0, new DateTimeOffset(new DateTime(2023, 9, 30, 13, 2, 31, 502, DateTimeKind.Unspecified).AddTicks(872), new TimeSpan(0, 3, 0, 0, 0)), null, "Smartphones, Radio & GPS" },
                    { 5, new DateTimeOffset(new DateTime(2023, 9, 30, 13, 2, 31, 502, DateTimeKind.Unspecified).AddTicks(916), new TimeSpan(0, 3, 0, 0, 0)), 0, new DateTimeOffset(new DateTime(2023, 9, 30, 13, 2, 31, 502, DateTimeKind.Unspecified).AddTicks(918), new TimeSpan(0, 3, 0, 0, 0)), null, "Photo / Video" },
                    { 6, new DateTimeOffset(new DateTime(2023, 9, 30, 13, 2, 31, 502, DateTimeKind.Unspecified).AddTicks(921), new TimeSpan(0, 3, 0, 0, 0)), 0, new DateTimeOffset(new DateTime(2023, 9, 30, 13, 2, 31, 502, DateTimeKind.Unspecified).AddTicks(922), new TimeSpan(0, 3, 0, 0, 0)), null, "TV / HiFi / Video" }
                });

            migrationBuilder.InsertData(
                table: "Subcategories",
                columns: new[] { "Id", "CategoryId", "CreatedAt", "CreatedBy", "ModifiedAt", "ModifiedBy", "Name" },
                values: new object[,]
                {
                    { 1, 1, new DateTimeOffset(new DateTime(2023, 9, 30, 13, 2, 31, 502, DateTimeKind.Unspecified).AddTicks(1037), new TimeSpan(0, 3, 0, 0, 0)), 0, new DateTimeOffset(new DateTime(2023, 9, 30, 13, 2, 31, 502, DateTimeKind.Unspecified).AddTicks(1041), new TimeSpan(0, 3, 0, 0, 0)), null, "Laptops / Notebooks" },
                    { 2, 1, new DateTimeOffset(new DateTime(2023, 9, 30, 13, 2, 31, 502, DateTimeKind.Unspecified).AddTicks(1044), new TimeSpan(0, 3, 0, 0, 0)), 0, new DateTimeOffset(new DateTime(2023, 9, 30, 13, 2, 31, 502, DateTimeKind.Unspecified).AddTicks(1045), new TimeSpan(0, 3, 0, 0, 0)), null, "Apple MacBook" },
                    { 3, 2, new DateTimeOffset(new DateTime(2023, 9, 30, 13, 2, 31, 502, DateTimeKind.Unspecified).AddTicks(1047), new TimeSpan(0, 3, 0, 0, 0)), 0, new DateTimeOffset(new DateTime(2023, 9, 30, 13, 2, 31, 502, DateTimeKind.Unspecified).AddTicks(1049), new TimeSpan(0, 3, 0, 0, 0)), null, "Monitors" },
                    { 4, 2, new DateTimeOffset(new DateTime(2023, 9, 30, 13, 2, 31, 502, DateTimeKind.Unspecified).AddTicks(1051), new TimeSpan(0, 3, 0, 0, 0)), 0, new DateTimeOffset(new DateTime(2023, 9, 30, 13, 2, 31, 502, DateTimeKind.Unspecified).AddTicks(1052), new TimeSpan(0, 3, 0, 0, 0)), null, "All-in-One Printers" },
                    { 5, 3, new DateTimeOffset(new DateTime(2023, 9, 30, 13, 2, 31, 502, DateTimeKind.Unspecified).AddTicks(1054), new TimeSpan(0, 3, 0, 0, 0)), 0, new DateTimeOffset(new DateTime(2023, 9, 30, 13, 2, 31, 502, DateTimeKind.Unspecified).AddTicks(1056), new TimeSpan(0, 3, 0, 0, 0)), null, "Processors (CPUs)" },
                    { 6, 3, new DateTimeOffset(new DateTime(2023, 9, 30, 13, 2, 31, 502, DateTimeKind.Unspecified).AddTicks(1058), new TimeSpan(0, 3, 0, 0, 0)), 0, new DateTimeOffset(new DateTime(2023, 9, 30, 13, 2, 31, 502, DateTimeKind.Unspecified).AddTicks(1060), new TimeSpan(0, 3, 0, 0, 0)), null, "AMD Graphics cards" },
                    { 7, 4, new DateTimeOffset(new DateTime(2023, 9, 30, 13, 2, 31, 502, DateTimeKind.Unspecified).AddTicks(1062), new TimeSpan(0, 3, 0, 0, 0)), 0, new DateTimeOffset(new DateTime(2023, 9, 30, 13, 2, 31, 502, DateTimeKind.Unspecified).AddTicks(1063), new TimeSpan(0, 3, 0, 0, 0)), null, "Smartphones & Cell Phones" },
                    { 8, 4, new DateTimeOffset(new DateTime(2023, 9, 30, 13, 2, 31, 502, DateTimeKind.Unspecified).AddTicks(1065), new TimeSpan(0, 3, 0, 0, 0)), 0, new DateTimeOffset(new DateTime(2023, 9, 30, 13, 2, 31, 502, DateTimeKind.Unspecified).AddTicks(1067), new TimeSpan(0, 3, 0, 0, 0)), null, "Apple iPhones" },
                    { 9, 5, new DateTimeOffset(new DateTime(2023, 9, 30, 13, 2, 31, 502, DateTimeKind.Unspecified).AddTicks(1069), new TimeSpan(0, 3, 0, 0, 0)), 0, new DateTimeOffset(new DateTime(2023, 9, 30, 13, 2, 31, 502, DateTimeKind.Unspecified).AddTicks(1070), new TimeSpan(0, 3, 0, 0, 0)), null, "Digital Cameras" },
                    { 10, 5, new DateTimeOffset(new DateTime(2023, 9, 30, 13, 2, 31, 502, DateTimeKind.Unspecified).AddTicks(1073), new TimeSpan(0, 3, 0, 0, 0)), 0, new DateTimeOffset(new DateTime(2023, 9, 30, 13, 2, 31, 502, DateTimeKind.Unspecified).AddTicks(1075), new TimeSpan(0, 3, 0, 0, 0)), null, "Instant Cameras" },
                    { 11, 6, new DateTimeOffset(new DateTime(2023, 9, 30, 13, 2, 31, 502, DateTimeKind.Unspecified).AddTicks(1077), new TimeSpan(0, 3, 0, 0, 0)), 0, new DateTimeOffset(new DateTime(2023, 9, 30, 13, 2, 31, 502, DateTimeKind.Unspecified).AddTicks(1078), new TimeSpan(0, 3, 0, 0, 0)), null, "LED TV / LCD TV" },
                    { 12, 6, new DateTimeOffset(new DateTime(2023, 9, 30, 13, 2, 31, 502, DateTimeKind.Unspecified).AddTicks(1081), new TimeSpan(0, 3, 0, 0, 0)), 0, new DateTimeOffset(new DateTime(2023, 9, 30, 13, 2, 31, 502, DateTimeKind.Unspecified).AddTicks(1082), new TimeSpan(0, 3, 0, 0, 0)), null, "OLED TV" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Subcategories",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Subcategories",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Subcategories",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Subcategories",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Subcategories",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Subcategories",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Subcategories",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Subcategories",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Subcategories",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Subcategories",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Subcategories",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Subcategories",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6);
        }
    }
}
