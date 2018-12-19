using Microsoft.EntityFrameworkCore.Migrations;

namespace QuanLyThuVien.Migrations
{
    public partial class asdad1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "IDNhanVien",
                table: "MuonSaches",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_MuonSaches_IDNhanVien",
                table: "MuonSaches",
                column: "IDNhanVien");

            migrationBuilder.AddForeignKey(
                name: "FK_MuonSaches_NhanViens_IDNhanVien",
                table: "MuonSaches",
                column: "IDNhanVien",
                principalTable: "NhanViens",
                principalColumn: "IDNhanVien",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MuonSaches_NhanViens_IDNhanVien",
                table: "MuonSaches");

            migrationBuilder.DropIndex(
                name: "IX_MuonSaches_IDNhanVien",
                table: "MuonSaches");

            migrationBuilder.DropColumn(
                name: "IDNhanVien",
                table: "MuonSaches");
        }
    }
}
