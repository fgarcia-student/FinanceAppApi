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
    [Migration("20190519221544_AdjustingFolderStructure")]
    partial class AdjustingFolderStructure
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062");

            modelBuilder.Entity("FinanceApp.Models.Entities.InputEntity", b =>
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

            modelBuilder.Entity("FinanceApp.Models.Entities.InputTemplateEntity", b =>
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

            modelBuilder.Entity("FinanceApp.Models.Entities.TypeEntity", b =>
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

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatorId = 1,
                            DateCreated = new DateTime(2019, 5, 19, 22, 15, 43, 754, DateTimeKind.Utc).AddTicks(730),
                            Description = "Income",
                            IsDeleted = false
                        },
                        new
                        {
                            Id = 2,
                            CreatorId = 1,
                            DateCreated = new DateTime(2019, 5, 19, 22, 15, 43, 754, DateTimeKind.Utc).AddTicks(730),
                            Description = "Expense",
                            IsDeleted = false
                        },
                        new
                        {
                            Id = 3,
                            CreatorId = 1,
                            DateCreated = new DateTime(2019, 5, 19, 22, 15, 43, 754, DateTimeKind.Utc).AddTicks(730),
                            Description = "Saving",
                            IsDeleted = false
                        });
                });

            modelBuilder.Entity("FinanceApp.Models.Entities.InputEntity", b =>
                {
                    b.HasOne("FinanceApp.Models.Entities.InputTemplateEntity", "InputTemplate")
                        .WithMany()
                        .HasForeignKey("InputTemplateId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("FinanceApp.Models.Entities.InputTemplateEntity", b =>
                {
                    b.HasOne("FinanceApp.Models.Entities.TypeEntity", "Type")
                        .WithMany()
                        .HasForeignKey("TypeId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
