﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Pandemic_MIS.Services.OrganizationManagementAPI.Data;

#nullable disable

namespace Pandemic_MIS.Services.OrganizationManagementAPI.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20240125074046_SeedDataToPandemicContactsTable")]
    partial class SeedDataToPandemicContactsTable
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Pandemic_MIS.Services.OrganizationManagementAPI.Models.Organization", b =>
                {
                    b.Property<int>("OrganizationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("OrganizationId"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ContactName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("OrganizationName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OrganizationType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PhoneNumber")
                        .HasColumnType("int");

                    b.HasKey("OrganizationId");

                    b.ToTable("Organizations");

                    b.HasData(
                        new
                        {
                            OrganizationId = 1,
                            Address = "Test Address 1",
                            ContactName = "Test 1",
                            CreatedBy = "ad_rpeiris",
                            CreatedDate = new DateTime(2024, 1, 25, 13, 10, 45, 602, DateTimeKind.Local).AddTicks(6701),
                            Email = "Test1@gmail.com",
                            IsActive = true,
                            OrganizationName = "Organization 1",
                            OrganizationType = "Organization Type 1",
                            PhoneNumber = 112637483
                        },
                        new
                        {
                            OrganizationId = 2,
                            Address = "Test Address 2",
                            ContactName = "Test 2",
                            CreatedBy = "ad_rpeiris",
                            CreatedDate = new DateTime(2024, 1, 25, 13, 10, 45, 602, DateTimeKind.Local).AddTicks(6823),
                            Email = "Test2@gmail.com",
                            IsActive = true,
                            OrganizationName = "Organization 2",
                            OrganizationType = "Organization Type 2",
                            PhoneNumber = 112637487
                        });
                });

            modelBuilder.Entity("Pandemic_MIS.Services.OrganizationManagementAPI.Models.PandemicContact", b =>
                {
                    b.Property<int>("PandemicContactId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PandemicContactId"));

                    b.Property<DateTime>("CheckInTime")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("CheckOutTime")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NicNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("OrganizationId")
                        .HasColumnType("int");

                    b.Property<int>("PhoneNumber")
                        .HasColumnType("int");

                    b.HasKey("PandemicContactId");

                    b.ToTable("PandemicContacts");

                    b.HasData(
                        new
                        {
                            PandemicContactId = 1,
                            CheckInTime = new DateTime(2024, 1, 25, 13, 10, 45, 602, DateTimeKind.Local).AddTicks(6849),
                            CheckOutTime = new DateTime(2024, 1, 25, 13, 10, 45, 602, DateTimeKind.Local).AddTicks(6849),
                            CreatedDate = new DateTime(2024, 1, 25, 13, 10, 45, 602, DateTimeKind.Local).AddTicks(6851),
                            Name = "Nisha Perera",
                            NicNumber = "934455522V",
                            OrganizationId = 1,
                            PhoneNumber = 778364772
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
