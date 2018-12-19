using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace QuanLyThuVien.Migrations
{
    public partial class alterloaisach : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "LoaiSach",
                table: "Saches",
                newName: "IDLoai");

            migrationBuilder.CreateTable(
                name: "LoaiSach",
                columns: table => new
                {
                    IDLoai = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    TenLoai = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LoaiSach", x => x.IDLoai);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Saches_IDLoai",
                table: "Saches",
                column: "IDLoai");

            migrationBuilder.AddForeignKey(
                name: "FK_Saches_LoaiSach_IDLoai",
                table: "Saches",
                column: "IDLoai",
                principalTable: "LoaiSach",
                principalColumn: "IDLoai",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Saches_LoaiSach_IDLoai",
                table: "Saches");

            migrationBuilder.DropTable(
                name: "LoaiSach");

            migrationBuilder.DropIndex(
                name: "IX_Saches_IDLoai",
                table: "Saches");

            migrationBuilder.RenameColumn(
                name: "IDLoai",
                table: "Saches",
                newName: "LoaiSach");
        }
    }
}
