﻿// <auto-generated />
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
    [Migration("20231212174046_AddNewOrganizationManagementToDb")]
    partial class AddNewOrganizationManagementToDb
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
                            Email = "Test2@gmail.com",
                            IsActive = true,
                            OrganizationName = "Organization 2",
                            OrganizationType = "Organization Type 2",
                            PhoneNumber = 112637487
                        });
                });
#pragma warning restore 612, 618
        }
    }
}