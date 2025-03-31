﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using mytown.Models.mytown.DataAccess;

#nullable disable

namespace mytown.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            MySqlModelBuilderExtensions.AutoIncrementColumns(modelBuilder);

            modelBuilder.Entity("mytown.Models.BusinessRegister", b =>
                {
                    b.Property<int>("BusRegId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("BusRegId"));

                    b.Property<string>("Address1")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("varchar(200)");

                    b.Property<string>("Address2")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("varchar(200)");

                    b.Property<string>("BusEmail")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<string>("BusMobileNo")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("varchar(15)");

                    b.Property<int>("BuscatId")
                        .HasColumnType("int");

                    b.Property<string>("BusinessUsername")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Businessname")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<int>("BusservId")
                        .HasColumnType("int");

                    b.Property<string>("CnfPassword")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Gstin")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("varchar(15)");

                    b.Property<string>("LicenseType")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("NewPassword")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<int>("RegId")
                        .HasColumnType("int");

                    b.Property<string>("Town")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<string>("businessCity")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<string>("businessCountry")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<string>("businessState")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.HasKey("BusRegId");

                    b.ToTable("BusinessRegisters");
                });

            modelBuilder.Entity("mytown.Models.Payments", b =>
                {
                    b.Property<int>("PaymentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("PaymentId"));

                    b.Property<decimal>("AmountPaid")
                        .HasColumnType("decimal(65,30)");

                    b.Property<int>("OrderId")
                        .HasColumnType("int");

                    b.Property<DateTime>("PaymentDate")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("PaymentMethod")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("PaymentStatus")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("PaymentId");

                    b.ToTable("Payments");
                });

            modelBuilder.Entity("mytown.Models.Registration", b =>
                {
                    b.Property<int>("RegId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("RegId"));

                    b.Property<string>("City")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<string>("CnfPassword")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<DateTime>("Dob")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("varchar(200)");

                    b.Property<string>("NewPassword")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Otp")
                        .IsRequired()
                        .HasMaxLength(6)
                        .HasColumnType("varchar(6)");

                    b.Property<string>("PhoneNo")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("varchar(15)");

                    b.Property<string>("Role")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("State")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Town")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.HasKey("RegId");

                    b.ToTable("Registrations");
                });

            modelBuilder.Entity("mytown.Models.ShopperRegister", b =>
                {
                    b.Property<int>("ShopperRegId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("ShopperRegId"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(300)
                        .HasColumnType("varchar(300)");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("varchar(200)");

                    b.Property<bool>("IsEmailVerified")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("varchar(15)");

                    b.Property<string>("PhotoName")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("varchar(200)");

                    b.Property<string>("PostalCode")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("varchar(10)");

                    b.Property<string>("State")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Town")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.HasKey("ShopperRegId");

                    b.ToTable("ShopperRegisters");
                });

            modelBuilder.Entity("mytown.Models.ShopperVerification", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("varchar(200)");

                    b.Property<DateTime>("ExpiryDate")
                        .HasColumnType("datetime(6)");

                    b.Property<bool>("IsVerified")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("VerificationToken")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("ShopperVerification");
                });

            modelBuilder.Entity("mytown.Models.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("UserId"));

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("UserId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("mytown.Models.addtocart", b =>
                {
                    b.Property<int>("CartId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("CartId"));

                    b.Property<int>("BusRegId")
                        .HasColumnType("int");

                    b.Property<int>("BuscatId")
                        .HasColumnType("int");

                    b.Property<int>("ShopperRegId")
                        .HasColumnType("int");

                    b.Property<string>("orderstatus")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("prod_qty")
                        .HasColumnType("int");

                    b.Property<int>("prod_subcat_id")
                        .HasColumnType("int");

                    b.Property<int>("product_id")
                        .HasColumnType("int");

                    b.Property<decimal>("product_price")
                        .HasColumnType("decimal(65,30)");

                    b.HasKey("CartId");

                    b.ToTable("addtocart");
                });

            modelBuilder.Entity("mytown.Models.businesscategoriescs", b =>
                {
                    b.Property<int>("BuscatId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("BuscatId"));

                    b.Property<string>("Businesscategory_name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.HasKey("BuscatId");

                    b.ToTable("BusinessCategories");

                    b.HasData(
                        new
                        {
                            BuscatId = 1,
                            Businesscategory_name = "products"
                        },
                        new
                        {
                            BuscatId = 2,
                            Businesscategory_name = "services"
                        });
                });

            modelBuilder.Entity("mytown.Models.businessprofile", b =>
                {
                    b.Property<int>("businessprofile_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("businessprofile_id"));

                    b.Property<int>("BusCatId")
                        .HasColumnType("int");

                    b.Property<int>("BusRegId")
                        .HasColumnType("int");

                    b.Property<int>("BusServId")
                        .HasColumnType("int");

                    b.Property<string>("BusinessUsername")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Businesscategory_name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Businessservice_name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("banner_path")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("bus_time")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("business_about")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("business_location")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("image_positionx")
                        .HasColumnType("int");

                    b.Property<int>("image_positiony")
                        .HasColumnType("int");

                    b.Property<string>("profile_status")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<float>("zoom")
                        .HasColumnType("float");

                    b.HasKey("businessprofile_id");

                    b.ToTable("BusinessProfiles");
                });

            modelBuilder.Entity("mytown.Models.businessservices", b =>
                {
                    b.Property<int>("BusservId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("BusservId"));

                    b.Property<string>("Businessservice_name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.HasKey("BusservId");

                    b.ToTable("BusinessServices");
                });

            modelBuilder.Entity("mytown.Models.order", b =>
                {
                    b.Property<int>("OrderId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("OrderId"));

                    b.Property<DateTime>("OrderDate")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("OrderStatus")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("ShippingType")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("ShopperRegId")
                        .HasColumnType("int");

                    b.Property<decimal>("TotalAmount")
                        .HasColumnType("decimal(65,30)");

                    b.HasKey("OrderId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("mytown.Models.orderdetails", b =>
                {
                    b.Property<int>("OrderDetailId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("OrderDetailId"));

                    b.Property<int>("OrderId")
                        .HasColumnType("int");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(65,30)");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<int>("StoreId")
                        .HasColumnType("int");

                    b.HasKey("OrderDetailId");

                    b.ToTable("OrderDetails");
                });

            modelBuilder.Entity("mytown.Models.product_sub_categories", b =>
                {
                    b.Property<int>("prod_subcat_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("prod_subcat_id"));

                    b.Property<int>("BuscatId")
                        .HasColumnType("int");

                    b.Property<string>("prod_subcat_image")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("prod_subcat_name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.HasKey("prod_subcat_id");

                    b.ToTable("product_sub_categories");
                });

            modelBuilder.Entity("mytown.Models.products", b =>
                {
                    b.Property<int>("product_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("product_id"));

                    b.Property<int>("BusRegId")
                        .HasColumnType("int");

                    b.Property<int>("BuscatId")
                        .HasColumnType("int");

                    b.Property<int>("prod_subcat_id")
                        .HasColumnType("int");

                    b.Property<decimal>("product_cost")
                        .HasPrecision(18, 2)
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("product_description")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("varchar(500)");

                    b.Property<decimal>("product_height")
                        .HasColumnType("decimal(65,30)");

                    b.Property<string>("product_image")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<decimal>("product_length")
                        .HasPrecision(18, 2)
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("product_name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<decimal>("product_quantity")
                        .HasPrecision(18, 2)
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("product_subject")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<decimal>("product_weight")
                        .HasPrecision(18, 2)
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("product_width")
                        .HasPrecision(18, 2)
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("product_id");

                    b.ToTable("products");
                });

            modelBuilder.Entity("mytown.Models.services", b =>
                {
                    b.Property<int>("service_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("service_id"));

                    b.Property<int>("BusRegId")
                        .HasColumnType("int");

                    b.Property<int>("BusservId")
                        .HasColumnType("int");

                    b.Property<int>("serv_subcat_id")
                        .HasColumnType("int");

                    b.Property<decimal>("service_cost")
                        .HasPrecision(18, 2)
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("service_description")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("service_image")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("service_name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<string>("service_subject")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("service_id");

                    b.ToTable("services");
                });

            modelBuilder.Entity("mytown.Models.services_sub_categories", b =>
                {
                    b.Property<int>("serv_subcat_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("serv_subcat_id"));

                    b.Property<int>("BusservId")
                        .HasColumnType("int");

                    b.Property<string>("serv_subcat_image")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("serv_subcat_name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.HasKey("serv_subcat_id");

                    b.ToTable("services_sub_categories");
                });

            modelBuilder.Entity("mytown.Models.subcategoryimages_busregid", b =>
                {
                    b.Property<int>("Image_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Image_Id"));

                    b.Property<int>("BusRegId")
                        .HasColumnType("int");

                    b.Property<int>("BuscatId")
                        .HasColumnType("int");

                    b.Property<int>("Prod_subcat_id")
                        .HasColumnType("int");

                    b.Property<string>("Prod_subcat_image")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Prod_subcat_name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.HasKey("Image_Id");

                    b.ToTable("subcategoryimages_Busregids", (string)null);
                });
#pragma warning restore 612, 618
        }
    }
}
