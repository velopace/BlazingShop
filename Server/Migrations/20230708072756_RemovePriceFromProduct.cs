using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlazingShop.Server.Migrations
{
    /// <inheritdoc />
    public partial class RemovePriceFromProduct : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "OriginalPrice",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "Price",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "Views",
                table: "Products");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2023, 7, 8, 3, 27, 56, 735, DateTimeKind.Local).AddTicks(5280));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2023, 7, 8, 3, 27, 56, 735, DateTimeKind.Local).AddTicks(5330));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2023, 7, 8, 3, 27, 56, 735, DateTimeKind.Local).AddTicks(5330));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2023, 7, 8, 3, 27, 56, 735, DateTimeKind.Local).AddTicks(5390));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2023, 7, 8, 3, 27, 56, 735, DateTimeKind.Local).AddTicks(5390));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2023, 7, 8, 3, 27, 56, 735, DateTimeKind.Local).AddTicks(5390));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2023, 7, 8, 3, 27, 56, 735, DateTimeKind.Local).AddTicks(5400));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateCreated",
                value: new DateTime(2023, 7, 8, 3, 27, 56, 735, DateTimeKind.Local).AddTicks(5400));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateCreated",
                value: new DateTime(2023, 7, 8, 3, 27, 56, 735, DateTimeKind.Local).AddTicks(5400));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "OriginalPrice",
                table: "Products",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "Price",
                table: "Products",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<int>(
                name: "Views",
                table: "Products",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "OriginalPrice", "Price", "Views" },
                values: new object[] { new DateTime(2023, 7, 8, 3, 21, 57, 15, DateTimeKind.Local).AddTicks(7960), 0m, 0m, 0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "OriginalPrice", "Price", "Views" },
                values: new object[] { new DateTime(2023, 7, 8, 3, 21, 57, 15, DateTimeKind.Local).AddTicks(8010), 0m, 0m, 0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "OriginalPrice", "Price", "Views" },
                values: new object[] { new DateTime(2023, 7, 8, 3, 21, 57, 15, DateTimeKind.Local).AddTicks(8020), 0m, 0m, 0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "OriginalPrice", "Price", "Views" },
                values: new object[] { new DateTime(2023, 7, 8, 3, 21, 57, 15, DateTimeKind.Local).AddTicks(8020), 0m, 0m, 0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "OriginalPrice", "Price", "Views" },
                values: new object[] { new DateTime(2023, 7, 8, 3, 21, 57, 15, DateTimeKind.Local).AddTicks(8020), 0m, 0m, 0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "OriginalPrice", "Price", "Views" },
                values: new object[] { new DateTime(2023, 7, 8, 3, 21, 57, 15, DateTimeKind.Local).AddTicks(8030), 0m, 0m, 0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "OriginalPrice", "Price", "Views" },
                values: new object[] { new DateTime(2023, 7, 8, 3, 21, 57, 15, DateTimeKind.Local).AddTicks(8030), 0m, 0m, 0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "OriginalPrice", "Price", "Views" },
                values: new object[] { new DateTime(2023, 7, 8, 3, 21, 57, 15, DateTimeKind.Local).AddTicks(8030), 0m, 0m, 0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "OriginalPrice", "Price", "Views" },
                values: new object[] { new DateTime(2023, 7, 8, 3, 21, 57, 15, DateTimeKind.Local).AddTicks(8030), 0m, 0m, 0 });
        }
    }
}
