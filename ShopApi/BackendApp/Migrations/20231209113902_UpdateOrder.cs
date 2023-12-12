using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BackendApp.Migrations
{
    /// <inheritdoc />
    public partial class UpdateOrder : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Address",
                table: "Orders",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 12, 9, 13, 39, 2, 92, DateTimeKind.Unspecified).AddTicks(7808), new TimeSpan(0, 2, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 12, 9, 13, 39, 2, 92, DateTimeKind.Unspecified).AddTicks(7811), new TimeSpan(0, 2, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 12, 9, 13, 39, 2, 92, DateTimeKind.Unspecified).AddTicks(7813), new TimeSpan(0, 2, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 12, 9, 13, 39, 2, 92, DateTimeKind.Unspecified).AddTicks(7814), new TimeSpan(0, 2, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 12, 9, 13, 39, 2, 92, DateTimeKind.Unspecified).AddTicks(7816), new TimeSpan(0, 2, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 12, 9, 13, 39, 2, 92, DateTimeKind.Unspecified).AddTicks(7818), new TimeSpan(0, 2, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 12, 9, 13, 39, 2, 92, DateTimeKind.Unspecified).AddTicks(7820), new TimeSpan(0, 2, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 12, 9, 13, 39, 2, 92, DateTimeKind.Unspecified).AddTicks(7821), new TimeSpan(0, 2, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 12, 9, 13, 39, 2, 92, DateTimeKind.Unspecified).AddTicks(7823), new TimeSpan(0, 2, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 12, 9, 13, 39, 2, 92, DateTimeKind.Unspecified).AddTicks(7825), new TimeSpan(0, 2, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 12, 9, 13, 39, 2, 92, DateTimeKind.Unspecified).AddTicks(7827), new TimeSpan(0, 2, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 12, 9, 13, 39, 2, 92, DateTimeKind.Unspecified).AddTicks(7828), new TimeSpan(0, 2, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 12, 9, 13, 39, 2, 92, DateTimeKind.Unspecified).AddTicks(7831), new TimeSpan(0, 2, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 12, 9, 13, 39, 2, 92, DateTimeKind.Unspecified).AddTicks(7832), new TimeSpan(0, 2, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 12, 9, 13, 39, 2, 92, DateTimeKind.Unspecified).AddTicks(7900), new TimeSpan(0, 2, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 12, 9, 13, 39, 2, 92, DateTimeKind.Unspecified).AddTicks(7902), new TimeSpan(0, 2, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 12, 9, 13, 39, 2, 92, DateTimeKind.Unspecified).AddTicks(7906), new TimeSpan(0, 2, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 12, 9, 13, 39, 2, 92, DateTimeKind.Unspecified).AddTicks(7907), new TimeSpan(0, 2, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 12, 9, 13, 39, 2, 92, DateTimeKind.Unspecified).AddTicks(7910), new TimeSpan(0, 2, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 12, 9, 13, 39, 2, 92, DateTimeKind.Unspecified).AddTicks(7911), new TimeSpan(0, 2, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 12, 9, 13, 39, 2, 92, DateTimeKind.Unspecified).AddTicks(7913), new TimeSpan(0, 2, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 12, 9, 13, 39, 2, 92, DateTimeKind.Unspecified).AddTicks(7915), new TimeSpan(0, 2, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 12, 9, 13, 39, 2, 92, DateTimeKind.Unspecified).AddTicks(7917), new TimeSpan(0, 2, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 12, 9, 13, 39, 2, 92, DateTimeKind.Unspecified).AddTicks(7919), new TimeSpan(0, 2, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 12, 9, 13, 39, 2, 92, DateTimeKind.Unspecified).AddTicks(7920), new TimeSpan(0, 2, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 12, 9, 13, 39, 2, 92, DateTimeKind.Unspecified).AddTicks(7922), new TimeSpan(0, 2, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 12, 9, 13, 39, 2, 92, DateTimeKind.Unspecified).AddTicks(7924), new TimeSpan(0, 2, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 12, 9, 13, 39, 2, 92, DateTimeKind.Unspecified).AddTicks(7925), new TimeSpan(0, 2, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 12, 9, 13, 39, 2, 92, DateTimeKind.Unspecified).AddTicks(7927), new TimeSpan(0, 2, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 12, 9, 13, 39, 2, 92, DateTimeKind.Unspecified).AddTicks(7928), new TimeSpan(0, 2, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 12, 9, 13, 39, 2, 92, DateTimeKind.Unspecified).AddTicks(7930), new TimeSpan(0, 2, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 12, 9, 13, 39, 2, 92, DateTimeKind.Unspecified).AddTicks(7932), new TimeSpan(0, 2, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 12, 9, 13, 39, 2, 92, DateTimeKind.Unspecified).AddTicks(7934), new TimeSpan(0, 2, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 12, 9, 13, 39, 2, 92, DateTimeKind.Unspecified).AddTicks(7935), new TimeSpan(0, 2, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 12, 9, 13, 39, 2, 92, DateTimeKind.Unspecified).AddTicks(7938), new TimeSpan(0, 2, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 12, 9, 13, 39, 2, 92, DateTimeKind.Unspecified).AddTicks(7940), new TimeSpan(0, 2, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 12, 9, 13, 39, 2, 92, DateTimeKind.Unspecified).AddTicks(7942), new TimeSpan(0, 2, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 12, 9, 13, 39, 2, 92, DateTimeKind.Unspecified).AddTicks(7943), new TimeSpan(0, 2, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 12, 9, 13, 39, 2, 92, DateTimeKind.Unspecified).AddTicks(7945), new TimeSpan(0, 2, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 12, 9, 13, 39, 2, 92, DateTimeKind.Unspecified).AddTicks(7946), new TimeSpan(0, 2, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 12, 9, 13, 39, 2, 92, DateTimeKind.Unspecified).AddTicks(7948), new TimeSpan(0, 2, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 12, 9, 13, 39, 2, 92, DateTimeKind.Unspecified).AddTicks(7950), new TimeSpan(0, 2, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 12, 9, 13, 39, 2, 92, DateTimeKind.Unspecified).AddTicks(7952), new TimeSpan(0, 2, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 12, 9, 13, 39, 2, 92, DateTimeKind.Unspecified).AddTicks(7953), new TimeSpan(0, 2, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 12, 9, 13, 39, 2, 92, DateTimeKind.Unspecified).AddTicks(7545), new TimeSpan(0, 2, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 12, 9, 13, 39, 2, 92, DateTimeKind.Unspecified).AddTicks(7607), new TimeSpan(0, 2, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 12, 9, 13, 39, 2, 92, DateTimeKind.Unspecified).AddTicks(7611), new TimeSpan(0, 2, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 12, 9, 13, 39, 2, 92, DateTimeKind.Unspecified).AddTicks(7612), new TimeSpan(0, 2, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 12, 9, 13, 39, 2, 92, DateTimeKind.Unspecified).AddTicks(7615), new TimeSpan(0, 2, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 12, 9, 13, 39, 2, 92, DateTimeKind.Unspecified).AddTicks(7616), new TimeSpan(0, 2, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 12, 9, 13, 39, 2, 92, DateTimeKind.Unspecified).AddTicks(7618), new TimeSpan(0, 2, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 12, 9, 13, 39, 2, 92, DateTimeKind.Unspecified).AddTicks(7620), new TimeSpan(0, 2, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 12, 9, 13, 39, 2, 92, DateTimeKind.Unspecified).AddTicks(7622), new TimeSpan(0, 2, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 12, 9, 13, 39, 2, 92, DateTimeKind.Unspecified).AddTicks(7623), new TimeSpan(0, 2, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 12, 9, 13, 39, 2, 92, DateTimeKind.Unspecified).AddTicks(7625), new TimeSpan(0, 2, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 12, 9, 13, 39, 2, 92, DateTimeKind.Unspecified).AddTicks(7626), new TimeSpan(0, 2, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 12, 9, 13, 39, 2, 92, DateTimeKind.Unspecified).AddTicks(7739), new TimeSpan(0, 2, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 12, 9, 13, 39, 2, 92, DateTimeKind.Unspecified).AddTicks(7743), new TimeSpan(0, 2, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 12, 9, 13, 39, 2, 92, DateTimeKind.Unspecified).AddTicks(7747), new TimeSpan(0, 2, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 12, 9, 13, 39, 2, 92, DateTimeKind.Unspecified).AddTicks(7749), new TimeSpan(0, 2, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 12, 9, 13, 39, 2, 92, DateTimeKind.Unspecified).AddTicks(7751), new TimeSpan(0, 2, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 12, 9, 13, 39, 2, 92, DateTimeKind.Unspecified).AddTicks(7752), new TimeSpan(0, 2, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 12, 9, 13, 39, 2, 92, DateTimeKind.Unspecified).AddTicks(7755), new TimeSpan(0, 2, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 12, 9, 13, 39, 2, 92, DateTimeKind.Unspecified).AddTicks(7756), new TimeSpan(0, 2, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 12, 9, 13, 39, 2, 92, DateTimeKind.Unspecified).AddTicks(7758), new TimeSpan(0, 2, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 12, 9, 13, 39, 2, 92, DateTimeKind.Unspecified).AddTicks(7760), new TimeSpan(0, 2, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 12, 9, 13, 39, 2, 92, DateTimeKind.Unspecified).AddTicks(7762), new TimeSpan(0, 2, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 12, 9, 13, 39, 2, 92, DateTimeKind.Unspecified).AddTicks(7763), new TimeSpan(0, 2, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 12, 9, 13, 39, 2, 92, DateTimeKind.Unspecified).AddTicks(7765), new TimeSpan(0, 2, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 12, 9, 13, 39, 2, 92, DateTimeKind.Unspecified).AddTicks(7767), new TimeSpan(0, 2, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 12, 9, 13, 39, 2, 92, DateTimeKind.Unspecified).AddTicks(7769), new TimeSpan(0, 2, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 12, 9, 13, 39, 2, 92, DateTimeKind.Unspecified).AddTicks(7771), new TimeSpan(0, 2, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 12, 9, 13, 39, 2, 92, DateTimeKind.Unspecified).AddTicks(7773), new TimeSpan(0, 2, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 12, 9, 13, 39, 2, 92, DateTimeKind.Unspecified).AddTicks(7774), new TimeSpan(0, 2, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 12, 9, 13, 39, 2, 92, DateTimeKind.Unspecified).AddTicks(7776), new TimeSpan(0, 2, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 12, 9, 13, 39, 2, 92, DateTimeKind.Unspecified).AddTicks(7778), new TimeSpan(0, 2, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 12, 9, 13, 39, 2, 92, DateTimeKind.Unspecified).AddTicks(7780), new TimeSpan(0, 2, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 12, 9, 13, 39, 2, 92, DateTimeKind.Unspecified).AddTicks(7781), new TimeSpan(0, 2, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 12, 9, 13, 39, 2, 92, DateTimeKind.Unspecified).AddTicks(7783), new TimeSpan(0, 2, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 12, 9, 13, 39, 2, 92, DateTimeKind.Unspecified).AddTicks(7785), new TimeSpan(0, 2, 0, 0, 0)) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Address",
                table: "Orders");

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
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 12, 4, 58, 986, DateTimeKind.Unspecified).AddTicks(2604), new TimeSpan(0, 2, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 12, 4, 58, 986, DateTimeKind.Unspecified).AddTicks(2606), new TimeSpan(0, 2, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 12, 4, 58, 986, DateTimeKind.Unspecified).AddTicks(2608), new TimeSpan(0, 2, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 12, 4, 58, 986, DateTimeKind.Unspecified).AddTicks(2609), new TimeSpan(0, 2, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 12, 4, 58, 986, DateTimeKind.Unspecified).AddTicks(2611), new TimeSpan(0, 2, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 12, 4, 58, 986, DateTimeKind.Unspecified).AddTicks(2613), new TimeSpan(0, 2, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 12, 4, 58, 986, DateTimeKind.Unspecified).AddTicks(2615), new TimeSpan(0, 2, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 12, 4, 58, 986, DateTimeKind.Unspecified).AddTicks(2616), new TimeSpan(0, 2, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 12, 4, 58, 986, DateTimeKind.Unspecified).AddTicks(2618), new TimeSpan(0, 2, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 12, 4, 58, 986, DateTimeKind.Unspecified).AddTicks(2619), new TimeSpan(0, 2, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 12, 4, 58, 986, DateTimeKind.Unspecified).AddTicks(2621), new TimeSpan(0, 2, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 12, 4, 58, 986, DateTimeKind.Unspecified).AddTicks(2623), new TimeSpan(0, 2, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 12, 4, 58, 986, DateTimeKind.Unspecified).AddTicks(2625), new TimeSpan(0, 2, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 12, 4, 58, 986, DateTimeKind.Unspecified).AddTicks(2626), new TimeSpan(0, 2, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 12, 4, 58, 986, DateTimeKind.Unspecified).AddTicks(2628), new TimeSpan(0, 2, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 12, 4, 58, 986, DateTimeKind.Unspecified).AddTicks(2630), new TimeSpan(0, 2, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 12, 4, 58, 986, DateTimeKind.Unspecified).AddTicks(2631), new TimeSpan(0, 2, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 12, 4, 58, 986, DateTimeKind.Unspecified).AddTicks(2633), new TimeSpan(0, 2, 0, 0, 0)) });

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
    }
}
