﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RoomService.Models;

namespace RoomService.WebApi.Migrations
{
    [DbContext(typeof(ServiceContext))]
    [Migration("20210201092718_initialcreate")]
    partial class initialcreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.2");

            modelBuilder.Entity("RoomService.Models.Service", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT");

                    b.Property<bool>("IsBonusActivated")
                        .HasColumnType("INTEGER");

                    b.Property<string>("PromoCode")
                        .HasColumnType("TEXT");

                    b.Property<string>("SiteName")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Services");

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            Description = "Description1",
                            IsBonusActivated = false,
                            PromoCode = "PromoCode1",
                            SiteName = "SiteConstructor.io"
                        },
                        new
                        {
                            Id = 2L,
                            Description = "Description2",
                            IsBonusActivated = false,
                            PromoCode = "PromoCode2",
                            SiteName = "AppVision.io"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
