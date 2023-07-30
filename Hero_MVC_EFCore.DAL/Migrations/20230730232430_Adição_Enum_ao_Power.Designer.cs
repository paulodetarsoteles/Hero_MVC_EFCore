﻿// <auto-generated />
using System;
using Hero_MVC_EFCore.DAL.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Hero_MVC_EFCore.DAL.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20230730232430_Adição_Enum_ao_Power")]
    partial class Adição_Enum_ao_Power
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("FilmHero", b =>
                {
                    b.Property<int>("FilmsFilmId")
                        .HasColumnType("int");

                    b.Property<int>("HeroesHeroId")
                        .HasColumnType("int");

                    b.HasKey("FilmsFilmId", "HeroesHeroId");

                    b.HasIndex("HeroesHeroId");

                    b.ToTable("FilmHero");
                });

            modelBuilder.Entity("Hero_MVC_EFCore.Domain.Models.Film", b =>
                {
                    b.Property<int>("FilmId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("FilmId"));

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Rate")
                        .HasColumnType("int");

                    b.HasKey("FilmId");

                    b.ToTable("Films");
                });

            modelBuilder.Entity("Hero_MVC_EFCore.Domain.Models.Hero", b =>
                {
                    b.Property<int>("HeroId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("HeroId"));

                    b.Property<bool>("Active")
                        .HasColumnType("bit");

                    b.Property<string>("Comments")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SecretIdentityId")
                        .HasColumnType("int");

                    b.Property<DateTime>("UpdateDate")
                        .HasColumnType("datetime2");

                    b.HasKey("HeroId");

                    b.HasIndex("SecretIdentityId")
                        .IsUnique();

                    b.ToTable("Heroes");
                });

            modelBuilder.Entity("Hero_MVC_EFCore.Domain.Models.Power", b =>
                {
                    b.Property<int>("PowerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PowerId"));

                    b.Property<int?>("HeroId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Type")
                        .HasColumnType("int");

                    b.HasKey("PowerId");

                    b.HasIndex("HeroId");

                    b.ToTable("Powers");
                });

            modelBuilder.Entity("Hero_MVC_EFCore.Domain.Models.SecretIdentity", b =>
                {
                    b.Property<int>("SecretIdentityId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SecretIdentityId"));

                    b.Property<string>("Comments")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("UpdateDate")
                        .HasColumnType("datetime2");

                    b.HasKey("SecretIdentityId");

                    b.ToTable("SecretIdentities");
                });

            modelBuilder.Entity("FilmHero", b =>
                {
                    b.HasOne("Hero_MVC_EFCore.Domain.Models.Film", null)
                        .WithMany()
                        .HasForeignKey("FilmsFilmId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Hero_MVC_EFCore.Domain.Models.Hero", null)
                        .WithMany()
                        .HasForeignKey("HeroesHeroId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Hero_MVC_EFCore.Domain.Models.Hero", b =>
                {
                    b.HasOne("Hero_MVC_EFCore.Domain.Models.SecretIdentity", "SecretIdentity")
                        .WithOne("Hero")
                        .HasForeignKey("Hero_MVC_EFCore.Domain.Models.Hero", "SecretIdentityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("SecretIdentity");
                });

            modelBuilder.Entity("Hero_MVC_EFCore.Domain.Models.Power", b =>
                {
                    b.HasOne("Hero_MVC_EFCore.Domain.Models.Hero", "Hero")
                        .WithMany("Powers")
                        .HasForeignKey("HeroId");

                    b.Navigation("Hero");
                });

            modelBuilder.Entity("Hero_MVC_EFCore.Domain.Models.Hero", b =>
                {
                    b.Navigation("Powers");
                });

            modelBuilder.Entity("Hero_MVC_EFCore.Domain.Models.SecretIdentity", b =>
                {
                    b.Navigation("Hero");
                });
#pragma warning restore 612, 618
        }
    }
}
