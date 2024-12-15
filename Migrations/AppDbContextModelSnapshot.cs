﻿// <auto-generated />
using Laliga.DBContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Laliga.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Laliga.Models.Laligaa", b =>
                {
                    b.Property<int>("LaligaID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("LaligaID"));

                    b.Property<string>("LaligaWinner")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("LaligaID");

                    b.ToTable("Laligas");
                });

            modelBuilder.Entity("Laliga.Models.Player", b =>
                {
                    b.Property<int>("PlayerID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PlayerID"));

                    b.Property<string>("PlayerName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("TeamID")
                        .HasColumnType("int");

                    b.Property<int?>("laligaaLaligaID")
                        .HasColumnType("int");

                    b.HasKey("PlayerID");

                    b.HasIndex("TeamID");

                    b.HasIndex("laligaaLaligaID");

                    b.ToTable("Players");
                });

            modelBuilder.Entity("Laliga.Models.Team", b =>
                {
                    b.Property<int>("TeamID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TeamID"));

                    b.Property<string>("TeamName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TeamID");

                    b.ToTable("Teams");
                });

            modelBuilder.Entity("Laliga.Models.Player", b =>
                {
                    b.HasOne("Laliga.Models.Team", "team")
                        .WithMany("players")
                        .HasForeignKey("TeamID");

                    b.HasOne("Laliga.Models.Laligaa", "laligaa")
                        .WithMany("players")
                        .HasForeignKey("laligaaLaligaID");

                    b.Navigation("laligaa");

                    b.Navigation("team");
                });

            modelBuilder.Entity("Laliga.Models.Laligaa", b =>
                {
                    b.Navigation("players");
                });

            modelBuilder.Entity("Laliga.Models.Team", b =>
                {
                    b.Navigation("players");
                });
#pragma warning restore 612, 618
        }
    }
}
