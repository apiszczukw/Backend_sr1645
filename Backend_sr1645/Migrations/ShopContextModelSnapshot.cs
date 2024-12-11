﻿// <auto-generated />
using System;
using Backend_sr1645.DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Backend_sr1645.Migrations
{
    [DbContext(typeof(ShopContext))]
    partial class ShopContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.36")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Backend_sr1645.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<float?>("Price")
                        .HasColumnType("real");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "pomidor",
                            Price = 5.6f,
                            Quantity = 0
                        },
                        new
                        {
                            Id = 2,
                            Name = "ziemniaki",
                            Price = 2.6f,
                            Quantity = 0
                        },
                        new
                        {
                            Id = 3,
                            Name = "ogórek",
                            Price = 6.2f,
                            Quantity = 0
                        },
                        new
                        {
                            Id = 4,
                            Name = "kalafior",
                            Price = 10.6f,
                            Quantity = 0
                        },
                        new
                        {
                            Id = 5,
                            Name = "brokuł",
                            Price = 8.9f,
                            Quantity = 0
                        },
                        new
                        {
                            Id = 6,
                            Name = "cukinia",
                            Price = 7.99f,
                            Quantity = 0
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
