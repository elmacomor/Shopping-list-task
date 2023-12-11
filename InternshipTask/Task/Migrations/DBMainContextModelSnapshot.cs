﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using TactaTask.Data;


#nullable disable

namespace TactaTask.Migrations
{
    [DbContext(typeof(DBMainContext))]
    partial class DBMainContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("TactaTask.Models.Item", b =>
                {
                    b.Property<int>("ItemId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ItemId"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Price")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ItemId");

                    b.ToTable("Items");
                });

            modelBuilder.Entity("TactaTask.Models.Shopper", b =>
                {
                    b.Property<int>("ShopperId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ShopperId"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasColumnType("nvarchar(30)");

                    b.HasKey("ShopperId");

                    b.ToTable("Shoppers");
                });

            modelBuilder.Entity("TactaTask.Models.ShoppingList", b =>
                {
                    b.Property<int>("ShoppingListId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ShoppingListId"));

                    b.Property<int>("ItemId")
                        .HasColumnType("int");

                    b.Property<int>("ShopperId")
                        .HasColumnType("int");

                    b.HasKey("ShoppingListId");

                    b.HasIndex("ItemId");

                    b.HasIndex("ShopperId");

                    b.ToTable("ShoppingList");
                });

            modelBuilder.Entity("TactaTask.Models.ShoppingList", b =>
                {
                    b.HasOne("TactaTask.Models.Item", "Item")
                        .WithMany()
                        .HasForeignKey("ItemId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TactaTask.Models.Shopper", "Shopper")
                        .WithMany()
                        .HasForeignKey("ShopperId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Item");

                    b.Navigation("Shopper");
                });
#pragma warning restore 612, 618
        }
    }
}
