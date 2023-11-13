using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BackendApp.Migrations
{
    /// <inheritdoc />
    public partial class Mistake : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PubclicUserId",
                table: "Users");

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
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PubclicUserId",
                table: "Users",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 10, 17, 15, 58, 56, 729, DateTimeKind.Unspecified).AddTicks(5893), new TimeSpan(0, 3, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 10, 17, 15, 58, 56, 729, DateTimeKind.Unspecified).AddTicks(5895), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 10, 17, 15, 58, 56, 729, DateTimeKind.Unspecified).AddTicks(5898), new TimeSpan(0, 3, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 10, 17, 15, 58, 56, 729, DateTimeKind.Unspecified).AddTicks(5899), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 10, 17, 15, 58, 56, 729, DateTimeKind.Unspecified).AddTicks(5901), new TimeSpan(0, 3, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 10, 17, 15, 58, 56, 729, DateTimeKind.Unspecified).AddTicks(5903), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 10, 17, 15, 58, 56, 729, DateTimeKind.Unspecified).AddTicks(5905), new TimeSpan(0, 3, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 10, 17, 15, 58, 56, 729, DateTimeKind.Unspecified).AddTicks(5906), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 10, 17, 15, 58, 56, 729, DateTimeKind.Unspecified).AddTicks(5908), new TimeSpan(0, 3, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 10, 17, 15, 58, 56, 729, DateTimeKind.Unspecified).AddTicks(5910), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 10, 17, 15, 58, 56, 729, DateTimeKind.Unspecified).AddTicks(5912), new TimeSpan(0, 3, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 10, 17, 15, 58, 56, 729, DateTimeKind.Unspecified).AddTicks(5913), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 10, 17, 15, 58, 56, 729, DateTimeKind.Unspecified).AddTicks(5915), new TimeSpan(0, 3, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 10, 17, 15, 58, 56, 729, DateTimeKind.Unspecified).AddTicks(5917), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 10, 17, 15, 58, 56, 729, DateTimeKind.Unspecified).AddTicks(5919), new TimeSpan(0, 3, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 10, 17, 15, 58, 56, 729, DateTimeKind.Unspecified).AddTicks(5920), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 10, 17, 15, 58, 56, 729, DateTimeKind.Unspecified).AddTicks(5922), new TimeSpan(0, 3, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 10, 17, 15, 58, 56, 729, DateTimeKind.Unspecified).AddTicks(5923), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 10, 17, 15, 58, 56, 729, DateTimeKind.Unspecified).AddTicks(5925), new TimeSpan(0, 3, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 10, 17, 15, 58, 56, 729, DateTimeKind.Unspecified).AddTicks(5927), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 10, 17, 15, 58, 56, 729, DateTimeKind.Unspecified).AddTicks(5929), new TimeSpan(0, 3, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 10, 17, 15, 58, 56, 729, DateTimeKind.Unspecified).AddTicks(5930), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 10, 17, 15, 58, 56, 729, DateTimeKind.Unspecified).AddTicks(5932), new TimeSpan(0, 3, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 10, 17, 15, 58, 56, 729, DateTimeKind.Unspecified).AddTicks(5934), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 10, 17, 15, 58, 56, 729, DateTimeKind.Unspecified).AddTicks(5936), new TimeSpan(0, 3, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 10, 17, 15, 58, 56, 729, DateTimeKind.Unspecified).AddTicks(5937), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 10, 17, 15, 58, 56, 729, DateTimeKind.Unspecified).AddTicks(5939), new TimeSpan(0, 3, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 10, 17, 15, 58, 56, 729, DateTimeKind.Unspecified).AddTicks(5941), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 10, 17, 15, 58, 56, 729, DateTimeKind.Unspecified).AddTicks(5530), new TimeSpan(0, 3, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 10, 17, 15, 58, 56, 729, DateTimeKind.Unspecified).AddTicks(5585), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 10, 17, 15, 58, 56, 729, DateTimeKind.Unspecified).AddTicks(5588), new TimeSpan(0, 3, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 10, 17, 15, 58, 56, 729, DateTimeKind.Unspecified).AddTicks(5590), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 10, 17, 15, 58, 56, 729, DateTimeKind.Unspecified).AddTicks(5592), new TimeSpan(0, 3, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 10, 17, 15, 58, 56, 729, DateTimeKind.Unspecified).AddTicks(5594), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 10, 17, 15, 58, 56, 729, DateTimeKind.Unspecified).AddTicks(5595), new TimeSpan(0, 3, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 10, 17, 15, 58, 56, 729, DateTimeKind.Unspecified).AddTicks(5597), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 10, 17, 15, 58, 56, 729, DateTimeKind.Unspecified).AddTicks(5599), new TimeSpan(0, 3, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 10, 17, 15, 58, 56, 729, DateTimeKind.Unspecified).AddTicks(5600), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 10, 17, 15, 58, 56, 729, DateTimeKind.Unspecified).AddTicks(5602), new TimeSpan(0, 3, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 10, 17, 15, 58, 56, 729, DateTimeKind.Unspecified).AddTicks(5604), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 10, 17, 15, 58, 56, 729, DateTimeKind.Unspecified).AddTicks(5747), new TimeSpan(0, 3, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 10, 17, 15, 58, 56, 729, DateTimeKind.Unspecified).AddTicks(5751), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 10, 17, 15, 58, 56, 729, DateTimeKind.Unspecified).AddTicks(5798), new TimeSpan(0, 3, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 10, 17, 15, 58, 56, 729, DateTimeKind.Unspecified).AddTicks(5800), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 10, 17, 15, 58, 56, 729, DateTimeKind.Unspecified).AddTicks(5836), new TimeSpan(0, 3, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 10, 17, 15, 58, 56, 729, DateTimeKind.Unspecified).AddTicks(5838), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 10, 17, 15, 58, 56, 729, DateTimeKind.Unspecified).AddTicks(5840), new TimeSpan(0, 3, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 10, 17, 15, 58, 56, 729, DateTimeKind.Unspecified).AddTicks(5841), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 10, 17, 15, 58, 56, 729, DateTimeKind.Unspecified).AddTicks(5843), new TimeSpan(0, 3, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 10, 17, 15, 58, 56, 729, DateTimeKind.Unspecified).AddTicks(5845), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 10, 17, 15, 58, 56, 729, DateTimeKind.Unspecified).AddTicks(5847), new TimeSpan(0, 3, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 10, 17, 15, 58, 56, 729, DateTimeKind.Unspecified).AddTicks(5848), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 10, 17, 15, 58, 56, 729, DateTimeKind.Unspecified).AddTicks(5850), new TimeSpan(0, 3, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 10, 17, 15, 58, 56, 729, DateTimeKind.Unspecified).AddTicks(5852), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 10, 17, 15, 58, 56, 729, DateTimeKind.Unspecified).AddTicks(5854), new TimeSpan(0, 3, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 10, 17, 15, 58, 56, 729, DateTimeKind.Unspecified).AddTicks(5856), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 10, 17, 15, 58, 56, 729, DateTimeKind.Unspecified).AddTicks(5858), new TimeSpan(0, 3, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 10, 17, 15, 58, 56, 729, DateTimeKind.Unspecified).AddTicks(5859), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 10, 17, 15, 58, 56, 729, DateTimeKind.Unspecified).AddTicks(5861), new TimeSpan(0, 3, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 10, 17, 15, 58, 56, 729, DateTimeKind.Unspecified).AddTicks(5863), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 10, 17, 15, 58, 56, 729, DateTimeKind.Unspecified).AddTicks(5865), new TimeSpan(0, 3, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 10, 17, 15, 58, 56, 729, DateTimeKind.Unspecified).AddTicks(5866), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 10, 17, 15, 58, 56, 729, DateTimeKind.Unspecified).AddTicks(5868), new TimeSpan(0, 3, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 10, 17, 15, 58, 56, 729, DateTimeKind.Unspecified).AddTicks(5870), new TimeSpan(0, 3, 0, 0, 0)) });
        }
    }
}
