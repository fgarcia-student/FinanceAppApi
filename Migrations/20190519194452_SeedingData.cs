using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FinanceApp.Migrations
{
    public partial class SeedingData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Types",
                columns: new[] { "Id", "CreatorId", "DateCreated", "DateModified", "Description", "IsDeleted", "ModifierId" },
                values: new object[] { 1, 1, new DateTime(2019, 5, 19, 19, 44, 51, 803, DateTimeKind.Utc).AddTicks(9520), null, "Income", false, null });

            migrationBuilder.InsertData(
                table: "Types",
                columns: new[] { "Id", "CreatorId", "DateCreated", "DateModified", "Description", "IsDeleted", "ModifierId" },
                values: new object[] { 2, 1, new DateTime(2019, 5, 19, 19, 44, 51, 808, DateTimeKind.Utc).AddTicks(4490), null, "Expense", false, null });

            migrationBuilder.InsertData(
                table: "Types",
                columns: new[] { "Id", "CreatorId", "DateCreated", "DateModified", "Description", "IsDeleted", "ModifierId" },
                values: new object[] { 3, 1, new DateTime(2019, 5, 19, 19, 44, 51, 808, DateTimeKind.Utc).AddTicks(5040), null, "Saving", false, null });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Types",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Types",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Types",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
