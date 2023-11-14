﻿// <auto-generated />
using System;
using BackendApp.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BackendApp.Migrations
{
    [DbContext(typeof(ShopContext))]
    [Migration("20231017130050_Mistake")]
    partial class Mistake
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("BackendApp.Models.Basket", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTimeOffset>("CreatedAt")
                        .HasColumnType("datetimeoffset");

                    b.Property<int>("CreatedBy")
                        .HasColumnType("int");

                    b.Property<DateTimeOffset>("DateAdded")
                        .HasColumnType("datetimeoffset");

                    b.Property<DateTimeOffset>("ModifiedAt")
                        .HasColumnType("datetimeoffset");

                    b.Property<int?>("ModifiedBy")
                        .HasColumnType("int");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("PublicUserId")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PublicUserId");

                    b.ToTable("Baskets");
                });

            modelBuilder.Entity("BackendApp.Models.Brand", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTimeOffset>("CreatedAt")
                        .HasColumnType("datetimeoffset");

                    b.Property<int>("CreatedBy")
                        .HasColumnType("int");

                    b.Property<DateTimeOffset>("ModifiedAt")
                        .HasColumnType("datetimeoffset");

                    b.Property<int?>("ModifiedBy")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Brands");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedAt = new DateTimeOffset(new DateTime(2023, 10, 17, 16, 0, 50, 832, DateTimeKind.Unspecified).AddTicks(7996), new TimeSpan(0, 3, 0, 0, 0)),
                            CreatedBy = 0,
                            ModifiedAt = new DateTimeOffset(new DateTime(2023, 10, 17, 16, 0, 50, 832, DateTimeKind.Unspecified).AddTicks(7999), new TimeSpan(0, 3, 0, 0, 0)),
                            Name = "Apple"
                        },
                        new
                        {
                            Id = 2,
                            CreatedAt = new DateTimeOffset(new DateTime(2023, 10, 17, 16, 0, 50, 832, DateTimeKind.Unspecified).AddTicks(8001), new TimeSpan(0, 3, 0, 0, 0)),
                            CreatedBy = 0,
                            ModifiedAt = new DateTimeOffset(new DateTime(2023, 10, 17, 16, 0, 50, 832, DateTimeKind.Unspecified).AddTicks(8003), new TimeSpan(0, 3, 0, 0, 0)),
                            Name = "LG"
                        },
                        new
                        {
                            Id = 3,
                            CreatedAt = new DateTimeOffset(new DateTime(2023, 10, 17, 16, 0, 50, 832, DateTimeKind.Unspecified).AddTicks(8005), new TimeSpan(0, 3, 0, 0, 0)),
                            CreatedBy = 0,
                            ModifiedAt = new DateTimeOffset(new DateTime(2023, 10, 17, 16, 0, 50, 832, DateTimeKind.Unspecified).AddTicks(8006), new TimeSpan(0, 3, 0, 0, 0)),
                            Name = "Canon"
                        },
                        new
                        {
                            Id = 4,
                            CreatedAt = new DateTimeOffset(new DateTime(2023, 10, 17, 16, 0, 50, 832, DateTimeKind.Unspecified).AddTicks(8008), new TimeSpan(0, 3, 0, 0, 0)),
                            CreatedBy = 0,
                            ModifiedAt = new DateTimeOffset(new DateTime(2023, 10, 17, 16, 0, 50, 832, DateTimeKind.Unspecified).AddTicks(8010), new TimeSpan(0, 3, 0, 0, 0)),
                            Name = "Nikon"
                        },
                        new
                        {
                            Id = 5,
                            CreatedAt = new DateTimeOffset(new DateTime(2023, 10, 17, 16, 0, 50, 832, DateTimeKind.Unspecified).AddTicks(8012), new TimeSpan(0, 3, 0, 0, 0)),
                            CreatedBy = 0,
                            ModifiedAt = new DateTimeOffset(new DateTime(2023, 10, 17, 16, 0, 50, 832, DateTimeKind.Unspecified).AddTicks(8013), new TimeSpan(0, 3, 0, 0, 0)),
                            Name = "Google"
                        },
                        new
                        {
                            Id = 6,
                            CreatedAt = new DateTimeOffset(new DateTime(2023, 10, 17, 16, 0, 50, 832, DateTimeKind.Unspecified).AddTicks(8015), new TimeSpan(0, 3, 0, 0, 0)),
                            CreatedBy = 0,
                            ModifiedAt = new DateTimeOffset(new DateTime(2023, 10, 17, 16, 0, 50, 832, DateTimeKind.Unspecified).AddTicks(8017), new TimeSpan(0, 3, 0, 0, 0)),
                            Name = "Samsung"
                        },
                        new
                        {
                            Id = 7,
                            CreatedAt = new DateTimeOffset(new DateTime(2023, 10, 17, 16, 0, 50, 832, DateTimeKind.Unspecified).AddTicks(8019), new TimeSpan(0, 3, 0, 0, 0)),
                            CreatedBy = 0,
                            ModifiedAt = new DateTimeOffset(new DateTime(2023, 10, 17, 16, 0, 50, 832, DateTimeKind.Unspecified).AddTicks(8020), new TimeSpan(0, 3, 0, 0, 0)),
                            Name = "Nvidia"
                        },
                        new
                        {
                            Id = 8,
                            CreatedAt = new DateTimeOffset(new DateTime(2023, 10, 17, 16, 0, 50, 832, DateTimeKind.Unspecified).AddTicks(8022), new TimeSpan(0, 3, 0, 0, 0)),
                            CreatedBy = 0,
                            ModifiedAt = new DateTimeOffset(new DateTime(2023, 10, 17, 16, 0, 50, 832, DateTimeKind.Unspecified).AddTicks(8024), new TimeSpan(0, 3, 0, 0, 0)),
                            Name = "AMD"
                        },
                        new
                        {
                            Id = 9,
                            CreatedAt = new DateTimeOffset(new DateTime(2023, 10, 17, 16, 0, 50, 832, DateTimeKind.Unspecified).AddTicks(8026), new TimeSpan(0, 3, 0, 0, 0)),
                            CreatedBy = 0,
                            ModifiedAt = new DateTimeOffset(new DateTime(2023, 10, 17, 16, 0, 50, 832, DateTimeKind.Unspecified).AddTicks(8027), new TimeSpan(0, 3, 0, 0, 0)),
                            Name = "GIGABYTE"
                        },
                        new
                        {
                            Id = 10,
                            CreatedAt = new DateTimeOffset(new DateTime(2023, 10, 17, 16, 0, 50, 832, DateTimeKind.Unspecified).AddTicks(8029), new TimeSpan(0, 3, 0, 0, 0)),
                            CreatedBy = 0,
                            ModifiedAt = new DateTimeOffset(new DateTime(2023, 10, 17, 16, 0, 50, 832, DateTimeKind.Unspecified).AddTicks(8031), new TimeSpan(0, 3, 0, 0, 0)),
                            Name = "BenQ"
                        },
                        new
                        {
                            Id = 11,
                            CreatedAt = new DateTimeOffset(new DateTime(2023, 10, 17, 16, 0, 50, 832, DateTimeKind.Unspecified).AddTicks(8033), new TimeSpan(0, 3, 0, 0, 0)),
                            CreatedBy = 0,
                            ModifiedAt = new DateTimeOffset(new DateTime(2023, 10, 17, 16, 0, 50, 832, DateTimeKind.Unspecified).AddTicks(8034), new TimeSpan(0, 3, 0, 0, 0)),
                            Name = "Intel"
                        },
                        new
                        {
                            Id = 12,
                            CreatedAt = new DateTimeOffset(new DateTime(2023, 10, 17, 16, 0, 50, 832, DateTimeKind.Unspecified).AddTicks(8036), new TimeSpan(0, 3, 0, 0, 0)),
                            CreatedBy = 0,
                            ModifiedAt = new DateTimeOffset(new DateTime(2023, 10, 17, 16, 0, 50, 832, DateTimeKind.Unspecified).AddTicks(8038), new TimeSpan(0, 3, 0, 0, 0)),
                            Name = "Fujifilm"
                        },
                        new
                        {
                            Id = 13,
                            CreatedAt = new DateTimeOffset(new DateTime(2023, 10, 17, 16, 0, 50, 832, DateTimeKind.Unspecified).AddTicks(8040), new TimeSpan(0, 3, 0, 0, 0)),
                            CreatedBy = 0,
                            ModifiedAt = new DateTimeOffset(new DateTime(2023, 10, 17, 16, 0, 50, 832, DateTimeKind.Unspecified).AddTicks(8041), new TimeSpan(0, 3, 0, 0, 0)),
                            Name = "Philips"
                        },
                        new
                        {
                            Id = 14,
                            CreatedAt = new DateTimeOffset(new DateTime(2023, 10, 17, 16, 0, 50, 832, DateTimeKind.Unspecified).AddTicks(8043), new TimeSpan(0, 3, 0, 0, 0)),
                            CreatedBy = 0,
                            ModifiedAt = new DateTimeOffset(new DateTime(2023, 10, 17, 16, 0, 50, 832, DateTimeKind.Unspecified).AddTicks(8045), new TimeSpan(0, 3, 0, 0, 0)),
                            Name = "Panasonic"
                        });
                });

            modelBuilder.Entity("BackendApp.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTimeOffset>("CreatedAt")
                        .HasColumnType("datetimeoffset");

                    b.Property<int>("CreatedBy")
                        .HasColumnType("int");

                    b.Property<DateTimeOffset>("ModifiedAt")
                        .HasColumnType("datetimeoffset");

                    b.Property<int?>("ModifiedBy")
                        .HasColumnType("int");

                    b.Property<string>("NameOfCategory")
                        .IsRequired()
                        .HasMaxLength(120)
                        .HasColumnType("nvarchar(120)");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedAt = new DateTimeOffset(new DateTime(2023, 10, 17, 16, 0, 50, 832, DateTimeKind.Unspecified).AddTicks(7703), new TimeSpan(0, 3, 0, 0, 0)),
                            CreatedBy = 0,
                            ModifiedAt = new DateTimeOffset(new DateTime(2023, 10, 17, 16, 0, 50, 832, DateTimeKind.Unspecified).AddTicks(7760), new TimeSpan(0, 3, 0, 0, 0)),
                            NameOfCategory = "Laptops, Tablets & PCs"
                        },
                        new
                        {
                            Id = 2,
                            CreatedAt = new DateTimeOffset(new DateTime(2023, 10, 17, 16, 0, 50, 832, DateTimeKind.Unspecified).AddTicks(7763), new TimeSpan(0, 3, 0, 0, 0)),
                            CreatedBy = 0,
                            ModifiedAt = new DateTimeOffset(new DateTime(2023, 10, 17, 16, 0, 50, 832, DateTimeKind.Unspecified).AddTicks(7765), new TimeSpan(0, 3, 0, 0, 0)),
                            NameOfCategory = "Computer & Office"
                        },
                        new
                        {
                            Id = 3,
                            CreatedAt = new DateTimeOffset(new DateTime(2023, 10, 17, 16, 0, 50, 832, DateTimeKind.Unspecified).AddTicks(7767), new TimeSpan(0, 3, 0, 0, 0)),
                            CreatedBy = 0,
                            ModifiedAt = new DateTimeOffset(new DateTime(2023, 10, 17, 16, 0, 50, 832, DateTimeKind.Unspecified).AddTicks(7769), new TimeSpan(0, 3, 0, 0, 0)),
                            NameOfCategory = "Hardware & Components"
                        },
                        new
                        {
                            Id = 4,
                            CreatedAt = new DateTimeOffset(new DateTime(2023, 10, 17, 16, 0, 50, 832, DateTimeKind.Unspecified).AddTicks(7771), new TimeSpan(0, 3, 0, 0, 0)),
                            CreatedBy = 0,
                            ModifiedAt = new DateTimeOffset(new DateTime(2023, 10, 17, 16, 0, 50, 832, DateTimeKind.Unspecified).AddTicks(7772), new TimeSpan(0, 3, 0, 0, 0)),
                            NameOfCategory = "Smartphones, Radio & GPS"
                        },
                        new
                        {
                            Id = 5,
                            CreatedAt = new DateTimeOffset(new DateTime(2023, 10, 17, 16, 0, 50, 832, DateTimeKind.Unspecified).AddTicks(7774), new TimeSpan(0, 3, 0, 0, 0)),
                            CreatedBy = 0,
                            ModifiedAt = new DateTimeOffset(new DateTime(2023, 10, 17, 16, 0, 50, 832, DateTimeKind.Unspecified).AddTicks(7776), new TimeSpan(0, 3, 0, 0, 0)),
                            NameOfCategory = "Photo / Video"
                        },
                        new
                        {
                            Id = 6,
                            CreatedAt = new DateTimeOffset(new DateTime(2023, 10, 17, 16, 0, 50, 832, DateTimeKind.Unspecified).AddTicks(7778), new TimeSpan(0, 3, 0, 0, 0)),
                            CreatedBy = 0,
                            ModifiedAt = new DateTimeOffset(new DateTime(2023, 10, 17, 16, 0, 50, 832, DateTimeKind.Unspecified).AddTicks(7779), new TimeSpan(0, 3, 0, 0, 0)),
                            NameOfCategory = "TV / HiFi / Video"
                        });
                });

            modelBuilder.Entity("BackendApp.Models.Favourite", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTimeOffset>("CreatedAt")
                        .HasColumnType("datetimeoffset");

                    b.Property<int>("CreatedBy")
                        .HasColumnType("int");

                    b.Property<DateTimeOffset>("DateAdded")
                        .HasColumnType("datetimeoffset");

                    b.Property<DateTimeOffset>("ModifiedAt")
                        .HasColumnType("datetimeoffset");

                    b.Property<int?>("ModifiedBy")
                        .HasColumnType("int");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ProductId");

                    b.HasIndex("UserId");

                    b.ToTable("Favourites");
                });

            modelBuilder.Entity("BackendApp.Models.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("BasketId")
                        .HasColumnType("int");

                    b.Property<DateTimeOffset>("CreatedAt")
                        .HasColumnType("datetimeoffset");

                    b.Property<int>("CreatedBy")
                        .HasColumnType("int");

                    b.Property<DateTimeOffset>("ModifiedAt")
                        .HasColumnType("datetimeoffset");

                    b.Property<int?>("ModifiedBy")
                        .HasColumnType("int");

                    b.Property<DateTime>("OrderDate")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.HasIndex("BasketId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("BackendApp.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("BrandId")
                        .HasColumnType("int");

                    b.Property<int>("Count")
                        .HasColumnType("int");

                    b.Property<DateTimeOffset>("CreatedAt")
                        .HasColumnType("datetimeoffset");

                    b.Property<int>("CreatedBy")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTimeOffset>("ModifiedAt")
                        .HasColumnType("datetimeoffset");

                    b.Property<int?>("ModifiedBy")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("SubcategoryId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("BrandId");

                    b.HasIndex("SubcategoryId");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("BackendApp.Models.ProductBasket", b =>
                {
                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("BasketId")
                        .HasColumnType("int");

                    b.HasKey("ProductId", "BasketId");

                    b.HasIndex("BasketId");

                    b.ToTable("ProductBasket");
                });

            modelBuilder.Entity("BackendApp.Models.PublicUser", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTimeOffset>("CreatedAt")
                        .HasColumnType("datetimeoffset");

                    b.Property<int>("CreatedBy")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTimeOffset>("ModifiedAt")
                        .HasColumnType("datetimeoffset");

                    b.Property<int?>("ModifiedBy")
                        .HasColumnType("int");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("Email")
                        .IsUnique();

                    b.ToTable("PublicUsers");
                });

            modelBuilder.Entity("BackendApp.Models.Subcategory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<DateTimeOffset>("CreatedAt")
                        .HasColumnType("datetimeoffset");

                    b.Property<int>("CreatedBy")
                        .HasColumnType("int");

                    b.Property<DateTimeOffset>("ModifiedAt")
                        .HasColumnType("datetimeoffset");

                    b.Property<int?>("ModifiedBy")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Subcategories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryId = 1,
                            CreatedAt = new DateTimeOffset(new DateTime(2023, 10, 17, 16, 0, 50, 832, DateTimeKind.Unspecified).AddTicks(7893), new TimeSpan(0, 3, 0, 0, 0)),
                            CreatedBy = 0,
                            ModifiedAt = new DateTimeOffset(new DateTime(2023, 10, 17, 16, 0, 50, 832, DateTimeKind.Unspecified).AddTicks(7896), new TimeSpan(0, 3, 0, 0, 0)),
                            Name = "Laptops / Notebooks"
                        },
                        new
                        {
                            Id = 2,
                            CategoryId = 1,
                            CreatedAt = new DateTimeOffset(new DateTime(2023, 10, 17, 16, 0, 50, 832, DateTimeKind.Unspecified).AddTicks(7899), new TimeSpan(0, 3, 0, 0, 0)),
                            CreatedBy = 0,
                            ModifiedAt = new DateTimeOffset(new DateTime(2023, 10, 17, 16, 0, 50, 832, DateTimeKind.Unspecified).AddTicks(7900), new TimeSpan(0, 3, 0, 0, 0)),
                            Name = "Apple MacBook"
                        },
                        new
                        {
                            Id = 3,
                            CategoryId = 2,
                            CreatedAt = new DateTimeOffset(new DateTime(2023, 10, 17, 16, 0, 50, 832, DateTimeKind.Unspecified).AddTicks(7903), new TimeSpan(0, 3, 0, 0, 0)),
                            CreatedBy = 0,
                            ModifiedAt = new DateTimeOffset(new DateTime(2023, 10, 17, 16, 0, 50, 832, DateTimeKind.Unspecified).AddTicks(7904), new TimeSpan(0, 3, 0, 0, 0)),
                            Name = "Monitors"
                        },
                        new
                        {
                            Id = 4,
                            CategoryId = 2,
                            CreatedAt = new DateTimeOffset(new DateTime(2023, 10, 17, 16, 0, 50, 832, DateTimeKind.Unspecified).AddTicks(7906), new TimeSpan(0, 3, 0, 0, 0)),
                            CreatedBy = 0,
                            ModifiedAt = new DateTimeOffset(new DateTime(2023, 10, 17, 16, 0, 50, 832, DateTimeKind.Unspecified).AddTicks(7908), new TimeSpan(0, 3, 0, 0, 0)),
                            Name = "All-in-One Printers"
                        },
                        new
                        {
                            Id = 5,
                            CategoryId = 3,
                            CreatedAt = new DateTimeOffset(new DateTime(2023, 10, 17, 16, 0, 50, 832, DateTimeKind.Unspecified).AddTicks(7910), new TimeSpan(0, 3, 0, 0, 0)),
                            CreatedBy = 0,
                            ModifiedAt = new DateTimeOffset(new DateTime(2023, 10, 17, 16, 0, 50, 832, DateTimeKind.Unspecified).AddTicks(7911), new TimeSpan(0, 3, 0, 0, 0)),
                            Name = "Processors (CPUs)"
                        },
                        new
                        {
                            Id = 6,
                            CategoryId = 3,
                            CreatedAt = new DateTimeOffset(new DateTime(2023, 10, 17, 16, 0, 50, 832, DateTimeKind.Unspecified).AddTicks(7913), new TimeSpan(0, 3, 0, 0, 0)),
                            CreatedBy = 0,
                            ModifiedAt = new DateTimeOffset(new DateTime(2023, 10, 17, 16, 0, 50, 832, DateTimeKind.Unspecified).AddTicks(7915), new TimeSpan(0, 3, 0, 0, 0)),
                            Name = "AMD Graphics cards"
                        },
                        new
                        {
                            Id = 7,
                            CategoryId = 4,
                            CreatedAt = new DateTimeOffset(new DateTime(2023, 10, 17, 16, 0, 50, 832, DateTimeKind.Unspecified).AddTicks(7917), new TimeSpan(0, 3, 0, 0, 0)),
                            CreatedBy = 0,
                            ModifiedAt = new DateTimeOffset(new DateTime(2023, 10, 17, 16, 0, 50, 832, DateTimeKind.Unspecified).AddTicks(7918), new TimeSpan(0, 3, 0, 0, 0)),
                            Name = "Smartphones & Cell Phones"
                        },
                        new
                        {
                            Id = 8,
                            CategoryId = 4,
                            CreatedAt = new DateTimeOffset(new DateTime(2023, 10, 17, 16, 0, 50, 832, DateTimeKind.Unspecified).AddTicks(7920), new TimeSpan(0, 3, 0, 0, 0)),
                            CreatedBy = 0,
                            ModifiedAt = new DateTimeOffset(new DateTime(2023, 10, 17, 16, 0, 50, 832, DateTimeKind.Unspecified).AddTicks(7922), new TimeSpan(0, 3, 0, 0, 0)),
                            Name = "Apple iPhones"
                        },
                        new
                        {
                            Id = 9,
                            CategoryId = 5,
                            CreatedAt = new DateTimeOffset(new DateTime(2023, 10, 17, 16, 0, 50, 832, DateTimeKind.Unspecified).AddTicks(7924), new TimeSpan(0, 3, 0, 0, 0)),
                            CreatedBy = 0,
                            ModifiedAt = new DateTimeOffset(new DateTime(2023, 10, 17, 16, 0, 50, 832, DateTimeKind.Unspecified).AddTicks(7925), new TimeSpan(0, 3, 0, 0, 0)),
                            Name = "Digital Cameras"
                        },
                        new
                        {
                            Id = 10,
                            CategoryId = 5,
                            CreatedAt = new DateTimeOffset(new DateTime(2023, 10, 17, 16, 0, 50, 832, DateTimeKind.Unspecified).AddTicks(7927), new TimeSpan(0, 3, 0, 0, 0)),
                            CreatedBy = 0,
                            ModifiedAt = new DateTimeOffset(new DateTime(2023, 10, 17, 16, 0, 50, 832, DateTimeKind.Unspecified).AddTicks(7929), new TimeSpan(0, 3, 0, 0, 0)),
                            Name = "Instant Cameras"
                        },
                        new
                        {
                            Id = 11,
                            CategoryId = 6,
                            CreatedAt = new DateTimeOffset(new DateTime(2023, 10, 17, 16, 0, 50, 832, DateTimeKind.Unspecified).AddTicks(7931), new TimeSpan(0, 3, 0, 0, 0)),
                            CreatedBy = 0,
                            ModifiedAt = new DateTimeOffset(new DateTime(2023, 10, 17, 16, 0, 50, 832, DateTimeKind.Unspecified).AddTicks(7932), new TimeSpan(0, 3, 0, 0, 0)),
                            Name = "LED TV / LCD TV"
                        },
                        new
                        {
                            Id = 12,
                            CategoryId = 6,
                            CreatedAt = new DateTimeOffset(new DateTime(2023, 10, 17, 16, 0, 50, 832, DateTimeKind.Unspecified).AddTicks(7934), new TimeSpan(0, 3, 0, 0, 0)),
                            CreatedBy = 0,
                            ModifiedAt = new DateTimeOffset(new DateTime(2023, 10, 17, 16, 0, 50, 832, DateTimeKind.Unspecified).AddTicks(7936), new TimeSpan(0, 3, 0, 0, 0)),
                            Name = "OLED TV"
                        });
                });

            modelBuilder.Entity("BackendApp.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTimeOffset>("CreatedAt")
                        .HasColumnType("datetimeoffset");

                    b.Property<int>("CreatedBy")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTimeOffset>("ModifiedAt")
                        .HasColumnType("datetimeoffset");

                    b.Property<int?>("ModifiedBy")
                        .HasColumnType("int");

                    b.Property<byte[]>("PasswordHash")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.Property<byte[]>("PasswordSalt")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.Property<int>("PublicUserId")
                        .HasColumnType("int");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("PublicUserId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("BackendApp.Models.Basket", b =>
                {
                    b.HasOne("BackendApp.Models.PublicUser", "PublicUser")
                        .WithMany()
                        .HasForeignKey("PublicUserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("PublicUser");
                });

            modelBuilder.Entity("BackendApp.Models.Favourite", b =>
                {
                    b.HasOne("BackendApp.Models.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BackendApp.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");

                    b.Navigation("User");
                });

            modelBuilder.Entity("BackendApp.Models.Order", b =>
                {
                    b.HasOne("BackendApp.Models.Basket", "Basket")
                        .WithMany()
                        .HasForeignKey("BasketId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Basket");
                });

            modelBuilder.Entity("BackendApp.Models.Product", b =>
                {
                    b.HasOne("BackendApp.Models.Brand", "Brand")
                        .WithMany()
                        .HasForeignKey("BrandId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BackendApp.Models.Subcategory", "Subcategory")
                        .WithMany()
                        .HasForeignKey("SubcategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Brand");

                    b.Navigation("Subcategory");
                });

            modelBuilder.Entity("BackendApp.Models.ProductBasket", b =>
                {
                    b.HasOne("BackendApp.Models.Basket", "Basket")
                        .WithMany("ProductBasket")
                        .HasForeignKey("BasketId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BackendApp.Models.Product", "Product")
                        .WithMany("ProductBasket")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Basket");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("BackendApp.Models.Subcategory", b =>
                {
                    b.HasOne("BackendApp.Models.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("BackendApp.Models.User", b =>
                {
                    b.HasOne("BackendApp.Models.PublicUser", "PublicUser")
                        .WithMany()
                        .HasForeignKey("PublicUserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("PublicUser");
                });

            modelBuilder.Entity("BackendApp.Models.Basket", b =>
                {
                    b.Navigation("ProductBasket");
                });

            modelBuilder.Entity("BackendApp.Models.Product", b =>
                {
                    b.Navigation("ProductBasket");
                });
#pragma warning restore 612, 618
        }
    }
}