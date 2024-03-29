﻿// <auto-generated />
using System;
using Cinemate.API.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Cinemate.API.Migrations
{
    [DbContext(typeof(CinemateDbContext))]
    [Migration("20240221093321_ExpandMovieEntity")]
    partial class ExpandMovieEntity
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Cinemate.API.Entities.Authorization", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("descriptions");

                    b.HasKey("Id");

                    b.HasIndex("Description")
                        .IsUnique();

                    b.ToTable("authorizations");
                });

            modelBuilder.Entity("Cinemate.API.Entities.Employee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("AuthorizationId")
                        .HasColumnType("integer")
                        .HasColumnName("authorization_id");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("email");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("first_name");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("last_name");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("password");

                    b.HasKey("Id");

                    b.HasIndex("AuthorizationId");

                    b.HasIndex("Email")
                        .IsUnique();

                    b.ToTable("employees");
                });

            modelBuilder.Entity("Cinemate.API.Entities.Movie", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Cast")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("cast");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("description");

                    b.Property<string>("Director")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("director");

                    b.Property<int>("Duration")
                        .HasColumnType("integer")
                        .HasColumnName("duration");

                    b.Property<string>("Kijkwijzers")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("kijkwijzers");

                    b.Property<int>("MovieCategoryId")
                        .HasColumnType("integer")
                        .HasColumnName("movie_category_id");

                    b.Property<int>("ReleaseYear")
                        .HasColumnType("integer")
                        .HasColumnName("release_year");

                    b.Property<decimal>("Review")
                        .HasColumnType("numeric")
                        .HasColumnName("review");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("title");

                    b.HasKey("Id");

                    b.HasIndex("MovieCategoryId");

                    b.ToTable("movies");
                });

            modelBuilder.Entity("Cinemate.API.Entities.MovieCategory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("name");

                    b.HasKey("Id");

                    b.ToTable("movie_categories");
                });

            modelBuilder.Entity("Cinemate.API.Entities.PromoCode", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<bool>("Active")
                        .HasColumnType("boolean")
                        .HasColumnName("active");

                    b.Property<string>("Discount")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("discount");

                    b.Property<string>("DiscountType")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("discount_type");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("name");

                    b.Property<int?>("UsesLeft")
                        .HasColumnType("integer")
                        .HasColumnName("uses_left");

                    b.HasKey("Id");

                    b.HasIndex("Name")
                        .IsUnique();

                    b.ToTable("promo_codes");
                });

            modelBuilder.Entity("Cinemate.API.Entities.Reservation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int?>("EmployeeId")
                        .HasColumnType("integer")
                        .HasColumnName("employee_id");

                    b.Property<bool>("Paid")
                        .HasColumnType("boolean")
                        .HasColumnName("paid");

                    b.Property<string>("PaymentType")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("payment_type");

                    b.Property<int>("ScreeningId")
                        .HasColumnType("integer")
                        .HasColumnName("screening_id");

                    b.Property<int>("SeatReservedId")
                        .HasColumnType("integer")
                        .HasColumnName("seat_reserved_id");

                    b.Property<int>("TicketId")
                        .HasColumnType("integer")
                        .HasColumnName("ticket_id");

                    b.Property<int>("UserId")
                        .HasColumnType("integer")
                        .HasColumnName("user_id");

                    b.HasKey("Id");

                    b.HasIndex("EmployeeId");

                    b.HasIndex("ScreeningId");

                    b.HasIndex("UserId");

                    b.ToTable("reservations");
                });

            modelBuilder.Entity("Cinemate.API.Entities.Screening", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("MovieId")
                        .HasColumnType("integer")
                        .HasColumnName("movie_id");

                    b.Property<DateTime>("MovieStart")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("movie_start");

                    b.Property<int>("TheaterRoomId")
                        .HasColumnType("integer")
                        .HasColumnName("theater_room_id");

                    b.Property<int>("TheatherRoomId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("MovieId");

                    b.HasIndex("TheatherRoomId");

                    b.ToTable("screenings");
                });

            modelBuilder.Entity("Cinemate.API.Entities.Seat", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("Number")
                        .HasColumnType("integer")
                        .HasColumnName("number");

                    b.Property<int>("Row")
                        .HasColumnType("integer")
                        .HasColumnName("row");

                    b.Property<int>("TheaterRoomId")
                        .HasColumnType("integer")
                        .HasColumnName("theater_room_id");

                    b.Property<int>("TheatherRoomId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("TheatherRoomId");

                    b.ToTable("seats");
                });

            modelBuilder.Entity("Cinemate.API.Entities.SeatReserved", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("ReservationId")
                        .HasColumnType("integer")
                        .HasColumnName("reservation_id");

                    b.Property<int>("ScreeningId")
                        .HasColumnType("integer")
                        .HasColumnName("screening_id");

                    b.Property<int>("SeatId")
                        .HasColumnType("integer")
                        .HasColumnName("seat_id");

                    b.HasKey("Id");

                    b.HasIndex("ReservationId");

                    b.HasIndex("ScreeningId");

                    b.HasIndex("SeatId");

                    b.ToTable("seats_reserved");
                });

            modelBuilder.Entity("Cinemate.API.Entities.Theather", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("city");

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasMaxLength(2)
                        .HasColumnType("character varying(2)")
                        .HasColumnName("country");

                    b.Property<string>("HouseNr")
                        .HasColumnType("text")
                        .HasColumnName("house_nr");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("name");

                    b.Property<string>("Street")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("street");

                    b.HasKey("Id");

                    b.HasIndex("Name")
                        .IsUnique();

                    b.ToTable("theathers");
                });

            modelBuilder.Entity("Cinemate.API.Entities.TheatherRoom", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("name");

                    b.Property<int>("SeatsNo")
                        .HasColumnType("integer")
                        .HasColumnName("seats_no");

                    b.Property<int>("TheaterId")
                        .HasColumnType("integer")
                        .HasColumnName("theater_id");

                    b.Property<int>("TheatherId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("TheatherId");

                    b.ToTable("theather_rooms");
                });

            modelBuilder.Entity("Cinemate.API.Entities.Ticket", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<decimal>("BasePrice")
                        .HasColumnType("numeric")
                        .HasColumnName("base_price");

                    b.Property<decimal>("PriceAfterDiscount")
                        .HasColumnType("numeric")
                        .HasColumnName("price_after_discount");

                    b.Property<int>("ReservationId")
                        .HasColumnType("integer")
                        .HasColumnName("reservation_id");

                    b.HasKey("Id");

                    b.HasIndex("ReservationId");

                    b.ToTable("tickets");
                });

            modelBuilder.Entity("Cinemate.API.Entities.TicketPromoCodes", b =>
                {
                    b.Property<int>("TicketId")
                        .HasColumnType("integer");

                    b.Property<int>("PromoCodeId")
                        .HasColumnType("integer");

                    b.HasKey("TicketId", "PromoCodeId");

                    b.HasIndex("PromoCodeId");

                    b.ToTable("ticket_promo_codes");
                });

            modelBuilder.Entity("Cinemate.API.Entities.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("email");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("name");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("password");

                    b.Property<bool>("SubscribedToNewsletter")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("boolean")
                        .HasDefaultValue(false)
                        .HasColumnName("subscribed_to_newsletter");

                    b.HasKey("Id");

                    b.HasIndex("Email")
                        .IsUnique();

                    b.ToTable("users");
                });

            modelBuilder.Entity("Cinemate.API.Entities.UserReview", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Review")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("review");

                    b.Property<int>("ScreeningId")
                        .HasColumnType("integer")
                        .HasColumnName("screening_id");

                    b.Property<int>("UserId")
                        .HasColumnType("integer")
                        .HasColumnName("user_id");

                    b.HasKey("Id");

                    b.HasIndex("ScreeningId");

                    b.HasIndex("UserId");

                    b.ToTable("user_reviews");
                });

            modelBuilder.Entity("Cinemate.API.Entities.Employee", b =>
                {
                    b.HasOne("Cinemate.API.Entities.Authorization", "Authorization")
                        .WithMany()
                        .HasForeignKey("AuthorizationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Authorization");
                });

            modelBuilder.Entity("Cinemate.API.Entities.Movie", b =>
                {
                    b.HasOne("Cinemate.API.Entities.MovieCategory", "MovieCategory")
                        .WithMany()
                        .HasForeignKey("MovieCategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("MovieCategory");
                });

            modelBuilder.Entity("Cinemate.API.Entities.Reservation", b =>
                {
                    b.HasOne("Cinemate.API.Entities.Employee", "Employee")
                        .WithMany()
                        .HasForeignKey("EmployeeId");

                    b.HasOne("Cinemate.API.Entities.Screening", "Screening")
                        .WithMany()
                        .HasForeignKey("ScreeningId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Cinemate.API.Entities.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Employee");

                    b.Navigation("Screening");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Cinemate.API.Entities.Screening", b =>
                {
                    b.HasOne("Cinemate.API.Entities.Movie", "Movie")
                        .WithMany()
                        .HasForeignKey("MovieId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Cinemate.API.Entities.TheatherRoom", "TheatherRoom")
                        .WithMany()
                        .HasForeignKey("TheatherRoomId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Movie");

                    b.Navigation("TheatherRoom");
                });

            modelBuilder.Entity("Cinemate.API.Entities.Seat", b =>
                {
                    b.HasOne("Cinemate.API.Entities.TheatherRoom", "TheatherRoom")
                        .WithMany()
                        .HasForeignKey("TheatherRoomId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("TheatherRoom");
                });

            modelBuilder.Entity("Cinemate.API.Entities.SeatReserved", b =>
                {
                    b.HasOne("Cinemate.API.Entities.Reservation", "Reservation")
                        .WithMany("SeatReserved")
                        .HasForeignKey("ReservationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Cinemate.API.Entities.Screening", "Screening")
                        .WithMany()
                        .HasForeignKey("ScreeningId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Cinemate.API.Entities.Seat", "Seat")
                        .WithMany()
                        .HasForeignKey("SeatId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Reservation");

                    b.Navigation("Screening");

                    b.Navigation("Seat");
                });

            modelBuilder.Entity("Cinemate.API.Entities.TheatherRoom", b =>
                {
                    b.HasOne("Cinemate.API.Entities.Theather", "Theather")
                        .WithMany()
                        .HasForeignKey("TheatherId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Theather");
                });

            modelBuilder.Entity("Cinemate.API.Entities.Ticket", b =>
                {
                    b.HasOne("Cinemate.API.Entities.Reservation", "Reservation")
                        .WithMany("Ticket")
                        .HasForeignKey("ReservationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Reservation");
                });

            modelBuilder.Entity("Cinemate.API.Entities.TicketPromoCodes", b =>
                {
                    b.HasOne("Cinemate.API.Entities.PromoCode", "PromoCode")
                        .WithMany("TicketPromoCodes")
                        .HasForeignKey("PromoCodeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Cinemate.API.Entities.Ticket", "Ticket")
                        .WithMany("TicketPromoCodes")
                        .HasForeignKey("TicketId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("PromoCode");

                    b.Navigation("Ticket");
                });

            modelBuilder.Entity("Cinemate.API.Entities.UserReview", b =>
                {
                    b.HasOne("Cinemate.API.Entities.Screening", "Screening")
                        .WithMany()
                        .HasForeignKey("ScreeningId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Cinemate.API.Entities.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Screening");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Cinemate.API.Entities.PromoCode", b =>
                {
                    b.Navigation("TicketPromoCodes");
                });

            modelBuilder.Entity("Cinemate.API.Entities.Reservation", b =>
                {
                    b.Navigation("SeatReserved");

                    b.Navigation("Ticket");
                });

            modelBuilder.Entity("Cinemate.API.Entities.Ticket", b =>
                {
                    b.Navigation("TicketPromoCodes");
                });
#pragma warning restore 612, 618
        }
    }
}
