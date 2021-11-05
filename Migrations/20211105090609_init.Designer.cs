﻿// <auto-generated />
using System;
using InvenManager.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace InvenManager.Migrations
{
    [DbContext(typeof(InvenManagerContext))]
    [Migration("20211105090609_init")]
    partial class init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0-rc.2.21480.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("InvenManager.Models.Owner", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Owner");
                });

            modelBuilder.Entity("InvenManager.wwwroot.Models.AssetModel", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<DateTime>("AcquiredDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("AllocatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Category")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("InStock")
                        .HasColumnType("bit");

                    b.Property<string>("Item")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<int?>("OwnerID")
                        .HasColumnType("int");

                    b.Property<string>("SerialNo")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("OwnerID");

                    b.ToTable("AssetModel");
                });

            modelBuilder.Entity("InvenManager.wwwroot.Models.AssetModel", b =>
                {
                    b.HasOne("InvenManager.Models.Owner", "Owner")
                        .WithMany()
                        .HasForeignKey("OwnerID");

                    b.Navigation("Owner");
                });
#pragma warning restore 612, 618
        }
    }
}