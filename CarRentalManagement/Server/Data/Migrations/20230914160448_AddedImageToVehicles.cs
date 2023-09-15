using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CarRentalManagement.Server.Data.Migrations
{
    public partial class AddedImageToVehicles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ImageName",
                table: "Vehicles",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5418e8e3-b7a7-48e9-b310-e03c156b31fd",
                column: "ConcurrencyStamp",
                value: "bb4a9035-5616-47c0-80f4-73a04a545c65");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e1b86601-8938-4216-a8f8-58926cd4f163",
                column: "ConcurrencyStamp",
                value: "f3f23d68-9449-424f-b762-6b0f3abc7784");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "282e3eb4-a2e1-49b3-b4fd-7ce6b8d144ca",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f21f81e2-3b42-4524-815f-9f1313150696", "AQAAAAEAACcQAAAAEJrKwRy2QIQrWP4a2Z8vFGobw4yv6dhi9UaoYf172IWMJ0+EVte9GBpsY6FL2PcPtg==", "34996800-8069-47cc-910d-05e42427bfc3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ca63949a-9f93-44aa-836c-3e7aa2cafb36",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "308bdc2c-00a1-4639-acee-861b2328ea46", "AQAAAAEAACcQAAAAEAECmHZPzgeZEuWEWPdLYTTqy3J+iwZ+FCst1HQY19LjWG+hIDVM346udW/KzkIVvA==", "448ed7ed-7c90-4150-a540-b893208a016c" });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 9, 14, 9, 4, 47, 896, DateTimeKind.Local).AddTicks(302), new DateTime(2023, 9, 14, 9, 4, 47, 896, DateTimeKind.Local).AddTicks(8288) });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 9, 14, 9, 4, 47, 896, DateTimeKind.Local).AddTicks(9169), new DateTime(2023, 9, 14, 9, 4, 47, 896, DateTimeKind.Local).AddTicks(9175) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 9, 14, 9, 4, 47, 897, DateTimeKind.Local).AddTicks(9503), new DateTime(2023, 9, 14, 9, 4, 47, 897, DateTimeKind.Local).AddTicks(9511) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 9, 14, 9, 4, 47, 897, DateTimeKind.Local).AddTicks(9814), new DateTime(2023, 9, 14, 9, 4, 47, 897, DateTimeKind.Local).AddTicks(9818) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 9, 14, 9, 4, 47, 898, DateTimeKind.Local).AddTicks(2785), new DateTime(2023, 9, 14, 9, 4, 47, 898, DateTimeKind.Local).AddTicks(2790) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 9, 14, 9, 4, 47, 898, DateTimeKind.Local).AddTicks(3086), new DateTime(2023, 9, 14, 9, 4, 47, 898, DateTimeKind.Local).AddTicks(3090) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 9, 14, 9, 4, 47, 898, DateTimeKind.Local).AddTicks(3092), new DateTime(2023, 9, 14, 9, 4, 47, 898, DateTimeKind.Local).AddTicks(3093) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 9, 14, 9, 4, 47, 898, DateTimeKind.Local).AddTicks(3095), new DateTime(2023, 9, 14, 9, 4, 47, 898, DateTimeKind.Local).AddTicks(3096) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImageName",
                table: "Vehicles");

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
    }
}
