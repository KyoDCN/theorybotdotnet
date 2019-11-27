﻿// <auto-generated />
using DiscordBotDotNet.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DiscordBotDotNet.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.0.1");

            modelBuilder.Entity("DSharpPlus.Entities.DiscordRole", b =>
                {
                    b.Property<ulong>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<bool>("IsHoisted")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("IsManaged")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("IsMentionable")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<long>("Permissions")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Position")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("PublicGuildRoles");
                });

            modelBuilder.Entity("DiscordBotDotNet.Domain.Quote", b =>
                {
                    b.Property<ulong>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Author")
                        .HasColumnType("TEXT");

                    b.Property<string>("Content")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Quotes");
                });
#pragma warning restore 612, 618
        }
    }
}