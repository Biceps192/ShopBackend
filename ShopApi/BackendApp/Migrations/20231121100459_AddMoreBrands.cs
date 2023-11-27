using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BackendApp.Migrations
{
    /// <inheritdoc />
    public partial class AddMoreBrands : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 12, 4, 58, 986, DateTimeKind.Unspecified).AddTicks(2558), new TimeSpan(0, 2, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 12, 4, 58, 986, DateTimeKind.Unspecified).AddTicks(2560), new TimeSpan(0, 2, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 12, 4, 58, 986, DateTimeKind.Unspecified).AddTicks(2563), new TimeSpan(0, 2, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 12, 4, 58, 986, DateTimeKind.Unspecified).AddTicks(2565), new TimeSpan(0, 2, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 12, 4, 58, 986, DateTimeKind.Unspecified).AddTicks(2567), new TimeSpan(0, 2, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 12, 4, 58, 986, DateTimeKind.Unspecified).AddTicks(2568), new TimeSpan(0, 2, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 12, 4, 58, 986, DateTimeKind.Unspecified).AddTicks(2570), new TimeSpan(0, 2, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 12, 4, 58, 986, DateTimeKind.Unspecified).AddTicks(2572), new TimeSpan(0, 2, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 12, 4, 58, 986, DateTimeKind.Unspecified).AddTicks(2574), new TimeSpan(0, 2, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 12, 4, 58, 986, DateTimeKind.Unspecified).AddTicks(2575), new TimeSpan(0, 2, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 12, 4, 58, 986, DateTimeKind.Unspecified).AddTicks(2577), new TimeSpan(0, 2, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 12, 4, 58, 986, DateTimeKind.Unspecified).AddTicks(2579), new TimeSpan(0, 2, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 12, 4, 58, 986, DateTimeKind.Unspecified).AddTicks(2580), new TimeSpan(0, 2, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 12, 4, 58, 986, DateTimeKind.Unspecified).AddTicks(2582), new TimeSpan(0, 2, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 12, 4, 58, 986, DateTimeKind.Unspecified).AddTicks(2584), new TimeSpan(0, 2, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 12, 4, 58, 986, DateTimeKind.Unspecified).AddTicks(2585), new TimeSpan(0, 2, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 12, 4, 58, 986, DateTimeKind.Unspecified).AddTicks(2587), new TimeSpan(0, 2, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 12, 4, 58, 986, DateTimeKind.Unspecified).AddTicks(2589), new TimeSpan(0, 2, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 12, 4, 58, 986, DateTimeKind.Unspecified).AddTicks(2591), new TimeSpan(0, 2, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 12, 4, 58, 986, DateTimeKind.Unspecified).AddTicks(2592), new TimeSpan(0, 2, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 12, 4, 58, 986, DateTimeKind.Unspecified).AddTicks(2594), new TimeSpan(0, 2, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 12, 4, 58, 986, DateTimeKind.Unspecified).AddTicks(2596), new TimeSpan(0, 2, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 12, 4, 58, 986, DateTimeKind.Unspecified).AddTicks(2597), new TimeSpan(0, 2, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 12, 4, 58, 986, DateTimeKind.Unspecified).AddTicks(2599), new TimeSpan(0, 2, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 12, 4, 58, 986, DateTimeKind.Unspecified).AddTicks(2601), new TimeSpan(0, 2, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 12, 4, 58, 986, DateTimeKind.Unspecified).AddTicks(2602), new TimeSpan(0, 2, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedAt", "ModifiedAt", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 12, 4, 58, 986, DateTimeKind.Unspecified).AddTicks(2604), new TimeSpan(0, 2, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 12, 4, 58, 986, DateTimeKind.Unspecified).AddTicks(2606), new TimeSpan(0, 2, 0, 0, 0)), "Lenovo" });

            migrationBuilder.InsertData(
                table: "Brands",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "ModifiedAt", "ModifiedBy", "Name" },
                values: new object[,]
                {
                    { 15, new DateTimeOffset(new DateTime(2023, 11, 21, 12, 4, 58, 986, DateTimeKind.Unspecified).AddTicks(2608), new TimeSpan(0, 2, 0, 0, 0)), 0, new DateTimeOffset(new DateTime(2023, 11, 21, 12, 4, 58, 986, DateTimeKind.Unspecified).AddTicks(2609), new TimeSpan(0, 2, 0, 0, 0)), null, "Logitech" },
                    { 16, new DateTimeOffset(new DateTime(2023, 11, 21, 12, 4, 58, 986, DateTimeKind.Unspecified).AddTicks(2611), new TimeSpan(0, 2, 0, 0, 0)), 0, new DateTimeOffset(new DateTime(2023, 11, 21, 12, 4, 58, 986, DateTimeKind.Unspecified).AddTicks(2613), new TimeSpan(0, 2, 0, 0, 0)), null, "Kingston" },
                    { 17, new DateTimeOffset(new DateTime(2023, 11, 21, 12, 4, 58, 986, DateTimeKind.Unspecified).AddTicks(2615), new TimeSpan(0, 2, 0, 0, 0)), 0, new DateTimeOffset(new DateTime(2023, 11, 21, 12, 4, 58, 986, DateTimeKind.Unspecified).AddTicks(2616), new TimeSpan(0, 2, 0, 0, 0)), null, "Energizer" },
                    { 18, new DateTimeOffset(new DateTime(2023, 11, 21, 12, 4, 58, 986, DateTimeKind.Unspecified).AddTicks(2618), new TimeSpan(0, 2, 0, 0, 0)), 0, new DateTimeOffset(new DateTime(2023, 11, 21, 12, 4, 58, 986, DateTimeKind.Unspecified).AddTicks(2619), new TimeSpan(0, 2, 0, 0, 0)), null, "Razer" },
                    { 19, new DateTimeOffset(new DateTime(2023, 11, 21, 12, 4, 58, 986, DateTimeKind.Unspecified).AddTicks(2621), new TimeSpan(0, 2, 0, 0, 0)), 0, new DateTimeOffset(new DateTime(2023, 11, 21, 12, 4, 58, 986, DateTimeKind.Unspecified).AddTicks(2623), new TimeSpan(0, 2, 0, 0, 0)), null, "be quiet!" },
                    { 20, new DateTimeOffset(new DateTime(2023, 11, 21, 12, 4, 58, 986, DateTimeKind.Unspecified).AddTicks(2625), new TimeSpan(0, 2, 0, 0, 0)), 0, new DateTimeOffset(new DateTime(2023, 11, 21, 12, 4, 58, 986, DateTimeKind.Unspecified).AddTicks(2626), new TimeSpan(0, 2, 0, 0, 0)), null, "Xiaomi" },
                    { 21, new DateTimeOffset(new DateTime(2023, 11, 21, 12, 4, 58, 986, DateTimeKind.Unspecified).AddTicks(2628), new TimeSpan(0, 2, 0, 0, 0)), 0, new DateTimeOffset(new DateTime(2023, 11, 21, 12, 4, 58, 986, DateTimeKind.Unspecified).AddTicks(2630), new TimeSpan(0, 2, 0, 0, 0)), null, "Razer" },
                    { 22, new DateTimeOffset(new DateTime(2023, 11, 21, 12, 4, 58, 986, DateTimeKind.Unspecified).AddTicks(2631), new TimeSpan(0, 2, 0, 0, 0)), 0, new DateTimeOffset(new DateTime(2023, 11, 21, 12, 4, 58, 986, DateTimeKind.Unspecified).AddTicks(2633), new TimeSpan(0, 2, 0, 0, 0)), null, "Optoma" }
                });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 12, 4, 58, 986, DateTimeKind.Unspecified).AddTicks(2304), new TimeSpan(0, 2, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 12, 4, 58, 986, DateTimeKind.Unspecified).AddTicks(2362), new TimeSpan(0, 2, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 12, 4, 58, 986, DateTimeKind.Unspecified).AddTicks(2365), new TimeSpan(0, 2, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 12, 4, 58, 986, DateTimeKind.Unspecified).AddTicks(2367), new TimeSpan(0, 2, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 12, 4, 58, 986, DateTimeKind.Unspecified).AddTicks(2369), new TimeSpan(0, 2, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 12, 4, 58, 986, DateTimeKind.Unspecified).AddTicks(2371), new TimeSpan(0, 2, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 12, 4, 58, 986, DateTimeKind.Unspecified).AddTicks(2373), new TimeSpan(0, 2, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 12, 4, 58, 986, DateTimeKind.Unspecified).AddTicks(2374), new TimeSpan(0, 2, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 12, 4, 58, 986, DateTimeKind.Unspecified).AddTicks(2376), new TimeSpan(0, 2, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 12, 4, 58, 986, DateTimeKind.Unspecified).AddTicks(2378), new TimeSpan(0, 2, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 12, 4, 58, 986, DateTimeKind.Unspecified).AddTicks(2379), new TimeSpan(0, 2, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 12, 4, 58, 986, DateTimeKind.Unspecified).AddTicks(2381), new TimeSpan(0, 2, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 12, 4, 58, 986, DateTimeKind.Unspecified).AddTicks(2496), new TimeSpan(0, 2, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 12, 4, 58, 986, DateTimeKind.Unspecified).AddTicks(2499), new TimeSpan(0, 2, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 12, 4, 58, 986, DateTimeKind.Unspecified).AddTicks(2503), new TimeSpan(0, 2, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 12, 4, 58, 986, DateTimeKind.Unspecified).AddTicks(2504), new TimeSpan(0, 2, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 12, 4, 58, 986, DateTimeKind.Unspecified).AddTicks(2506), new TimeSpan(0, 2, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 12, 4, 58, 986, DateTimeKind.Unspecified).AddTicks(2508), new TimeSpan(0, 2, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 12, 4, 58, 986, DateTimeKind.Unspecified).AddTicks(2510), new TimeSpan(0, 2, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 12, 4, 58, 986, DateTimeKind.Unspecified).AddTicks(2512), new TimeSpan(0, 2, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 12, 4, 58, 986, DateTimeKind.Unspecified).AddTicks(2514), new TimeSpan(0, 2, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 12, 4, 58, 986, DateTimeKind.Unspecified).AddTicks(2515), new TimeSpan(0, 2, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 12, 4, 58, 986, DateTimeKind.Unspecified).AddTicks(2517), new TimeSpan(0, 2, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 12, 4, 58, 986, DateTimeKind.Unspecified).AddTicks(2519), new TimeSpan(0, 2, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 12, 4, 58, 986, DateTimeKind.Unspecified).AddTicks(2521), new TimeSpan(0, 2, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 12, 4, 58, 986, DateTimeKind.Unspecified).AddTicks(2522), new TimeSpan(0, 2, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 12, 4, 58, 986, DateTimeKind.Unspecified).AddTicks(2524), new TimeSpan(0, 2, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 12, 4, 58, 986, DateTimeKind.Unspecified).AddTicks(2526), new TimeSpan(0, 2, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 12, 4, 58, 986, DateTimeKind.Unspecified).AddTicks(2528), new TimeSpan(0, 2, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 12, 4, 58, 986, DateTimeKind.Unspecified).AddTicks(2529), new TimeSpan(0, 2, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 12, 4, 58, 986, DateTimeKind.Unspecified).AddTicks(2531), new TimeSpan(0, 2, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 12, 4, 58, 986, DateTimeKind.Unspecified).AddTicks(2533), new TimeSpan(0, 2, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 12, 4, 58, 986, DateTimeKind.Unspecified).AddTicks(2535), new TimeSpan(0, 2, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 12, 4, 58, 986, DateTimeKind.Unspecified).AddTicks(2536), new TimeSpan(0, 2, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 12, 4, 58, 986, DateTimeKind.Unspecified).AddTicks(2538), new TimeSpan(0, 2, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 12, 4, 58, 986, DateTimeKind.Unspecified).AddTicks(2540), new TimeSpan(0, 2, 0, 0, 0)) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 20, 18, 24, 24, 544, DateTimeKind.Unspecified).AddTicks(8905), new TimeSpan(0, 2, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 20, 18, 24, 24, 544, DateTimeKind.Unspecified).AddTicks(8907), new TimeSpan(0, 2, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 20, 18, 24, 24, 544, DateTimeKind.Unspecified).AddTicks(8911), new TimeSpan(0, 2, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 20, 18, 24, 24, 544, DateTimeKind.Unspecified).AddTicks(8912), new TimeSpan(0, 2, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 20, 18, 24, 24, 544, DateTimeKind.Unspecified).AddTicks(8914), new TimeSpan(0, 2, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 20, 18, 24, 24, 544, DateTimeKind.Unspecified).AddTicks(8916), new TimeSpan(0, 2, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 20, 18, 24, 24, 544, DateTimeKind.Unspecified).AddTicks(8917), new TimeSpan(0, 2, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 20, 18, 24, 24, 544, DateTimeKind.Unspecified).AddTicks(8919), new TimeSpan(0, 2, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 20, 18, 24, 24, 544, DateTimeKind.Unspecified).AddTicks(8921), new TimeSpan(0, 2, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 20, 18, 24, 24, 544, DateTimeKind.Unspecified).AddTicks(8922), new TimeSpan(0, 2, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 20, 18, 24, 24, 544, DateTimeKind.Unspecified).AddTicks(8924), new TimeSpan(0, 2, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 20, 18, 24, 24, 544, DateTimeKind.Unspecified).AddTicks(8926), new TimeSpan(0, 2, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 20, 18, 24, 24, 544, DateTimeKind.Unspecified).AddTicks(8928), new TimeSpan(0, 2, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 20, 18, 24, 24, 544, DateTimeKind.Unspecified).AddTicks(8929), new TimeSpan(0, 2, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 20, 18, 24, 24, 544, DateTimeKind.Unspecified).AddTicks(8932), new TimeSpan(0, 2, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 20, 18, 24, 24, 544, DateTimeKind.Unspecified).AddTicks(8933), new TimeSpan(0, 2, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 20, 18, 24, 24, 544, DateTimeKind.Unspecified).AddTicks(8935), new TimeSpan(0, 2, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 20, 18, 24, 24, 544, DateTimeKind.Unspecified).AddTicks(8936), new TimeSpan(0, 2, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 20, 18, 24, 24, 544, DateTimeKind.Unspecified).AddTicks(8938), new TimeSpan(0, 2, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 20, 18, 24, 24, 544, DateTimeKind.Unspecified).AddTicks(8940), new TimeSpan(0, 2, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 20, 18, 24, 24, 544, DateTimeKind.Unspecified).AddTicks(8942), new TimeSpan(0, 2, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 20, 18, 24, 24, 544, DateTimeKind.Unspecified).AddTicks(8943), new TimeSpan(0, 2, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 20, 18, 24, 24, 544, DateTimeKind.Unspecified).AddTicks(8945), new TimeSpan(0, 2, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 20, 18, 24, 24, 544, DateTimeKind.Unspecified).AddTicks(8946), new TimeSpan(0, 2, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 20, 18, 24, 24, 544, DateTimeKind.Unspecified).AddTicks(8948), new TimeSpan(0, 2, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 20, 18, 24, 24, 544, DateTimeKind.Unspecified).AddTicks(8950), new TimeSpan(0, 2, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedAt", "ModifiedAt", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 20, 18, 24, 24, 544, DateTimeKind.Unspecified).AddTicks(8952), new TimeSpan(0, 2, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 20, 18, 24, 24, 544, DateTimeKind.Unspecified).AddTicks(8953), new TimeSpan(0, 2, 0, 0, 0)), "Panasonic" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 20, 18, 24, 24, 544, DateTimeKind.Unspecified).AddTicks(8643), new TimeSpan(0, 2, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 20, 18, 24, 24, 544, DateTimeKind.Unspecified).AddTicks(8700), new TimeSpan(0, 2, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 20, 18, 24, 24, 544, DateTimeKind.Unspecified).AddTicks(8705), new TimeSpan(0, 2, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 20, 18, 24, 24, 544, DateTimeKind.Unspecified).AddTicks(8707), new TimeSpan(0, 2, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 20, 18, 24, 24, 544, DateTimeKind.Unspecified).AddTicks(8709), new TimeSpan(0, 2, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 20, 18, 24, 24, 544, DateTimeKind.Unspecified).AddTicks(8710), new TimeSpan(0, 2, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 20, 18, 24, 24, 544, DateTimeKind.Unspecified).AddTicks(8712), new TimeSpan(0, 2, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 20, 18, 24, 24, 544, DateTimeKind.Unspecified).AddTicks(8714), new TimeSpan(0, 2, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 20, 18, 24, 24, 544, DateTimeKind.Unspecified).AddTicks(8716), new TimeSpan(0, 2, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 20, 18, 24, 24, 544, DateTimeKind.Unspecified).AddTicks(8717), new TimeSpan(0, 2, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 20, 18, 24, 24, 544, DateTimeKind.Unspecified).AddTicks(8719), new TimeSpan(0, 2, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 20, 18, 24, 24, 544, DateTimeKind.Unspecified).AddTicks(8721), new TimeSpan(0, 2, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 20, 18, 24, 24, 544, DateTimeKind.Unspecified).AddTicks(8841), new TimeSpan(0, 2, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 20, 18, 24, 24, 544, DateTimeKind.Unspecified).AddTicks(8845), new TimeSpan(0, 2, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 20, 18, 24, 24, 544, DateTimeKind.Unspecified).AddTicks(8848), new TimeSpan(0, 2, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 20, 18, 24, 24, 544, DateTimeKind.Unspecified).AddTicks(8849), new TimeSpan(0, 2, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 20, 18, 24, 24, 544, DateTimeKind.Unspecified).AddTicks(8852), new TimeSpan(0, 2, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 20, 18, 24, 24, 544, DateTimeKind.Unspecified).AddTicks(8853), new TimeSpan(0, 2, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 20, 18, 24, 24, 544, DateTimeKind.Unspecified).AddTicks(8855), new TimeSpan(0, 2, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 20, 18, 24, 24, 544, DateTimeKind.Unspecified).AddTicks(8857), new TimeSpan(0, 2, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 20, 18, 24, 24, 544, DateTimeKind.Unspecified).AddTicks(8859), new TimeSpan(0, 2, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 20, 18, 24, 24, 544, DateTimeKind.Unspecified).AddTicks(8860), new TimeSpan(0, 2, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 20, 18, 24, 24, 544, DateTimeKind.Unspecified).AddTicks(8862), new TimeSpan(0, 2, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 20, 18, 24, 24, 544, DateTimeKind.Unspecified).AddTicks(8864), new TimeSpan(0, 2, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 20, 18, 24, 24, 544, DateTimeKind.Unspecified).AddTicks(8866), new TimeSpan(0, 2, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 20, 18, 24, 24, 544, DateTimeKind.Unspecified).AddTicks(8867), new TimeSpan(0, 2, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 20, 18, 24, 24, 544, DateTimeKind.Unspecified).AddTicks(8870), new TimeSpan(0, 2, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 20, 18, 24, 24, 544, DateTimeKind.Unspecified).AddTicks(8871), new TimeSpan(0, 2, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 20, 18, 24, 24, 544, DateTimeKind.Unspecified).AddTicks(8873), new TimeSpan(0, 2, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 20, 18, 24, 24, 544, DateTimeKind.Unspecified).AddTicks(8875), new TimeSpan(0, 2, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 20, 18, 24, 24, 544, DateTimeKind.Unspecified).AddTicks(8877), new TimeSpan(0, 2, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 20, 18, 24, 24, 544, DateTimeKind.Unspecified).AddTicks(8878), new TimeSpan(0, 2, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 20, 18, 24, 24, 544, DateTimeKind.Unspecified).AddTicks(8880), new TimeSpan(0, 2, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 20, 18, 24, 24, 544, DateTimeKind.Unspecified).AddTicks(8882), new TimeSpan(0, 2, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 20, 18, 24, 24, 544, DateTimeKind.Unspecified).AddTicks(8884), new TimeSpan(0, 2, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 20, 18, 24, 24, 544, DateTimeKind.Unspecified).AddTicks(8885), new TimeSpan(0, 2, 0, 0, 0)) });
        }
    }
}
