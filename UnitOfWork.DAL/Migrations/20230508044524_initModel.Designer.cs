﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using UnitOfWork.DAL.DbContexts;

namespace UnitOfWork.DAL.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20230508044524_initModel")]
    partial class initModel
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.14-servicing-32113")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("UnitOfWork.DAL.Entities.Category", b =>
                {
                    b.Property<int>("IdCateogory")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("NameCategory")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.HasKey("IdCateogory");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("UnitOfWork.DAL.Entities.Product", b =>
                {
                    b.Property<int>("IdProduct")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("IdCateogory");

                    b.Property<string>("NameProduct")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<int>("Price");

                    b.HasKey("IdProduct");

                    b.HasIndex("IdCateogory");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("UnitOfWork.DAL.Entities.Product", b =>
                {
                    b.HasOne("UnitOfWork.DAL.Entities.Category", "Category")
                        .WithMany("Products")
                        .HasForeignKey("IdCateogory")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}