﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Staff.Infrastructure.Persistence;

#nullable disable

namespace Staff.Infrastructure.Migrations
{
    [DbContext(typeof(StaffDbContext))]
    [Migration("20240301114111_initialmigration")]
    partial class initialmigration
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Staff.Domain.Entities.Constant.DegreeLevel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("LastModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Level")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("DegreeLevel");
                });

            modelBuilder.Entity("Staff.Domain.Entities.Constant.StaffEmploymentStatus", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("LastModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("StaffEmploymentStatus");
                });

            modelBuilder.Entity("Staff.Domain.Entities.Constant.StaffEmploymentType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("LastModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("StaffEmploymentType");
                });

            modelBuilder.Entity("Staff.Domain.Entities.Constant.StaffPositionLevel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("LastModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Level")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("StaffPositionLevel");
                });

            modelBuilder.Entity("Staff.Domain.Entities.Department.DepartmentCategory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("LastModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("DepartmentCategory");
                });

            modelBuilder.Entity("Staff.Domain.Entities.Department.DepartmentInfo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("DepartmentCategoryId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("LastModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("DepartmentCategoryId");

                    b.ToTable("DepartmentInfo");
                });

            modelBuilder.Entity("Staff.Domain.Entities.Junction.EmploymentDetailDepartment", b =>
                {
                    b.Property<int>("DepartmentInfoId")
                        .HasColumnType("int")
                        .HasColumnOrder(2);

                    b.Property<int>("EmploymentDetialId")
                        .HasColumnType("int")
                        .HasColumnOrder(1);

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("LastModifiedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("DepartmentInfoId", "EmploymentDetialId");

                    b.HasIndex("EmploymentDetialId");

                    b.ToTable("StaffEmploymentDetialDepartment");
                });

            modelBuilder.Entity("Staff.Domain.Entities.Staff.StaffEducationDetail", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("CertificateImage")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("DegreeLevelId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("LastModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("PreviousInstituteName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("StaffId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("DegreeLevelId");

                    b.HasIndex("StaffId");

                    b.ToTable("StaffEducationDetails");
                });

            modelBuilder.Entity("Staff.Domain.Entities.Staff.StaffEmploymentDetail", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("DepartmentCategoryId")
                        .HasColumnType("int");

                    b.Property<DateTime>("EmployedAt")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("LastModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("LeftAt")
                        .HasColumnType("datetime2");

                    b.Property<int?>("PositionLevelId")
                        .HasColumnType("int");

                    b.Property<int>("StaffId")
                        .HasColumnType("int");

                    b.Property<int?>("StatusId")
                        .HasColumnType("int");

                    b.Property<int?>("TypeId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("DepartmentCategoryId");

                    b.HasIndex("PositionLevelId");

                    b.HasIndex("StaffId")
                        .IsUnique();

                    b.HasIndex("StatusId");

                    b.HasIndex("TypeId");

                    b.ToTable("StaffEmploymentDetail");
                });

            modelBuilder.Entity("Staff.Domain.Entities.Staff.StaffPersonalInfo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Area")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("LastModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("MobileNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nationality")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nic")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NicImage")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PassportImage")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PermanentAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Religion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ResidentialAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StaffNo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("StaffInfos");
                });

            modelBuilder.Entity("Staff.Domain.Entities.Department.DepartmentInfo", b =>
                {
                    b.HasOne("Staff.Domain.Entities.Department.DepartmentCategory", "DepartmentCategory")
                        .WithMany("DepartmentInfos")
                        .HasForeignKey("DepartmentCategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("DepartmentCategory");
                });

            modelBuilder.Entity("Staff.Domain.Entities.Junction.EmploymentDetailDepartment", b =>
                {
                    b.HasOne("Staff.Domain.Entities.Department.DepartmentInfo", "DepartmentInfo")
                        .WithMany("EmploymentDetails")
                        .HasForeignKey("DepartmentInfoId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Staff.Domain.Entities.Staff.StaffEmploymentDetail", "EmploymentDetail")
                        .WithMany("DepartmentInfos")
                        .HasForeignKey("EmploymentDetialId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("DepartmentInfo");

                    b.Navigation("EmploymentDetail");
                });

            modelBuilder.Entity("Staff.Domain.Entities.Staff.StaffEducationDetail", b =>
                {
                    b.HasOne("Staff.Domain.Entities.Constant.DegreeLevel", "DegreeLevel")
                        .WithMany("EducationDetials")
                        .HasForeignKey("DegreeLevelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Staff.Domain.Entities.Staff.StaffPersonalInfo", "Staff")
                        .WithMany("EducationDetails")
                        .HasForeignKey("StaffId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("DegreeLevel");

                    b.Navigation("Staff");
                });

            modelBuilder.Entity("Staff.Domain.Entities.Staff.StaffEmploymentDetail", b =>
                {
                    b.HasOne("Staff.Domain.Entities.Department.DepartmentCategory", "DepartmentCategory")
                        .WithMany("EmploymentDetails")
                        .HasForeignKey("DepartmentCategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Staff.Domain.Entities.Constant.StaffPositionLevel", "PositionLevel")
                        .WithMany("EmploymentDetails")
                        .HasForeignKey("PositionLevelId")
                        .OnDelete(DeleteBehavior.SetNull);

                    b.HasOne("Staff.Domain.Entities.Staff.StaffPersonalInfo", "StaffInfo")
                        .WithOne("EmploymentDetail")
                        .HasForeignKey("Staff.Domain.Entities.Staff.StaffEmploymentDetail", "StaffId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Staff.Domain.Entities.Constant.StaffEmploymentStatus", "Status")
                        .WithMany("EmploymentDetails")
                        .HasForeignKey("StatusId")
                        .OnDelete(DeleteBehavior.SetNull);

                    b.HasOne("Staff.Domain.Entities.Constant.StaffEmploymentType", "Type")
                        .WithMany("EmploymentDetails")
                        .HasForeignKey("TypeId")
                        .OnDelete(DeleteBehavior.SetNull);

                    b.Navigation("DepartmentCategory");

                    b.Navigation("PositionLevel");

                    b.Navigation("StaffInfo");

                    b.Navigation("Status");

                    b.Navigation("Type");
                });

            modelBuilder.Entity("Staff.Domain.Entities.Constant.DegreeLevel", b =>
                {
                    b.Navigation("EducationDetials");
                });

            modelBuilder.Entity("Staff.Domain.Entities.Constant.StaffEmploymentStatus", b =>
                {
                    b.Navigation("EmploymentDetails");
                });

            modelBuilder.Entity("Staff.Domain.Entities.Constant.StaffEmploymentType", b =>
                {
                    b.Navigation("EmploymentDetails");
                });

            modelBuilder.Entity("Staff.Domain.Entities.Constant.StaffPositionLevel", b =>
                {
                    b.Navigation("EmploymentDetails");
                });

            modelBuilder.Entity("Staff.Domain.Entities.Department.DepartmentCategory", b =>
                {
                    b.Navigation("DepartmentInfos");

                    b.Navigation("EmploymentDetails");
                });

            modelBuilder.Entity("Staff.Domain.Entities.Department.DepartmentInfo", b =>
                {
                    b.Navigation("EmploymentDetails");
                });

            modelBuilder.Entity("Staff.Domain.Entities.Staff.StaffEmploymentDetail", b =>
                {
                    b.Navigation("DepartmentInfos");
                });

            modelBuilder.Entity("Staff.Domain.Entities.Staff.StaffPersonalInfo", b =>
                {
                    b.Navigation("EducationDetails");

                    b.Navigation("EmploymentDetail");
                });
#pragma warning restore 612, 618
        }
    }
}
