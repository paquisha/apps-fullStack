﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ScoreCard.Infrastructure;

#nullable disable

namespace ScoreCard.Infrastructure.Migrations
{
    [DbContext(typeof(ScoreCardDbContext))]
    [Migration("20230405210606_initialMigrations3")]
    partial class initialMigrations3
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ScoreCard.Domain.Entities.ControlRecommendationId", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ControlRemediationId")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<Guid>("SecurityScoreSnapshotId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("SecurityScoreSnapshotId");

                    b.ToTable("ControlRecommendationId", (string)null);
                });

            modelBuilder.Entity("ScoreCard.Domain.Entities.Customer", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.HasKey("Id");

                    b.ToTable("Customer", (string)null);
                });

            modelBuilder.Entity("ScoreCard.Domain.Entities.CustomerSecretInformation", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ApplicationId")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("ClientSecret")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<Guid>("CustomerId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("TenantId")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.HasKey("Id");

                    b.HasIndex("CustomerId")
                        .IsUnique();

                    b.ToTable("CustomerSecretInformation", (string)null);
                });

            modelBuilder.Entity("ScoreCard.Domain.Entities.SecureScore", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<decimal>("CurrentScore")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("MaxScore")
                        .HasColumnType("int");

                    b.Property<decimal>("PercentageScore")
                        .HasMaxLength(255)
                        .HasColumnType("decimal(18,2)");

                    b.Property<Guid>("SecurityScoreSnapshotId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("SubscriptionId")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("Tenantid")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<int>("Weight")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("SecurityScoreSnapshotId");

                    b.ToTable("SecureScore", (string)null);
                });

            modelBuilder.Entity("ScoreCard.Domain.Entities.SecurityPlan", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("AzureDefenderPlan")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<Guid>("SecurityScoreSnapshotId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Status")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("SubscriptionId")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.HasKey("Id");

                    b.HasIndex("SecurityScoreSnapshotId");

                    b.ToTable("SecurityPlan", (string)null);
                });

            modelBuilder.Entity("ScoreCard.Domain.Entities.SecurityScoreControl", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ControlId")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("ControlName")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("ControlType")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<decimal>("CurrentScore")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("HealthyResourceCount")
                        .HasColumnType("int");

                    b.Property<int>("MaxScore")
                        .HasColumnType("int");

                    b.Property<int>("NotAppliclableResourceCount")
                        .HasColumnType("int");

                    b.Property<decimal>("PercentageScore")
                        .HasColumnType("decimal(18,2)");

                    b.Property<Guid>("SecurityScoreSnapshotId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("SubscriptionId")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("TenantId")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<int>("UnhealthyResourceCount")
                        .HasColumnType("int");

                    b.Property<int>("Weight")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("SecurityScoreSnapshotId");

                    b.ToTable("SecurityScoreControl", (string)null);
                });

            modelBuilder.Entity("ScoreCard.Domain.Entities.SecurityScoreSnapshot", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CustomerId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("SnapshotDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("SubscriptionId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("SubscriptionId");

                    b.ToTable("SecurityScoreSnapshot", (string)null);
                });

            modelBuilder.Entity("ScoreCard.Domain.Entities.SecurityStandard", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ComplianceStandard")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<int>("FailControl")
                        .HasColumnType("int");

                    b.Property<int>("PassedControl")
                        .HasColumnType("int");

                    b.Property<Guid>("SecurityScoreSnapshotId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("State")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("SubscriptionId")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("TenantId")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<int>("UnsupportedControl")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("SecurityScoreSnapshotId");

                    b.ToTable("SecurityStandard", (string)null);
                });

            modelBuilder.Entity("ScoreCard.Domain.Entities.Subscription", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CustomerId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("SubscriptionId")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.HasKey("Id");

                    b.HasIndex("CustomerId");

                    b.ToTable("Subscription", (string)null);
                });

            modelBuilder.Entity("ScoreCard.Domain.Entities.ControlRecommendationId", b =>
                {
                    b.HasOne("ScoreCard.Domain.Entities.SecurityScoreSnapshot", null)
                        .WithMany("ControlRecommendationIds")
                        .HasForeignKey("SecurityScoreSnapshotId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ScoreCard.Domain.Entities.CustomerSecretInformation", b =>
                {
                    b.HasOne("ScoreCard.Domain.Entities.Customer", null)
                        .WithOne("CustomerSecretInformation")
                        .HasForeignKey("ScoreCard.Domain.Entities.CustomerSecretInformation", "CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ScoreCard.Domain.Entities.SecureScore", b =>
                {
                    b.HasOne("ScoreCard.Domain.Entities.SecurityScoreSnapshot", null)
                        .WithMany("SecureScores")
                        .HasForeignKey("SecurityScoreSnapshotId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ScoreCard.Domain.Entities.SecurityPlan", b =>
                {
                    b.HasOne("ScoreCard.Domain.Entities.SecurityScoreSnapshot", null)
                        .WithMany("SecurityPlans")
                        .HasForeignKey("SecurityScoreSnapshotId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ScoreCard.Domain.Entities.SecurityScoreControl", b =>
                {
                    b.HasOne("ScoreCard.Domain.Entities.SecurityScoreSnapshot", null)
                        .WithMany("SecurityScoreControls")
                        .HasForeignKey("SecurityScoreSnapshotId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ScoreCard.Domain.Entities.SecurityScoreSnapshot", b =>
                {
                    b.HasOne("ScoreCard.Domain.Entities.Subscription", null)
                        .WithMany("SecurityScoreSnapshots")
                        .HasForeignKey("SubscriptionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ScoreCard.Domain.Entities.SecurityStandard", b =>
                {
                    b.HasOne("ScoreCard.Domain.Entities.SecurityScoreSnapshot", null)
                        .WithMany("SecurityStandards")
                        .HasForeignKey("SecurityScoreSnapshotId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ScoreCard.Domain.Entities.Subscription", b =>
                {
                    b.HasOne("ScoreCard.Domain.Entities.Customer", null)
                        .WithMany("Subscriptions")
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ScoreCard.Domain.Entities.Customer", b =>
                {
                    b.Navigation("CustomerSecretInformation");

                    b.Navigation("Subscriptions");
                });

            modelBuilder.Entity("ScoreCard.Domain.Entities.SecurityScoreSnapshot", b =>
                {
                    b.Navigation("ControlRecommendationIds");

                    b.Navigation("SecureScores");

                    b.Navigation("SecurityPlans");

                    b.Navigation("SecurityScoreControls");

                    b.Navigation("SecurityStandards");
                });

            modelBuilder.Entity("ScoreCard.Domain.Entities.Subscription", b =>
                {
                    b.Navigation("SecurityScoreSnapshots");
                });
#pragma warning restore 612, 618
        }
    }
}