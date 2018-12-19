using Microsoft.EntityFrameworkCore.Migrations;

namespace QuanLyThuVien.Migrations
{
    public partial class asdadsada : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddForeignKey(
                name: "FK_NhanViens_ChiNhanhs_IDChiNhanh",
                table: "NhanViens",
                column: "IDChiNhanh",
                principalTable: "ChiNhanhs",
                principalColumn: "IDChiNhanh",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
