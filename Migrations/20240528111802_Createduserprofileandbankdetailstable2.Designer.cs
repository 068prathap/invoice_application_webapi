﻿// <auto-generated />
using System;
using InvoiceApplication.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace InvoiceApplication.Migrations
{
    [DbContext(typeof(InvoiceAppContext))]
    [Migration("20240528111802_Createduserprofileandbankdetailstable2")]
    partial class Createduserprofileandbankdetailstable2
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("InvoiceApplication.Models.BillsList", b =>
                {
                    b.Property<int>("InvoiceId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("InvoiceId"));

                    b.Property<decimal>("CGSTAmount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("CGSTPercentage")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("ClientId")
                        .HasColumnType("int");

                    b.Property<decimal>("FinalTotalAmount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateOnly>("InvoiceDate")
                        .HasColumnType("date");

                    b.Property<decimal>("RoundOff")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("SGSTAmount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("SGSTPercentage")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("TotalAmount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("TranspotationId")
                        .HasColumnType("int");

                    b.HasKey("InvoiceId");

                    b.HasIndex("ClientId");

                    b.HasIndex("TranspotationId");

                    b.ToTable("BillsList");
                });

            modelBuilder.Entity("InvoiceApplication.Models.ClientsList", b =>
                {
                    b.Property<int>("ClientId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ClientId"));

                    b.Property<string>("ClientAddress")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClientGSTNo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClientName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ClientId");

                    b.ToTable("ClientsList");
                });

            modelBuilder.Entity("InvoiceApplication.Models.InvoiceProductDetails", b =>
                {
                    b.Property<int>("ProductDetailsId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ProductDetailsId"));

                    b.Property<int>("ClientHSNCode")
                        .HasColumnType("int");

                    b.Property<int>("InvoiceId")
                        .HasColumnType("int");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("ProductQuantity")
                        .HasColumnType("int");

                    b.Property<decimal>("ProductRate")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("ProductTotalAmount")
                        .HasColumnType("int");

                    b.HasKey("ProductDetailsId");

                    b.HasIndex("InvoiceId");

                    b.HasIndex("ProductId");

                    b.ToTable("InvoiceProductDetails");
                });

            modelBuilder.Entity("InvoiceApplication.Models.ProductsList", b =>
                {
                    b.Property<int>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ProductId"));

                    b.Property<string>("ProductName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ProductId");

                    b.ToTable("ProductsList");
                });

            modelBuilder.Entity("InvoiceApplication.Models.TranspotationDetails", b =>
                {
                    b.Property<int>("TranspotationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TranspotationId"));

                    b.Property<DateOnly>("TranspotationDate")
                        .HasColumnType("date");

                    b.Property<string>("TranspotationMode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<TimeOnly>("TranspotationTime")
                        .HasColumnType("time");

                    b.Property<string>("TranspotationVehicleNo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TranspotationId");

                    b.ToTable("TranspotationDetails");
                });

            modelBuilder.Entity("InvoiceApplication.Models.UserBankDetails", b =>
                {
                    b.Property<int>("BankDetailsId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("BankDetailsId"));

                    b.Property<string>("BankAccountNo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BankBranch")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BankName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IFSCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("BankDetailsId");

                    b.ToTable("UserBankDetails");
                });

            modelBuilder.Entity("InvoiceApplication.Models.UsersList", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UserId"));

                    b.Property<string>("UserEmail")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserPassword")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserPhone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserTextileName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId");

                    b.ToTable("UsersList");
                });

            modelBuilder.Entity("InvoiceApplication.Models.UsersProfile", b =>
                {
                    b.Property<int>("ProfileId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ProfileId"));

                    b.Property<int>("BankDetailsId")
                        .HasColumnType("int");

                    b.Property<string>("UserAddress")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserGSTNo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("ProfileId");

                    b.HasIndex("BankDetailsId");

                    b.HasIndex("UserId");

                    b.ToTable("UsersProfile");
                });

            modelBuilder.Entity("InvoiceApplication.Models.BillsList", b =>
                {
                    b.HasOne("InvoiceApplication.Models.ClientsList", "ClientsList")
                        .WithMany()
                        .HasForeignKey("ClientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("InvoiceApplication.Models.TranspotationDetails", "TranspotationDetails")
                        .WithMany()
                        .HasForeignKey("TranspotationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ClientsList");

                    b.Navigation("TranspotationDetails");
                });

            modelBuilder.Entity("InvoiceApplication.Models.InvoiceProductDetails", b =>
                {
                    b.HasOne("InvoiceApplication.Models.BillsList", "BillsList")
                        .WithMany()
                        .HasForeignKey("InvoiceId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("InvoiceApplication.Models.ProductsList", "ProductsList")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("BillsList");

                    b.Navigation("ProductsList");
                });

            modelBuilder.Entity("InvoiceApplication.Models.UsersProfile", b =>
                {
                    b.HasOne("InvoiceApplication.Models.UserBankDetails", "UserBankDetails")
                        .WithMany()
                        .HasForeignKey("BankDetailsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("InvoiceApplication.Models.UsersList", "UsersList")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("UserBankDetails");

                    b.Navigation("UsersList");
                });
#pragma warning restore 612, 618
        }
    }
}
