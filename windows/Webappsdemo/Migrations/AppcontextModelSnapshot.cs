﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Webappsdemo.Models;

namespace Webappsdemo.Migrations
{
    [DbContext(typeof(Appcontext))]
    partial class AppcontextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Webappsdemo.Models.Products", b =>
                {
                    b.Property<int>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CatelogType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Department")
                        .HasColumnType("int");

                    b.Property<string>("ProductName")
                        .IsRequired()
                        .HasColumnType("nvarchar(30)")
                        .HasMaxLength(30);

                    b.HasKey("ProductId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            ProductId = 34,
                            CatelogType = "Ele",
                            Department = 1,
                            ProductName = "TV"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
