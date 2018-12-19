using Microsoft.EntityFrameworkCore.Migrations;

namespace QuanLyThuVien.Migrations
{
    public partial class capnhatsach : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DanhGia",
                table: "Saches",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "HinhAnh",
                table: "Saches",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TienMua",
                table: "Saches",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TienMuon",
                table: "Saches",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DanhGia",
                table: "Saches");

            migrationBuilder.DropColumn(
                name: "HinhAnh",
                table: "Saches");

            migrationBuilder.DropColumn(
                name: "TienMua",
                table: "Saches");

            migrationBuilder.DropColumn(
                name: "TienMuon",
                table: "Saches");
        }
    }
}
