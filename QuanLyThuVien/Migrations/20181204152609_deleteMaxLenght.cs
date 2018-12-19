using Microsoft.EntityFrameworkCore.Migrations;

namespace QuanLyThuVien.Migrations
{
    public partial class deleteMaxLenght : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "TaiKhoan",
                table: "NhanViens",
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 8);

            migrationBuilder.AlterColumn<string>(
                name: "MatKhau",
                table: "NhanViens",
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 8);

            migrationBuilder.AlterColumn<string>(
                name: "TaiKhoan",
                table: "DocGias",
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 8);

            migrationBuilder.AlterColumn<string>(
                name: "MatKhau",
                table: "DocGias",
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 8);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "TaiKhoan",
                table: "NhanViens",
                maxLength: 8,
                nullable: false,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "MatKhau",
                table: "NhanViens",
                maxLength: 8,
                nullable: false,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "TaiKhoan",
                table: "DocGias",
                maxLength: 8,
                nullable: false,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "MatKhau",
                table: "DocGias",
                maxLength: 8,
                nullable: false,
                oldClrType: typeof(string));
        }
    }
}
