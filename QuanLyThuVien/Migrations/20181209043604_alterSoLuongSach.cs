using Microsoft.EntityFrameworkCore.Migrations;

namespace QuanLyThuVien.Migrations
{
    public partial class alterSoLuongSach : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SoSachCon",
                table: "Saches");

            migrationBuilder.DropColumn(
                name: "TongSoLuong",
                table: "Saches");

            migrationBuilder.AddColumn<int>(
                name: "SoSachCon",
                table: "SachChiNhanhs",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TongSoLuong",
                table: "SachChiNhanhs",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SoSachCon",
                table: "SachChiNhanhs");

            migrationBuilder.DropColumn(
                name: "TongSoLuong",
                table: "SachChiNhanhs");

            migrationBuilder.AddColumn<int>(
                name: "SoSachCon",
                table: "Saches",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TongSoLuong",
                table: "Saches",
                nullable: false,
                defaultValue: 0);
        }
    }
}
