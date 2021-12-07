﻿// <auto-generated />
using System;
using DataStorage;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DataStorage.Migrations
{
    [DbContext(typeof(ImagesLibraryContext))]
    partial class ImagesLibraryContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("Entities.ImageInfo", b =>
                {
                    b.Property<int>("ImageInfoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ImageHash")
                        .HasColumnType("TEXT");

                    b.Property<string>("ImageName")
                        .HasColumnType("TEXT");

                    b.HasKey("ImageInfoId");

                    b.ToTable("ImagesInfo");
                });

            modelBuilder.Entity("Entities.ImageInfoDetails", b =>
                {
                    b.Property<int>("ImageInfoDetailsId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<byte[]>("Image")
                        .HasColumnType("BLOB");

                    b.Property<int>("ImageInfoId")
                        .HasColumnType("INTEGER");

                    b.HasKey("ImageInfoDetailsId");

                    b.HasIndex("ImageInfoId")
                        .IsUnique();

                    b.ToTable("ImagesInfoDetails");
                });

            modelBuilder.Entity("Entities.RecognizedObject", b =>
                {
                    b.Property<int>("ObjectId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("CategoryName")
                        .HasColumnType("TEXT");

                    b.Property<double>("Confidence")
                        .HasColumnType("REAL");

                    b.Property<int>("ImageInfoId")
                        .HasColumnType("INTEGER");

                    b.HasKey("ObjectId");

                    b.HasIndex("ImageInfoId");

                    b.ToTable("RecognizedObjects");
                });

            modelBuilder.Entity("Entities.ImageInfoDetails", b =>
                {
                    b.HasOne("Entities.ImageInfo", null)
                        .WithOne("ImageInfoDetails")
                        .HasForeignKey("Entities.ImageInfoDetails", "ImageInfoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Entities.RecognizedObject", b =>
                {
                    b.HasOne("Entities.ImageInfo", null)
                        .WithMany("RecognizedObjects")
                        .HasForeignKey("ImageInfoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Entities.ImageInfo", b =>
                {
                    b.Navigation("ImageInfoDetails");

                    b.Navigation("RecognizedObjects");
                });
#pragma warning restore 612, 618
        }
    }
}
