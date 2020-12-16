﻿// <auto-generated />
using System;
using EmployeeSystem.Storage;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace EmploymentSystemMvc.Migrations
{
    [DbContext(typeof(ApplicationContext))]
    [Migration("20201211142310_InitDb")]
    partial class InitDb
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                .HasAnnotation("ProductVersion", "3.1.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("EmployeeSystem.Storage.EFModels.Concern", b =>
                {
                    b.Property<Guid>("ConcernId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<DateTime>("ConcernDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("ConcernRemarks")
                        .HasColumnType("text");

                    b.Property<string>("ConcernStatus")
                        .HasColumnType("text");

                    b.Property<string>("ConcernType")
                        .HasColumnType("text");

                    b.Property<Guid>("EmployeeId")
                        .HasColumnType("uuid");

                    b.HasKey("ConcernId");

                    b.HasIndex("EmployeeId");

                    b.ToTable("Concern");
                });

            modelBuilder.Entity("EmployeeSystem.Storage.EFModels.Employee", b =>
                {
                    b.Property<Guid>("EmployeeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Address")
                        .HasColumnType("text");

                    b.Property<DateTime>("DateofBirth")
                        .HasColumnType("timestamp without time zone");

                    b.Property<DateTime>("DateofJoining")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Designation")
                        .HasColumnType("text");

                    b.Property<string>("EmploymentType")
                        .HasColumnType("text");

                    b.Property<string>("Experience")
                        .HasColumnType("text");

                    b.Property<string>("FirstName")
                        .HasColumnType("text");

                    b.Property<string>("Gender")
                        .HasColumnType("text");

                    b.Property<string>("LastName")
                        .HasColumnType("text");

                    b.Property<string>("MobileNo")
                        .HasColumnType("text");

                    b.Property<string>("Qualification")
                        .HasColumnType("text");

                    b.HasKey("EmployeeId");

                    b.ToTable("Employee");
                });

            modelBuilder.Entity("EmployeeSystem.Storage.EFModels.Holiday", b =>
                {
                    b.Property<Guid>("HolidayId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Comments")
                        .HasColumnType("text");

                    b.Property<DateTime>("FromDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("HolidayName")
                        .HasColumnType("text");

                    b.Property<DateTime>("ToDate")
                        .HasColumnType("timestamp without time zone");

                    b.HasKey("HolidayId");

                    b.ToTable("Holiday");
                });

            modelBuilder.Entity("EmployeeSystem.Storage.EFModels.Leave", b =>
                {
                    b.Property<Guid>("LeaveId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<Guid>("EmployeeId")
                        .HasColumnType("uuid");

                    b.Property<DateTime>("FromDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("LeaveStatus")
                        .HasColumnType("text");

                    b.Property<string>("LeaveType")
                        .HasColumnType("text");

                    b.Property<string>("Reason")
                        .HasColumnType("text");

                    b.Property<DateTime>("ToDate")
                        .HasColumnType("timestamp without time zone");

                    b.HasKey("LeaveId");

                    b.HasIndex("EmployeeId");

                    b.ToTable("Leave");
                });

            modelBuilder.Entity("EmployeeSystem.Storage.EFModels.Concern", b =>
                {
                    b.HasOne("EmployeeSystem.Storage.EFModels.Employee", "Employee")
                        .WithMany()
                        .HasForeignKey("EmployeeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("EmployeeSystem.Storage.EFModels.Leave", b =>
                {
                    b.HasOne("EmployeeSystem.Storage.EFModels.Employee", "Employee")
                        .WithMany()
                        .HasForeignKey("EmployeeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
