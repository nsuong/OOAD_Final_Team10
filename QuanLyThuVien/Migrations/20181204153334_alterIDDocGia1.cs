using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace QuanLyThuVien.Migrations
{
    public partial class alterIDDocGia1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MuonSaches_DocGias_IDDocGia",
                table: "MuonSaches");

            migrationBuilder.DropIndex(
                name: "IX_MuonSaches_IDDocGia",
                table: "MuonSaches");

            migrationBuilder.DropPrimaryKey(
                name: "PK_DocGias",
                table: "DocGias");

            migrationBuilder.DropColumn(
                name: "IDDocGia",
                table: "MuonSaches");

            migrationBuilder.DropColumn(
                name: "IDDocGia",
                table: "DocGias");

            migrationBuilder.AddColumn<int>(
                name: "DocGiaid",
                table: "MuonSaches",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "id",
                table: "DocGias",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AddPrimaryKey(
                name: "PK_DocGias",
                table: "DocGias",
                column: "id");

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MuonSaches_DocGias_DocGiaid",
                table: "MuonSaches");

            migrationBuilder.DropIndex(
                name: "IX_MuonSaches_DocGiaid",
                table: "MuonSaches");

            migrationBuilder.DropPrimaryKey(
                name: "PK_DocGias",
                table: "DocGias");

            migrationBuilder.DropColumn(
                name: "DocGiaid",
                table: "MuonSaches");

            migrationBuilder.DropColumn(
                name: "id",
                table: "DocGias");

            migrationBuilder.AddColumn<string>(
                name: "IDDocGia",
                table: "MuonSaches",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "IDDocGia",
                table: "DocGias",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "PK_DocGias",
                table: "DocGias",
                column: "IDDocGia");

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
    }
}
