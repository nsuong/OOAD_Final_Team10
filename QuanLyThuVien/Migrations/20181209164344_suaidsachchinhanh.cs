using Microsoft.EntityFrameworkCore.Migrations;

namespace QuanLyThuVien.Migrations
{
    public partial class suaidsachchinhanh : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ID",
                table: "SachChiNhanhs",
                newName: "IDSachChiNhanh");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "IDSachChiNhanh",
                table: "SachChiNhanhs",
                newName: "ID");
        }
    }
}
