﻿// <auto-generated />
using System;
using HomeOrganiser.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace HomeOrganiser.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("HomeOrganiser.Core.Entities.Utility", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("ID");

                    b.Property<DateTime?>("ContractEndDate")
                        .IsRequired()
                        .HasColumnType("datetime2");

                    b.Property<int?>("ContractLength")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<DateTime?>("CreatedOn")
                        .HasColumnType("datetime");

                    b.Property<float?>("CurrentPrice")
                        .IsRequired()
                        .HasColumnType("real");

                    b.Property<DateTime?>("ModifiedOn")
                        .HasColumnType("datetime");

                    b.Property<int?>("NotificationTime")
                        .HasColumnType("int");

                    b.Property<string>("Provider")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("UtilityType")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Utilities", (string)null);
                });
#pragma warning restore 612, 618
        }
    }
}
