using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace eShopSolution.Data.Migrations
{
    public partial class ChangeFileLengthType : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
        }
    }
}
