using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CarRentalManagement.Server.Data.Migrations
{
    public partial class AddDefaultUsers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "FistName",
                table: "AspNetUsers",
                newName: "FirstName");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5418e8e3-b7a7-48e9-b310-e03c156b31fd",
                column: "ConcurrencyStamp",
                value: "452da3d5-ef36-4d19-bc9b-762886443341");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e1b86601-8938-4216-a8f8-58926cd4f163",
                column: "ConcurrencyStamp",
                value: "3c4189a4-47a4-4c09-9398-fa82fb08446a");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "282e3eb4-a2e1-49b3-b4fd-7ce6b8d144ca", 0, "577f51ce-214a-47b6-a334-eba22bff8fb7", "admin@localhost.com", false, "System", "Admin", false, null, "ADMIN@LOCALHOST.COM", "ADMIN@LOCALHOST.COM", "AQAAAAEAACcQAAAAELPjQlRIhdpUmx0N4kNNokOFBar1Qz0pW0XluS9yi+PHX6MyRPJ9WatgUI/myxfCsg==", null, false, "a647e1f4-332a-4350-9aed-3532e665fb64", false, "admin@localhost.com" },
                    { "ca63949a-9f93-44aa-836c-3e7aa2cafb36", 0, "d123113e-cbbf-4358-a615-bb7b100f7c50", "user@localhost.com", false, "System", "User", false, null, "USER@LOCALHOST.COM", "USER@LOCALHOST.COM", "AQAAAAEAACcQAAAAEBds58KG+Gpoq3iLHtIvBcfE2x+0y2oXbSHIbjRiZFTJrwNtIRHJzxyr2Ce7vNdlMA==", null, false, "27ee5659-aca7-4da5-840c-bc8c874e49d7", false, "user@localhost.com" }
                });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 9, 7, 9, 29, 47, 646, DateTimeKind.Local).AddTicks(9823), new DateTime(2023, 9, 7, 9, 29, 47, 648, DateTimeKind.Local).AddTicks(1654) });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 9, 7, 9, 29, 47, 648, DateTimeKind.Local).AddTicks(2546), new DateTime(2023, 9, 7, 9, 29, 47, 648, DateTimeKind.Local).AddTicks(2550) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 9, 7, 9, 29, 47, 649, DateTimeKind.Local).AddTicks(3052), new DateTime(2023, 9, 7, 9, 29, 47, 649, DateTimeKind.Local).AddTicks(3059) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 9, 7, 9, 29, 47, 649, DateTimeKind.Local).AddTicks(3371), new DateTime(2023, 9, 7, 9, 29, 47, 649, DateTimeKind.Local).AddTicks(3374) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 9, 7, 9, 29, 47, 649, DateTimeKind.Local).AddTicks(6466), new DateTime(2023, 9, 7, 9, 29, 47, 649, DateTimeKind.Local).AddTicks(6470) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 9, 7, 9, 29, 47, 649, DateTimeKind.Local).AddTicks(6850), new DateTime(2023, 9, 7, 9, 29, 47, 649, DateTimeKind.Local).AddTicks(6854) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 9, 7, 9, 29, 47, 649, DateTimeKind.Local).AddTicks(6855), new DateTime(2023, 9, 7, 9, 29, 47, 649, DateTimeKind.Local).AddTicks(6856) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 9, 7, 9, 29, 47, 649, DateTimeKind.Local).AddTicks(6857), new DateTime(2023, 9, 7, 9, 29, 47, 649, DateTimeKind.Local).AddTicks(6858) });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "5418e8e3-b7a7-48e9-b310-e03c156b31fd", "282e3eb4-a2e1-49b3-b4fd-7ce6b8d144ca" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "e1b86601-8938-4216-a8f8-58926cd4f163", "ca63949a-9f93-44aa-836c-3e7aa2cafb36" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "5418e8e3-b7a7-48e9-b310-e03c156b31fd", "282e3eb4-a2e1-49b3-b4fd-7ce6b8d144ca" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "e1b86601-8938-4216-a8f8-58926cd4f163", "ca63949a-9f93-44aa-836c-3e7aa2cafb36" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "282e3eb4-a2e1-49b3-b4fd-7ce6b8d144ca");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ca63949a-9f93-44aa-836c-3e7aa2cafb36");

            migrationBuilder.RenameColumn(
                name: "FirstName",
                table: "AspNetUsers",
                newName: "FistName");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5418e8e3-b7a7-48e9-b310-e03c156b31fd",
                column: "ConcurrencyStamp",
                value: "7a55f3ed-bdd7-416e-8352-a18277361736");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e1b86601-8938-4216-a8f8-58926cd4f163",
                column: "ConcurrencyStamp",
                value: "3da78fec-fd2e-448a-bbe4-45a40173dd9b");

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
    }
}
