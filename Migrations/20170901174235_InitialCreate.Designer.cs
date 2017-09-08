﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using ScrumCentral.Models;
using System;

namespace ScrumCentral.Migrations
{
    [DbContext(typeof(PokerSessionContext))]
    [Migration("20170901174235_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.0-rtm-26452");

            modelBuilder.Entity("ScrumCentral.Models.Player", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("PlayerName");

                    b.Property<int?>("PokerSessionID");

                    b.HasKey("Id");

                    b.HasIndex("PokerSessionID");

                    b.ToTable("Player");
                });

            modelBuilder.Entity("ScrumCentral.Models.PokerSession", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<float>("Average");

                    b.Property<string>("Name");

                    b.Property<float>("NumberOfVotes");

                    b.Property<int>("TotalCount");

                    b.HasKey("ID");

                    b.ToTable("PokerSession");
                });

            modelBuilder.Entity("ScrumCentral.Models.Player", b =>
                {
                    b.HasOne("ScrumCentral.Models.PokerSession")
                        .WithMany("Users")
                        .HasForeignKey("PokerSessionID");
                });
#pragma warning restore 612, 618
        }
    }
}
