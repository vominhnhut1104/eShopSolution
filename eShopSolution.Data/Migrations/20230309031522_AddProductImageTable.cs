using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace eShopSolution.Data.Migrations
{
    public partial class AddProductImageTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDate",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 3, 7, 17, 31, 56, 96, DateTimeKind.Local).AddTicks(4957));

            migrationBuilder.CreateTable(
                name: "ProductImages",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    ImagePath = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Caption = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    IsDefault = table.Column<bool>(type: "bit", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SortOrder = table.Column<int>(type: "int", nullable: false),
                    FileSize = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductImages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductImages_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("d3d8efd1-71a9-4b72-abe0-85a58d580cd6"),
                column: "ConcurrencyStamp",
                value: "518b44dd-ad03-454d-a499-03d45bdb98af");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("695c4c59-41a0-40e0-8c39-66526cd4462e"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "bd6e4da3-b9ed-450a-bceb-59a8fde933a0", "AQAAAAEAACcQAAAAEJZDSmywWp1xnDjFq7eev+Ab9yTqd6QHfF95b3iqZbZhKe5xsAI/TGR5thHd6y1PFA==" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2023, 3, 9, 10, 15, 21, 426, DateTimeKind.Local).AddTicks(6735));

            migrationBuilder.CreateIndex(
                name: "IX_ProductImages_ProductId",
                table: "ProductImages",
                column: "ProductId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProductImages");

            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDate",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 3, 7, 17, 31, 56, 96, DateTimeKind.Local).AddTicks(4957),
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("d3d8efd1-71a9-4b72-abe0-85a58d580cd6"),
                column: "ConcurrencyStamp",
                value: "2ddf9955-6032-49f4-a49a-2d6180686099");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("695c4c59-41a0-40e0-8c39-66526cd4462e"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "0f5a77de-ca1c-4de3-8178-dd501460f173", "AQAAAAEAACcQAAAAEAW22uRIDn3jZcDtVIE0NKOPkpLMJiaqHEjdqAkhQXhjk8JSXbzaR4ghVWqQrHkF8g==" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2023, 3, 7, 17, 31, 56, 98, DateTimeKind.Local).AddTicks(2732));
        }
    }
}
