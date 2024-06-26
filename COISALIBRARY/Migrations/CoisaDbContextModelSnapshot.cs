﻿// <auto-generated />
using System;
using COISALIBRARY.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace COISALIBRARY.Migrations
{
    [DbContext(typeof(CoisaDbContext))]
    partial class CoisaDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("COISALIBRARY.Models.Items", b =>
                {
                    b.Property<string>("strItemId")
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<bool>("isdeleted")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("strCategoryId")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("strDesc")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("strItemName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("strPhoto")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<double>("strPreviousPrice")
                        .HasColumnType("double");

                    b.Property<double>("strPrice")
                        .HasColumnType("double");

                    b.Property<double>("strQty")
                        .HasColumnType("double");

                    b.HasKey("strItemId");

                    b.ToTable("items");
                });

            modelBuilder.Entity("COISALIBRARY.Models.OrderItems", b =>
                {
                    b.Property<string>("id")
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<bool>("isdeleted")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("strImageUrl")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("strName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("strOrderId")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<double>("strPrice")
                        .HasColumnType("double");

                    b.Property<double>("strQty")
                        .HasColumnType("double");

                    b.HasKey("id");

                    b.ToTable("orderItems");
                });

            modelBuilder.Entity("COISALIBRARY.Models.Orders", b =>
                {
                    b.Property<string>("strOderId")
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("County")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Region")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<double>("amount")
                        .HasColumnType("double");

                    b.Property<DateTime>("date")
                        .HasColumnType("datetime(6)");

                    b.Property<bool>("isdeleted")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("order_no")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<bool>("shipped_status")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("strphone")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("user_id")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("strOderId");

                    b.ToTable("orders");
                });

            modelBuilder.Entity("COISALIBRARY.Models.Product_Category", b =>
                {
                    b.Property<string>("strId")
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<bool>("Isdeleted")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("strCatName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("strCatPhoto")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("strId");

                    b.ToTable("product_Categories");
                });

            modelBuilder.Entity("COISALIBRARY.Models.Users", b =>
                {
                    b.Property<string>("strUserId")
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<int>("Role")
                        .HasColumnType("int");

                    b.Property<string>("password")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("strEmail")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("strPhone")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("strUsername")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("strUserId");

                    b.ToTable("users");
                });
#pragma warning restore 612, 618
        }
    }
}
