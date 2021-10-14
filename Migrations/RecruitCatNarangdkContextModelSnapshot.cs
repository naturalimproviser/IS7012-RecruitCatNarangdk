﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RecruitCatNarangdk.Data;

namespace RecruitCatNarangdk.Migrations
{
    [DbContext(typeof(RecruitCatNarangdkContext))]
    partial class RecruitCatNarangdkContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("RecruitCatNarangdk.Models.Candidate", b =>
                {
                    b.Property<int>("CandidateId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CompanyId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("datetime2");

                    b.Property<string>("EmailAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Gender")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("IndustryId")
                        .HasColumnType("int");

                    b.Property<int>("JobTitleId")
                        .HasColumnType("int");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MiddleName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PerformanceRating")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SocialSecurityNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("StartDate")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("TargetSalary")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("CandidateId");

                    b.HasIndex("CompanyId");

                    b.HasIndex("IndustryId");

                    b.HasIndex("JobTitleId");

                    b.ToTable("Candidate");
                });

            modelBuilder.Entity("RecruitCatNarangdk.Models.Company", b =>
                {
                    b.Property<int>("CompanyId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CompanyName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("CompanyNetWorth")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("CompanyPosition")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("IndustryId")
                        .HasColumnType("int");

                    b.Property<long>("Location")
                        .HasColumnType("bigint");

                    b.Property<decimal>("MaxSalary")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("MinSalary")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int?>("NumberOfCandidates")
                        .HasColumnType("int");

                    b.Property<DateTime?>("StartDate")
                        .HasColumnType("datetime2");

                    b.HasKey("CompanyId");

                    b.HasIndex("IndustryId");

                    b.ToTable("Company");
                });

            modelBuilder.Entity("RecruitCatNarangdk.Models.Industry", b =>
                {
                    b.Property<int>("IndustryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ContactNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EmailId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("IndustryFoundedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("IndustryLocation")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IndustryName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsPrivate")
                        .HasColumnType("bit");

                    b.HasKey("IndustryId");

                    b.ToTable("Industry");
                });

            modelBuilder.Entity("RecruitCatNarangdk.Models.JobTitle", b =>
                {
                    b.Property<int>("JobTitleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("IsFullTime")
                        .HasColumnType("bit");

                    b.Property<string>("JobDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("MaxSalary")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("MinSalary")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("JobTitleId");

                    b.ToTable("JobTitle");
                });

            modelBuilder.Entity("RecruitCatNarangdk.Models.Candidate", b =>
                {
                    b.HasOne("RecruitCatNarangdk.Models.Company", "Company")
                        .WithMany("Candidates")
                        .HasForeignKey("CompanyId");

                    b.HasOne("RecruitCatNarangdk.Models.Industry", "Industry")
                        .WithMany("Candidates")
                        .HasForeignKey("IndustryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RecruitCatNarangdk.Models.JobTitle", "JobTitle")
                        .WithMany("Candidates")
                        .HasForeignKey("JobTitleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("RecruitCatNarangdk.Models.Company", b =>
                {
                    b.HasOne("RecruitCatNarangdk.Models.Industry", "Industry")
                        .WithMany("Companies")
                        .HasForeignKey("IndustryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
