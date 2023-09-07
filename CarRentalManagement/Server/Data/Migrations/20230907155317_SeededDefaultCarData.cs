using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CarRentalManagement.Server.Data.Migrations
{
    public partial class SeededDefaultCarData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Colours",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2023, 9, 7, 8, 53, 17, 69, DateTimeKind.Local).AddTicks(4495), new DateTime(2023, 9, 7, 8, 53, 17, 70, DateTimeKind.Local).AddTicks(8452), "Black", "System" },
                    { 2, "System", new DateTime(2023, 9, 7, 8, 53, 17, 70, DateTimeKind.Local).AddTicks(9343), new DateTime(2023, 9, 7, 8, 53, 17, 70, DateTimeKind.Local).AddTicks(9348), "Blue", "System" }
                });

            migrationBuilder.InsertData(
                table: "Makes",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2023, 9, 7, 8, 53, 17, 71, DateTimeKind.Local).AddTicks(9210), new DateTime(2023, 9, 7, 8, 53, 17, 71, DateTimeKind.Local).AddTicks(9217), "Toyota", "System" },
                    { 2, "System", new DateTime(2023, 9, 7, 8, 53, 17, 71, DateTimeKind.Local).AddTicks(9521), new DateTime(2023, 9, 7, 8, 53, 17, 71, DateTimeKind.Local).AddTicks(9524), "Honda", "System" }
                });

            migrationBuilder.InsertData(
                table: "Models",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2023, 9, 7, 8, 53, 17, 72, DateTimeKind.Local).AddTicks(2430), new DateTime(2023, 9, 7, 8, 53, 17, 72, DateTimeKind.Local).AddTicks(2436), "Prius", "System" },
                    { 2, "System", new DateTime(2023, 9, 7, 8, 53, 17, 72, DateTimeKind.Local).AddTicks(2763), new DateTime(2023, 9, 7, 8, 53, 17, 72, DateTimeKind.Local).AddTicks(2767), "Corolla", "System" },
                    { 3, "System", new DateTime(2023, 9, 7, 8, 53, 17, 72, DateTimeKind.Local).AddTicks(2768), new DateTime(2023, 9, 7, 8, 53, 17, 72, DateTimeKind.Local).AddTicks(2769), "Civic", "System" },
                    { 4, "System", new DateTime(2023, 9, 7, 8, 53, 17, 72, DateTimeKind.Local).AddTicks(2770), new DateTime(2023, 9, 7, 8, 53, 17, 72, DateTimeKind.Local).AddTicks(2771), "CRV", "System" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}
