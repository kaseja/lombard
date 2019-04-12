﻿// <auto-generated />
using System;
using Lombard.DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Lombard.DAL.Migrations
{
    [DbContext(typeof(EFDbContext))]
    [Migration("20190412214021_init")]
    partial class init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.0-rtm-30799");

            modelBuilder.Entity("Lombard.DAL.Models.Customer", b =>
                {
                    b.Property<int>("CustomerID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("FirstName");

                    b.Property<string>("LastName");

                    b.HasKey("CustomerID");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("Lombard.DAL.Models.Employee", b =>
                {
                    b.Property<int>("EmployeeID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("FirstName");

                    b.Property<string>("LastName");

                    b.HasKey("EmployeeID");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("Lombard.DAL.Models.Item", b =>
                {
                    b.Property<int>("ItemId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.Property<decimal>("PurchasePrice");

                    b.Property<double>("Quantity");

                    b.Property<decimal>("SellingPrice");

                    b.Property<int?>("TransactionId");

                    b.Property<string>("Unit");

                    b.HasKey("ItemId");

                    b.HasIndex("TransactionId");

                    b.ToTable("Items");
                });

            modelBuilder.Entity("Lombard.DAL.Models.Report", b =>
                {
                    b.Property<int>("ReportId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Stock");

                    b.Property<double>("TotalProfit");

                    b.Property<double>("TotalRotation");

                    b.HasKey("ReportId");

                    b.ToTable("Reports");
                });

            modelBuilder.Entity("Lombard.DAL.Models.Transaction", b =>
                {
                    b.Property<int>("TransactionId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CustomerId");

                    b.Property<int>("EmployeeId");

                    b.Property<DateTime>("TransactionDate");

                    b.Property<int>("TransactionType");

                    b.HasKey("TransactionId");

                    b.HasIndex("CustomerId");

                    b.HasIndex("EmployeeId");

                    b.ToTable("Transactions");
                });

            modelBuilder.Entity("Lombard.DAL.Models.Item", b =>
                {
                    b.HasOne("Lombard.DAL.Models.Transaction")
                        .WithMany("Items")
                        .HasForeignKey("TransactionId");
                });

            modelBuilder.Entity("Lombard.DAL.Models.Transaction", b =>
                {
                    b.HasOne("Lombard.DAL.Models.Customer", "Customer")
                        .WithMany()
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Lombard.DAL.Models.Employee", "Employee")
                        .WithMany()
                        .HasForeignKey("EmployeeId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
