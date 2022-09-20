﻿// <auto-generated />
using System;
using Labb1MVC_V3.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Labb1MVC_V3.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.28")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Labb1MVC_V3.Models.Book", b =>
                {
                    b.Property<int>("BookId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("BookAuthor")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BookName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("NumberOfBooksInStock")
                        .HasColumnType("int");

                    b.HasKey("BookId");

                    b.ToTable("Books");

                    b.HasData(
                        new
                        {
                            BookId = 1,
                            BookAuthor = "Golda Stokes",
                            BookName = "Bedfordshire",
                            Description = "Placeat autem veritatis id temporibus dolorum. Est est vel nulla nihil vero quia ipsam ipsam. Autem ea dolor. Odit aliquam vitae. Sint voluptatum reprehenderit.",
                            NumberOfBooksInStock = 1
                        },
                        new
                        {
                            BookId = 2,
                            BookAuthor = "Herminia Larson",
                            BookName = "deposit calculating Metrics",
                            Description = "Sunt neque sequi accusamus veniam aut. Nihil sapiente sit non. Blanditiis rerum autem rerum ut reiciendis cum. Qui nihil perspiciatis sint qui. Debitis voluptatem dolorem suscipit necessitatibus perspiciatis dicta doloribus non.",
                            NumberOfBooksInStock = 6
                        },
                        new
                        {
                            BookId = 3,
                            BookAuthor = "Antonia McLaughlin",
                            BookName = "extend didactic Practical Frozen Shoes",
                            Description = "Ipsam dignissimos ducimus voluptas molestiae. Ratione et ut qui atque. Aspernatur quaerat et nostrum nam excepturi totam tempore non nobis. Dolor nihil aut sunt. Fuga iusto quasi quia recusandae qui pariatur saepe dignissimos cumque. Porro et incidunt porro expedita ipsam voluptas ipsum.",
                            NumberOfBooksInStock = 6
                        },
                        new
                        {
                            BookId = 4,
                            BookAuthor = "Loma Green",
                            BookName = "Auto Loan Account Connecticut scalable",
                            Description = "Quam dolor voluptatem doloribus et expedita. Asperiores minima voluptate id nulla. At placeat est exercitationem delectus dolores et aspernatur quo exercitationem. Asperiores dolorum excepturi vitae.",
                            NumberOfBooksInStock = 5
                        },
                        new
                        {
                            BookId = 5,
                            BookAuthor = "Chase Grady",
                            BookName = "Phased",
                            Description = "Repudiandae labore sint alias eaque sit saepe. Et repellendus pariatur nihil autem distinctio. Distinctio autem ea quia qui rerum a.",
                            NumberOfBooksInStock = 7
                        },
                        new
                        {
                            BookId = 6,
                            BookAuthor = "Clarabelle Collier",
                            BookName = "Intelligent Plastic Ball",
                            Description = "Et non eligendi illo ab dolores dolorem voluptas. Et consequuntur non assumenda consequatur impedit consequatur molestias iste consequatur. A expedita et tenetur et quod at voluptas consequatur. Velit non fugit dolorem dicta neque delectus blanditiis. Ullam in natus rerum reiciendis eum temporibus.",
                            NumberOfBooksInStock = 3
                        },
                        new
                        {
                            BookId = 7,
                            BookAuthor = "Ericka Trantow",
                            BookName = "Bedfordshire calculate",
                            Description = "Iste quod vel enim rerum maiores possimus enim impedit velit. Id quisquam perspiciatis. Illo earum molestias. In perferendis cum consequuntur. Sit sint aliquid nobis aut error.",
                            NumberOfBooksInStock = 5
                        },
                        new
                        {
                            BookId = 8,
                            BookAuthor = "Lenore Farrell",
                            BookName = "Creek",
                            Description = "Distinctio deserunt et voluptas enim. Optio aut dolorum rerum veniam optio est illum. Voluptas rerum debitis laborum ex reiciendis consequuntur harum. Molestiae qui mollitia. Neque mollitia itaque vel velit rerum pariatur est mollitia.",
                            NumberOfBooksInStock = 5
                        },
                        new
                        {
                            BookId = 9,
                            BookAuthor = "Hailee Jacobs",
                            BookName = "Buckinghamshire Tokelau",
                            Description = "Repellendus non fugit dolor qui laborum quis quia provident. Qui eveniet consequuntur eaque dolorem facilis voluptatem consequatur rem quis. Ut dicta qui.",
                            NumberOfBooksInStock = 2
                        },
                        new
                        {
                            BookId = 10,
                            BookAuthor = "D'angelo Pacocha",
                            BookName = "Rubber Ford",
                            Description = "Consequatur nisi quae quam quia. Consequuntur ipsam ipsam et. Repellendus minima blanditiis recusandae debitis officiis in non eveniet.",
                            NumberOfBooksInStock = 6
                        });
                });

            modelBuilder.Entity("Labb1MVC_V3.Models.Customer", b =>
                {
                    b.Property<int>("CustomerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CustomerEmail")
                        .IsRequired()
                        .HasColumnType("nvarchar(40)")
                        .HasMaxLength(40);

                    b.Property<string>("CustomerFName")
                        .IsRequired()
                        .HasColumnType("nvarchar(25)")
                        .HasMaxLength(25);

                    b.Property<string>("CustomerLName")
                        .IsRequired()
                        .HasColumnType("nvarchar(25)")
                        .HasMaxLength(25);

                    b.HasKey("CustomerId");

                    b.ToTable("Customers");

                    b.HasData(
                        new
                        {
                            CustomerId = 1,
                            CustomerEmail = "Derek_Kunde30@hotmail.com",
                            CustomerFName = "Ike",
                            CustomerLName = "Howell"
                        },
                        new
                        {
                            CustomerId = 2,
                            CustomerEmail = "Ryder_Farrell@yahoo.com",
                            CustomerFName = "Moses",
                            CustomerLName = "Becker"
                        },
                        new
                        {
                            CustomerId = 3,
                            CustomerEmail = "Carolanne.Rippin@gmail.com",
                            CustomerFName = "Leif",
                            CustomerLName = "Schmidt"
                        },
                        new
                        {
                            CustomerId = 4,
                            CustomerEmail = "Makenna.OReilly@gmail.com",
                            CustomerFName = "Rylan",
                            CustomerLName = "Krajcik"
                        },
                        new
                        {
                            CustomerId = 5,
                            CustomerEmail = "Irma_Zieme50@yahoo.com",
                            CustomerFName = "Retha",
                            CustomerLName = "Rodriguez"
                        },
                        new
                        {
                            CustomerId = 6,
                            CustomerEmail = "Isabel_Ankunding13@yahoo.com",
                            CustomerFName = "Veda",
                            CustomerLName = "Purdy"
                        },
                        new
                        {
                            CustomerId = 7,
                            CustomerEmail = "Drew_Glover@yahoo.com",
                            CustomerFName = "Heber",
                            CustomerLName = "Feeney"
                        },
                        new
                        {
                            CustomerId = 8,
                            CustomerEmail = "Abigale.Legros@gmail.com",
                            CustomerFName = "Mya",
                            CustomerLName = "Bogisich"
                        },
                        new
                        {
                            CustomerId = 9,
                            CustomerEmail = "Tyler30@gmail.com",
                            CustomerFName = "Richmond",
                            CustomerLName = "Bahringer"
                        },
                        new
                        {
                            CustomerId = 10,
                            CustomerEmail = "Tyree_Bradtke72@yahoo.com",
                            CustomerFName = "Harrison",
                            CustomerLName = "Feeney"
                        });
                });

            modelBuilder.Entity("Labb1MVC_V3.Models.LoanedBook", b =>
                {
                    b.Property<int>("LoanedBookId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("BookId")
                        .HasColumnType("int");

                    b.Property<int>("CustomerId")
                        .HasColumnType("int");

                    b.Property<DateTime>("LoanDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("ReturnDate")
                        .HasColumnType("datetime2");

                    b.HasKey("LoanedBookId");

                    b.HasIndex("BookId");

                    b.HasIndex("CustomerId");

                    b.ToTable("Loan");

                    b.HasData(
                        new
                        {
                            LoanedBookId = 1,
                            BookId = 6,
                            CustomerId = 5,
                            LoanDate = new DateTime(2022, 9, 19, 14, 34, 7, 897, DateTimeKind.Local).AddTicks(3584),
                            ReturnDate = new DateTime(2022, 10, 19, 14, 34, 7, 899, DateTimeKind.Local).AddTicks(2534)
                        },
                        new
                        {
                            LoanedBookId = 2,
                            BookId = 1,
                            CustomerId = 4,
                            LoanDate = new DateTime(2022, 9, 19, 14, 34, 7, 899, DateTimeKind.Local).AddTicks(5451),
                            ReturnDate = new DateTime(2022, 10, 19, 14, 34, 7, 899, DateTimeKind.Local).AddTicks(5470)
                        },
                        new
                        {
                            LoanedBookId = 3,
                            BookId = 7,
                            CustomerId = 4,
                            LoanDate = new DateTime(2022, 9, 19, 14, 34, 7, 899, DateTimeKind.Local).AddTicks(5640),
                            ReturnDate = new DateTime(2022, 10, 19, 14, 34, 7, 899, DateTimeKind.Local).AddTicks(5644)
                        },
                        new
                        {
                            LoanedBookId = 4,
                            BookId = 2,
                            CustomerId = 3,
                            LoanDate = new DateTime(2022, 9, 19, 14, 34, 7, 899, DateTimeKind.Local).AddTicks(5654),
                            ReturnDate = new DateTime(2022, 10, 19, 14, 34, 7, 899, DateTimeKind.Local).AddTicks(5656)
                        },
                        new
                        {
                            LoanedBookId = 5,
                            BookId = 1,
                            CustomerId = 3,
                            LoanDate = new DateTime(2022, 9, 19, 14, 34, 7, 899, DateTimeKind.Local).AddTicks(5664),
                            ReturnDate = new DateTime(2022, 10, 19, 14, 34, 7, 899, DateTimeKind.Local).AddTicks(5666)
                        });
                });

            modelBuilder.Entity("Labb1MVC_V3.Models.LoanedBook", b =>
                {
                    b.HasOne("Labb1MVC_V3.Models.Book", "Book")
                        .WithMany("LoanedBook")
                        .HasForeignKey("BookId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Labb1MVC_V3.Models.Customer", "Customer")
                        .WithMany("LoanedBook")
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
