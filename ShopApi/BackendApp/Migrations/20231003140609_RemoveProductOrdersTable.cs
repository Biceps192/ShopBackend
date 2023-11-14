using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BackendApp.Migrations
{
    /// <inheritdoc />
    public partial class RemoveProductOrdersTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Baskets_Products_ProductId",
                table: "Baskets");

            migrationBuilder.DropForeignKey(
                name: "FK_Orders_PublicUsers_PublicUserId",
                table: "Orders");

            migrationBuilder.DropTable(
                name: "ProductOrders");

            migrationBuilder.DropIndex(
                name: "IX_Baskets_ProductId",
                table: "Baskets");

            migrationBuilder.DropColumn(
                name: "ProductId",
                table: "Baskets");

            migrationBuilder.RenameColumn(
                name: "PublicUserId",
                table: "Orders",
                newName: "BasketId");

            migrationBuilder.RenameIndex(
                name: "IX_Orders_PublicUserId",
                table: "Orders",
                newName: "IX_Orders_BasketId");

            migrationBuilder.AddColumn<decimal>(
                name: "Price",
                table: "Orders",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.CreateTable(
                name: "ProductBasket",
                columns: table => new
                {
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    BasketId = table.Column<int>(type: "int", nullable: false)
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

            migrationBuilder.CreateIndex(
                name: "IX_ProductBasket_BasketId",
                table: "ProductBasket",
                column: "BasketId");

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Baskets_BasketId",
                table: "Orders",
                column: "BasketId",
                principalTable: "Baskets",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Baskets_BasketId",
                table: "Orders");

            migrationBuilder.DropTable(
                name: "ProductBasket");

            migrationBuilder.DropColumn(
                name: "Price",
                table: "Orders");

            migrationBuilder.RenameColumn(
                name: "BasketId",
                table: "Orders",
                newName: "PublicUserId");

            migrationBuilder.RenameIndex(
                name: "IX_Orders_BasketId",
                table: "Orders",
                newName: "IX_Orders_PublicUserId");

            migrationBuilder.AddColumn<int>(
                name: "ProductId",
                table: "Baskets",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "ProductOrders",
                columns: table => new
                {
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    OrderId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductOrders", x => new { x.ProductId, x.OrderId });
                    table.ForeignKey(
                        name: "FK_ProductOrders_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductOrders_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 10, 3, 15, 59, 27, 276, DateTimeKind.Unspecified).AddTicks(5672), new TimeSpan(0, 3, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 10, 3, 15, 59, 27, 276, DateTimeKind.Unspecified).AddTicks(5674), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 10, 3, 15, 59, 27, 276, DateTimeKind.Unspecified).AddTicks(5676), new TimeSpan(0, 3, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 10, 3, 15, 59, 27, 276, DateTimeKind.Unspecified).AddTicks(5678), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 10, 3, 15, 59, 27, 276, DateTimeKind.Unspecified).AddTicks(5680), new TimeSpan(0, 3, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 10, 3, 15, 59, 27, 276, DateTimeKind.Unspecified).AddTicks(5682), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 10, 3, 15, 59, 27, 276, DateTimeKind.Unspecified).AddTicks(5684), new TimeSpan(0, 3, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 10, 3, 15, 59, 27, 276, DateTimeKind.Unspecified).AddTicks(5685), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 10, 3, 15, 59, 27, 276, DateTimeKind.Unspecified).AddTicks(5687), new TimeSpan(0, 3, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 10, 3, 15, 59, 27, 276, DateTimeKind.Unspecified).AddTicks(5689), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 10, 3, 15, 59, 27, 276, DateTimeKind.Unspecified).AddTicks(5691), new TimeSpan(0, 3, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 10, 3, 15, 59, 27, 276, DateTimeKind.Unspecified).AddTicks(5692), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 10, 3, 15, 59, 27, 276, DateTimeKind.Unspecified).AddTicks(5694), new TimeSpan(0, 3, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 10, 3, 15, 59, 27, 276, DateTimeKind.Unspecified).AddTicks(5696), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 10, 3, 15, 59, 27, 276, DateTimeKind.Unspecified).AddTicks(5698), new TimeSpan(0, 3, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 10, 3, 15, 59, 27, 276, DateTimeKind.Unspecified).AddTicks(5699), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 10, 3, 15, 59, 27, 276, DateTimeKind.Unspecified).AddTicks(5701), new TimeSpan(0, 3, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 10, 3, 15, 59, 27, 276, DateTimeKind.Unspecified).AddTicks(5703), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 10, 3, 15, 59, 27, 276, DateTimeKind.Unspecified).AddTicks(5705), new TimeSpan(0, 3, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 10, 3, 15, 59, 27, 276, DateTimeKind.Unspecified).AddTicks(5706), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 10, 3, 15, 59, 27, 276, DateTimeKind.Unspecified).AddTicks(5708), new TimeSpan(0, 3, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 10, 3, 15, 59, 27, 276, DateTimeKind.Unspecified).AddTicks(5710), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 10, 3, 15, 59, 27, 276, DateTimeKind.Unspecified).AddTicks(5713), new TimeSpan(0, 3, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 10, 3, 15, 59, 27, 276, DateTimeKind.Unspecified).AddTicks(5715), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 10, 3, 15, 59, 27, 276, DateTimeKind.Unspecified).AddTicks(5717), new TimeSpan(0, 3, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 10, 3, 15, 59, 27, 276, DateTimeKind.Unspecified).AddTicks(5718), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 10, 3, 15, 59, 27, 276, DateTimeKind.Unspecified).AddTicks(5720), new TimeSpan(0, 3, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 10, 3, 15, 59, 27, 276, DateTimeKind.Unspecified).AddTicks(5722), new TimeSpan(0, 3, 0, 0, 0)) });

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

            migrationBuilder.CreateIndex(
                name: "IX_Baskets_ProductId",
                table: "Baskets",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductOrders_OrderId",
                table: "ProductOrders",
                column: "OrderId");

            migrationBuilder.AddForeignKey(
                name: "FK_Baskets_Products_ProductId",
                table: "Baskets",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_PublicUsers_PublicUserId",
                table: "Orders",
                column: "PublicUserId",
                principalTable: "PublicUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
