using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CarRentalManagement.Server.Data.Migrations
{
    public partial class MadeDateInNull : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "DateIn",
                table: "Bookings",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5418e8e3-b7a7-48e9-b310-e03c156b31fd",
                column: "ConcurrencyStamp",
                value: "fd2855ed-650e-4473-a8b0-1d16f5af3020");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e1b86601-8938-4216-a8f8-58926cd4f163",
                column: "ConcurrencyStamp",
                value: "94d0d6b5-7737-4933-8530-bf01e1a24f55");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "282e3eb4-a2e1-49b3-b4fd-7ce6b8d144ca",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1dedd991-e377-49d6-9015-1548365beb27", "AQAAAAEAACcQAAAAECZ3E+ebmIAzuk+VD1Agj62XfZJcl6oD0zfHj7dOhtScdbRMH263eznBCVEa+C5kPw==", "94d1206f-2077-422b-bfde-4cd825d5e113" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ca63949a-9f93-44aa-836c-3e7aa2cafb36",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ff939fc1-cf35-4c58-95f1-d6a808dea272", "AQAAAAEAACcQAAAAEBj7jfydr16roOjVhu516zeh8c8emTYWunHpeYYRku2jVgq/eutBbkmRxmwdg6dLug==", "3c53242e-1733-4b23-a720-9cf61964777c" });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 9, 12, 11, 36, 53, 662, DateTimeKind.Local).AddTicks(7930), new DateTime(2023, 9, 12, 11, 36, 53, 663, DateTimeKind.Local).AddTicks(5588) });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 9, 12, 11, 36, 53, 663, DateTimeKind.Local).AddTicks(6427), new DateTime(2023, 9, 12, 11, 36, 53, 663, DateTimeKind.Local).AddTicks(6433) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 9, 12, 11, 36, 53, 664, DateTimeKind.Local).AddTicks(6210), new DateTime(2023, 9, 12, 11, 36, 53, 664, DateTimeKind.Local).AddTicks(6218) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 9, 12, 11, 36, 53, 664, DateTimeKind.Local).AddTicks(6522), new DateTime(2023, 9, 12, 11, 36, 53, 664, DateTimeKind.Local).AddTicks(6526) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 9, 12, 11, 36, 53, 664, DateTimeKind.Local).AddTicks(9378), new DateTime(2023, 9, 12, 11, 36, 53, 664, DateTimeKind.Local).AddTicks(9384) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 9, 12, 11, 36, 53, 664, DateTimeKind.Local).AddTicks(9676), new DateTime(2023, 9, 12, 11, 36, 53, 664, DateTimeKind.Local).AddTicks(9680) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 9, 12, 11, 36, 53, 664, DateTimeKind.Local).AddTicks(9681), new DateTime(2023, 9, 12, 11, 36, 53, 664, DateTimeKind.Local).AddTicks(9682) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 9, 12, 11, 36, 53, 664, DateTimeKind.Local).AddTicks(9684), new DateTime(2023, 9, 12, 11, 36, 53, 664, DateTimeKind.Local).AddTicks(9685) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "DateIn",
                table: "Bookings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

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

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "282e3eb4-a2e1-49b3-b4fd-7ce6b8d144ca",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "577f51ce-214a-47b6-a334-eba22bff8fb7", "AQAAAAEAACcQAAAAELPjQlRIhdpUmx0N4kNNokOFBar1Qz0pW0XluS9yi+PHX6MyRPJ9WatgUI/myxfCsg==", "a647e1f4-332a-4350-9aed-3532e665fb64" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ca63949a-9f93-44aa-836c-3e7aa2cafb36",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d123113e-cbbf-4358-a615-bb7b100f7c50", "AQAAAAEAACcQAAAAEBds58KG+Gpoq3iLHtIvBcfE2x+0y2oXbSHIbjRiZFTJrwNtIRHJzxyr2Ce7vNdlMA==", "27ee5659-aca7-4da5-840c-bc8c874e49d7" });

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
        }
    }
}
