using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlazingShop.Server.Migrations
{
    /// <inheritdoc />
    public partial class ProductViews : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                columns: new[] { "DateCreated", "Views" },
                values: new object[] { new DateTime(2023, 7, 9, 8, 27, 15, 482, DateTimeKind.Local).AddTicks(9430), 0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "Views" },
                values: new object[] { new DateTime(2023, 7, 9, 8, 27, 15, 482, DateTimeKind.Local).AddTicks(9490), 0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "Views" },
                values: new object[] { new DateTime(2023, 7, 9, 8, 27, 15, 482, DateTimeKind.Local).AddTicks(9490), 0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "Views" },
                values: new object[] { new DateTime(2023, 7, 9, 8, 27, 15, 482, DateTimeKind.Local).AddTicks(9490), 0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "Views" },
                values: new object[] { new DateTime(2023, 7, 9, 8, 27, 15, 482, DateTimeKind.Local).AddTicks(9500), 0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "Views" },
                values: new object[] { new DateTime(2023, 7, 9, 8, 27, 15, 482, DateTimeKind.Local).AddTicks(9500), 0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "Views" },
                values: new object[] { new DateTime(2023, 7, 9, 8, 27, 15, 482, DateTimeKind.Local).AddTicks(9500), 0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "Views" },
                values: new object[] { new DateTime(2023, 7, 9, 8, 27, 15, 482, DateTimeKind.Local).AddTicks(9500), 0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "Views" },
                values: new object[] { new DateTime(2023, 7, 9, 8, 27, 15, 482, DateTimeKind.Local).AddTicks(9510), 0 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Views",
                table: "Products");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2023, 7, 9, 4, 34, 10, 615, DateTimeKind.Local).AddTicks(320));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2023, 7, 9, 4, 34, 10, 615, DateTimeKind.Local).AddTicks(370));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2023, 7, 9, 4, 34, 10, 615, DateTimeKind.Local).AddTicks(370));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2023, 7, 9, 4, 34, 10, 615, DateTimeKind.Local).AddTicks(380));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2023, 7, 9, 4, 34, 10, 615, DateTimeKind.Local).AddTicks(380));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2023, 7, 9, 4, 34, 10, 615, DateTimeKind.Local).AddTicks(380));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2023, 7, 9, 4, 34, 10, 615, DateTimeKind.Local).AddTicks(380));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateCreated",
                value: new DateTime(2023, 7, 9, 4, 34, 10, 615, DateTimeKind.Local).AddTicks(390));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateCreated",
                value: new DateTime(2023, 7, 9, 4, 34, 10, 615, DateTimeKind.Local).AddTicks(390));
        }
    }
}
