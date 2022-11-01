﻿// <auto-generated />
using System;
using GrillBot.Cache.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace GrillBot.Cache.Migrations
{
    [DbContext(typeof(GrillBotCacheContext))]
    [Migration("20221101184401_RemovedDirectApi")]
    partial class RemovedDirectApi
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("GrillBot.Cache.Entity.InviteMetadata", b =>
                {
                    b.Property<string>("GuildId")
                        .HasMaxLength(30)
                        .HasColumnType("character varying(30)");

                    b.Property<string>("Code")
                        .HasMaxLength(10)
                        .HasColumnType("character varying(10)");

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("CreatorId")
                        .HasMaxLength(30)
                        .HasColumnType("character varying(30)");

                    b.Property<bool>("IsVanity")
                        .HasColumnType("boolean");

                    b.Property<int>("Uses")
                        .HasColumnType("integer");

                    b.HasKey("GuildId", "Code");

                    b.ToTable("InviteMetadata");
                });

            modelBuilder.Entity("GrillBot.Cache.Entity.MessageIndex", b =>
                {
                    b.Property<string>("MessageId")
                        .HasMaxLength(30)
                        .HasColumnType("character varying(30)");

                    b.Property<string>("AuthorId")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("character varying(30)");

                    b.Property<string>("ChannelId")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("character varying(30)");

                    b.Property<string>("GuildId")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("character varying(30)");

                    b.HasKey("MessageId");

                    b.HasIndex(new[] { "AuthorId" }, "IX_MessageCache_AuthorId");

                    b.HasIndex(new[] { "ChannelId" }, "IX_MessageCache_ChannelId");

                    b.HasIndex(new[] { "GuildId" }, "IX_MessageCache_GuildId");

                    b.ToTable("MessageIndex");
                });

            modelBuilder.Entity("GrillBot.Cache.Entity.ProfilePicture", b =>
                {
                    b.Property<string>("UserId")
                        .HasMaxLength(30)
                        .HasColumnType("character varying(30)");

                    b.Property<short>("Size")
                        .HasColumnType("smallint");

                    b.Property<string>("AvatarId")
                        .HasMaxLength(255)
                        .HasColumnType("character varying(255)");

                    b.Property<byte[]>("Data")
                        .IsRequired()
                        .HasColumnType("bytea");

                    b.Property<bool>("IsAnimated")
                        .HasColumnType("boolean");

                    b.HasKey("UserId", "Size", "AvatarId");

                    b.ToTable("ProfilePictures");
                });
#pragma warning restore 612, 618
        }
    }
}
