﻿// <auto-generated />
using System;
using FinanceApp.DataAccess.Utility;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace FinanceApp.Migrations
{
  [DbContext(typeof(FinanceAppContext))]
  [Migration("20190519175737_InitialCreate")]
  partial class InitialCreate
  {
    protected override void BuildTargetModel(ModelBuilder modelBuilder)
    {
#pragma warning disable 612, 618
      modelBuilder
          .HasAnnotation("ProductVersion", "2.2.4-servicing-10062");

      modelBuilder.Entity("FinanceApp.Entities.InputEntity", b =>
          {
            b.Property<int>("Id")
                      .ValueGeneratedOnAdd();

            b.Property<DateTime?>("CompleteDate");

            b.Property<int>("CreatorId");

            b.Property<DateTime>("DateCreated");

            b.Property<DateTime?>("DateModified");

            b.Property<int>("InputTemplateId");

            b.Property<bool>("IsComplete");

            b.Property<bool>("IsDeleted");

            b.Property<int?>("ModifierId");

            b.Property<string>("Notes");

            b.HasKey("Id");

            b.HasIndex("InputTemplateId");

            b.ToTable("Inputs");
          });

      modelBuilder.Entity("FinanceApp.Entities.InputTemplateEntity", b =>
          {
            b.Property<int>("Id")
                      .ValueGeneratedOnAdd();

            b.Property<double>("Amount");

            b.Property<int>("CreatorId");

            b.Property<DateTime>("DateCreated");

            b.Property<DateTime?>("DateModified");

            b.Property<string>("Description");

            b.Property<bool>("IsDeleted");

            b.Property<string>("Label");

            b.Property<int?>("ModifierId");

            b.Property<int>("TypeId");

            b.HasKey("Id");

            b.HasIndex("TypeId");

            b.ToTable("InputTemplates");
          });

      modelBuilder.Entity("FinanceApp.Entities.TypeEntity", b =>
          {
            b.Property<int>("Id")
                      .ValueGeneratedOnAdd();

            b.Property<int>("CreatorId");

            b.Property<DateTime>("DateCreated");

            b.Property<DateTime?>("DateModified");

            b.Property<string>("Description");

            b.Property<bool>("IsDeleted");

            b.Property<int?>("ModifierId");

            b.HasKey("Id");

            b.ToTable("Types");
          });

      modelBuilder.Entity("FinanceApp.Entities.InputEntity", b =>
          {
            b.HasOne("FinanceApp.Entities.InputTemplateEntity", "InputTemplate")
                      .WithMany()
                      .HasForeignKey("InputTemplateId")
                      .OnDelete(DeleteBehavior.Cascade);
          });

      modelBuilder.Entity("FinanceApp.Entities.InputTemplateEntity", b =>
          {
            b.HasOne("FinanceApp.Entities.TypeEntity", "Type")
                      .WithMany()
                      .HasForeignKey("TypeId")
                      .OnDelete(DeleteBehavior.Cascade);
          });
#pragma warning restore 612, 618
    }
  }
}
