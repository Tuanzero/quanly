using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace QLNH_APIs.Migrations
{
    public partial class CapNhat1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Xoa",
                table: "VaiTro");

            migrationBuilder.DropColumn(
                name: "Xoa",
                table: "User");

            migrationBuilder.DropColumn(
                name: "Xoa",
                table: "TrangThai");

            migrationBuilder.DropColumn(
                name: "Vohieu",
                table: "OrderItem");

            migrationBuilder.DropColumn(
                name: "Xoa",
                table: "OrderItem");

            migrationBuilder.DropColumn(
                name: "Vohieu",
                table: "Order");

            migrationBuilder.DropColumn(
                name: "Xoa",
                table: "Order");

            migrationBuilder.DropColumn(
                name: "Xoa",
                table: "LoaiMonan");

            migrationBuilder.DropColumn(
                name: "Xoa",
                table: "Loaidonvi");

            migrationBuilder.DropColumn(
                name: "Xoa",
                table: "KhachHang");

            migrationBuilder.DropColumn(
                name: "Xoa",
                table: "Item");

            migrationBuilder.DropColumn(
                name: "Xoa",
                table: "HinhMonan");

            migrationBuilder.DropColumn(
                name: "Xoa",
                table: "Donvi");

            migrationBuilder.DropColumn(
                name: "Xoa",
                table: "Ban");

            migrationBuilder.CreateTable(
                name: "NhaHang",
                columns: table => new
                {
                    NhaHangId = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    NgayTao = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    NgayCapNhat = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    Sodienthoai = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    Diachi = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NhaHang", x => x.NhaHangId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "NhaHang");

            migrationBuilder.AddColumn<bool>(
                name: "Xoa",
                table: "VaiTro",
                type: "NUMBER(1)",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Xoa",
                table: "User",
                type: "NUMBER(1)",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Xoa",
                table: "TrangThai",
                type: "NUMBER(1)",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Vohieu",
                table: "OrderItem",
                type: "NUMBER(1)",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Xoa",
                table: "OrderItem",
                type: "NUMBER(1)",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Vohieu",
                table: "Order",
                type: "NUMBER(1)",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Xoa",
                table: "Order",
                type: "NUMBER(1)",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Xoa",
                table: "LoaiMonan",
                type: "NUMBER(1)",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Xoa",
                table: "Loaidonvi",
                type: "NUMBER(1)",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Xoa",
                table: "KhachHang",
                type: "NUMBER(1)",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Xoa",
                table: "Item",
                type: "NUMBER(1)",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Xoa",
                table: "HinhMonan",
                type: "NUMBER(1)",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Xoa",
                table: "Donvi",
                type: "NUMBER(1)",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Xoa",
                table: "Ban",
                type: "NUMBER(1)",
                nullable: false,
                defaultValue: false);
        }
    }
}
