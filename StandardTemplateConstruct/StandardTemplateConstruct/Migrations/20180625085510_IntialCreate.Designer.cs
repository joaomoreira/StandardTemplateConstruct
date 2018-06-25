﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using StandardTemplateConstruct.Data;
using StandardTemplateConstruct.Models;
using System;

namespace StandardTemplateConstruct.Migrations
{
    [DbContext(typeof(StandardTemplateConstructDbContext))]
    [Migration("20180625085510_IntialCreate")]
    partial class IntialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.3-rtm-10026")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("StandardTemplateConstruct.Models.ArmyList", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("ArmyLists");
                });

            modelBuilder.Entity("StandardTemplateConstruct.Models.Unit", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("ArmyListId");

                    b.Property<string>("Name");

                    b.Property<int>("UnitType");

                    b.HasKey("Id");

                    b.HasIndex("ArmyListId");

                    b.ToTable("Unit");
                });

            modelBuilder.Entity("StandardTemplateConstruct.Models.Unit", b =>
                {
                    b.HasOne("StandardTemplateConstruct.Models.ArmyList")
                        .WithMany("Units")
                        .HasForeignKey("ArmyListId");
                });
#pragma warning restore 612, 618
        }
    }
}
