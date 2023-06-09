﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PocketForzaHorizonCommunity.Back.Database;

#nullable disable

namespace PocketForzaHorizonCommunity.Back.Database.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20230508195726_TiresRename")]
    partial class TiresRename
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole<System.Guid>", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<System.Guid>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("RoleId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<System.Guid>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<System.Guid>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<System.Guid>", b =>
                {
                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("RoleId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<System.Guid>", b =>
                {
                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("PocketForzaHorizonCommunity.Back.Database.Entities.ApplicationUser", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("PocketForzaHorizonCommunity.Back.Database.Entities.CarEntities.Car", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CarTypeId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ImagePath")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("ManufactureId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Model")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.Property<int>("Year")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CarTypeId");

                    b.HasIndex("ManufactureId");

                    b.ToTable("Cars");
                });

            modelBuilder.Entity("PocketForzaHorizonCommunity.Back.Database.Entities.CarEntities.CarType", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Types");
                });

            modelBuilder.Entity("PocketForzaHorizonCommunity.Back.Database.Entities.CarEntities.Manufacture", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Manufactures");
                });

            modelBuilder.Entity("PocketForzaHorizonCommunity.Back.Database.Entities.Guides.Design", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CarId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("ForzaShareCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Rating")
                        .HasColumnType("float");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("CarId");

                    b.HasIndex("UserId");

                    b.ToTable("Designs");
                });

            modelBuilder.Entity("PocketForzaHorizonCommunity.Back.Database.Entities.Guides.DesignOptions", b =>
                {
                    b.Property<Guid>("DesignId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ThumbnailPath")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("DesignId");

                    b.ToTable("DesignsOptions");
                });

            modelBuilder.Entity("PocketForzaHorizonCommunity.Back.Database.Entities.Guides.GalleryImage", b =>
                {
                    b.Property<Guid>("DesignOptionsId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ImagePath")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("DesignOptionsId", "ImagePath");

                    b.ToTable("GalleryImage");
                });

            modelBuilder.Entity("PocketForzaHorizonCommunity.Back.Database.Entities.Guides.Tune", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CarId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("ForzaShareCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Rating")
                        .HasColumnType("float");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("CarId");

                    b.HasIndex("UserId");

                    b.ToTable("Tunes");
                });

            modelBuilder.Entity("PocketForzaHorizonCommunity.Back.Database.Entities.Guides.TuneOptions", b =>
                {
                    b.Property<Guid>("TuneId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("AntiRollBars")
                        .HasColumnType("int");

                    b.Property<int>("Aspiration")
                        .HasColumnType("int");

                    b.Property<int>("Brakes")
                        .HasColumnType("int");

                    b.Property<int>("Clutch")
                        .HasColumnType("int");

                    b.Property<int>("Compound")
                        .HasColumnType("int");

                    b.Property<int>("Differential")
                        .HasColumnType("int");

                    b.Property<int>("Displacement")
                        .HasColumnType("int");

                    b.Property<string>("DrivetrainDescription")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Engine")
                        .HasColumnType("int");

                    b.Property<string>("EngineDescription")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Exhaust")
                        .HasColumnType("int");

                    b.Property<int>("FrontTireWidth")
                        .HasColumnType("int");

                    b.Property<int>("FrontTrackWidth")
                        .HasColumnType("int");

                    b.Property<string>("HandlingDescription")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Ignition")
                        .HasColumnType("int");

                    b.Property<int>("Intake")
                        .HasColumnType("int");

                    b.Property<int>("RearTireWidth")
                        .HasColumnType("int");

                    b.Property<int>("RearTrackWidth")
                        .HasColumnType("int");

                    b.Property<int>("RollCage")
                        .HasColumnType("int");

                    b.Property<int>("Suspension")
                        .HasColumnType("int");

                    b.Property<string>("TiresDescription")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Transmission")
                        .HasColumnType("int");

                    b.HasKey("TuneId");

                    b.ToTable("TunesOptions");
                });

            modelBuilder.Entity("PocketForzaHorizonCommunity.Back.Database.Entities.OwnedCarsByUsers", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<Guid>("CarId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("CarId");

                    b.HasIndex("UserId");

                    b.ToTable("OwnedCarsByUsers");
                });

            modelBuilder.Entity("PocketForzaHorizonCommunity.Back.Database.Entities.UserStatistics.CampaignStatistics", b =>
                {
                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("DangerSignStars")
                        .HasColumnType("int");

                    b.Property<int>("DriftZoneStars")
                        .HasColumnType("int");

                    b.Property<int>("ExhibitionsCompleted")
                        .HasColumnType("int");

                    b.Property<int>("HeadToHeadEntered")
                        .HasColumnType("int");

                    b.Property<int>("HeadToHeadWon")
                        .HasColumnType("int");

                    b.Property<int>("SpeedTrapStars")
                        .HasColumnType("int");

                    b.Property<int>("SpeedZoneStars")
                        .HasColumnType("int");

                    b.Property<int>("StoriesCompleted")
                        .HasColumnType("int");

                    b.Property<int>("StoryStarsEarned")
                        .HasColumnType("int");

                    b.Property<int>("TotalRaces")
                        .HasColumnType("int");

                    b.Property<int>("TrailblazerStars")
                        .HasColumnType("int");

                    b.HasKey("UserId");

                    b.ToTable("CampaignStatistics");
                });

            modelBuilder.Entity("PocketForzaHorizonCommunity.Back.Database.Entities.UserStatistics.GeneralStatistics", b =>
                {
                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CarId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("CollisionsPerRace")
                        .HasColumnType("int");

                    b.Property<int>("DailyChallengesCompleted")
                        .HasColumnType("int");

                    b.Property<Guid>("FavouriteCarId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("GarageValue")
                        .HasColumnType("int");

                    b.Property<long>("TimeDrivenInTicks")
                        .HasColumnType("bigint");

                    b.Property<int>("TotalCleanLaps")
                        .HasColumnType("int");

                    b.Property<int>("TotalPodiums")
                        .HasColumnType("int");

                    b.Property<int>("TotalVictories")
                        .HasColumnType("int");

                    b.Property<int>("WeeklyChallengesComplited")
                        .HasColumnType("int");

                    b.HasKey("UserId");

                    b.HasIndex("CarId");

                    b.ToTable("GeneralStatistics");
                });

            modelBuilder.Entity("PocketForzaHorizonCommunity.Back.Database.Entities.UserStatistics.OnlineStatistics", b =>
                {
                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("ArcadeEventsCompleted")
                        .HasColumnType("int");

                    b.Property<int>("ArcadeEventsEntered")
                        .HasColumnType("int");

                    b.Property<int>("FlagRushWon")
                        .HasColumnType("int");

                    b.Property<int>("FlagsCaptured")
                        .HasColumnType("int");

                    b.Property<int>("GivenKudos")
                        .HasColumnType("int");

                    b.Property<int>("InfectedGamesWon")
                        .HasColumnType("int");

                    b.Property<int>("KingGamesWon")
                        .HasColumnType("int");

                    b.Property<int>("RecievedKudos")
                        .HasColumnType("int");

                    b.Property<int>("RivalsBeaten")
                        .HasColumnType("int");

                    b.Property<int>("RivalsLapsCompleted")
                        .HasColumnType("int");

                    b.Property<int>("TeamFlagRushWon")
                        .HasColumnType("int");

                    b.Property<int>("TeamKingGamesWon")
                        .HasColumnType("int");

                    b.Property<int>("TimesInfectedByOthers")
                        .HasColumnType("int");

                    b.Property<int>("TimesInfectedOthers")
                        .HasColumnType("int");

                    b.HasKey("UserId");

                    b.ToTable("OnlineStatistics");
                });

            modelBuilder.Entity("PocketForzaHorizonCommunity.Back.Database.Entities.UserStatistics.RecordsStatistics", b =>
                {
                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<double>("AvarageSpeed")
                        .HasColumnType("float");

                    b.Property<int>("DistanceDriven")
                        .HasColumnType("int");

                    b.Property<double>("HighestDangerSignScore")
                        .HasColumnType("float");

                    b.Property<int>("HighestDriftScore")
                        .HasColumnType("int");

                    b.Property<double>("HighestSpeedTrapScore")
                        .HasColumnType("float");

                    b.Property<double>("HighestSpeedZoneScore")
                        .HasColumnType("float");

                    b.Property<double>("LongestDrift")
                        .HasColumnType("float");

                    b.Property<double>("LongestJump")
                        .HasColumnType("float");

                    b.Property<long>("LongestSkillChainInTicks")
                        .HasColumnType("bigint");

                    b.Property<double>("TopSpeed")
                        .HasColumnType("float");

                    b.HasKey("UserId");

                    b.ToTable("RecordsStatistics");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<System.Guid>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole<System.Guid>", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<System.Guid>", b =>
                {
                    b.HasOne("PocketForzaHorizonCommunity.Back.Database.Entities.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<System.Guid>", b =>
                {
                    b.HasOne("PocketForzaHorizonCommunity.Back.Database.Entities.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<System.Guid>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole<System.Guid>", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PocketForzaHorizonCommunity.Back.Database.Entities.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<System.Guid>", b =>
                {
                    b.HasOne("PocketForzaHorizonCommunity.Back.Database.Entities.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("PocketForzaHorizonCommunity.Back.Database.Entities.CarEntities.Car", b =>
                {
                    b.HasOne("PocketForzaHorizonCommunity.Back.Database.Entities.CarEntities.CarType", "CarType")
                        .WithMany("Cars")
                        .HasForeignKey("CarTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PocketForzaHorizonCommunity.Back.Database.Entities.CarEntities.Manufacture", "Manufacture")
                        .WithMany("Cars")
                        .HasForeignKey("ManufactureId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CarType");

                    b.Navigation("Manufacture");
                });

            modelBuilder.Entity("PocketForzaHorizonCommunity.Back.Database.Entities.Guides.Design", b =>
                {
                    b.HasOne("PocketForzaHorizonCommunity.Back.Database.Entities.CarEntities.Car", "Car")
                        .WithMany("Designs")
                        .HasForeignKey("CarId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PocketForzaHorizonCommunity.Back.Database.Entities.ApplicationUser", "User")
                        .WithMany("Designs")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Car");

                    b.Navigation("User");
                });

            modelBuilder.Entity("PocketForzaHorizonCommunity.Back.Database.Entities.Guides.DesignOptions", b =>
                {
                    b.HasOne("PocketForzaHorizonCommunity.Back.Database.Entities.Guides.Design", "Design")
                        .WithOne("DesignOptions")
                        .HasForeignKey("PocketForzaHorizonCommunity.Back.Database.Entities.Guides.DesignOptions", "DesignId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Design");
                });

            modelBuilder.Entity("PocketForzaHorizonCommunity.Back.Database.Entities.Guides.GalleryImage", b =>
                {
                    b.HasOne("PocketForzaHorizonCommunity.Back.Database.Entities.Guides.DesignOptions", "DesignOptions")
                        .WithMany("Gallery")
                        .HasForeignKey("DesignOptionsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("DesignOptions");
                });

            modelBuilder.Entity("PocketForzaHorizonCommunity.Back.Database.Entities.Guides.Tune", b =>
                {
                    b.HasOne("PocketForzaHorizonCommunity.Back.Database.Entities.CarEntities.Car", "Car")
                        .WithMany("Tunes")
                        .HasForeignKey("CarId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PocketForzaHorizonCommunity.Back.Database.Entities.ApplicationUser", "User")
                        .WithMany("Tunes")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Car");

                    b.Navigation("User");
                });

            modelBuilder.Entity("PocketForzaHorizonCommunity.Back.Database.Entities.Guides.TuneOptions", b =>
                {
                    b.HasOne("PocketForzaHorizonCommunity.Back.Database.Entities.Guides.Tune", "Tune")
                        .WithOne("TuneOptions")
                        .HasForeignKey("PocketForzaHorizonCommunity.Back.Database.Entities.Guides.TuneOptions", "TuneId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Tune");
                });

            modelBuilder.Entity("PocketForzaHorizonCommunity.Back.Database.Entities.OwnedCarsByUsers", b =>
                {
                    b.HasOne("PocketForzaHorizonCommunity.Back.Database.Entities.CarEntities.Car", "Car")
                        .WithMany("OwnedCarsByUsers")
                        .HasForeignKey("CarId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PocketForzaHorizonCommunity.Back.Database.Entities.ApplicationUser", "User")
                        .WithMany("OwnedCarsByUsers")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Car");

                    b.Navigation("User");
                });

            modelBuilder.Entity("PocketForzaHorizonCommunity.Back.Database.Entities.UserStatistics.CampaignStatistics", b =>
                {
                    b.HasOne("PocketForzaHorizonCommunity.Back.Database.Entities.ApplicationUser", "User")
                        .WithOne("CampaignStatistics")
                        .HasForeignKey("PocketForzaHorizonCommunity.Back.Database.Entities.UserStatistics.CampaignStatistics", "UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("PocketForzaHorizonCommunity.Back.Database.Entities.UserStatistics.GeneralStatistics", b =>
                {
                    b.HasOne("PocketForzaHorizonCommunity.Back.Database.Entities.CarEntities.Car", "Car")
                        .WithMany()
                        .HasForeignKey("CarId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PocketForzaHorizonCommunity.Back.Database.Entities.ApplicationUser", "User")
                        .WithOne("GeneralStatistics")
                        .HasForeignKey("PocketForzaHorizonCommunity.Back.Database.Entities.UserStatistics.GeneralStatistics", "UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Car");

                    b.Navigation("User");
                });

            modelBuilder.Entity("PocketForzaHorizonCommunity.Back.Database.Entities.UserStatistics.OnlineStatistics", b =>
                {
                    b.HasOne("PocketForzaHorizonCommunity.Back.Database.Entities.ApplicationUser", "User")
                        .WithOne("OnlineStatistics")
                        .HasForeignKey("PocketForzaHorizonCommunity.Back.Database.Entities.UserStatistics.OnlineStatistics", "UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("PocketForzaHorizonCommunity.Back.Database.Entities.UserStatistics.RecordsStatistics", b =>
                {
                    b.HasOne("PocketForzaHorizonCommunity.Back.Database.Entities.ApplicationUser", "User")
                        .WithOne("RecordsStatistics")
                        .HasForeignKey("PocketForzaHorizonCommunity.Back.Database.Entities.UserStatistics.RecordsStatistics", "UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("PocketForzaHorizonCommunity.Back.Database.Entities.ApplicationUser", b =>
                {
                    b.Navigation("CampaignStatistics")
                        .IsRequired();

                    b.Navigation("Designs");

                    b.Navigation("GeneralStatistics")
                        .IsRequired();

                    b.Navigation("OnlineStatistics")
                        .IsRequired();

                    b.Navigation("OwnedCarsByUsers");

                    b.Navigation("RecordsStatistics")
                        .IsRequired();

                    b.Navigation("Tunes");
                });

            modelBuilder.Entity("PocketForzaHorizonCommunity.Back.Database.Entities.CarEntities.Car", b =>
                {
                    b.Navigation("Designs");

                    b.Navigation("OwnedCarsByUsers");

                    b.Navigation("Tunes");
                });

            modelBuilder.Entity("PocketForzaHorizonCommunity.Back.Database.Entities.CarEntities.CarType", b =>
                {
                    b.Navigation("Cars");
                });

            modelBuilder.Entity("PocketForzaHorizonCommunity.Back.Database.Entities.CarEntities.Manufacture", b =>
                {
                    b.Navigation("Cars");
                });

            modelBuilder.Entity("PocketForzaHorizonCommunity.Back.Database.Entities.Guides.Design", b =>
                {
                    b.Navigation("DesignOptions")
                        .IsRequired();
                });

            modelBuilder.Entity("PocketForzaHorizonCommunity.Back.Database.Entities.Guides.DesignOptions", b =>
                {
                    b.Navigation("Gallery");
                });

            modelBuilder.Entity("PocketForzaHorizonCommunity.Back.Database.Entities.Guides.Tune", b =>
                {
                    b.Navigation("TuneOptions")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
