using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DBApi.Migrations
{
    public partial class AddStatusAmdEndTime : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "EndTime",
                schema: "dbo",
                table: "Cars",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Status",
                schema: "dbo",
                table: "Cars",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EndTime",
                schema: "dbo",
                table: "Cars");

            migrationBuilder.DropColumn(
                name: "Status",
                schema: "dbo",
                table: "Cars");
        }
    }
}
