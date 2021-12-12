﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using QUOCDAT2KDEMO.Data;

namespace QUOCDAT2KDEMO.Migrations
{
    [DbContext(typeof(MvcMovieContext))]
    [Migration("20211201084841_Update_Table_2")]
    partial class Update_Table_2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.11");

            modelBuilder.Entity("dotnet.Models.Employee", b =>
                {
                    b.Property<string>("EmployeeId")
                        .HasColumnType("TEXT");

                    b.Property<string>("EmployeeAddress")
                        .HasColumnType("TEXT");

                    b.Property<string>("EmployeeName")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("TEXT");

                    b.Property<int>("EmployeePhoneNumber")
                        .HasColumnType("INTEGER");

                    b.HasKey("EmployeeId");

                    b.ToTable("Employee");
                });

            modelBuilder.Entity("dotnet.Models.HoaDon", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("KhachHangId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("PersonId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("khachHangsKhachHangId")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("PersonId");

                    b.HasIndex("khachHangsKhachHangId");

                    b.ToTable("HoaDon");
                });

            modelBuilder.Entity("dotnet.Models.KhachHang", b =>
                {
                    b.Property<string>("KhachHangId")
                        .HasColumnType("TEXT");

                    b.Property<string>("TenKhachHang")
                        .HasColumnType("TEXT");

                    b.HasKey("KhachHangId");

                    b.ToTable("KhachHang");
                });

            modelBuilder.Entity("dotnet.Models.Movie", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Genre")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("TEXT");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18, 2)");

                    b.Property<string>("Rating")
                        .IsRequired()
                        .HasMaxLength(5)
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("ReleaseDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Movie");
                });

            modelBuilder.Entity("dotnet.Models.Person", b =>
                {
                    b.Property<int>("PersonId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("FullName")
                        .HasColumnType("TEXT");

                    b.Property<string>("PersonCode")
                        .HasColumnType("TEXT");

                    b.HasKey("PersonId");

                    b.ToTable("People");
                });

            modelBuilder.Entity("dotnet.Models.Product", b =>
                {
                    b.Property<string>("ProductId")
                        .HasColumnType("TEXT");

                    b.Property<double>("Price")
                        .HasColumnType("REAL");

                    b.Property<string>("ProductName")
                        .HasColumnType("TEXT");

                    b.HasKey("ProductId");

                    b.ToTable("Product");
                });

            modelBuilder.Entity("dotnet.Models.NhanVien", b =>
                {
                    b.HasBaseType("dotnet.Models.Person");

                    b.Property<string>("Address")
                        .HasColumnType("TEXT");

                    b.Property<string>("MyProperty")
                        .HasColumnType("TEXT");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("TEXT");

                    b.ToTable("NhanVien");
                });

            modelBuilder.Entity("dotnet.Models.Student", b =>
                {
                    b.HasBaseType("dotnet.Models.Person");

                    b.Property<string>("Address")
                        .HasColumnType("TEXT");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("TEXT");

                    b.Property<string>("Universisty")
                        .HasColumnType("TEXT");

                    b.ToTable("Student");
                });

            modelBuilder.Entity("dotnet.Models.HoaDon", b =>
                {
                    b.HasOne("dotnet.Models.Person", "people")
                        .WithMany("hoadons")
                        .HasForeignKey("PersonId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("dotnet.Models.KhachHang", "khachHangs")
                        .WithMany("hoadons")
                        .HasForeignKey("khachHangsKhachHangId");

                    b.Navigation("khachHangs");

                    b.Navigation("people");
                });

            modelBuilder.Entity("dotnet.Models.NhanVien", b =>
                {
                    b.HasOne("dotnet.Models.Person", null)
                        .WithOne()
                        .HasForeignKey("dotnet.Models.NhanVien", "PersonId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("dotnet.Models.Student", b =>
                {
                    b.HasOne("dotnet.Models.Person", null)
                        .WithOne()
                        .HasForeignKey("dotnet.Models.Student", "PersonId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("dotnet.Models.KhachHang", b =>
                {
                    b.Navigation("hoadons");
                });

            modelBuilder.Entity("dotnet.Models.Person", b =>
                {
                    b.Navigation("hoadons");
                });
#pragma warning restore 612, 618
        }
    }
}
