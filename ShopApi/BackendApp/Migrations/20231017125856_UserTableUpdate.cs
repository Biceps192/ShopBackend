using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BackendApp.Migrations
{
    /// <inheritdoc />
    public partial class UserTableUpdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "UserName",
                table: "Users",
                newName: "Username");

            migrationBuilder.RenameColumn(
                name: "Password",
                table: "Users",
                newName: "Email");

            migrationBuilder.AddColumn<byte[]>(
                name: "PasswordHash",
                table: "Users",
                type: "varbinary(max)",
                nullable: false,
                defaultValue: new byte[0]);

            migrationBuilder.AddColumn<byte[]>(
                name: "PasswordSalt",
                table: "Users",
                type: "varbinary(max)",
                nullable: false,
                defaultValue: new byte[0]);

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PasswordHash",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "PasswordSalt",
                table: "Users");

            migrationBuilder.RenameColumn(
                name: "Username",
                table: "Users",
                newName: "UserName");

            migrationBuilder.RenameColumn(
                name: "Email",
                table: "Users",
                newName: "Password");

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 10, 3, 17, 6, 9, 390, DateTimeKind.Unspecified).AddTicks(5385), new TimeSpan(0, 3, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 10, 3, 17, 6, 9, 390, DateTimeKind.Unspecified).AddTicks(5387), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 10, 3, 17, 6, 9, 390, DateTimeKind.Unspecified).AddTicks(5389), new TimeSpan(0, 3, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 10, 3, 17, 6, 9, 390, DateTimeKind.Unspecified).AddTicks(5391), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 10, 3, 17, 6, 9, 390, DateTimeKind.Unspecified).AddTicks(5393), new TimeSpan(0, 3, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 10, 3, 17, 6, 9, 390, DateTimeKind.Unspecified).AddTicks(5394), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 10, 3, 17, 6, 9, 390, DateTimeKind.Unspecified).AddTicks(5396), new TimeSpan(0, 3, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 10, 3, 17, 6, 9, 390, DateTimeKind.Unspecified).AddTicks(5398), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 10, 3, 17, 6, 9, 390, DateTimeKind.Unspecified).AddTicks(5399), new TimeSpan(0, 3, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 10, 3, 17, 6, 9, 390, DateTimeKind.Unspecified).AddTicks(5401), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 10, 3, 17, 6, 9, 390, DateTimeKind.Unspecified).AddTicks(5403), new TimeSpan(0, 3, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 10, 3, 17, 6, 9, 390, DateTimeKind.Unspecified).AddTicks(5404), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 10, 3, 17, 6, 9, 390, DateTimeKind.Unspecified).AddTicks(5406), new TimeSpan(0, 3, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 10, 3, 17, 6, 9, 390, DateTimeKind.Unspecified).AddTicks(5408), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 10, 3, 17, 6, 9, 390, DateTimeKind.Unspecified).AddTicks(5410), new TimeSpan(0, 3, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 10, 3, 17, 6, 9, 390, DateTimeKind.Unspecified).AddTicks(5411), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 10, 3, 17, 6, 9, 390, DateTimeKind.Unspecified).AddTicks(5413), new TimeSpan(0, 3, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 10, 3, 17, 6, 9, 390, DateTimeKind.Unspecified).AddTicks(5415), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 10, 3, 17, 6, 9, 390, DateTimeKind.Unspecified).AddTicks(5417), new TimeSpan(0, 3, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 10, 3, 17, 6, 9, 390, DateTimeKind.Unspecified).AddTicks(5418), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 10, 3, 17, 6, 9, 390, DateTimeKind.Unspecified).AddTicks(5420), new TimeSpan(0, 3, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 10, 3, 17, 6, 9, 390, DateTimeKind.Unspecified).AddTicks(5422), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 10, 3, 17, 6, 9, 390, DateTimeKind.Unspecified).AddTicks(5424), new TimeSpan(0, 3, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 10, 3, 17, 6, 9, 390, DateTimeKind.Unspecified).AddTicks(5425), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 10, 3, 17, 6, 9, 390, DateTimeKind.Unspecified).AddTicks(5427), new TimeSpan(0, 3, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 10, 3, 17, 6, 9, 390, DateTimeKind.Unspecified).AddTicks(5429), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 10, 3, 17, 6, 9, 390, DateTimeKind.Unspecified).AddTicks(5430), new TimeSpan(0, 3, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 10, 3, 17, 6, 9, 390, DateTimeKind.Unspecified).AddTicks(5432), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 10, 3, 17, 6, 9, 390, DateTimeKind.Unspecified).AddTicks(4818), new TimeSpan(0, 3, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 10, 3, 17, 6, 9, 390, DateTimeKind.Unspecified).AddTicks(4883), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 10, 3, 17, 6, 9, 390, DateTimeKind.Unspecified).AddTicks(4887), new TimeSpan(0, 3, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 10, 3, 17, 6, 9, 390, DateTimeKind.Unspecified).AddTicks(4888), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 10, 3, 17, 6, 9, 390, DateTimeKind.Unspecified).AddTicks(4890), new TimeSpan(0, 3, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 10, 3, 17, 6, 9, 390, DateTimeKind.Unspecified).AddTicks(4892), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 10, 3, 17, 6, 9, 390, DateTimeKind.Unspecified).AddTicks(4894), new TimeSpan(0, 3, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 10, 3, 17, 6, 9, 390, DateTimeKind.Unspecified).AddTicks(4895), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 10, 3, 17, 6, 9, 390, DateTimeKind.Unspecified).AddTicks(4897), new TimeSpan(0, 3, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 10, 3, 17, 6, 9, 390, DateTimeKind.Unspecified).AddTicks(4899), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 10, 3, 17, 6, 9, 390, DateTimeKind.Unspecified).AddTicks(4901), new TimeSpan(0, 3, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 10, 3, 17, 6, 9, 390, DateTimeKind.Unspecified).AddTicks(4902), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 10, 3, 17, 6, 9, 390, DateTimeKind.Unspecified).AddTicks(5310), new TimeSpan(0, 3, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 10, 3, 17, 6, 9, 390, DateTimeKind.Unspecified).AddTicks(5315), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 10, 3, 17, 6, 9, 390, DateTimeKind.Unspecified).AddTicks(5319), new TimeSpan(0, 3, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 10, 3, 17, 6, 9, 390, DateTimeKind.Unspecified).AddTicks(5320), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 10, 3, 17, 6, 9, 390, DateTimeKind.Unspecified).AddTicks(5323), new TimeSpan(0, 3, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 10, 3, 17, 6, 9, 390, DateTimeKind.Unspecified).AddTicks(5324), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 10, 3, 17, 6, 9, 390, DateTimeKind.Unspecified).AddTicks(5326), new TimeSpan(0, 3, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 10, 3, 17, 6, 9, 390, DateTimeKind.Unspecified).AddTicks(5328), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 10, 3, 17, 6, 9, 390, DateTimeKind.Unspecified).AddTicks(5330), new TimeSpan(0, 3, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 10, 3, 17, 6, 9, 390, DateTimeKind.Unspecified).AddTicks(5332), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 10, 3, 17, 6, 9, 390, DateTimeKind.Unspecified).AddTicks(5334), new TimeSpan(0, 3, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 10, 3, 17, 6, 9, 390, DateTimeKind.Unspecified).AddTicks(5335), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 10, 3, 17, 6, 9, 390, DateTimeKind.Unspecified).AddTicks(5337), new TimeSpan(0, 3, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 10, 3, 17, 6, 9, 390, DateTimeKind.Unspecified).AddTicks(5339), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 10, 3, 17, 6, 9, 390, DateTimeKind.Unspecified).AddTicks(5341), new TimeSpan(0, 3, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 10, 3, 17, 6, 9, 390, DateTimeKind.Unspecified).AddTicks(5343), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 10, 3, 17, 6, 9, 390, DateTimeKind.Unspecified).AddTicks(5345), new TimeSpan(0, 3, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 10, 3, 17, 6, 9, 390, DateTimeKind.Unspecified).AddTicks(5346), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 10, 3, 17, 6, 9, 390, DateTimeKind.Unspecified).AddTicks(5349), new TimeSpan(0, 3, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 10, 3, 17, 6, 9, 390, DateTimeKind.Unspecified).AddTicks(5350), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 10, 3, 17, 6, 9, 390, DateTimeKind.Unspecified).AddTicks(5352), new TimeSpan(0, 3, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 10, 3, 17, 6, 9, 390, DateTimeKind.Unspecified).AddTicks(5354), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 10, 3, 17, 6, 9, 390, DateTimeKind.Unspecified).AddTicks(5356), new TimeSpan(0, 3, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 10, 3, 17, 6, 9, 390, DateTimeKind.Unspecified).AddTicks(5358), new TimeSpan(0, 3, 0, 0, 0)) });
        }
    }
}
