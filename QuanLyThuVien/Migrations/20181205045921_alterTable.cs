using Microsoft.EntityFrameworkCore.Migrations;

namespace QuanLyThuVien.Migrations
{
    public partial class alterTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MuonSaches_ChiNhanhs_IDChiNhanh",
                table: "MuonSaches");

            migrationBuilder.DropIndex(
                name: "IX_MuonSaches_IDChiNhanh",
                table: "MuonSaches");

            migrationBuilder.DropColumn(
                name: "IDChiNhanh",
                table: "MuonSaches");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "IDChiNhanh",
                table: "MuonSaches",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_MuonSaches_IDChiNhanh",
                table: "MuonSaches",
                column: "IDChiNhanh");
         
    }
    }
}
