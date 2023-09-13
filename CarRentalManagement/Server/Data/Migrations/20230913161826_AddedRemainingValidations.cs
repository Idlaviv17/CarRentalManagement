using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CarRentalManagement.Server.Data.Migrations
{
    public partial class AddedRemainingValidations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Vin",
                table: "Vehicles",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "LicensePlateNumber",
                table: "Vehicles",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Models",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Makes",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Colours",
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
                value: "58337386-9959-4b50-8edb-20a66edf55be");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e1b86601-8938-4216-a8f8-58926cd4f163",
                column: "ConcurrencyStamp",
                value: "607e5cbd-037b-4092-b94d-90d9074c214d");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "282e3eb4-a2e1-49b3-b4fd-7ce6b8d144ca",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bf41de65-a00b-41f5-bfcb-fcec5b96ca45", "AQAAAAEAACcQAAAAEI06SP1VfIZadKMBrZsGAKYQsqUhsOqeKC1SFJ20rDywgHTIHFpZh85yvRS0zcGKWA==", "f6828740-9cd7-44c8-b798-ae5f6ecc0671" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ca63949a-9f93-44aa-836c-3e7aa2cafb36",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "11c1c68d-18ff-4bfc-8a6e-3a5a89e3989a", "AQAAAAEAACcQAAAAELBeVci4qQ3ZA+QG9HbGJH4BrBscZosH3vE2tjBbxHq52OnqIJ4lmMG5m2aIOwq7kg==", "2b956151-a8d1-43cf-aeeb-a07a6d8b8ee5" });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 9, 13, 9, 18, 26, 200, DateTimeKind.Local).AddTicks(9900), new DateTime(2023, 9, 13, 9, 18, 26, 201, DateTimeKind.Local).AddTicks(7175) });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 9, 13, 9, 18, 26, 201, DateTimeKind.Local).AddTicks(8002), new DateTime(2023, 9, 13, 9, 18, 26, 201, DateTimeKind.Local).AddTicks(8007) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 9, 13, 9, 18, 26, 202, DateTimeKind.Local).AddTicks(7529), new DateTime(2023, 9, 13, 9, 18, 26, 202, DateTimeKind.Local).AddTicks(7536) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 9, 13, 9, 18, 26, 202, DateTimeKind.Local).AddTicks(7834), new DateTime(2023, 9, 13, 9, 18, 26, 202, DateTimeKind.Local).AddTicks(7838) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 9, 13, 9, 18, 26, 203, DateTimeKind.Local).AddTicks(833), new DateTime(2023, 9, 13, 9, 18, 26, 203, DateTimeKind.Local).AddTicks(840) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 9, 13, 9, 18, 26, 203, DateTimeKind.Local).AddTicks(1128), new DateTime(2023, 9, 13, 9, 18, 26, 203, DateTimeKind.Local).AddTicks(1132) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 9, 13, 9, 18, 26, 203, DateTimeKind.Local).AddTicks(1133), new DateTime(2023, 9, 13, 9, 18, 26, 203, DateTimeKind.Local).AddTicks(1134) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 9, 13, 9, 18, 26, 203, DateTimeKind.Local).AddTicks(1136), new DateTime(2023, 9, 13, 9, 18, 26, 203, DateTimeKind.Local).AddTicks(1136) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Vin",
                table: "Vehicles",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "LicensePlateNumber",
                table: "Vehicles",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Models",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Makes",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Colours",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

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
    }
}
