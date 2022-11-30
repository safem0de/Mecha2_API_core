﻿// <auto-generated />
using System;
using Mecha2_API_core.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Mecha2_API_core.Migrations
{
    [DbContext(typeof(ApiDbContext))]
    partial class ApiDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Mecha2_API_core.Models.Issue", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("EmployeeNo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("IssueDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("LotNo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Issues");
                });

            modelBuilder.Entity("Mecha2_API_core.Models.IssueDetail", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("DrawingNo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("IssueId")
                        .HasColumnType("int");

                    b.Property<string>("ItemNo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LotNo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<string>("SAPNo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("WOSNo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("IssueId");

                    b.ToTable("IssueDetails");
                });

            modelBuilder.Entity("Mecha2_API_core.Models.IssueDetail", b =>
                {
                    b.HasOne("Mecha2_API_core.Models.Issue", null)
                        .WithMany("IssueDetails")
                        .HasForeignKey("IssueId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Mecha2_API_core.Models.Issue", b =>
                {
                    b.Navigation("IssueDetails");
                });
#pragma warning restore 612, 618
        }
    }
}
