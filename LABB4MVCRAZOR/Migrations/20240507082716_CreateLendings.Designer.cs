﻿// <auto-generated />
using System;
using LABB4MVCRAZOR.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace LABB4MVCRAZOR.Migrations
{
    [DbContext(typeof(MvcRazorDbContext))]
    [Migration("20240507082716_CreateLendings")]
    partial class CreateLendings
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("LABB4MVCRAZOR.Models.Book", b =>
                {
                    b.Property<int>("BookId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("BookId"));

                    b.Property<string>("Author")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PublicationYear")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("BookId");

                    b.ToTable("Books");

                    b.HasData(
                        new
                        {
                            BookId = 1,
                            Author = "Evelyn Larson",
                            PublicationYear = 1996,
                            Title = "A day in the country"
                        },
                        new
                        {
                            BookId = 2,
                            Author = "Lily.P",
                            PublicationYear = 1990,
                            Title = "The Dog's Preference: A Human's Guide"
                        },
                        new
                        {
                            BookId = 3,
                            Author = "Ella Hermansson",
                            PublicationYear = 2000,
                            Title = "Lovely Life of Ella"
                        },
                        new
                        {
                            BookId = 4,
                            Author = "Fredrick Allingås",
                            PublicationYear = 2005,
                            Title = "Coding Mastery in a Month"
                        },
                        new
                        {
                            BookId = 5,
                            Author = "Eva Rönnberg",
                            PublicationYear = 2010,
                            Title = "Food History"
                        },
                        new
                        {
                            BookId = 6,
                            Author = "Liv Bergman",
                            PublicationYear = 1967,
                            Title = "Survive In The Forest"
                        },
                        new
                        {
                            BookId = 7,
                            Author = "Gunnar Olsen",
                            PublicationYear = 2015,
                            Title = "Fishing Guide"
                        },
                        new
                        {
                            BookId = 8,
                            Author = "Malin Gullikson",
                            PublicationYear = 2006,
                            Title = "How to Saving Money"
                        },
                        new
                        {
                            BookId = 9,
                            Author = "Tobbe Trollkarl",
                            PublicationYear = 2001,
                            Title = "Abrakadabra"
                        });
                });

            modelBuilder.Entity("LABB4MVCRAZOR.Models.Customer", b =>
                {
                    b.Property<int>("CustomerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CustomerId"));

                    b.Property<string>("CustomerName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CustomerId");

                    b.ToTable("Customers");

                    b.HasData(
                        new
                        {
                            CustomerId = 1,
                            CustomerName = "Viktoria Wallström",
                            Email = "viktoria-wallstrom@hotmail.com",
                            PhoneNumber = "0701234567"
                        },
                        new
                        {
                            CustomerId = 2,
                            CustomerName = "Nelly Nordlund",
                            Email = "nellynordlund@gmail.com",
                            PhoneNumber = "0702345678"
                        },
                        new
                        {
                            CustomerId = 3,
                            CustomerName = "Kelly Olsson",
                            Email = "kellyolsson@hotmail.com",
                            PhoneNumber = "0703456789"
                        });
                });

            modelBuilder.Entity("LABB4MVCRAZOR.Models.Lending", b =>
                {
                    b.Property<int>("LendingId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("LendingId"));

                    b.Property<int>("BookId")
                        .HasColumnType("int");

                    b.Property<int>("CustomerId")
                        .HasColumnType("int");

                    b.Property<DateTime>("LendDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("ReturnDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("Returned")
                        .HasColumnType("bit");

                    b.HasKey("LendingId");

                    b.HasIndex("BookId");

                    b.HasIndex("CustomerId");

                    b.ToTable("Lendings");

                    b.HasData(
                        new
                        {
                            LendingId = 1,
                            BookId = 1,
                            CustomerId = 1,
                            LendDate = new DateTime(2024, 4, 20, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ReturnDate = new DateTime(2024, 4, 28, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Returned = true
                        },
                        new
                        {
                            LendingId = 2,
                            BookId = 2,
                            CustomerId = 1,
                            LendDate = new DateTime(2024, 4, 20, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ReturnDate = new DateTime(2024, 4, 28, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Returned = false
                        },
                        new
                        {
                            LendingId = 3,
                            BookId = 3,
                            CustomerId = 2,
                            LendDate = new DateTime(2024, 4, 18, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ReturnDate = new DateTime(2024, 4, 26, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Returned = true
                        },
                        new
                        {
                            LendingId = 4,
                            BookId = 4,
                            CustomerId = 3,
                            LendDate = new DateTime(2024, 4, 25, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ReturnDate = new DateTime(2024, 5, 2, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Returned = false
                        },
                        new
                        {
                            LendingId = 5,
                            BookId = 5,
                            CustomerId = 4,
                            LendDate = new DateTime(2024, 5, 7, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ReturnDate = new DateTime(2024, 5, 22, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Returned = false
                        },
                        new
                        {
                            LendingId = 6,
                            BookId = 6,
                            CustomerId = 4,
                            LendDate = new DateTime(2024, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ReturnDate = new DateTime(2024, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Returned = false
                        },
                        new
                        {
                            LendingId = 7,
                            BookId = 7,
                            CustomerId = 5,
                            LendDate = new DateTime(2024, 5, 2, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ReturnDate = new DateTime(2024, 5, 19, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Returned = false
                        },
                        new
                        {
                            LendingId = 8,
                            BookId = 8,
                            CustomerId = 5,
                            LendDate = new DateTime(2024, 4, 20, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ReturnDate = new DateTime(2024, 5, 6, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Returned = true
                        },
                        new
                        {
                            LendingId = 9,
                            BookId = 9,
                            CustomerId = 6,
                            LendDate = new DateTime(2024, 4, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ReturnDate = new DateTime(2024, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Returned = true
                        });
                });

            modelBuilder.Entity("LABB4MVCRAZOR.Models.Lending", b =>
                {
                    b.HasOne("LABB4MVCRAZOR.Models.Book", "Book")
                        .WithMany()
                        .HasForeignKey("BookId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("LABB4MVCRAZOR.Models.Customer", "Customer")
                        .WithMany()
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Book");

                    b.Navigation("Customer");
                });
#pragma warning restore 612, 618
        }
    }
}
