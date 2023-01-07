﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using YouDontKnowEgypt.Models;

namespace YouDontKnowEgypt.Migrations
{
    [DbContext(typeof(YouDontKnowEgyptContext))]
    partial class YouDontKnowEgyptContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:Collation", "Arabic_CI_AS")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.6")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("YouDontKnowEgypt.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("name");

                    b.HasKey("Id");

                    b.ToTable("Category");
                });

            modelBuilder.Entity("YouDontKnowEgypt.Models.Comment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Comment1")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("comment");

                    b.Property<int?>("LocatoinId")
                        .HasColumnType("int")
                        .HasColumnName("Locatoin_id");

                    b.Property<int?>("UserId")
                        .HasColumnType("int")
                        .HasColumnName("user_id");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Comments");
                });

            modelBuilder.Entity("YouDontKnowEgypt.Models.Governorate", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .IsUnicode(false)
                        .HasColumnType("varchar(max)")
                        .HasColumnName("description");

                    b.Property<string>("Name")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("name");

                    b.HasKey("Id");

                    b.ToTable("Governorate");
                });

            modelBuilder.Entity("YouDontKnowEgypt.Models.Hotel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .IsUnicode(false)
                        .HasColumnType("varchar(max)")
                        .HasColumnName("description");

                    b.Property<int?>("GovernorateId")
                        .HasColumnType("int")
                        .HasColumnName("governorate_id");

                    b.Property<string>("Name")
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("varchar(100)")
                        .HasColumnName("name");

                    b.HasKey("Id");

                    b.HasIndex("GovernorateId");

                    b.ToTable("Hotels");
                });

            modelBuilder.Entity("YouDontKnowEgypt.Models.HotelsImage", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("HotelId")
                        .HasColumnType("int")
                        .HasColumnName("hotel_id");

                    b.Property<string>("ImagePath")
                        .IsUnicode(false)
                        .HasColumnType("varchar(max)")
                        .HasColumnName("image_path");

                    b.HasKey("Id");

                    b.HasIndex("HotelId");

                    b.ToTable("Hotels_image");
                });

            modelBuilder.Entity("YouDontKnowEgypt.Models.Location", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool?>("Approved")
                        .HasColumnType("bit")
                        .HasColumnName("approved");

                    b.Property<int?>("CategoryId")
                        .HasColumnType("int")
                        .HasColumnName("category_id");

                    b.Property<int?>("Count")
                        .HasColumnType("int")
                        .HasColumnName("count");

                    b.Property<DateTime?>("CreateDate")
                        .HasColumnType("date")
                        .HasColumnName("create_date");

                    b.Property<string>("Description")
                        .IsUnicode(false)
                        .HasColumnType("varchar(max)")
                        .HasColumnName("description");

                    b.Property<int?>("GovernorateId")
                        .HasColumnType("int")
                        .HasColumnName("governorate_id");

                    b.Property<string>("Name")
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("varchar(100)")
                        .HasColumnName("name");

                    b.Property<DateTime?>("UpdateDate")
                        .HasColumnType("date")
                        .HasColumnName("update_date");

                    b.Property<int?>("UserId")
                        .HasColumnType("int")
                        .HasColumnName("user_id");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.HasIndex("GovernorateId");

                    b.HasIndex("UserId");

                    b.ToTable("Location");
                });

            modelBuilder.Entity("YouDontKnowEgypt.Models.LocationImage", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ImagePath")
                        .IsUnicode(false)
                        .HasColumnType("varchar(max)")
                        .HasColumnName("image_path");

                    b.Property<int?>("LocationId")
                        .HasColumnType("int")
                        .HasColumnName("location_id");

                    b.HasKey("Id");

                    b.HasIndex("LocationId");

                    b.ToTable("Location_image");
                });

            modelBuilder.Entity("YouDontKnowEgypt.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("varchar(100)")
                        .HasColumnName("email");

                    b.Property<bool?>("IsAdmin")
                        .HasColumnType("bit")
                        .HasColumnName("isAdmin");

                    b.Property<string>("Name")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("name");

                    b.Property<string>("Password")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("password");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("YouDontKnowEgypt.Models.Comment", b =>
                {
                    b.HasOne("YouDontKnowEgypt.Models.User", "User")
                        .WithMany("Comments")
                        .HasForeignKey("UserId")
                        .HasConstraintName("FK_Comments_Users")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.Navigation("User");
                });

            modelBuilder.Entity("YouDontKnowEgypt.Models.Hotel", b =>
                {
                    b.HasOne("YouDontKnowEgypt.Models.Governorate", "Governorate")
                        .WithMany("Hotels")
                        .HasForeignKey("GovernorateId")
                        .HasConstraintName("FK__Hotels__governor__21B6055D")
                        .OnDelete(DeleteBehavior.SetNull);

                    b.Navigation("Governorate");
                });

            modelBuilder.Entity("YouDontKnowEgypt.Models.HotelsImage", b =>
                {
                    b.HasOne("YouDontKnowEgypt.Models.Hotel", "Hotel")
                        .WithMany("HotelsImages")
                        .HasForeignKey("HotelId")
                        .HasConstraintName("FK__Hotels_im__hotel__24927208")
                        .OnDelete(DeleteBehavior.SetNull);

                    b.Navigation("Hotel");
                });

            modelBuilder.Entity("YouDontKnowEgypt.Models.Location", b =>
                {
                    b.HasOne("YouDontKnowEgypt.Models.Category", "Category")
                        .WithMany("Locations")
                        .HasForeignKey("CategoryId")
                        .HasConstraintName("FK__Location__catego__1BFD2C07")
                        .OnDelete(DeleteBehavior.SetNull);

                    b.HasOne("YouDontKnowEgypt.Models.Governorate", "Governorate")
                        .WithMany("Locations")
                        .HasForeignKey("GovernorateId")
                        .HasConstraintName("FK__Location__govern__1CF15040")
                        .OnDelete(DeleteBehavior.SetNull);

                    b.HasOne("YouDontKnowEgypt.Models.User", "User")
                        .WithMany("Locations")
                        .HasForeignKey("UserId")
                        .HasConstraintName("FK__Location__user_i__1DE57479")
                        .OnDelete(DeleteBehavior.SetNull);

                    b.Navigation("Category");

                    b.Navigation("Governorate");

                    b.Navigation("User");
                });

            modelBuilder.Entity("YouDontKnowEgypt.Models.LocationImage", b =>
                {
                    b.HasOne("YouDontKnowEgypt.Models.Location", "Location")
                        .WithMany("LocationImages")
                        .HasForeignKey("LocationId")
                        .HasConstraintName("FK__Location___locat__398D8EEE")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.Navigation("Location");
                });

            modelBuilder.Entity("YouDontKnowEgypt.Models.Category", b =>
                {
                    b.Navigation("Locations");
                });

            modelBuilder.Entity("YouDontKnowEgypt.Models.Governorate", b =>
                {
                    b.Navigation("Hotels");

                    b.Navigation("Locations");
                });

            modelBuilder.Entity("YouDontKnowEgypt.Models.Hotel", b =>
                {
                    b.Navigation("HotelsImages");
                });

            modelBuilder.Entity("YouDontKnowEgypt.Models.Location", b =>
                {
                    b.Navigation("LocationImages");
                });

            modelBuilder.Entity("YouDontKnowEgypt.Models.User", b =>
                {
                    b.Navigation("Comments");

                    b.Navigation("Locations");
                });
#pragma warning restore 612, 618
        }
    }
}
