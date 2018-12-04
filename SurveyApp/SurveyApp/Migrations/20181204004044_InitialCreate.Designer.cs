﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SurveyApp;

namespace SurveyApp.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20181204004044_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.1-rtm-30846")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("SurveyApp.Entities.Survey", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CompanyName");

                    b.Property<bool>("DataAnalytics");

                    b.Property<string>("Email");

                    b.Property<string>("FullName");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("TrackAndTraceModules");

                    b.Property<bool>("WarehouseModules");

                    b.HasKey("Id");

                    b.ToTable("Surveys");
                });
#pragma warning restore 612, 618
        }
    }
}
