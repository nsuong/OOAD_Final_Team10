﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using QuanLyThuVien.Models;

namespace QuanLyThuVien.Migrations
{
    [DbContext(typeof(MyDBContext))]
    [Migration("20181205140727_aa")]
    partial class aa
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("QuanLyThuVien.Models.BinhLuan", b =>
                {
                    b.Property<int>("IDBinhLuan")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("IDDocGia");

                    b.Property<int>("IDSach");

                    b.Property<string>("NoiDung");

                    b.Property<string>("TenDocGia")
                        .IsRequired();

                    b.Property<DateTime>("ThoiGian");

                    b.HasKey("IDBinhLuan");

                    b.HasIndex("IDSach");

                    b.ToTable("BinhLuans");
                });

            modelBuilder.Entity("QuanLyThuVien.Models.ChiNhanh", b =>
                {
                    b.Property<int>("IDChiNhanh")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("DiaChi")
                        .IsRequired();

                    b.Property<int>("IDNhanVien");

                    b.Property<int>("IDQuanLy");

                    b.Property<DateTime>("NgayThanhLap");

                    b.Property<string>("TenChiNhanh")
                        .IsRequired();

                    b.HasKey("IDChiNhanh");

                    b.ToTable("ChiNhanhs");
                });

            modelBuilder.Entity("QuanLyThuVien.Models.DocGia", b =>
                {
                    b.Property<int>("IDDocGia")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("DiaChi");

                    b.Property<string>("HoTen")
                        .IsRequired();

                    b.Property<int>("LoaiDocGia");

                    b.Property<string>("MatKhau")
                        .IsRequired();

                    b.Property<DateTime>("NgaySinh");

                    b.Property<string>("TaiKhoan")
                        .IsRequired();

                    b.HasKey("IDDocGia");

                    b.ToTable("DocGias");
                });

            modelBuilder.Entity("QuanLyThuVien.Models.LoaiSach", b =>
                {
                    b.Property<int>("IDLoai")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("MoTa");

                    b.Property<string>("TenLoai")
                        .IsRequired();

                    b.HasKey("IDLoai");

                    b.ToTable("LoaiSaches");
                });

            modelBuilder.Entity("QuanLyThuVien.Models.MuonSach", b =>
                {
                    b.Property<int>("IDPhieu")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("IDDocGia");

                    b.Property<int>("IDNhanVien");

                    b.Property<int>("IDSach");

                    b.Property<DateTime>("NgayMuon");

                    b.Property<DateTime>("NgayTraDuKien");

                    b.Property<DateTime>("NgayTraThucTe");

                    b.Property<int>("PhiMuon");

                    b.Property<int>("TienCoc");

                    b.Property<string>("TinhTrangSach")
                        .IsRequired();

                    b.HasKey("IDPhieu");

                    b.HasIndex("IDDocGia");

                    b.HasIndex("IDNhanVien");

                    b.HasIndex("IDSach");

                    b.ToTable("MuonSaches");
                });

            modelBuilder.Entity("QuanLyThuVien.Models.NhanVien", b =>
                {
                    b.Property<int>("IDNhanVien")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("DiaChi");

                    b.Property<string>("HoTen")
                        .IsRequired();

                    b.Property<int>("IDChiNhanh");

                    b.Property<int>("LoaiNhanVien");

                    b.Property<string>("MatKhau")
                        .IsRequired();

                    b.Property<DateTime>("NgaySinh");

                    b.Property<string>("TaiKhoan")
                        .IsRequired();

                    b.HasKey("IDNhanVien");

                    b.HasIndex("IDChiNhanh");

                    b.ToTable("NhanViens");
                });

            modelBuilder.Entity("QuanLyThuVien.Models.Sach", b =>
                {
                    b.Property<int>("IDSach")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("IDLoai");

                    b.Property<string>("MoTa");

                    b.Property<int>("NamXuatBan");

                    b.Property<DateTime>("NgayNhap");

                    b.Property<string>("NhaXuatBan");

                    b.Property<int>("SoDanhGia");

                    b.Property<int>("SoSachCon");

                    b.Property<int>("SoTrang");

                    b.Property<string>("TacGia");

                    b.Property<string>("TenSach")
                        .IsRequired();

                    b.Property<int>("TongSoLuong");

                    b.Property<float>("XepHangTb");

                    b.HasKey("IDSach");

                    b.HasIndex("IDLoai");

                    b.ToTable("Saches");
                });

            modelBuilder.Entity("QuanLyThuVien.Models.SachChiNhanh", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(6)
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("IDChiNhanh")
                        .HasMaxLength(6);

                    b.Property<int>("IDSach")
                        .HasMaxLength(6);

                    b.HasKey("ID");

                    b.HasIndex("IDChiNhanh");

                    b.HasIndex("IDSach");

                    b.ToTable("SachChiNhanhs");
                });

            modelBuilder.Entity("QuanLyThuVien.Models.BinhLuan", b =>
                {
                    b.HasOne("QuanLyThuVien.Models.Sach", "Sach")
                        .WithMany()
                        .HasForeignKey("IDSach")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("QuanLyThuVien.Models.MuonSach", b =>
                {
                    b.HasOne("QuanLyThuVien.Models.DocGia", "DocGia")
                        .WithMany()
                        .HasForeignKey("IDDocGia")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("QuanLyThuVien.Models.NhanVien", "NhanVien")
                        .WithMany()
                        .HasForeignKey("IDNhanVien")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("QuanLyThuVien.Models.Sach", "Sach")
                        .WithMany()
                        .HasForeignKey("IDSach")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("QuanLyThuVien.Models.NhanVien", b =>
                {
                    b.HasOne("QuanLyThuVien.Models.ChiNhanh", "ChiNhanh")
                        .WithMany()
                        .HasForeignKey("IDChiNhanh")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("QuanLyThuVien.Models.Sach", b =>
                {
                    b.HasOne("QuanLyThuVien.Models.LoaiSach", "LoaiSach")
                        .WithMany()
                        .HasForeignKey("IDLoai")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("QuanLyThuVien.Models.SachChiNhanh", b =>
                {
                    b.HasOne("QuanLyThuVien.Models.ChiNhanh", "ChiNhanh")
                        .WithMany()
                        .HasForeignKey("IDChiNhanh")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("QuanLyThuVien.Models.Sach", "Sach")
                        .WithMany()
                        .HasForeignKey("IDSach")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
