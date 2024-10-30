using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace QLNH_APIs.Migrations
{
    public partial class AddLoaiMonan : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
           /* migrationBuilder.CreateTable(
                name: "LoaiMonan",
                columns: table => new
                {
                    Id = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    Tenloai = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    Mota = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LoaiMonan", x => x.Id);
                });*/
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
           /* migrationBuilder.DropTable(
                name: "LoaiMonan");*/
        }
    }
}
