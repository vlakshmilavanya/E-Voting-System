﻿// <auto-generated />
using System;
using BusinessDirectory.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BusinessDirectory.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20220320080043_addcontext")]
    partial class addcontext
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.2");

            modelBuilder.Entity("BusinessDirectory.DB.Models.Address", b =>
                {
                    b.Property<int>("AddressID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("AddressTimestamp")
                        .HasColumnType("TEXT");

                    b.Property<string>("Area")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Building")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("CountryId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Landmark")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<long>("Pincode")
                        .HasColumnType("INTEGER");

                    b.Property<int>("StateId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Street")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("UpdateDate")
                        .HasColumnType("TEXT");

                    b.HasKey("AddressID");

                    b.HasIndex("CountryId");

                    b.HasIndex("StateId");

                    b.ToTable("tblAddress");
                });

            modelBuilder.Entity("BusinessDirectory.DB.Models.Country", b =>
                {
                    b.Property<int>("CountryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("COuntryTimeStamp")
                        .HasColumnType("TEXT");

                    b.Property<string>("CountryName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("CountryId");

                    b.ToTable("tblCountries");
                });

            modelBuilder.Entity("BusinessDirectory.DB.Models.Query", b =>
                {
                    b.Property<int>("QueryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("QueryDescription")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("QueryTimestamp")
                        .HasColumnType("TEXT");

                    b.Property<int>("UserId")
                        .HasColumnType("INTEGER");

                    b.HasKey("QueryId");

                    b.HasIndex("UserId");

                    b.ToTable("tblQueries");
                });

            modelBuilder.Entity("BusinessDirectory.DB.Models.Roles", b =>
                {
                    b.Property<int>("RoleID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("CreatedBy")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("IsActive")
                        .HasColumnType("INTEGER");

                    b.Property<int>("RoleTypeID")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("RolesTimestamp")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("UpdateDate")
                        .HasColumnType("TEXT");

                    b.Property<int>("UserID")
                        .HasColumnType("INTEGER");

                    b.HasKey("RoleID");

                    b.HasIndex("RoleTypeID");

                    b.HasIndex("UserID");

                    b.ToTable("tblRoles");
                });

            modelBuilder.Entity("BusinessDirectory.DB.Models.RoleType", b =>
                {
                    b.Property<int>("RoleTypeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<bool>("IsActive")
                        .HasColumnType("INTEGER");

                    b.Property<string>("RoleTitle")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("RoleTypeId");

                    b.ToTable("tblRoleTypes");
                });

            modelBuilder.Entity("BusinessDirectory.DB.Models.ShareYourViews", b =>
                {
                    b.Property<int>("ShareYourViewsId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("UserId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("View")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("ViewsTimestamp")
                        .HasColumnType("TEXT");

                    b.HasKey("ShareYourViewsId");

                    b.HasIndex("UserId");

                    b.ToTable("tblShareYourViews");
                });

            modelBuilder.Entity("BusinessDirectory.DB.Models.State", b =>
                {
                    b.Property<int>("StateId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("StateName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("StateTimestamp")
                        .HasColumnType("TEXT");

                    b.HasKey("StateId");

                    b.ToTable("tblStates");
                });

            modelBuilder.Entity("BusinessDirectory.DB.Models.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("AddressID")
                        .HasColumnType("INTEGER");

                    b.Property<string>("EmailAddress")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<bool>("IsActive")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("IsCandidate")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("IsVoter")
                        .HasColumnType("INTEGER");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<long>("MobileNumber")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("UpdateTimestamp")
                        .HasColumnType("TEXT");

                    b.Property<int>("UpdatedBy")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("UserTimestamp")
                        .HasColumnType("TEXT");

                    b.Property<int>("numberOfVotes")
                        .HasColumnType("INTEGER");

                    b.HasKey("UserId");

                    b.HasIndex("AddressID");

                    b.ToTable("tblUsers");
                });

            modelBuilder.Entity("BusinessDirectory.DB.Models.Vote", b =>
                {
                    b.Property<int>("VoteId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<bool>("IsActive")
                        .HasColumnType("INTEGER");

                    b.Property<int>("UserId")
                        .HasColumnType("INTEGER");

                    b.HasKey("VoteId");

                    b.HasIndex("UserId");

                    b.ToTable("tblVotes");
                });

            modelBuilder.Entity("BusinessDirectory.DB.Models.Address", b =>
                {
                    b.HasOne("BusinessDirectory.DB.Models.Country", "Country")
                        .WithMany()
                        .HasForeignKey("CountryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BusinessDirectory.DB.Models.State", "State")
                        .WithMany()
                        .HasForeignKey("StateId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Country");

                    b.Navigation("State");
                });

            modelBuilder.Entity("BusinessDirectory.DB.Models.Query", b =>
                {
                    b.HasOne("BusinessDirectory.DB.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("BusinessDirectory.DB.Models.Roles", b =>
                {
                    b.HasOne("BusinessDirectory.DB.Models.RoleType", "RoleType")
                        .WithMany()
                        .HasForeignKey("RoleTypeID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BusinessDirectory.DB.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("RoleType");

                    b.Navigation("User");
                });

            modelBuilder.Entity("BusinessDirectory.DB.Models.ShareYourViews", b =>
                {
                    b.HasOne("BusinessDirectory.DB.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("BusinessDirectory.DB.Models.User", b =>
                {
                    b.HasOne("BusinessDirectory.DB.Models.Address", "Address")
                        .WithMany()
                        .HasForeignKey("AddressID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Address");
                });

            modelBuilder.Entity("BusinessDirectory.DB.Models.Vote", b =>
                {
                    b.HasOne("BusinessDirectory.DB.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });
#pragma warning restore 612, 618
        }
    }
}
