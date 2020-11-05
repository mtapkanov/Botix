﻿// <auto-generated />
using System;
using Botix.Bot.Infrastructure.DataBase;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace Botix.Bot.Infrastructure.Migrations
{
    [DbContext(typeof(BotDbContext))]
    [Migration("20201105195042_Initialization")]
    partial class Initialization
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                .HasAnnotation("ProductVersion", "3.1.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("Botix.Bot.Core.Domains.CallBack", b =>
                {
                    b.Property<long>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<long>("CallBackGroupID")
                        .HasColumnType("bigint");

                    b.Property<string>("Caption")
                        .HasColumnType("text");

                    b.Property<string>("Guid")
                        .HasColumnType("text");

                    b.HasKey("ID");

                    b.HasIndex("CallBackGroupID");

                    b.ToTable("CallBacks","api");
                });

            modelBuilder.Entity("Botix.Bot.Core.Domains.CallBackGroup", b =>
                {
                    b.Property<long>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp without time zone");

                    b.Property<bool>("IsProcessed")
                        .HasColumnType("boolean");

                    b.Property<string>("MessageCallBack")
                        .HasColumnType("text");

                    b.HasKey("ID");

                    b.ToTable("CallBackGroups","api");
                });

            modelBuilder.Entity("Botix.Bot.Core.Domains.User", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityAlwaysColumn);

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("FirstName")
                        .HasColumnType("text");

                    b.Property<long>("Identifier")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("UpdateAt")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Users","api");
                });

            modelBuilder.Entity("Botix.Bot.Core.Domains.CallBack", b =>
                {
                    b.HasOne("Botix.Bot.Core.Domains.CallBackGroup", "CallBackGroup")
                        .WithMany("CallBacks")
                        .HasForeignKey("CallBackGroupID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}