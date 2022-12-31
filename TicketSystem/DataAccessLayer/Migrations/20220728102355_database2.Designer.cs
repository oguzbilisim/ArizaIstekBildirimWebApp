﻿// <auto-generated />
using System;
using DataAccessLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DataAccessLayer.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20220728102355_database2")]
    partial class database2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.9")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("EntityLayer.Concrete.employeeinfo", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("LevelID")
                        .HasColumnType("int");

                    b.Property<int>("StatusID")
                        .HasColumnType("int");

                    b.Property<int>("UnitNameID")
                        .HasColumnType("int");

                    b.Property<DateTime?>("date")
                        .HasColumnType("datetime2");

                    b.Property<string>("description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("feedback")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("titleID")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("LevelID");

                    b.HasIndex("StatusID");

                    b.HasIndex("UnitNameID");

                    b.HasIndex("titleID");

                    b.ToTable("employeeinfos");
                });

            modelBuilder.Entity("EntityLayer.Concrete.level", b =>
                {
                    b.Property<int>("LevelID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("LevelName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("LevelID");

                    b.ToTable("levels");
                });

            modelBuilder.Entity("EntityLayer.Concrete.request", b =>
                {
                    b.Property<int>("RequestID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("RequestDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RequestRdoBtn")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("RequestID");

                    b.ToTable("requests");
                });

            modelBuilder.Entity("EntityLayer.Concrete.status", b =>
                {
                    b.Property<int>("StatusID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("StatusName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("StatusID");

                    b.ToTable("statuss");
                });

            modelBuilder.Entity("EntityLayer.Concrete.title", b =>
                {
                    b.Property<int>("TitleID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("TitleName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TitleID");

                    b.ToTable("titles");
                });

            modelBuilder.Entity("EntityLayer.Concrete.unitname", b =>
                {
                    b.Property<int>("UnitNameID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("UnitName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UnitNameID");

                    b.ToTable("unitnames");
                });

            modelBuilder.Entity("EntityLayer.Concrete.employeeinfo", b =>
                {
                    b.HasOne("EntityLayer.Concrete.level", "level")
                        .WithMany("employeeinfos")
                        .HasForeignKey("LevelID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EntityLayer.Concrete.status", "status")
                        .WithMany("employeeinfos")
                        .HasForeignKey("StatusID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EntityLayer.Concrete.unitname", "unitname")
                        .WithMany("employeeinfos")
                        .HasForeignKey("UnitNameID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EntityLayer.Concrete.title", "title")
                        .WithMany("employeeinfos")
                        .HasForeignKey("titleID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("level");

                    b.Navigation("status");

                    b.Navigation("title");

                    b.Navigation("unitname");
                });

            modelBuilder.Entity("EntityLayer.Concrete.level", b =>
                {
                    b.Navigation("employeeinfos");
                });

            modelBuilder.Entity("EntityLayer.Concrete.status", b =>
                {
                    b.Navigation("employeeinfos");
                });

            modelBuilder.Entity("EntityLayer.Concrete.title", b =>
                {
                    b.Navigation("employeeinfos");
                });

            modelBuilder.Entity("EntityLayer.Concrete.unitname", b =>
                {
                    b.Navigation("employeeinfos");
                });
#pragma warning restore 612, 618
        }
    }
}
