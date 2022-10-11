﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PuYuan.Models;

#nullable disable

namespace PuYuan.Migrations
{
    [DbContext(typeof(PuYuanContext))]
    [Migration("20220928071650_removeAccountFromFriend")]
    partial class removeAccountFromFriend
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("PuYuan.Models.BloodPressure", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<double?>("Diastolic")
                        .HasColumnType("float");

                    b.Property<int?>("Pulse")
                        .HasColumnType("int");

                    b.Property<DateTime?>("Recorded_at")
                        .HasColumnType("datetime2");

                    b.Property<double?>("Systolic")
                        .HasColumnType("float");

                    b.Property<string>("Uid")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("BloodPressure");
                });

            modelBuilder.Entity("PuYuan.Models.BloodSugar", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<DateTime?>("Recorded_at")
                        .HasColumnType("datetime2");

                    b.Property<int?>("Sugar")
                        .HasColumnType("int");

                    b.Property<string>("Uid")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("timeperiod")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.ToTable("BloodSugar");
                });

            modelBuilder.Entity("PuYuan.Models.Diary", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Image")
                        .HasColumnType("int");

                    b.Property<double?>("Lat")
                        .HasColumnType("float");

                    b.Property<double?>("Lng")
                        .HasColumnType("float");

                    b.Property<int?>("Meal")
                        .HasColumnType("int");

                    b.Property<DateTime?>("Recorded_at")
                        .HasColumnType("datetime2");

                    b.Property<string>("Tag")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Uid")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Diary");
                });

            modelBuilder.Entity("PuYuan.Models.Friend", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<int?>("Friend_type")
                        .HasColumnType("int");

                    b.Property<bool?>("Imread")
                        .HasColumnType("bit");

                    b.Property<string>("Invite_code")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool?>("Read")
                        .HasColumnType("bit");

                    b.Property<string>("Relation_id")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Status")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Uid")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Friends");
                });

            modelBuilder.Entity("PuYuan.Models.Medical", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<decimal?>("A1c")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Account")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool?>("Anti_hypertensives")
                        .HasColumnType("bit");

                    b.Property<int?>("Diabetes_type")
                        .HasColumnType("int");

                    b.Property<string>("Drugname")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool?>("Drugtype")
                        .HasColumnType("bit");

                    b.Property<bool?>("Insulin")
                        .HasColumnType("bit");

                    b.Property<bool?>("Oad")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("Recorded_at")
                        .HasColumnType("datetime2");

                    b.Property<string>("Uid")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Medical");
                });

            modelBuilder.Entity("PuYuan.Models.User", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<string>("Account")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Birthday")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<bool>("Emailck")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(false);

                    b.Property<bool>("Enabled")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(false);

                    b.Property<string>("Fcm_id")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool?>("Gender")
                        .HasColumnType("bit");

                    b.Property<double?>("Height")
                        .HasColumnType("float");

                    b.Property<string>("Message")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Uid")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Verifycode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double?>("Weight")
                        .HasColumnType("float");

                    b.HasKey("ID");

                    b.HasIndex("Email")
                        .IsUnique();

                    b.HasIndex("Phone")
                        .IsUnique()
                        .HasFilter("[Phone] IS NOT NULL");

                    b.ToTable("User");
                });

            modelBuilder.Entity("PuYuan.Models.UserSet", b =>
                {
                    b.Property<string>("Account")
                        .HasColumnType("nvarchar(450)");

                    b.Property<bool?>("After_meal")
                        .HasColumnType("bit");

                    b.Property<bool?>("After_recording")
                        .HasColumnType("bit");

                    b.Property<decimal?>("Bmi_max")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal?>("Bmi_min")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal?>("Body_fat_max")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal?>("Diastolic_max")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal?>("Diastolic_min")
                        .HasColumnType("decimal(18,2)");

                    b.Property<bool?>("No_recording_for_a_day")
                        .HasColumnType("bit");

                    b.Property<bool?>("Over_max_or_under_min")
                        .HasColumnType("bit");

                    b.Property<decimal?>("Pulse_max")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal?>("Pulse_min")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal?>("Sugar_after_max")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal?>("Sugar_after_min")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal?>("Sugar_before_max")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal?>("Sugar_before_min")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal?>("Sugar_delta_max")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal?>("Sugar_delta_min")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal?>("Sugar_evening_max")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal?>("Sugar_evening_min")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal?>("Sugar_morning_max")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal?>("Sugar_morning_min")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal?>("Systolic_max")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal?>("Systolic_min")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Uid")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool?>("Unit_of_height")
                        .HasColumnType("bit");

                    b.Property<bool?>("Unit_of_sugar")
                        .HasColumnType("bit");

                    b.Property<bool?>("Unit_of_weight")
                        .HasColumnType("bit");

                    b.Property<decimal?>("Weight_max")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal?>("Weight_min")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal?>("body_fat_min")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Account");

                    b.ToTable("UserSet");
                });

            modelBuilder.Entity("PuYuan.Models.Weight_M", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<double?>("Bmi")
                        .HasColumnType("float");

                    b.Property<double?>("Body_fat")
                        .HasColumnType("float");

                    b.Property<DateTime?>("Recorded_at")
                        .HasColumnType("datetime2");

                    b.Property<string>("Uid")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double?>("Weight")
                        .HasColumnType("float");

                    b.HasKey("ID");

                    b.ToTable("Weight");
                });
#pragma warning restore 612, 618
        }
    }
}
