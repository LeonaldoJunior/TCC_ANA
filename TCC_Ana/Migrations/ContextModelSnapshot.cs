﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TCC_Ana.DataModels;

namespace TCC_Ana.Migrations
{
    [DbContext(typeof(Context))]
    partial class ContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.11")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("TCC_Ana.DataModels.EndDeviceDb", b =>
                {
                    b.Property<int>("EventId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double>("AnalogIn1")
                        .HasColumnType("float");

                    b.Property<double>("AnalogIn2")
                        .HasColumnType("float");

                    b.Property<string>("ApplicationId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DevAddr")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DevEui")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EndDeviceId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("FCnt")
                        .HasColumnType("int");

                    b.Property<int>("FPort")
                        .HasColumnType("int");

                    b.Property<string>("FrmPayload")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("GatewayEui")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("GatewayId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ReceivedAt")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("EventId");

                    b.ToTable("EventsEndDevices");
                });
#pragma warning restore 612, 618
        }
    }
}
