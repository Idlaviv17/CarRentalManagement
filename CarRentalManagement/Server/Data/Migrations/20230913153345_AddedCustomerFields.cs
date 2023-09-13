using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CarRentalManagement.Server.Data.Migrations
{
    public partial class AddedCustomerFields : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: true);

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "Customers");

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
    }
}
