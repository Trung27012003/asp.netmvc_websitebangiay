﻿// <auto-generated />
using System;
using Assignment.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Assignment.Migrations
{
    [DbContext(typeof(DbContexts))]
    [Migration("20230407034249_migration")]
    partial class migration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Assignment.Models.Bill", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatDate")
                        .HasColumnType("Datetime");

                    b.Property<double>("Discount")
                        .HasColumnType("float");

                    b.Property<string>("RecipientAddress")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("RecipientName")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("RecipientPhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("ShippingFee")
                        .HasColumnType("int");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<int>("TotalAmout")
                        .HasColumnType("int");

                    b.Property<Guid>("UserID")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("ID");

                    b.HasIndex("UserID");

                    b.ToTable("HoaDon", (string)null);
                });

            modelBuilder.Entity("Assignment.Models.BillDetail", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Color")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.Property<Guid>("IDHD")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("IDSP")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Image")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<int>("Size")
                        .HasColumnType("int");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("ID");

                    b.HasIndex("IDHD");

                    b.HasIndex("IDSP");

                    b.ToTable("HoaDonChiTiet", (string)null);
                });

            modelBuilder.Entity("Assignment.Models.Cart", b =>
                {
                    b.Property<Guid>("UserID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(1000)");

                    b.HasKey("UserID");

                    b.ToTable("GioHang", (string)null);
                });

            modelBuilder.Entity("Assignment.Models.CartDetail", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Color")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.Property<Guid>("IDSP")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Image")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<int>("Size")
                        .HasColumnType("int");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.Property<Guid>("UserID")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("ID");

                    b.HasIndex("IDSP");

                    b.HasIndex("UserID");

                    b.ToTable("GioHangChiTiet", (string)null);
                });

            modelBuilder.Entity("Assignment.Models.CouponCode", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CouponCodes")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.Property<double>("CouponValue")
                        .HasColumnType("float");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.ToTable("MaGiamGia", (string)null);
                });

            modelBuilder.Entity("Assignment.Models.CouponCodeDetails", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CouponCodeID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CouponValue")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.Property<Guid>("ProductID")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("ID");

                    b.HasIndex("CouponCodeID");

                    b.HasIndex("ProductID");

                    b.ToTable("MaGiamGiaChiTiet", (string)null);
                });

            modelBuilder.Entity("Assignment.Models.Product", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("AvailableQuantity")
                        .HasColumnType("int");

                    b.Property<string>("Color")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(1000)");

                    b.Property<string>("Image")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Image1")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Image2")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Image3")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Image4")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Image5")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.Property<int>("Size")
                        .HasColumnType("int");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<string>("Supplier")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("ID");

                    b.ToTable("SanPham", (string)null);
                });

            modelBuilder.Entity("Assignment.Models.Role", b =>
                {
                    b.Property<Guid>("RoleID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleName")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.HasKey("RoleID");

                    b.ToTable("Role", (string)null);
                });

            modelBuilder.Entity("Assignment.Models.User", b =>
                {
                    b.Property<Guid>("UserID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Avata")
                        .IsRequired()
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(256)");

                    b.Property<Guid>("RoleID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("UserID");

                    b.HasIndex("RoleID");

                    b.ToTable("User", (string)null);
                });

            modelBuilder.Entity("Assignment.Models.Bill", b =>
                {
                    b.HasOne("Assignment.Models.User", "User")
                        .WithMany("Bills")
                        .HasForeignKey("UserID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("Assignment.Models.BillDetail", b =>
                {
                    b.HasOne("Assignment.Models.Bill", "Bill")
                        .WithMany("BillDetails")
                        .HasForeignKey("IDHD")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Assignment.Models.Product", "Product")
                        .WithMany("BillDetails")
                        .HasForeignKey("IDSP")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Bill");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("Assignment.Models.Cart", b =>
                {
                    b.HasOne("Assignment.Models.User", "User")
                        .WithOne()
                        .HasForeignKey("Assignment.Models.Cart", "UserID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("Assignment.Models.CartDetail", b =>
                {
                    b.HasOne("Assignment.Models.Product", "Product")
                        .WithMany("CartDetails")
                        .HasForeignKey("IDSP")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Assignment.Models.Cart", "Cart")
                        .WithMany("CartDetails")
                        .HasForeignKey("UserID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cart");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("Assignment.Models.CouponCodeDetails", b =>
                {
                    b.HasOne("Assignment.Models.CouponCode", "CouponCode")
                        .WithMany("CouponCodeDetails")
                        .HasForeignKey("CouponCodeID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Assignment.Models.Product", "Product")
                        .WithMany("CouponCodeDetails")
                        .HasForeignKey("ProductID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CouponCode");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("Assignment.Models.User", b =>
                {
                    b.HasOne("Assignment.Models.Role", "Role")
                        .WithMany("Users")
                        .HasForeignKey("RoleID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Role");
                });

            modelBuilder.Entity("Assignment.Models.Bill", b =>
                {
                    b.Navigation("BillDetails");
                });

            modelBuilder.Entity("Assignment.Models.Cart", b =>
                {
                    b.Navigation("CartDetails");
                });

            modelBuilder.Entity("Assignment.Models.CouponCode", b =>
                {
                    b.Navigation("CouponCodeDetails");
                });

            modelBuilder.Entity("Assignment.Models.Product", b =>
                {
                    b.Navigation("BillDetails");

                    b.Navigation("CartDetails");

                    b.Navigation("CouponCodeDetails");
                });

            modelBuilder.Entity("Assignment.Models.Role", b =>
                {
                    b.Navigation("Users");
                });

            modelBuilder.Entity("Assignment.Models.User", b =>
                {
                    b.Navigation("Bills");
                });
#pragma warning restore 612, 618
        }
    }
}