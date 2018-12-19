using Microsoft.EntityFrameworkCore.Migrations;

namespace QuanLyThuVien.Migrations
{
    public partial class alterIDDocGia6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MuonSaches_DocGias_DocGiaid",
                table: "MuonSaches");

            migrationBuilder.DropIndex(
                name: "IX_MuonSaches_DocGiaid",
                table: "MuonSaches");

            migrationBuilder.DropColumn(
                name: "DocGiaid",
                table: "MuonSaches");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "DocGias",
                newName: "IDDocGia");

            migrationBuilder.AddColumn<int>(
                name: "IDDocGia",
                table: "MuonSaches",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_MuonSaches_IDDocGia",
                table: "MuonSaches",
                column: "IDDocGia");

            migrationBuilder.AddForeignKey(
                name: "FK_MuonSaches_DocGias_IDDocGia",
                table: "MuonSaches",
                column: "IDDocGia",
                principalTable: "DocGias",
                principalColumn: "IDDocGia",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MuonSaches_DocGias_IDDocGia",
                table: "MuonSaches");

            migrationBuilder.DropIndex(
                name: "IX_MuonSaches_IDDocGia",
                table: "MuonSaches");

            migrationBuilder.DropColumn(
                name: "IDDocGia",
                table: "MuonSaches");

            migrationBuilder.RenameColumn(
                name: "IDDocGia",
                table: "DocGias",
                newName: "id");

            migrationBuilder.AddColumn<int>(
                name: "DocGiaid",
                table: "MuonSaches",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_MuonSaches_DocGiaid",
                table: "MuonSaches",
                column: "DocGiaid");

            migrationBuilder.AddForeignKey(
                name: "FK_MuonSaches_DocGias_DocGiaid",
                table: "MuonSaches",
                column: "DocGiaid",
                principalTable: "DocGias",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
