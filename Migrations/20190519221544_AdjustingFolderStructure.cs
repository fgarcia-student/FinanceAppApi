using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FinanceApp.Migrations
{
    public partial class AdjustingFolderStructure : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Types",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2019, 5, 19, 22, 15, 43, 754, DateTimeKind.Utc).AddTicks(730));

            migrationBuilder.UpdateData(
                table: "Types",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2019, 5, 19, 22, 15, 43, 754, DateTimeKind.Utc).AddTicks(730));

            migrationBuilder.UpdateData(
                table: "Types",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2019, 5, 19, 22, 15, 43, 754, DateTimeKind.Utc).AddTicks(730));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Types",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2019, 5, 19, 19, 44, 51, 803, DateTimeKind.Utc).AddTicks(9520));

            migrationBuilder.UpdateData(
                table: "Types",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2019, 5, 19, 19, 44, 51, 808, DateTimeKind.Utc).AddTicks(4490));

            migrationBuilder.UpdateData(
                table: "Types",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2019, 5, 19, 19, 44, 51, 808, DateTimeKind.Utc).AddTicks(5040));
        }
    }
}
