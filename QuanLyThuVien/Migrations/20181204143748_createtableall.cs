using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace QuanLyThuVien.Migrations
{
    public partial class createtableall : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BinhLuans",
                columns: table => new
                {
                    IDBinhLuan = table.Column<int>(maxLength: 6, nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    IDDocGia = table.Column<int>(maxLength: 6, nullable: false),
                    TenDocGia = table.Column<string>(nullable: false),
                    IDSach = table.Column<int>(maxLength: 6, nullable: false),
                    ThoiGian = table.Column<DateTime>(nullable: false),
                    NoiDung = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BinhLuans", x => x.IDBinhLuan);
                    table.ForeignKey(
                        name: "FK_BinhLuans_Saches_IDsach",
                        column: x => x.IDSach,
                        principalTable: "Saches",
                        principalColumn: "IDSach",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "DocGias",
                columns: table => new
                {
                    IDDocGia = table.Column<int>(maxLength: 6, nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    TaiKhoan = table.Column<string>(maxLength: 8, nullable: false),
                    MatKhau = table.Column<string>(maxLength: 8, nullable: false),
                    HoTen = table.Column<string>(nullable: false),
                    NgaySinh = table.Column<DateTime>(nullable: false),
                    LoaiDocGia = table.Column<int>(nullable: false),
                    DiaChi = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DocGias", x => x.IDDocGia);
                });

            migrationBuilder.CreateTable(
                name: "NhanViens",
                columns: table => new
                {
                    IDDocGia = table.Column<int>(maxLength: 6, nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    TaiKhoan = table.Column<string>(maxLength: 8, nullable: false),
                    MatKhau = table.Column<string>(maxLength: 8, nullable: false),
                    HoTen = table.Column<string>(nullable: false),
                    NgaySinh = table.Column<DateTime>(nullable: false),
                    LoaiNhanVien = table.Column<int>(nullable: false),
                    DiaChi = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NhanViens", x => x.IDDocGia);
                });

            migrationBuilder.CreateTable(
                name: "MuonSaches",
                columns: table => new
                {
                    IDPhieu = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    IDDocGia = table.Column<int>(nullable: false),
                    IDSach = table.Column<int>(nullable: false),
                    IDNhanVien = table.Column<int>(nullable: false),
                    TinhTrangSach = table.Column<string>(nullable: false),
                    PhiMuon = table.Column<int>(nullable: false),
                    TienCoc = table.Column<int>(nullable: false),
                    NgayMuon = table.Column<DateTime>(nullable: false),
                    NgayTraDuKien = table.Column<DateTime>(nullable: false),
                    NgayTraThucTe = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MuonSaches", x => x.IDPhieu);
                    table.ForeignKey(
                        name: "FK_MuonSaches_DocGias_IDDocGia",
                        column: x => x.IDDocGia,
                        principalTable: "DocGias",
                        principalColumn: "IDDocGia",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MuonSaches_NhanViens_IDNhanVien",
                        column: x => x.IDNhanVien,
                        principalTable: "NhanViens",
                        principalColumn: "IDDocGia",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MuonSaches_Saches_IDSach",
                        column: x => x.IDSach,
                        principalTable: "Saches",
                        principalColumn: "IDSach",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BinhLuans_IDsach",
                table: "BinhLuans",
                column: "IDsach");

            migrationBuilder.CreateIndex(
                name: "IX_MuonSaches_IDDocGia",
                table: "MuonSaches",
                column: "IDDocGia");

            migrationBuilder.CreateIndex(
                name: "IX_MuonSaches_IDNhanVien",
                table: "MuonSaches",
                column: "IDNhanVien");

            migrationBuilder.CreateIndex(
                name: "IX_MuonSaches_IDSach",
                table: "MuonSaches",
                column: "IDSach");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BinhLuans");

            migrationBuilder.DropTable(
                name: "MuonSaches");

            migrationBuilder.DropTable(
                name: "DocGias");

            migrationBuilder.DropTable(
                name: "NhanViens");
        }
    }
}
