using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace QLNH_APIs.Migrations
{
    public partial class Model : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
           /* migrationBuilder.AddColumn<DateTime>(
                name: "Created",
                table: "User",
                type: "TIMESTAMP(7)",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<bool>(
                name: "OffDuty",
                table: "User",
                type: "NUMBER(1)",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "Updated",
                table: "User",
                type: "TIMESTAMP(7)",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "VaitroId",
                table: "User",
                type: "NUMBER(10)",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "Xoa",
                table: "User",
                type: "NUMBER(1)",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "NgayCapNhat",
                table: "LoaiMonan",
                type: "TIMESTAMP(7)",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "NgayTao",
                table: "LoaiMonan",
                type: "TIMESTAMP(7)",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<bool>(
                name: "Xoa",
                table: "LoaiMonan",
                type: "NUMBER(1)",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "parentId",
                table: "LoaiMonan",
                type: "NUMBER(10)",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "DonviId",
                table: "Item",
                type: "NUMBER(10)",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<double>(
                name: "Gia",
                table: "Item",
                type: "BINARY_DOUBLE",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "Giamgia",
                table: "Item",
                type: "BINARY_DOUBLE",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<int>(
                name: "LoaiMonanId",
                table: "Item",
                type: "NUMBER(10)",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "NgayCapNhat",
                table: "Item",
                type: "TIMESTAMP(7)",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "NgayTao",
                table: "Item",
                type: "TIMESTAMP(7)",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<bool>(
                name: "Xoa",
                table: "Item",
                type: "NUMBER(1)",
                nullable: false,
                defaultValue: false);

            migrationBuilder.CreateTable(
                name: "HinhMonan",
                columns: table => new
                {
                    Id = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    Ten = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    Data = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    Mota = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    NgayTao = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: false),
                    NgayCapNhat = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: false),
                    Xoa = table.Column<bool>(type: "NUMBER(1)", nullable: false),
                    ItemModelId = table.Column<int>(type: "NUMBER(10)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HinhMonan", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HinhMonan_Item_ItemModelId",
                        column: x => x.ItemModelId,
                        principalTable: "Item",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "KhachHang",
                columns: table => new
                {
                    Id = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    Tenkhachhang = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    Sodienthoai = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    NgayTao = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: false),
                    NgayCapNhat = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: false),
                    Xoa = table.Column<bool>(type: "NUMBER(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KhachHang", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Loaidonvi",
                columns: table => new
                {
                    Id = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    Tenloai = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    Mota = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    NgayTao = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: false),
                    NgayCapNhat = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: false),
                    Xoa = table.Column<bool>(type: "NUMBER(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Loaidonvi", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Order",
                columns: table => new
                {
                    Id = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    Sodonhang = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    Mota = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    NgayTao = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: false),
                    NgayCapNhat = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: false),
                    Xoa = table.Column<bool>(type: "NUMBER(1)", nullable: false),
                    Vohieu = table.Column<bool>(type: "NUMBER(1)", nullable: false),
                    Tonggia = table.Column<double>(type: "BINARY_DOUBLE", nullable: false),
                    Tienthanhtoan = table.Column<double>(type: "BINARY_DOUBLE", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Order", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TrangThai",
                columns: table => new
                {
                    Id = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    TenTrangThai = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    Mota = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    NgayTao = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: false),
                    NgayCapNhat = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: false),
                    Xoa = table.Column<bool>(type: "NUMBER(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TrangThai", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "VaiTro",
                columns: table => new
                {
                    Id = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    Tenvaitro = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    Mota = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    NgayTao = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: false),
                    NgayCapNhat = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: false),
                    Xoa = table.Column<bool>(type: "NUMBER(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VaiTro", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Donvi",
                columns: table => new
                {
                    Id = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    TenDonvi = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    Mota = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    NgayTao = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: false),
                    NgayCapNhat = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: false),
                    Xoa = table.Column<bool>(type: "NUMBER(1)", nullable: false),
                    LoaidonviId = table.Column<int>(type: "NUMBER(10)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Donvi", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Donvi_Loaidonvi_LoaidonviId",
                        column: x => x.LoaidonviId,
                        principalTable: "Loaidonvi",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OrderItem",
                columns: table => new
                {
                    Id = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    Ten = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    Mota = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    NgayTao = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: false),
                    NgayCapNhat = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: false),
                    Xoa = table.Column<bool>(type: "NUMBER(1)", nullable: false),
                    Vohieu = table.Column<bool>(type: "NUMBER(1)", nullable: false),
                    Giaban = table.Column<double>(type: "BINARY_DOUBLE", nullable: false),
                    ItemId = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    OrderModelId = table.Column<int>(type: "NUMBER(10)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderItem", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OrderItem_Item_ItemId",
                        column: x => x.ItemId,
                        principalTable: "Item",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderItem_Order_OrderModelId",
                        column: x => x.OrderModelId,
                        principalTable: "Order",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Ban",
                columns: table => new
                {
                    Id = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    NgayTao = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: false),
                    NgayCapNhat = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: false),
                    Xoa = table.Column<bool>(type: "NUMBER(1)", nullable: false),
                    TrangthaiId = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    KhachhangId = table.Column<int>(type: "NUMBER(10)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ban", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Ban_KhachHang_KhachhangId",
                        column: x => x.KhachhangId,
                        principalTable: "KhachHang",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Ban_TrangThai_TrangthaiId",
                        column: x => x.TrangthaiId,
                        principalTable: "TrangThai",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_User_VaitroId",
                table: "User",
                column: "VaitroId");

            migrationBuilder.CreateIndex(
                name: "IX_Item_DonviId",
                table: "Item",
                column: "DonviId");

            migrationBuilder.CreateIndex(
                name: "IX_Item_LoaiMonanId",
                table: "Item",
                column: "LoaiMonanId");

            migrationBuilder.CreateIndex(
                name: "IX_Ban_KhachhangId",
                table: "Ban",
                column: "KhachhangId");

            migrationBuilder.CreateIndex(
                name: "IX_Ban_TrangthaiId",
                table: "Ban",
                column: "TrangthaiId");

            migrationBuilder.CreateIndex(
                name: "IX_Donvi_LoaidonviId",
                table: "Donvi",
                column: "LoaidonviId");

            migrationBuilder.CreateIndex(
                name: "IX_HinhMonan_ItemModelId",
                table: "HinhMonan",
                column: "ItemModelId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderItem_ItemId",
                table: "OrderItem",
                column: "ItemId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderItem_OrderModelId",
                table: "OrderItem",
                column: "OrderModelId");

            migrationBuilder.AddForeignKey(
                name: "FK_Item_Donvi_DonviId",
                table: "Item",
                column: "DonviId",
                principalTable: "Donvi",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Item_LoaiMonan_LoaiMonanId",
                table: "Item",
                column: "LoaiMonanId",
                principalTable: "LoaiMonan",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_User_VaiTro_VaitroId",
                table: "User",
                column: "VaitroId",
                principalTable: "VaiTro",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);*/
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
           /* migrationBuilder.DropForeignKey(
                name: "FK_Item_Donvi_DonviId",
                table: "Item");

            migrationBuilder.DropForeignKey(
                name: "FK_Item_LoaiMonan_LoaiMonanId",
                table: "Item");

            migrationBuilder.DropForeignKey(
                name: "FK_User_VaiTro_VaitroId",
                table: "User");

            migrationBuilder.DropTable(
                name: "Ban");

            migrationBuilder.DropTable(
                name: "Donvi");

            migrationBuilder.DropTable(
                name: "HinhMonan");

            migrationBuilder.DropTable(
                name: "OrderItem");

            migrationBuilder.DropTable(
                name: "VaiTro");

            migrationBuilder.DropTable(
                name: "KhachHang");

            migrationBuilder.DropTable(
                name: "TrangThai");

            migrationBuilder.DropTable(
                name: "Loaidonvi");

            migrationBuilder.DropTable(
                name: "Order");

            migrationBuilder.DropIndex(
                name: "IX_User_VaitroId",
                table: "User");

            migrationBuilder.DropIndex(
                name: "IX_Item_DonviId",
                table: "Item");

            migrationBuilder.DropIndex(
                name: "IX_Item_LoaiMonanId",
                table: "Item");

            migrationBuilder.DropColumn(
                name: "Created",
                table: "User");

            migrationBuilder.DropColumn(
                name: "OffDuty",
                table: "User");

            migrationBuilder.DropColumn(
                name: "Updated",
                table: "User");

            migrationBuilder.DropColumn(
                name: "VaitroId",
                table: "User");

            migrationBuilder.DropColumn(
                name: "Xoa",
                table: "User");

            migrationBuilder.DropColumn(
                name: "NgayCapNhat",
                table: "LoaiMonan");

            migrationBuilder.DropColumn(
                name: "NgayTao",
                table: "LoaiMonan");

            migrationBuilder.DropColumn(
                name: "Xoa",
                table: "LoaiMonan");

            migrationBuilder.DropColumn(
                name: "parentId",
                table: "LoaiMonan");

            migrationBuilder.DropColumn(
                name: "DonviId",
                table: "Item");

            migrationBuilder.DropColumn(
                name: "Gia",
                table: "Item");

            migrationBuilder.DropColumn(
                name: "Giamgia",
                table: "Item");

            migrationBuilder.DropColumn(
                name: "LoaiMonanId",
                table: "Item");

            migrationBuilder.DropColumn(
                name: "NgayCapNhat",
                table: "Item");

            migrationBuilder.DropColumn(
                name: "NgayTao",
                table: "Item");

            migrationBuilder.DropColumn(
                name: "Xoa",
                table: "Item");*/
        }
    }
}
