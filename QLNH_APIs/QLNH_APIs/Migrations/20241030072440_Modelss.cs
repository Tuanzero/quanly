using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace QLNH_APIs.Migrations
{
    public partial class Modelss : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
           /* migrationBuilder.DropForeignKey(
                name: "FK_HinhMonan_Item_ItemModelItemId",
                table: "HinhMonan");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderItem_Order_OrderModelOrderId",
                table: "OrderItem");

            migrationBuilder.RenameColumn(
                name: "OrderModelOrderId",
                table: "OrderItem",
                newName: "OrderId");

            migrationBuilder.RenameIndex(
                name: "IX_OrderItem_OrderModelOrderId",
                table: "OrderItem",
                newName: "IX_OrderItem_OrderId");

            migrationBuilder.RenameColumn(
                name: "ItemModelItemId",
                table: "HinhMonan",
                newName: "ItemId");

            migrationBuilder.RenameIndex(
                name: "IX_HinhMonan_ItemModelItemId",
                table: "HinhMonan",
                newName: "IX_HinhMonan_ItemId");

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

            migrationBuilder.AddForeignKey(
                name: "FK_HinhMonan_Item_ItemId",
                table: "HinhMonan",
                column: "ItemId",
                principalTable: "Item",
                principalColumn: "ItemId");

            migrationBuilder.AddForeignKey(
                name: "FK_OrderItem_Order_OrderId",
                table: "OrderItem",
                column: "OrderId",
                principalTable: "Order",
                principalColumn: "OrderId");*/
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
         /*   migrationBuilder.DropForeignKey(
                name: "FK_HinhMonan_Item_ItemId",
                table: "HinhMonan");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderItem_Order_OrderId",
                table: "OrderItem");

            migrationBuilder.RenameColumn(
                name: "OrderId",
                table: "OrderItem",
                newName: "OrderModelOrderId");

            migrationBuilder.RenameIndex(
                name: "IX_OrderItem_OrderId",
                table: "OrderItem",
                newName: "IX_OrderItem_OrderModelOrderId");

            migrationBuilder.RenameColumn(
                name: "ItemId",
                table: "HinhMonan",
                newName: "ItemModelItemId");

            migrationBuilder.RenameIndex(
                name: "IX_HinhMonan_ItemId",
                table: "HinhMonan",
                newName: "IX_HinhMonan_ItemModelItemId");

            migrationBuilder.AlterColumn<DateTime>(
                name: "NgayTao",
                table: "VaiTro",
                type: "TIMESTAMP(7)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "NVARCHAR2(2000)");

            migrationBuilder.AlterColumn<DateTime>(
                name: "NgayCapNhat",
                table: "VaiTro",
                type: "TIMESTAMP(7)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "NVARCHAR2(2000)");

            migrationBuilder.AlterColumn<DateTime>(
                name: "NgayTao",
                table: "TrangThai",
                type: "TIMESTAMP(7)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "NVARCHAR2(2000)");

            migrationBuilder.AlterColumn<DateTime>(
                name: "NgayCapNhat",
                table: "TrangThai",
                type: "TIMESTAMP(7)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "NVARCHAR2(2000)");

            migrationBuilder.AlterColumn<DateTime>(
                name: "NgayTao",
                table: "OrderItem",
                type: "TIMESTAMP(7)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "NVARCHAR2(2000)");

            migrationBuilder.AlterColumn<DateTime>(
                name: "NgayCapNhat",
                table: "OrderItem",
                type: "TIMESTAMP(7)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "NVARCHAR2(2000)");

            migrationBuilder.AlterColumn<DateTime>(
                name: "NgayTao",
                table: "Order",
                type: "TIMESTAMP(7)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "NVARCHAR2(2000)");

            migrationBuilder.AlterColumn<DateTime>(
                name: "NgayCapNhat",
                table: "Order",
                type: "TIMESTAMP(7)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "NVARCHAR2(2000)");

            migrationBuilder.AlterColumn<DateTime>(
                name: "NgayTao",
                table: "LoaiMonan",
                type: "TIMESTAMP(7)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "NVARCHAR2(2000)");

            migrationBuilder.AlterColumn<DateTime>(
                name: "NgayCapNhat",
                table: "LoaiMonan",
                type: "TIMESTAMP(7)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "NVARCHAR2(2000)");

            migrationBuilder.AlterColumn<DateTime>(
                name: "NgayTao",
                table: "Loaidonvi",
                type: "TIMESTAMP(7)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "NVARCHAR2(2000)");

            migrationBuilder.AlterColumn<DateTime>(
                name: "NgayCapNhat",
                table: "Loaidonvi",
                type: "TIMESTAMP(7)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "NVARCHAR2(2000)");

            migrationBuilder.AlterColumn<DateTime>(
                name: "NgayTao",
                table: "KhachHang",
                type: "TIMESTAMP(7)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "NVARCHAR2(2000)");

            migrationBuilder.AlterColumn<DateTime>(
                name: "NgayCapNhat",
                table: "KhachHang",
                type: "TIMESTAMP(7)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "NVARCHAR2(2000)");

            migrationBuilder.AlterColumn<DateTime>(
                name: "NgayTao",
                table: "Item",
                type: "TIMESTAMP(7)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "NVARCHAR2(2000)");

            migrationBuilder.AlterColumn<DateTime>(
                name: "NgayCapNhat",
                table: "Item",
                type: "TIMESTAMP(7)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "NVARCHAR2(2000)");

            migrationBuilder.AlterColumn<DateTime>(
                name: "NgayTao",
                table: "HinhMonan",
                type: "TIMESTAMP(7)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "NVARCHAR2(2000)");

            migrationBuilder.AlterColumn<DateTime>(
                name: "NgayCapNhat",
                table: "HinhMonan",
                type: "TIMESTAMP(7)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "NVARCHAR2(2000)");

            migrationBuilder.AlterColumn<DateTime>(
                name: "NgayTao",
                table: "Donvi",
                type: "TIMESTAMP(7)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "NVARCHAR2(2000)");

            migrationBuilder.AlterColumn<DateTime>(
                name: "NgayCapNhat",
                table: "Donvi",
                type: "TIMESTAMP(7)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "NVARCHAR2(2000)");

            migrationBuilder.AlterColumn<DateTime>(
                name: "NgayTao",
                table: "Ban",
                type: "TIMESTAMP(7)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "NVARCHAR2(2000)");

            migrationBuilder.AlterColumn<DateTime>(
                name: "NgayCapNhat",
                table: "Ban",
                type: "TIMESTAMP(7)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "NVARCHAR2(2000)");

            migrationBuilder.AddForeignKey(
                name: "FK_HinhMonan_Item_ItemModelItemId",
                table: "HinhMonan",
                column: "ItemModelItemId",
                principalTable: "Item",
                principalColumn: "ItemId");

            migrationBuilder.AddForeignKey(
                name: "FK_OrderItem_Order_OrderModelOrderId",
                table: "OrderItem",
                column: "OrderModelOrderId",
                principalTable: "Order",
                principalColumn: "OrderId");*/
        }
    }
}
