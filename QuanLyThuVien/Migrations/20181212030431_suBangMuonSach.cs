using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace QuanLyThuVien.Migrations
{
    public partial class suBangMuonSach : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NgayTraDuKien",
                table: "MuonSaches");

            migrationBuilder.DropColumn(
                name: "NgayTraThucTe",
                table: "MuonSaches");

            migrationBuilder.AddColumn<string>(
                name: "TenChiNhanh",
                table: "MuonSaches",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TrangThai",
                table: "MuonSaches",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TenChiNhanh",
                table: "MuonSaches");

            migrationBuilder.DropColumn(
                name: "TrangThai",
                table: "MuonSaches");

            migrationBuilder.AddColumn<DateTime>(
                name: "NgayTraDuKien",
                table: "MuonSaches",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "NgayTraThucTe",
                table: "MuonSaches",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }
    }
}
