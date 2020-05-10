﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MyAppBack.Data;

namespace MyAppBack.Migrations
{
    [DbContext(typeof(DataDbContext))]
    [Migration("20200504205439_NewM2")]
    partial class NewM2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.1");

            modelBuilder.Entity("MyAppBack.Models.Item", b =>
                {
                    b.Property<int>("ItemId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("Counter")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("EnrolledDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("Link")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("LinkName")
                        .HasColumnType("TEXT");

                    b.Property<string>("QrPath")
                        .HasColumnType("TEXT");

                    b.Property<string>("ShortLink")
                        .HasColumnType("TEXT");

                    b.Property<string>("Token")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("UserId")
                        .HasColumnType("INTEGER");

                    b.HasKey("ItemId");

                    b.ToTable("Items");
                });

            modelBuilder.Entity("MyAppBack.Models.MainPageProduct", b =>
                {
                    b.Property<int>("MainPageProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime?>("EnrolledDate")
                        .HasColumnType("TEXT");

                    b.Property<int>("GuId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("PictureUrl")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<bool?>("ProductIsSelected")
                        .HasColumnType("INTEGER");

                    b.Property<int>("ProductPrice")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("ProductRegionId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("ProductTitle")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int?>("ProductTypeId")
                        .HasColumnType("INTEGER");

                    b.HasKey("MainPageProductId");

                    b.HasIndex("ProductRegionId");

                    b.HasIndex("ProductTypeId");

                    b.ToTable("MainPageProducts");
                });

            modelBuilder.Entity("MyAppBack.Models.OrderAggregate.DeliveryMethod", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("DeliveryTime")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Price")
                        .HasColumnType("INTEGER");

                    b.Property<string>("ShortName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("DeliveryMethods");
                });

            modelBuilder.Entity("MyAppBack.Models.OrderAggregate.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ByerEmail")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("DeliveryMethodId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTimeOffset>("OrderDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("PaymentIntentId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Subtotal")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("DeliveryMethodId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("MyAppBack.Models.OrderAggregate.OrderItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("OrderId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Price")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Quantity")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("OrderId");

                    b.ToTable("OrderItems");
                });

            modelBuilder.Entity("MyAppBack.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasMaxLength(200);

                    b.Property<DateTime?>("EnrolledDate")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int?>("GuId")
                        .IsRequired()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasMaxLength(100);

                    b.Property<string>("PictureUrl")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<bool?>("ProductIsSelected")
                        .HasColumnType("INTEGER");

                    b.Property<int>("ProductPrice")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("ProductRegionId")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("ProductTypeId")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("Quantity")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("ProductRegionId");

                    b.HasIndex("ProductTypeId");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("MyAppBack.Models.ProductRegion", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("ProductRegions");
                });

            modelBuilder.Entity("MyAppBack.Models.ProductType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("ProductTypes");
                });

            modelBuilder.Entity("MyAppBack.Models.MainPageProduct", b =>
                {
                    b.HasOne("MyAppBack.Models.ProductRegion", "ProductRegion")
                        .WithMany()
                        .HasForeignKey("ProductRegionId");

                    b.HasOne("MyAppBack.Models.ProductType", "ProductType")
                        .WithMany()
                        .HasForeignKey("ProductTypeId");
                });

            modelBuilder.Entity("MyAppBack.Models.OrderAggregate.Order", b =>
                {
                    b.HasOne("MyAppBack.Models.OrderAggregate.DeliveryMethod", "DeliveryMethod")
                        .WithMany()
                        .HasForeignKey("DeliveryMethodId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.OwnsOne("MyAppBack.Models.OrderAggregate.Address", "ShipToAddress", b1 =>
                        {
                            b1.Property<int>("OrderId")
                                .HasColumnType("INTEGER");

                            b1.Property<string>("City")
                                .IsRequired()
                                .HasColumnType("TEXT");

                            b1.Property<string>("FirstName")
                                .IsRequired()
                                .HasColumnType("TEXT");

                            b1.Property<string>("House")
                                .IsRequired()
                                .HasColumnType("TEXT");

                            b1.Property<string>("LastName")
                                .IsRequired()
                                .HasColumnType("TEXT");

                            b1.Property<string>("Street")
                                .IsRequired()
                                .HasColumnType("TEXT");

                            b1.Property<string>("ZipCode")
                                .IsRequired()
                                .HasColumnType("TEXT");

                            b1.HasKey("OrderId");

                            b1.ToTable("Orders");

                            b1.WithOwner()
                                .HasForeignKey("OrderId");
                        });
                });

            modelBuilder.Entity("MyAppBack.Models.OrderAggregate.OrderItem", b =>
                {
                    b.HasOne("MyAppBack.Models.OrderAggregate.Order", null)
                        .WithMany("OrderItems")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.OwnsOne("MyAppBack.Models.OrderAggregate.ProductItemOrdered", "ItemOrdered", b1 =>
                        {
                            b1.Property<int>("OrderItemId")
                                .HasColumnType("INTEGER");

                            b1.Property<string>("PictureUrl")
                                .IsRequired()
                                .HasColumnType("TEXT");

                            b1.Property<int>("ProductItemId")
                                .HasColumnType("INTEGER");

                            b1.Property<string>("ProductName")
                                .IsRequired()
                                .HasColumnType("TEXT");

                            b1.HasKey("OrderItemId");

                            b1.ToTable("OrderItems");

                            b1.WithOwner()
                                .HasForeignKey("OrderItemId");
                        });
                });

            modelBuilder.Entity("MyAppBack.Models.Product", b =>
                {
                    b.HasOne("MyAppBack.Models.ProductRegion", "ProductRegion")
                        .WithMany()
                        .HasForeignKey("ProductRegionId");

                    b.HasOne("MyAppBack.Models.ProductType", "ProductType")
                        .WithMany()
                        .HasForeignKey("ProductTypeId");
                });
#pragma warning restore 612, 618
        }
    }
}