using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace eShopSolution.Data.Migrations
{
    public partial class CustomerDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CustomerId",
                table: "Orders",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Customer",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Gender = table.Column<bool>(type: "bit", nullable: false),
                    Phonenumber = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Bank = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customer", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("d3d8efd1-71a9-4b72-abe0-85a58d580cd6"),
                column: "ConcurrencyStamp",
                value: "74612aa2-dd33-483e-bcb5-eb27bb2f90aa");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("695c4c59-41a0-40e0-8c39-66526cd4462e"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "f6dd8ae7-edbb-47ce-9a1e-a13f39e70349", "AQAAAAEAACcQAAAAEHDnndsnRbd5ytIYZXqi7vijUz036QrYxs5vfdjhBu7lnNa3KDHEj9Y7sTZJ+jLxrg==" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2023, 3, 28, 18, 16, 24, 717, DateTimeKind.Local).AddTicks(8722));

            migrationBuilder.CreateIndex(
                name: "IX_Orders_CustomerId",
                table: "Orders",
                column: "CustomerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Customer_CustomerId",
                table: "Orders",
                column: "CustomerId",
                principalTable: "Customer",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Customer_CustomerId",
                table: "Orders");

            migrationBuilder.DropTable(
                name: "Customer");

            migrationBuilder.DropIndex(
                name: "IX_Orders_CustomerId",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "CustomerId",
                table: "Orders");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("d3d8efd1-71a9-4b72-abe0-85a58d580cd6"),
                column: "ConcurrencyStamp",
                value: "55f101f1-b4c9-4dd7-b256-043ff804da70");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("695c4c59-41a0-40e0-8c39-66526cd4462e"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "1aaebece-b022-4ce8-8418-fce7f5848b0b", "AQAAAAEAACcQAAAAEF7mVS47RhuH6/kvGVcE0a4aZ+0FV+JBCkrjU8tT0HE1SOFwKydEgtybQnrL80uU4g==" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2023, 3, 9, 15, 16, 18, 577, DateTimeKind.Local).AddTicks(7872));
        }
    }
}
