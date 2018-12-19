using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace QuanLyThuVien.Migrations
{
    public partial class createtable1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ChiNhanhs",
                columns: table => new
                {
                    IDChiNhanh = table.Column<int>(maxLength: 6, nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    TenChiNhanh = table.Column<string>(nullable: false),
                    DiaChi = table.Column<string>(nullable: false),
                    NgayThanhLap = table.Column<DateTime>(nullable: false),
                    IDQuanLy = table.Column<int>(nullable: false),
                    IDNhanVien = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChiNhanhs", x => x.IDChiNhanh);
                });

            migrationBuilder.CreateTable(
                name: "Saches",
                columns: table => new
                {
                    IDSach = table.Column<int>(maxLength: 6, nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    TenSach = table.Column<string>(nullable: false),
                    LoaiSach = table.Column<int>(nullable: false),
                    TacGia = table.Column<string>(nullable: true),
                    NhaXuatBan = table.Column<string>(nullable: true),
                    NamXuatBan = table.Column<int>(nullable: false),
                    SoTrang = table.Column<int>(nullable: false),
                    MoTa = table.Column<string>(nullable: true),
                    NgayNhap = table.Column<DateTime>(nullable: false),
                    TongSoLuong = table.Column<int>(nullable: false),
                    SoSachCon = table.Column<int>(nullable: false),
                    XepHangTb = table.Column<float>(nullable: false),
                    SoDanhGia = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Saches", x => x.IDSach);
                });

            migrationBuilder.CreateTable(
                name: "SachChiNhanhs",
                columns: table => new
                {
                    ID = table.Column<int>(maxLength: 6, nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    IDSach = table.Column<int>(maxLength: 6, nullable: false),
                    IDChiNhanh = table.Column<int>(maxLength: 6, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SachChiNhanhs", x => x.ID);
                    table.ForeignKey(
                        name: "FK_SachChiNhanhs_ChiNhanhs_IDChiNhanh",
                        column: x => x.IDChiNhanh,
                        principalTable: "ChiNhanhs",
                        principalColumn: "IDChiNhanh",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SachChiNhanhs_Saches_IDSach",
                        column: x => x.IDSach,
                        principalTable: "Saches",
                        principalColumn: "IDSach",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_SachChiNhanhs_IDChiNhanh",
                table: "SachChiNhanhs",
                column: "IDChiNhanh");

            migrationBuilder.CreateIndex(
                name: "IX_SachChiNhanhs_IDSach",
                table: "SachChiNhanhs",
                column: "IDSach");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SachChiNhanhs");

            migrationBuilder.DropTable(
                name: "ChiNhanhs");

            migrationBuilder.DropTable(
                name: "Saches");
        }
    }
}
