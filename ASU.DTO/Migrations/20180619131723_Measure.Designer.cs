﻿// <auto-generated />
using System;
using ASU.DTO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ASU.DTO.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20180619131723_Measure")]
    partial class Measure
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.0-rtm-30799")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ASU.DTO.Actors.BaseActor", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Discriminator")
                        .IsRequired();

                    b.Property<bool>("IsSaved");

                    b.Property<string>("Mnemo");

                    b.Property<string>("Name");

                    b.Property<decimal?>("OriginalId");

                    b.HasKey("Id");

                    b.ToTable("BaseActor");

                    b.HasDiscriminator<string>("Discriminator").HasValue("BaseActor");
                });

            modelBuilder.Entity("ASU.DTO.Entities.BaseEntity", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("AuthorId");

                    b.Property<string>("Discriminator")
                        .IsRequired();

                    b.Property<bool>("IsSaved");

                    b.Property<string>("Mnemo");

                    b.Property<string>("Name");

                    b.Property<string>("Note");

                    b.Property<decimal>("OriginalId");

                    b.Property<string>("OwnerId");

                    b.Property<string>("ParentId");

                    b.HasKey("Id");

                    b.HasIndex("AuthorId");

                    b.HasIndex("OwnerId");

                    b.HasIndex("ParentId");

                    b.ToTable("BaseEntity");

                    b.HasDiscriminator<string>("Discriminator").HasValue("BaseEntity");
                });

            modelBuilder.Entity("ASU.DTO.Entities.MeasurementType", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("IsSaved");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("MeasurementTypes");
                });

            modelBuilder.Entity("ASU.DTO.User", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("IsActive");

                    b.Property<bool>("IsSaved");

                    b.Property<string>("Login");

                    b.Property<string>("OrganizationId");

                    b.Property<string>("Password");

                    b.Property<string>("PersonId");

                    b.HasKey("Id");

                    b.HasIndex("OrganizationId");

                    b.HasIndex("PersonId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("ASU.DTO.Actors.Declarant", b =>
                {
                    b.HasBaseType("ASU.DTO.Actors.BaseActor");

                    b.Property<string>("Address");

                    b.Property<string>("IIN");

                    b.Property<string>("Phone");

                    b.ToTable("Declarant");

                    b.HasDiscriminator().HasValue("Declarant");
                });

            modelBuilder.Entity("ASU.DTO.Actors.Verificator", b =>
                {
                    b.HasBaseType("ASU.DTO.Actors.BaseActor");

                    b.Property<string>("Address")
                        .HasColumnName("Verificator_Address");

                    b.Property<string>("Certificate");

                    b.Property<string>("Code");

                    b.Property<string>("Director");

                    b.Property<bool>("IsCheckAuthor");

                    b.Property<string>("Phone")
                        .HasColumnName("Verificator_Phone");

                    b.ToTable("Verificator");

                    b.HasDiscriminator().HasValue("Verificator");
                });

            modelBuilder.Entity("ASU.DTO.Entities.TestEquipment", b =>
                {
                    b.HasBaseType("ASU.DTO.Entities.BaseEntity");

                    b.Property<string>("TECoutry");

                    b.Property<string>("TEManufatureDate");

                    b.Property<string>("TEModel");

                    b.Property<string>("TEProducer");

                    b.Property<string>("TEWorkNumber");

                    b.ToTable("TestEquipment");

                    b.HasDiscriminator().HasValue("TestEquipment");
                });

            modelBuilder.Entity("ASU.DTO.Entities.BaseEntity", b =>
                {
                    b.HasOne("ASU.DTO.Actors.BaseActor", "Author")
                        .WithMany()
                        .HasForeignKey("AuthorId");

                    b.HasOne("ASU.DTO.Actors.BaseActor", "Owner")
                        .WithMany()
                        .HasForeignKey("OwnerId");

                    b.HasOne("ASU.DTO.Entities.BaseEntity", "Parent")
                        .WithMany()
                        .HasForeignKey("ParentId");
                });

            modelBuilder.Entity("ASU.DTO.User", b =>
                {
                    b.HasOne("ASU.DTO.Actors.BaseActor", "Organization")
                        .WithMany()
                        .HasForeignKey("OrganizationId");

                    b.HasOne("ASU.DTO.Actors.BaseActor", "Person")
                        .WithMany()
                        .HasForeignKey("PersonId");
                });
#pragma warning restore 612, 618
        }
    }
}