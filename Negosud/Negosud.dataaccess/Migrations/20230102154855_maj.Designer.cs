﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Negosud.dataaccess;

#nullable disable

namespace Negosud.dataaccess.Migrations
{
    [DbContext(typeof(NegosudContext))]
    [Migration("20230102154855_maj")]
    partial class maj
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Negosud.dataaccess.Tables.CommandCustomer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<int>("Number")
                        .HasColumnType("int");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("CommandCustomers");
                });

            modelBuilder.Entity("Negosud.dataaccess.Tables.CommandSupplier", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<int>("Number")
                        .HasColumnType("int");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("CommandSuppliers");
                });

            modelBuilder.Entity("Negosud.dataaccess.Tables.Customer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("CommandCustomerId")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PhoneNumber")
                        .HasColumnType("int");

                    b.Property<string>("PhysicalAddress")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PostalCode")
                        .HasColumnType("int");

                    b.Property<string>("Town")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CommandCustomerId");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("Negosud.dataaccess.Tables.CustomerOrderContent", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<float>("BeforePriceTax")
                        .HasColumnType("real");

                    b.Property<int?>("CommandCustomerId")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<float>("Vat")
                        .HasColumnType("real");

                    b.HasKey("Id");

                    b.HasIndex("CommandCustomerId");

                    b.ToTable("CustomerOrderContents");
                });

            modelBuilder.Entity("Negosud.dataaccess.Tables.Family", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Families");
                });

            modelBuilder.Entity("Negosud.dataaccess.Tables.Item", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("CustomerId")
                        .HasColumnType("int");

                    b.Property<int?>("CustomerOrderContentId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ItemFamilyId")
                        .HasColumnType("int");

                    b.Property<int>("MinLimit")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Picture")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("PurchasePriceBT")
                        .HasColumnType("real");

                    b.Property<float>("SellingPriceBT")
                        .HasColumnType("real");

                    b.Property<int?>("StockMovementId")
                        .HasColumnType("int");

                    b.Property<int?>("SupplierId")
                        .HasColumnType("int");

                    b.Property<int?>("SupplierOrderContentId")
                        .HasColumnType("int");

                    b.Property<float>("Vat")
                        .HasColumnType("real");

                    b.Property<int>("YearItem")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CustomerId");

                    b.HasIndex("CustomerOrderContentId");

                    b.HasIndex("ItemFamilyId");

                    b.HasIndex("StockMovementId");

                    b.HasIndex("SupplierId");

                    b.HasIndex("SupplierOrderContentId");

                    b.ToTable("Items");
                });

            modelBuilder.Entity("Negosud.dataaccess.Tables.ReasonRegularization", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<bool>("Sense")
                        .HasColumnType("bit");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("ReasonRegularizations");
                });

            modelBuilder.Entity("Negosud.dataaccess.Tables.Regularization", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("Inventorist")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ReasonRegularizationId")
                        .HasColumnType("int");

                    b.Property<int?>("StockMovementId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ReasonRegularizationId");

                    b.HasIndex("StockMovementId");

                    b.ToTable("Regularizations");
                });

            modelBuilder.Entity("Negosud.dataaccess.Tables.StockMovement", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("StockMovements");
                });

            modelBuilder.Entity("Negosud.dataaccess.Tables.Supplier", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("CommandSupplierId")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PhoneNumber")
                        .HasColumnType("int");

                    b.Property<string>("PhysicalAddress")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PostalCode")
                        .HasColumnType("int");

                    b.Property<string>("Town")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CommandSupplierId");

                    b.ToTable("Suppliers");
                });

            modelBuilder.Entity("Negosud.dataaccess.Tables.SupplierOrderContent", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<float>("BeforePriceTax")
                        .HasColumnType("real");

                    b.Property<int?>("CommandSupplierId")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<float>("VAT")
                        .HasColumnType("real");

                    b.HasKey("Id");

                    b.HasIndex("CommandSupplierId");

                    b.ToTable("SupplierOrderContents");
                });

            modelBuilder.Entity("Negosud.dataaccess.Tables.Customer", b =>
                {
                    b.HasOne("Negosud.dataaccess.Tables.CommandCustomer", null)
                        .WithMany("Customers")
                        .HasForeignKey("CommandCustomerId");
                });

            modelBuilder.Entity("Negosud.dataaccess.Tables.CustomerOrderContent", b =>
                {
                    b.HasOne("Negosud.dataaccess.Tables.CommandCustomer", null)
                        .WithMany("CustomerOrderContents")
                        .HasForeignKey("CommandCustomerId");
                });

            modelBuilder.Entity("Negosud.dataaccess.Tables.Item", b =>
                {
                    b.HasOne("Negosud.dataaccess.Tables.Customer", null)
                        .WithMany("Items")
                        .HasForeignKey("CustomerId");

                    b.HasOne("Negosud.dataaccess.Tables.CustomerOrderContent", null)
                        .WithMany("Items")
                        .HasForeignKey("CustomerOrderContentId");

                    b.HasOne("Negosud.dataaccess.Tables.Family", "ItemFamily")
                        .WithMany("Items")
                        .HasForeignKey("ItemFamilyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Negosud.dataaccess.Tables.StockMovement", null)
                        .WithMany("Items")
                        .HasForeignKey("StockMovementId");

                    b.HasOne("Negosud.dataaccess.Tables.Supplier", null)
                        .WithMany("Items")
                        .HasForeignKey("SupplierId");

                    b.HasOne("Negosud.dataaccess.Tables.SupplierOrderContent", null)
                        .WithMany("Items")
                        .HasForeignKey("SupplierOrderContentId");

                    b.Navigation("ItemFamily");
                });

            modelBuilder.Entity("Negosud.dataaccess.Tables.Regularization", b =>
                {
                    b.HasOne("Negosud.dataaccess.Tables.ReasonRegularization", null)
                        .WithMany("Regularizations")
                        .HasForeignKey("ReasonRegularizationId");

                    b.HasOne("Negosud.dataaccess.Tables.StockMovement", null)
                        .WithMany("Regularizations")
                        .HasForeignKey("StockMovementId");
                });

            modelBuilder.Entity("Negosud.dataaccess.Tables.Supplier", b =>
                {
                    b.HasOne("Negosud.dataaccess.Tables.CommandSupplier", null)
                        .WithMany("Suppliers")
                        .HasForeignKey("CommandSupplierId");
                });

            modelBuilder.Entity("Negosud.dataaccess.Tables.SupplierOrderContent", b =>
                {
                    b.HasOne("Negosud.dataaccess.Tables.CommandSupplier", null)
                        .WithMany("SupplierOrderContents")
                        .HasForeignKey("CommandSupplierId");
                });

            modelBuilder.Entity("Negosud.dataaccess.Tables.CommandCustomer", b =>
                {
                    b.Navigation("CustomerOrderContents");

                    b.Navigation("Customers");
                });

            modelBuilder.Entity("Negosud.dataaccess.Tables.CommandSupplier", b =>
                {
                    b.Navigation("SupplierOrderContents");

                    b.Navigation("Suppliers");
                });

            modelBuilder.Entity("Negosud.dataaccess.Tables.Customer", b =>
                {
                    b.Navigation("Items");
                });

            modelBuilder.Entity("Negosud.dataaccess.Tables.CustomerOrderContent", b =>
                {
                    b.Navigation("Items");
                });

            modelBuilder.Entity("Negosud.dataaccess.Tables.Family", b =>
                {
                    b.Navigation("Items");
                });

            modelBuilder.Entity("Negosud.dataaccess.Tables.ReasonRegularization", b =>
                {
                    b.Navigation("Regularizations");
                });

            modelBuilder.Entity("Negosud.dataaccess.Tables.StockMovement", b =>
                {
                    b.Navigation("Items");

                    b.Navigation("Regularizations");
                });

            modelBuilder.Entity("Negosud.dataaccess.Tables.Supplier", b =>
                {
                    b.Navigation("Items");
                });

            modelBuilder.Entity("Negosud.dataaccess.Tables.SupplierOrderContent", b =>
                {
                    b.Navigation("Items");
                });
#pragma warning restore 612, 618
        }
    }
}
