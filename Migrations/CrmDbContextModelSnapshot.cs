﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using myapi.Data;

#nullable disable

namespace myapi.Migrations
{
    [DbContext(typeof(CrmDbContext))]
    partial class CrmDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("myapi.Models.Account", b =>
                {
                    b.Property<int>("AccountId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AccountId"));

                    b.Property<string>("AccountName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Industry")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Website")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AccountId");

                    b.ToTable("Accounts");
                });

            modelBuilder.Entity("myapi.Models.Activity", b =>
                {
                    b.Property<int>("ActivityId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ActivityId"));

                    b.Property<DateTime>("ActivityDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("LeadId")
                        .HasColumnType("int");

                    b.Property<string>("Subject")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ActivityId");

                    b.HasIndex("LeadId");

                    b.ToTable("Activities");
                });

            modelBuilder.Entity("myapi.Models.AppTask", b =>
                {
                    b.Property<int>("AppTaskId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AppTaskId"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DueDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsCompleted")
                        .HasColumnType("bit");

                    b.Property<int?>("LeadId")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AppTaskId");

                    b.HasIndex("LeadId");

                    b.ToTable("AppTasks");
                });

            modelBuilder.Entity("myapi.Models.Campaign", b =>
                {
                    b.Property<int>("CampaignId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CampaignId"));

                    b.Property<decimal>("ActualCost")
                        .HasColumnType("decimal(18, 2)");

                    b.Property<decimal>("Budget")
                        .HasColumnType("decimal(18, 2)");

                    b.Property<string>("CampaignName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CampaignId");

                    b.ToTable("Campaigns");
                });

            modelBuilder.Entity("myapi.Models.Contact", b =>
                {
                    b.Property<int>("ContactId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ContactId"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("LeadId")
                        .HasColumnType("int");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Position")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ContactId");

                    b.HasIndex("LeadId");

                    b.ToTable("Contacts");
                });

            modelBuilder.Entity("myapi.Models.Deal", b =>
                {
                    b.Property<int>("DealId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DealId"));

                    b.Property<int>("AccountId")
                        .HasColumnType("int");

                    b.Property<decimal>("Amount")
                        .HasColumnType("decimal(18, 2)");

                    b.Property<DateTime>("CloseDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("DealName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("LeadId")
                        .HasColumnType("int");

                    b.Property<string>("Stage")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("DealId");

                    b.HasIndex("AccountId");

                    b.HasIndex("LeadId");

                    b.ToTable("Deals");
                });

            modelBuilder.Entity("myapi.Models.Email", b =>
                {
                    b.Property<int>("EmailId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("EmailId"));

                    b.Property<string>("Body")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("LeadId")
                        .HasColumnType("int");

                    b.Property<DateTime>("SentDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Subject")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("EmailId");

                    b.HasIndex("LeadId");

                    b.ToTable("Emails");
                });

            modelBuilder.Entity("myapi.Models.Invoice", b =>
                {
                    b.Property<int>("InvoiceId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("InvoiceId"));

                    b.Property<DateTime>("DueDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("InvoiceDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("InvoiceNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("LeadId")
                        .HasColumnType("int");

                    b.Property<decimal>("TotalAmount")
                        .HasColumnType("decimal(18, 2)");

                    b.HasKey("InvoiceId");

                    b.HasIndex("LeadId");

                    b.ToTable("Invoices");
                });

            modelBuilder.Entity("myapi.Models.Lead", b =>
                {
                    b.Property<int?>("LeadId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int?>("LeadId"));

                    b.Property<int?>("AccountId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("ConvertedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("LeadId");

                    b.HasIndex("AccountId");

                    b.ToTable("Leads");
                });

            modelBuilder.Entity("myapi.Models.Quote", b =>
                {
                    b.Property<int>("QuoteId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("QuoteId"));

                    b.Property<int?>("LeadId")
                        .HasColumnType("int");

                    b.Property<string>("QuoteNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("TotalAmount")
                        .HasColumnType("decimal(18, 2)");

                    b.Property<DateTime>("ValidUntil")
                        .HasColumnType("datetime2");

                    b.HasKey("QuoteId");

                    b.HasIndex("LeadId");

                    b.ToTable("Quotes");
                });

            modelBuilder.Entity("myapi.Models.Activity", b =>
                {
                    b.HasOne("myapi.Models.Lead", "Lead")
                        .WithMany("Activities")
                        .HasForeignKey("LeadId");

                    b.Navigation("Lead");
                });

            modelBuilder.Entity("myapi.Models.AppTask", b =>
                {
                    b.HasOne("myapi.Models.Lead", "Lead")
                        .WithMany("AppTasks")
                        .HasForeignKey("LeadId")
                        .OnDelete(DeleteBehavior.SetNull);

                    b.Navigation("Lead");
                });

            modelBuilder.Entity("myapi.Models.Contact", b =>
                {
                    b.HasOne("myapi.Models.Lead", "Lead")
                        .WithMany("Contacts")
                        .HasForeignKey("LeadId");

                    b.Navigation("Lead");
                });

            modelBuilder.Entity("myapi.Models.Deal", b =>
                {
                    b.HasOne("myapi.Models.Account", "Account")
                        .WithMany("Deals")
                        .HasForeignKey("AccountId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("myapi.Models.Lead", "Lead")
                        .WithMany("Deals")
                        .HasForeignKey("LeadId");

                    b.Navigation("Account");

                    b.Navigation("Lead");
                });

            modelBuilder.Entity("myapi.Models.Email", b =>
                {
                    b.HasOne("myapi.Models.Lead", "Lead")
                        .WithMany("Emails")
                        .HasForeignKey("LeadId");

                    b.Navigation("Lead");
                });

            modelBuilder.Entity("myapi.Models.Invoice", b =>
                {
                    b.HasOne("myapi.Models.Lead", "Lead")
                        .WithMany("Invoices")
                        .HasForeignKey("LeadId");

                    b.Navigation("Lead");
                });

            modelBuilder.Entity("myapi.Models.Lead", b =>
                {
                    b.HasOne("myapi.Models.Account", "Account")
                        .WithMany("Leads")
                        .HasForeignKey("AccountId");

                    b.Navigation("Account");
                });

            modelBuilder.Entity("myapi.Models.Quote", b =>
                {
                    b.HasOne("myapi.Models.Lead", "Lead")
                        .WithMany("Quotes")
                        .HasForeignKey("LeadId");

                    b.Navigation("Lead");
                });

            modelBuilder.Entity("myapi.Models.Account", b =>
                {
                    b.Navigation("Deals");

                    b.Navigation("Leads");
                });

            modelBuilder.Entity("myapi.Models.Lead", b =>
                {
                    b.Navigation("Activities");

                    b.Navigation("AppTasks");

                    b.Navigation("Contacts");

                    b.Navigation("Deals");

                    b.Navigation("Emails");

                    b.Navigation("Invoices");

                    b.Navigation("Quotes");
                });
#pragma warning restore 612, 618
        }
    }
}
