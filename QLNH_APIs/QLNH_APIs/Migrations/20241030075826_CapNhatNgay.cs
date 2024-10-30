using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace QLNH_APIs.Migrations
{
    public partial class CapNhatNgay : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
          /*  migrationBuilder.AlterColumn<string>(
                name: "Updated",
                table: "User",
                type: "NVARCHAR2(2000)",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP(7)");

            migrationBuilder.AlterColumn<string>(
                name: "Created",
                table: "User",
                type: "NVARCHAR2(2000)",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP(7)");*/
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
         /*   migrationBuilder.AlterColumn<DateTime>(
                name: "Updated",
                table: "User",
                type: "TIMESTAMP(7)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "NVARCHAR2(2000)");

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "User",
                type: "TIMESTAMP(7)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "NVARCHAR2(2000)");*/
        }
    }
}
