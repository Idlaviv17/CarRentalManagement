using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CarRentalManagement.Server.Data.Migrations
{
    public partial class SeedDefaultRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "e1b86601-8938-4216-a8f8-58926cd4f163", "3da78fec-fd2e-448a-bbe4-45a40173dd9b", "User", "USER" },
                    { "5418e8e3-b7a7-48e9-b310-e03c156b31fd", "7a55f3ed-bdd7-416e-8352-a18277361736", "Administrator", "ADMINISTRATOR" }
                });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 9, 7, 9, 5, 45, 353, DateTimeKind.Local).AddTicks(6241), new DateTime(2023, 9, 7, 9, 5, 45, 354, DateTimeKind.Local).AddTicks(3383) });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 9, 7, 9, 5, 45, 354, DateTimeKind.Local).AddTicks(4249), new DateTime(2023, 9, 7, 9, 5, 45, 354, DateTimeKind.Local).AddTicks(4254) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 9, 7, 9, 5, 45, 355, DateTimeKind.Local).AddTicks(4126), new DateTime(2023, 9, 7, 9, 5, 45, 355, DateTimeKind.Local).AddTicks(4134) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 9, 7, 9, 5, 45, 355, DateTimeKind.Local).AddTicks(4435), new DateTime(2023, 9, 7, 9, 5, 45, 355, DateTimeKind.Local).AddTicks(4438) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 9, 7, 9, 5, 45, 355, DateTimeKind.Local).AddTicks(7456), new DateTime(2023, 9, 7, 9, 5, 45, 355, DateTimeKind.Local).AddTicks(7463) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 9, 7, 9, 5, 45, 355, DateTimeKind.Local).AddTicks(7766), new DateTime(2023, 9, 7, 9, 5, 45, 355, DateTimeKind.Local).AddTicks(7769) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 9, 7, 9, 5, 45, 355, DateTimeKind.Local).AddTicks(7771), new DateTime(2023, 9, 7, 9, 5, 45, 355, DateTimeKind.Local).AddTicks(7772) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 9, 7, 9, 5, 45, 355, DateTimeKind.Local).AddTicks(7773), new DateTime(2023, 9, 7, 9, 5, 45, 355, DateTimeKind.Local).AddTicks(7774) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5418e8e3-b7a7-48e9-b310-e03c156b31fd");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e1b86601-8938-4216-a8f8-58926cd4f163");

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 9, 7, 8, 53, 17, 69, DateTimeKind.Local).AddTicks(4495), new DateTime(2023, 9, 7, 8, 53, 17, 70, DateTimeKind.Local).AddTicks(8452) });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 9, 7, 8, 53, 17, 70, DateTimeKind.Local).AddTicks(9343), new DateTime(2023, 9, 7, 8, 53, 17, 70, DateTimeKind.Local).AddTicks(9348) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 9, 7, 8, 53, 17, 71, DateTimeKind.Local).AddTicks(9210), new DateTime(2023, 9, 7, 8, 53, 17, 71, DateTimeKind.Local).AddTicks(9217) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 9, 7, 8, 53, 17, 71, DateTimeKind.Local).AddTicks(9521), new DateTime(2023, 9, 7, 8, 53, 17, 71, DateTimeKind.Local).AddTicks(9524) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 9, 7, 8, 53, 17, 72, DateTimeKind.Local).AddTicks(2430), new DateTime(2023, 9, 7, 8, 53, 17, 72, DateTimeKind.Local).AddTicks(2436) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 9, 7, 8, 53, 17, 72, DateTimeKind.Local).AddTicks(2763), new DateTime(2023, 9, 7, 8, 53, 17, 72, DateTimeKind.Local).AddTicks(2767) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 9, 7, 8, 53, 17, 72, DateTimeKind.Local).AddTicks(2768), new DateTime(2023, 9, 7, 8, 53, 17, 72, DateTimeKind.Local).AddTicks(2769) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 9, 7, 8, 53, 17, 72, DateTimeKind.Local).AddTicks(2770), new DateTime(2023, 9, 7, 8, 53, 17, 72, DateTimeKind.Local).AddTicks(2771) });
        }
    }
}
