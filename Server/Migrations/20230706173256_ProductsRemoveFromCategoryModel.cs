using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlazingShop.Server.Migrations
{
    /// <inheritdoc />
    public partial class ProductsRemoveFromCategoryModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2023, 7, 6, 13, 32, 56, 6, DateTimeKind.Local).AddTicks(9380));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2023, 7, 6, 13, 32, 56, 6, DateTimeKind.Local).AddTicks(9440));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2023, 7, 6, 13, 32, 56, 6, DateTimeKind.Local).AddTicks(9440));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2023, 7, 6, 13, 32, 56, 6, DateTimeKind.Local).AddTicks(9530));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2023, 7, 6, 13, 32, 56, 6, DateTimeKind.Local).AddTicks(9530));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2023, 7, 6, 13, 32, 56, 6, DateTimeKind.Local).AddTicks(9530));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2023, 7, 6, 13, 32, 56, 6, DateTimeKind.Local).AddTicks(9540));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateCreated",
                value: new DateTime(2023, 7, 6, 13, 32, 56, 6, DateTimeKind.Local).AddTicks(9540));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateCreated",
                value: new DateTime(2023, 7, 6, 13, 32, 56, 6, DateTimeKind.Local).AddTicks(9540));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2023, 7, 6, 13, 10, 6, 124, DateTimeKind.Local).AddTicks(7500));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2023, 7, 6, 13, 10, 6, 124, DateTimeKind.Local).AddTicks(7550));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2023, 7, 6, 13, 10, 6, 124, DateTimeKind.Local).AddTicks(7550));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2023, 7, 6, 13, 10, 6, 124, DateTimeKind.Local).AddTicks(7640));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2023, 7, 6, 13, 10, 6, 124, DateTimeKind.Local).AddTicks(7640));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2023, 7, 6, 13, 10, 6, 124, DateTimeKind.Local).AddTicks(7640));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2023, 7, 6, 13, 10, 6, 124, DateTimeKind.Local).AddTicks(7650));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateCreated",
                value: new DateTime(2023, 7, 6, 13, 10, 6, 124, DateTimeKind.Local).AddTicks(7650));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateCreated",
                value: new DateTime(2023, 7, 6, 13, 10, 6, 124, DateTimeKind.Local).AddTicks(7650));
        }
    }
}
