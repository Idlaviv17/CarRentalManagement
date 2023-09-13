using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CarRentalManagement.Server.Data.Migrations
{
    public partial class AddedValidationsToCustomers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "TaxId",
                table: "Customers",
                type: "nvarchar(15)",
                maxLength: 15,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "Customers",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "Customers",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "EmailAddress",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ContactNumber",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5418e8e3-b7a7-48e9-b310-e03c156b31fd",
                column: "ConcurrencyStamp",
                value: "3a513603-f3f8-4b1a-9fcd-8a9a65f377a2");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e1b86601-8938-4216-a8f8-58926cd4f163",
                column: "ConcurrencyStamp",
                value: "9263beb8-d9ff-44f1-878b-8b1813265f48");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "282e3eb4-a2e1-49b3-b4fd-7ce6b8d144ca",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "62214385-6e9b-4910-bce1-8df3482e31e2", "AQAAAAEAACcQAAAAEEARE+7KT6MSDxs50hAQk7O5H3GaDnGULYCy9ZYl1gUolfJb7FbUr/poZwJbsAGwhw==", "9577b267-12a9-40ce-8175-10826d170a4f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ca63949a-9f93-44aa-836c-3e7aa2cafb36",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "43b9026d-d10d-4fe1-8f3f-281a01f72c33", "AQAAAAEAACcQAAAAECGyvbjzcv1mYYliTIP60d8Lm7wd+nZ/6a/BdI3t/78iYqKrg5l+1NZRsjpb/shmkA==", "ffaf2163-847e-4a13-a8d5-8171d65a7bd8" });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 9, 13, 8, 50, 55, 436, DateTimeKind.Local).AddTicks(1060), new DateTime(2023, 9, 13, 8, 50, 55, 436, DateTimeKind.Local).AddTicks(8654) });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 9, 13, 8, 50, 55, 436, DateTimeKind.Local).AddTicks(9510), new DateTime(2023, 9, 13, 8, 50, 55, 436, DateTimeKind.Local).AddTicks(9516) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 9, 13, 8, 50, 55, 437, DateTimeKind.Local).AddTicks(9837), new DateTime(2023, 9, 13, 8, 50, 55, 437, DateTimeKind.Local).AddTicks(9846) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 9, 13, 8, 50, 55, 438, DateTimeKind.Local).AddTicks(147), new DateTime(2023, 9, 13, 8, 50, 55, 438, DateTimeKind.Local).AddTicks(151) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 9, 13, 8, 50, 55, 438, DateTimeKind.Local).AddTicks(3167), new DateTime(2023, 9, 13, 8, 50, 55, 438, DateTimeKind.Local).AddTicks(3173) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 9, 13, 8, 50, 55, 438, DateTimeKind.Local).AddTicks(3540), new DateTime(2023, 9, 13, 8, 50, 55, 438, DateTimeKind.Local).AddTicks(3544) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 9, 13, 8, 50, 55, 438, DateTimeKind.Local).AddTicks(3547), new DateTime(2023, 9, 13, 8, 50, 55, 438, DateTimeKind.Local).AddTicks(3548) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 9, 13, 8, 50, 55, 438, DateTimeKind.Local).AddTicks(3549), new DateTime(2023, 9, 13, 8, 50, 55, 438, DateTimeKind.Local).AddTicks(3550) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "TaxId",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(15)",
                oldMaxLength: 15);

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "EmailAddress",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "ContactNumber",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5418e8e3-b7a7-48e9-b310-e03c156b31fd",
                column: "ConcurrencyStamp",
                value: "32458dae-2a43-498c-bf6b-5a739c49a4f5");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e1b86601-8938-4216-a8f8-58926cd4f163",
                column: "ConcurrencyStamp",
                value: "ca6da507-7757-45c4-94a0-474982ad0afe");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "282e3eb4-a2e1-49b3-b4fd-7ce6b8d144ca",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ba28bdcb-44df-44d3-ba92-fd7d2d5d9075", "AQAAAAEAACcQAAAAEDITZKiIcCcdSHGPU/sB/9elEaUUK9rxQU6QR/AsNww/qYLTkioEHPEgCWIoGLX8KA==", "df254257-ca52-4a5e-8822-c4dc7ce81b2b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ca63949a-9f93-44aa-836c-3e7aa2cafb36",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8fadef97-8de5-481e-ad41-73cfb26e253a", "AQAAAAEAACcQAAAAEBahN0IJWwCpfV49Pa0jXb+2f38LwWs2v/zK7JelzgUxCGBqy9tKi+Y5VKpjYIq2cQ==", "d82c4bb5-1e54-4578-ac2d-d8dbe5bee430" });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 9, 13, 8, 33, 45, 84, DateTimeKind.Local).AddTicks(2091), new DateTime(2023, 9, 13, 8, 33, 45, 84, DateTimeKind.Local).AddTicks(9504) });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 9, 13, 8, 33, 45, 85, DateTimeKind.Local).AddTicks(500), new DateTime(2023, 9, 13, 8, 33, 45, 85, DateTimeKind.Local).AddTicks(506) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 9, 13, 8, 33, 45, 86, DateTimeKind.Local).AddTicks(613), new DateTime(2023, 9, 13, 8, 33, 45, 86, DateTimeKind.Local).AddTicks(622) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 9, 13, 8, 33, 45, 86, DateTimeKind.Local).AddTicks(933), new DateTime(2023, 9, 13, 8, 33, 45, 86, DateTimeKind.Local).AddTicks(936) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 9, 13, 8, 33, 45, 86, DateTimeKind.Local).AddTicks(3995), new DateTime(2023, 9, 13, 8, 33, 45, 86, DateTimeKind.Local).AddTicks(4000) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 9, 13, 8, 33, 45, 86, DateTimeKind.Local).AddTicks(4295), new DateTime(2023, 9, 13, 8, 33, 45, 86, DateTimeKind.Local).AddTicks(4299) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 9, 13, 8, 33, 45, 86, DateTimeKind.Local).AddTicks(4301), new DateTime(2023, 9, 13, 8, 33, 45, 86, DateTimeKind.Local).AddTicks(4302) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 9, 13, 8, 33, 45, 86, DateTimeKind.Local).AddTicks(4303), new DateTime(2023, 9, 13, 8, 33, 45, 86, DateTimeKind.Local).AddTicks(4304) });
        }
    }
}
