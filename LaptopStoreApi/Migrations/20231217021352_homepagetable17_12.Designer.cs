﻿// <auto-generated />
using System;
using LaptopStoreApi.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace LaptopStoreApi.Migrations
{
    [DbContext(typeof(ApplicationLaptopDbContext))]
    [Migration("20231217021352_homepagetable17_12")]
    partial class homepagetable17_12
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("LaptopStoreApi.Data.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("LaptopStoreApi.Data.DonHang", b =>
                {
                    b.Property<int>("MaDh")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MaDh"));

                    b.Property<string>("DiaChiGiao")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("NgayDat")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValueSql("getutcdate()");

                    b.Property<DateTime?>("NgayGiao")
                        .HasColumnType("datetime2");

                    b.Property<string>("NguoiNhan")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SoDienThoai")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TinhTrangDonHang")
                        .HasColumnType("int");

                    b.HasKey("MaDh");

                    b.ToTable("DonHangs", (string)null);
                });

            modelBuilder.Entity("LaptopStoreApi.Data.DonHangChiTiet", b =>
                {
                    b.Property<int>("MaDh")
                        .HasColumnType("int");

                    b.Property<int>("MaLaptop")
                        .HasColumnType("int");

                    b.Property<double>("DonGia")
                        .HasColumnType("float");

                    b.Property<byte>("GiamGia")
                        .HasColumnType("tinyint");

                    b.Property<int>("SoLuong")
                        .HasColumnType("int");

                    b.HasKey("MaDh", "MaLaptop");

                    b.HasIndex("MaLaptop");

                    b.ToTable("ChiTietDonHangs", (string)null);
                });

            modelBuilder.Entity("LaptopStoreApi.Data.Homepage", b =>
                {
                    b.Property<int?>("HomePageId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int?>("HomePageId"));

                    b.Property<int>("LaptopMaLaptop")
                        .HasColumnType("int");

                    b.Property<int?>("MaLaptop")
                        .HasColumnType("int");

                    b.Property<string>("SlideImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("VideoUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("HomePageId");

                    b.HasIndex("LaptopMaLaptop");

                    b.ToTable("Homepage");
                });

            modelBuilder.Entity("LaptopStoreApi.Data.Laptop", b =>
                {
                    b.Property<int>("MaLaptop")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MaLaptop"));

                    b.Property<int?>("CategoryId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("Gia")
                        .HasColumnType("decimal(18,2)");

                    b.Property<byte>("GiamGia")
                        .HasColumnType("tinyint");

                    b.Property<string>("Hangsx")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImgPath")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("LastModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<double>("LoaiManHinh")
                        .HasColumnType("float");

                    b.Property<string>("Mau")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Mota")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("NamSanXuat")
                        .HasColumnType("int");

                    b.Property<string>("TenLaptop")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("MaLaptop");

                    b.HasIndex("CategoryId");

                    b.ToTable("Laptops");
                });

            modelBuilder.Entity("LaptopStoreApi.Data.DonHangChiTiet", b =>
                {
                    b.HasOne("LaptopStoreApi.Data.DonHang", "DonHang")
                        .WithMany("DonHangChiTiets")
                        .HasForeignKey("MaDh")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FK_DonHangCT_DonHang");

                    b.HasOne("LaptopStoreApi.Data.Laptop", "Laptop")
                        .WithMany("DonHangChiTiets")
                        .HasForeignKey("MaLaptop")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FK_DonHangCT_Laptop");

                    b.Navigation("DonHang");

                    b.Navigation("Laptop");
                });

            modelBuilder.Entity("LaptopStoreApi.Data.Homepage", b =>
                {
                    b.HasOne("LaptopStoreApi.Data.Laptop", "Laptop")
                        .WithMany()
                        .HasForeignKey("LaptopMaLaptop")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Laptop");
                });

            modelBuilder.Entity("LaptopStoreApi.Data.Laptop", b =>
                {
                    b.HasOne("LaptopStoreApi.Data.Category", "Category")
                        .WithMany("Laptops")
                        .HasForeignKey("CategoryId");

                    b.Navigation("Category");
                });

            modelBuilder.Entity("LaptopStoreApi.Data.Category", b =>
                {
                    b.Navigation("Laptops");
                });

            modelBuilder.Entity("LaptopStoreApi.Data.DonHang", b =>
                {
                    b.Navigation("DonHangChiTiets");
                });

            modelBuilder.Entity("LaptopStoreApi.Data.Laptop", b =>
                {
                    b.Navigation("DonHangChiTiets");
                });
#pragma warning restore 612, 618
        }
    }
}
