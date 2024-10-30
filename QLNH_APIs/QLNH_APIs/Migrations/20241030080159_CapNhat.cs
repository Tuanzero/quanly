using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace QLNH_APIs.Migrations
{
    public partial class CapNhat : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {

            migrationBuilder.AlterColumn<string>(
                name: "NgayTao",
                table: "Ban",
                type: "NVARCHAR2(2000)",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP(7)");

            migrationBuilder.AlterColumn<string>(
                name: "NgayCapNhat",
                table: "Ban",
                type: "NVARCHAR2(2000)",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP(7)");

            migrationBuilder.AlterColumn<string>(
                name: "NgayTao",
                table: "Donvi",
                type: "NVARCHAR2(2000)",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP(7)");

            migrationBuilder.AlterColumn<string>(
                name: "NgayCapNhat",
                table: "Donvi",
                type: "NVARCHAR2(2000)",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP(7)");

            migrationBuilder.AlterColumn<string>(
                name: "NgayTao",
                table: "HinhMonan",
                type: "NVARCHAR2(2000)",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP(7)");

            migrationBuilder.AlterColumn<string>(
                name: "NgayCapNhat",
                table: "HinhMonan",
                type: "NVARCHAR2(2000)",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP(7)");

            migrationBuilder.AlterColumn<string>(
                name: "NgayTao",
                table: "Item",
                type: "NVARCHAR2(2000)",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP(7)");

            migrationBuilder.AlterColumn<string>(
                name: "NgayCapNhat",
                table: "Item",
                type: "NVARCHAR2(2000)",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP(7)");

            migrationBuilder.AlterColumn<string>(
                name: "NgayTao",
                table: "KhachHang",
                type: "NVARCHAR2(2000)",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP(7)");

            migrationBuilder.AlterColumn<string>(
                name: "NgayCapNhat",
                table: "KhachHang",
                type: "NVARCHAR2(2000)",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP(7)");

            migrationBuilder.AlterColumn<string>(
                name: "NgayTao",
                table: "Loaidonvi",
                type: "NVARCHAR2(2000)",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP(7)");

            migrationBuilder.AlterColumn<string>(
                name: "NgayCapNhat",
                table: "Loaidonvi",
                type: "NVARCHAR2(2000)",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP(7)");

            migrationBuilder.AlterColumn<string>(
                name: "NgayTao",
                table: "LoaiMonan",
                type: "NVARCHAR2(2000)",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP(7)");

            migrationBuilder.AlterColumn<string>(
                name: "NgayCapNhat",
                table: "LoaiMonan",
                type: "NVARCHAR2(2000)",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP(7)");

            migrationBuilder.AlterColumn<string>(
                name: "NgayTao",
                table: "Order",
                type: "NVARCHAR2(2000)",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP(7)");

            migrationBuilder.AlterColumn<string>(
                name: "NgayCapNhat",
                table: "Order",
                type: "NVARCHAR2(2000)",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP(7)");

            migrationBuilder.AlterColumn<string>(
                name: "NgayTao",
                table: "OrderItem",
                type: "NVARCHAR2(2000)",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP(7)");

            migrationBuilder.AlterColumn<string>(
                name: "NgayCapNhat",
                table: "OrderItem",
                type: "NVARCHAR2(2000)",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP(7)");

            migrationBuilder.AlterColumn<string>(
                name: "NgayTao",
                table: "TrangThai",
                type: "NVARCHAR2(2000)",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP(7)");

            migrationBuilder.AlterColumn<string>(
                name: "NgayCapNhat",
                table: "TrangThai",
                type: "NVARCHAR2(2000)",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP(7)");

            migrationBuilder.AlterColumn<string>(
                name: "NgayTao",
                table: "VaiTro",
                type: "NVARCHAR2(2000)",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP(7)");

            migrationBuilder.AlterColumn<string>(
                name: "NgayCapNhat",
                table: "VaiTro",
                type: "NVARCHAR2(2000)",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP(7)");

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "NgayTao",
                table: "User",
                newName: "Updated");

            migrationBuilder.RenameColumn(
                name: "NgayCapNhat",
                table: "User",
                newName: "Created");
        }
    }
}
