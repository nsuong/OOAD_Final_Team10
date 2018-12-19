using Microsoft.EntityFrameworkCore.Migrations;

namespace QuanLyThuVien.Migrations
{
    public partial class alterAllTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Saches_LoaiSach_IDLoai",
                table: "Saches");

            migrationBuilder.DropPrimaryKey(
                name: "PK_LoaiSach",
                table: "LoaiSach");

            migrationBuilder.RenameTable(
                name: "LoaiSach",
                newName: "LoaiSaches");

            migrationBuilder.AddColumn<int>(
                name: "IDChiNhanh",
                table: "NhanViens",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "IDChiNhanh",
                table: "MuonSaches",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "MoTa",
                table: "LoaiSaches",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_LoaiSaches",
                table: "LoaiSaches",
                column: "IDLoai");

            migrationBuilder.CreateIndex(
                name: "IX_NhanViens_IDChiNhanh",
                table: "NhanViens",
                column: "IDChiNhanh");

            migrationBuilder.CreateIndex(
                name: "IX_MuonSaches_IDChiNhanh",
                table: "MuonSaches",
                column: "IDChiNhanh");

            migrationBuilder.AddForeignKey(
                name: "FK_MuonSaches_ChiNhanhs_IDChiNhanh",
                table: "MuonSaches",
                column: "IDChiNhanh",
                principalTable: "ChiNhanhs",
                principalColumn: "IDChiNhanh",
                onDelete: ReferentialAction.Cascade);

            

            migrationBuilder.AddForeignKey(
                name: "FK_Saches_LoaiSaches_IDLoai",
                table: "Saches",
                column: "IDLoai",
                principalTable: "LoaiSaches",
                principalColumn: "IDLoai",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MuonSaches_ChiNhanhs_IDChiNhanh",
                table: "MuonSaches");

            migrationBuilder.DropForeignKey(
                name: "FK_NhanViens_ChiNhanhs_IDChiNhanh",
                table: "NhanViens");

            migrationBuilder.DropForeignKey(
                name: "FK_Saches_LoaiSaches_IDLoai",
                table: "Saches");

            migrationBuilder.DropIndex(
                name: "IX_NhanViens_IDChiNhanh",
                table: "NhanViens");

            migrationBuilder.DropIndex(
                name: "IX_MuonSaches_IDChiNhanh",
                table: "MuonSaches");

            migrationBuilder.DropPrimaryKey(
                name: "PK_LoaiSaches",
                table: "LoaiSaches");

            migrationBuilder.DropColumn(
                name: "IDChiNhanh",
                table: "NhanViens");

            migrationBuilder.DropColumn(
                name: "IDChiNhanh",
                table: "MuonSaches");

            migrationBuilder.DropColumn(
                name: "MoTa",
                table: "LoaiSaches");

            migrationBuilder.RenameTable(
                name: "LoaiSaches",
                newName: "LoaiSach");

            migrationBuilder.AddPrimaryKey(
                name: "PK_LoaiSach",
                table: "LoaiSach",
                column: "IDLoai");

            migrationBuilder.AddForeignKey(
                name: "FK_Saches_LoaiSach_IDLoai",
                table: "Saches",
                column: "IDLoai",
                principalTable: "LoaiSach",
                principalColumn: "IDLoai",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
