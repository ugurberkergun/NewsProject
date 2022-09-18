﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using NewsProject.DAL.Concreate.EntityFramework.DbContexts;

#nullable disable

namespace NewsProject.DAL.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20220918185349_initial")]
    partial class initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Core.Entities.Concreate.OperationClaim", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("varchar(500)");

                    b.HasKey("Id");

                    b.ToTable("OperationClaims");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Admin"
                        });
                });

            modelBuilder.Entity("Core.Entities.Concreate.UserOperationClaim", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int?>("OperationClaimId")
                        .HasColumnType("int");

                    b.Property<int?>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("UserOperationClaims");
                });

            modelBuilder.Entity("NewsProject.Core.Entities.Concreate.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<byte[]>("PasswordHash")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("varbinary(500)");

                    b.Property<byte[]>("PasswordSalt")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("varbinary(500)");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("NewsProject.Entities.Concreate.News", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<int>("NewsCategoryId")
                        .HasColumnType("int");

                    b.Property<string>("NewsContext")
                        .IsRequired()
                        .HasMaxLength(1200)
                        .HasColumnType("nvarchar(1200)");

                    b.Property<string>("NewsHeader")
                        .IsRequired()
                        .HasMaxLength(70)
                        .HasColumnType("nvarchar(70)");

                    b.Property<string>("PhotoUrl")
                        .IsRequired()
                        .HasMaxLength(300)
                        .HasColumnType("nvarchar(300)");

                    b.HasKey("Id");

                    b.HasIndex("NewsCategoryId");

                    b.ToTable("News");
                });

            modelBuilder.Entity("NewsProject.Entities.Concreate.NewsCategory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasMaxLength(70)
                        .HasColumnType("nvarchar(70)");

                    b.HasKey("Id");

                    b.ToTable("NewsCategories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryName = "Ekonomi"
                        },
                        new
                        {
                            Id = 2,
                            CategoryName = "Spor"
                        },
                        new
                        {
                            Id = 3,
                            CategoryName = "Magazin"
                        },
                        new
                        {
                            Id = 4,
                            CategoryName = "Turizm"
                        },
                        new
                        {
                            Id = 5,
                            CategoryName = "Dünya"
                        });
                });

            modelBuilder.Entity("NewsProject.Entities.Concreate.News", b =>
                {
                    b.HasOne("NewsProject.Entities.Concreate.NewsCategory", "NewsCategory")
                        .WithMany("News")
                        .HasForeignKey("NewsCategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("NewsCategory");
                });

            modelBuilder.Entity("NewsProject.Entities.Concreate.NewsCategory", b =>
                {
                    b.Navigation("News");
                });
#pragma warning restore 612, 618
        }
    }
}
