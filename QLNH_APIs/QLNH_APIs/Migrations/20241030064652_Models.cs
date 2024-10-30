using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace QLNH_APIs.Migrations
{
    public partial class Models : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
          /*  migrationBuilder.DropForeignKey(
                name: "FK_HinhMonan_Item_ItemModelId",
                table: "HinhMonan");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderItem_Order_OrderModelId",
                table: "OrderItem");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "VaiTro",
                newName: "VaitroId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "TrangThai",
                newName: "TrangthaiId");

            migrationBuilder.RenameColumn(
                name: "OrderModelId",
                table: "OrderItem",
                newName: "OrderModelOrderId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "OrderItem",
                newName: "OrderItemId");

            migrationBuilder.RenameIndex(
                name: "IX_OrderItem_OrderModelId",
                table: "OrderItem",
                newName: "IX_OrderItem_OrderModelOrderId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Order",
                newName: "OrderId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "LoaiMonan",
                newName: "LoaiMonanId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Loaidonvi",
                newName: "LoaidonviId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "KhachHang",
                newName: "KhachhangId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Item",
                newName: "ItemId");

            migrationBuilder.RenameColumn(
                name: "ItemModelId",
                table: "HinhMonan",
                newName: "ItemModelItemId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "HinhMonan",
                newName: "HinhMonanId");

            migrationBuilder.RenameIndex(
                name: "IX_HinhMonan_ItemModelId",
                table: "HinhMonan",
                newName: "IX_HinhMonan_ItemModelItemId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Donvi",
                newName: "DonviId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Ban",
                newName: "BanId");

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
           /* migrationBuilder.DropForeignKey(
                name: "FK_HinhMonan_Item_ItemModelItemId",
                table: "HinhMonan");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderItem_Order_OrderModelOrderId",
                table: "OrderItem");

            migrationBuilder.RenameColumn(
                name: "VaitroId",
                table: "VaiTro",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "TrangthaiId",
                table: "TrangThai",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "OrderModelOrderId",
                table: "OrderItem",
                newName: "OrderModelId");

            migrationBuilder.RenameColumn(
                name: "OrderItemId",
                table: "OrderItem",
                newName: "Id");

            migrationBuilder.RenameIndex(
                name: "IX_OrderItem_OrderModelOrderId",
                table: "OrderItem",
                newName: "IX_OrderItem_OrderModelId");

            migrationBuilder.RenameColumn(
                name: "OrderId",
                table: "Order",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "LoaiMonanId",
                table: "LoaiMonan",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "LoaidonviId",
                table: "Loaidonvi",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "KhachhangId",
                table: "KhachHang",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "ItemId",
                table: "Item",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "ItemModelItemId",
                table: "HinhMonan",
                newName: "ItemModelId");

            migrationBuilder.RenameColumn(
                name: "HinhMonanId",
                table: "HinhMonan",
                newName: "Id");

            migrationBuilder.RenameIndex(
                name: "IX_HinhMonan_ItemModelItemId",
                table: "HinhMonan",
                newName: "IX_HinhMonan_ItemModelId");

            migrationBuilder.RenameColumn(
                name: "DonviId",
                table: "Donvi",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "BanId",
                table: "Ban",
                newName: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_HinhMonan_Item_ItemModelId",
                table: "HinhMonan",
                column: "ItemModelId",
                principalTable: "Item",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_OrderItem_Order_OrderModelId",
                table: "OrderItem",
                column: "OrderModelId",
                principalTable: "Order",
                principalColumn: "Id");*/
        }
    }
}
