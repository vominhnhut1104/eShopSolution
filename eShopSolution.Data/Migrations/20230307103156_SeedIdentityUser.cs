using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace eShopSolution.Data.Migrations
{
    public partial class SeedIdentityUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDate",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 3, 7, 17, 31, 56, 96, DateTimeKind.Local).AddTicks(4957),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 3, 7, 17, 18, 39, 387, DateTimeKind.Local).AddTicks(9352));

            migrationBuilder.InsertData(
                table: "AppRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Description", "Name", "NormalizedName" },
                values: new object[] { new Guid("d3d8efd1-71a9-4b72-abe0-85a58d580cd6"), "2ddf9955-6032-49f4-a49a-2d6180686099", "Administrator role", "admin", "admin" });

            migrationBuilder.InsertData(
                table: "AppUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { new Guid("d3d8efd1-71a9-4b72-abe0-85a58d580cd6"), new Guid("695c4c59-41a0-40e0-8c39-66526cd4462e") });

            migrationBuilder.InsertData(
                table: "AppUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Dob", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("695c4c59-41a0-40e0-8c39-66526cd4462e"), 0, "0f5a77de-ca1c-4de3-8178-dd501460f173", new DateTime(2001, 11, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "vominhnhut1104@gmail.com", true, "Nhut", "Minh", false, null, "vominhnhut1104@gmail.com", "admin", "AQAAAAEAACcQAAAAEAW22uRIDn3jZcDtVIE0NKOPkpLMJiaqHEjdqAkhQXhjk8JSXbzaR4ghVWqQrHkF8g==", null, false, "", false, "admin" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2023, 3, 7, 17, 31, 56, 98, DateTimeKind.Local).AddTicks(2732));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("d3d8efd1-71a9-4b72-abe0-85a58d580cd6"));

            migrationBuilder.DeleteData(
                table: "AppUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("d3d8efd1-71a9-4b72-abe0-85a58d580cd6"), new Guid("695c4c59-41a0-40e0-8c39-66526cd4462e") });

            migrationBuilder.DeleteData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("695c4c59-41a0-40e0-8c39-66526cd4462e"));

            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDate",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 3, 7, 17, 18, 39, 387, DateTimeKind.Local).AddTicks(9352),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 3, 7, 17, 31, 56, 96, DateTimeKind.Local).AddTicks(4957));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2023, 3, 7, 17, 18, 39, 389, DateTimeKind.Local).AddTicks(5855));
        }
    }
}
