// <auto-generated />
using System;
using BillingLibrary;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BillingLibrary.Migrations
{
    [DbContext(typeof(BillingContext))]
    partial class BillingContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.0");

            modelBuilder.Entity("BillingLibrary.Models.BillModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<decimal>("Amount")
                        .HasColumnType("TEXT");

                    b.Property<string>("Category")
                        .HasColumnType("TEXT");

                    b.Property<int>("ClientId")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("ClientModelId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("TEXT");

                    b.Property<int>("Period")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime?>("UpdatedOn")
                        .HasColumnType("TEXT");

                    b.Property<string>("state")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("ClientModelId");

                    b.ToTable("Bills");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Amount = 0.99189049940981m,
                            Category = "SEWER",
                            ClientId = 1,
                            CreatedOn = new DateTime(2022, 11, 21, 15, 47, 51, 629, DateTimeKind.Local).AddTicks(8484),
                            Period = 202001,
                            UpdatedOn = new DateTime(2022, 11, 21, 15, 47, 51, 629, DateTimeKind.Local).AddTicks(8484),
                            state = "Pending"
                        },
                        new
                        {
                            Id = 2,
                            Amount = 0.55169781052477m,
                            Category = "SEWER",
                            ClientId = 1,
                            CreatedOn = new DateTime(2022, 11, 21, 15, 47, 51, 629, DateTimeKind.Local).AddTicks(8535),
                            Period = 202002,
                            UpdatedOn = new DateTime(2022, 11, 21, 15, 47, 51, 629, DateTimeKind.Local).AddTicks(8535),
                            state = "Pending"
                        },
                        new
                        {
                            Id = 3,
                            Amount = 0.446380794059207m,
                            Category = "ELECTRICITY",
                            ClientId = 1,
                            CreatedOn = new DateTime(2022, 11, 21, 15, 47, 51, 629, DateTimeKind.Local).AddTicks(8537),
                            Period = 202001,
                            UpdatedOn = new DateTime(2022, 11, 21, 15, 47, 51, 629, DateTimeKind.Local).AddTicks(8538),
                            state = "Pending"
                        },
                        new
                        {
                            Id = 4,
                            Amount = 0.333095093639911m,
                            Category = "ELECTRICITY",
                            ClientId = 1,
                            CreatedOn = new DateTime(2022, 11, 21, 15, 47, 51, 629, DateTimeKind.Local).AddTicks(8540),
                            Period = 202002,
                            UpdatedOn = new DateTime(2022, 11, 21, 15, 47, 51, 629, DateTimeKind.Local).AddTicks(8540),
                            state = "Pending"
                        },
                        new
                        {
                            Id = 5,
                            Amount = 0.25697477362134m,
                            Category = "WATER",
                            ClientId = 1,
                            CreatedOn = new DateTime(2022, 11, 21, 15, 47, 51, 629, DateTimeKind.Local).AddTicks(8542),
                            Period = 202001,
                            UpdatedOn = new DateTime(2022, 11, 21, 15, 47, 51, 629, DateTimeKind.Local).AddTicks(8543),
                            state = "Pending"
                        },
                        new
                        {
                            Id = 6,
                            Amount = 0.92189068694969m,
                            Category = "WATER",
                            ClientId = 1,
                            CreatedOn = new DateTime(2022, 11, 21, 15, 47, 51, 629, DateTimeKind.Local).AddTicks(8547),
                            Period = 202002,
                            UpdatedOn = new DateTime(2022, 11, 21, 15, 47, 51, 629, DateTimeKind.Local).AddTicks(8548),
                            state = "Pending"
                        },
                        new
                        {
                            Id = 7,
                            Amount = 0.12353522778867m,
                            Category = "SEWER",
                            ClientId = 2,
                            CreatedOn = new DateTime(2022, 11, 21, 15, 47, 51, 629, DateTimeKind.Local).AddTicks(8550),
                            Period = 202001,
                            UpdatedOn = new DateTime(2022, 11, 21, 15, 47, 51, 629, DateTimeKind.Local).AddTicks(8550),
                            state = "Pending"
                        },
                        new
                        {
                            Id = 8,
                            Amount = 0.385353059924271m,
                            Category = "SEWER",
                            ClientId = 2,
                            CreatedOn = new DateTime(2022, 11, 21, 15, 47, 51, 629, DateTimeKind.Local).AddTicks(8553),
                            Period = 202002,
                            UpdatedOn = new DateTime(2022, 11, 21, 15, 47, 51, 629, DateTimeKind.Local).AddTicks(8553),
                            state = "Pending"
                        },
                        new
                        {
                            Id = 9,
                            Amount = 0.341528808053661m,
                            Category = "ELECTRICITY",
                            ClientId = 2,
                            CreatedOn = new DateTime(2022, 11, 21, 15, 47, 51, 629, DateTimeKind.Local).AddTicks(8555),
                            Period = 202001,
                            UpdatedOn = new DateTime(2022, 11, 21, 15, 47, 51, 629, DateTimeKind.Local).AddTicks(8556),
                            state = "Pending"
                        },
                        new
                        {
                            Id = 10,
                            Amount = 0.433490466808958m,
                            Category = "ELECTRICITY",
                            ClientId = 2,
                            CreatedOn = new DateTime(2022, 11, 21, 15, 47, 51, 629, DateTimeKind.Local).AddTicks(8559),
                            Period = 202002,
                            UpdatedOn = new DateTime(2022, 11, 21, 15, 47, 51, 629, DateTimeKind.Local).AddTicks(8560),
                            state = "Pending"
                        },
                        new
                        {
                            Id = 11,
                            Amount = 0.125487542634803m,
                            Category = "WATER",
                            ClientId = 2,
                            CreatedOn = new DateTime(2022, 11, 21, 15, 47, 51, 629, DateTimeKind.Local).AddTicks(8562),
                            Period = 202001,
                            UpdatedOn = new DateTime(2022, 11, 21, 15, 47, 51, 629, DateTimeKind.Local).AddTicks(8562),
                            state = "Pending"
                        },
                        new
                        {
                            Id = 12,
                            Amount = 0.238826462657073m,
                            Category = "WATER",
                            ClientId = 2,
                            CreatedOn = new DateTime(2022, 11, 21, 15, 47, 51, 629, DateTimeKind.Local).AddTicks(8565),
                            Period = 202002,
                            UpdatedOn = new DateTime(2022, 11, 21, 15, 47, 51, 629, DateTimeKind.Local).AddTicks(8565),
                            state = "Pending"
                        },
                        new
                        {
                            Id = 13,
                            Amount = 0.959969244256725m,
                            Category = "SEWER",
                            ClientId = 3,
                            CreatedOn = new DateTime(2022, 11, 21, 15, 47, 51, 629, DateTimeKind.Local).AddTicks(8567),
                            Period = 202001,
                            UpdatedOn = new DateTime(2022, 11, 21, 15, 47, 51, 629, DateTimeKind.Local).AddTicks(8567),
                            state = "Pending"
                        },
                        new
                        {
                            Id = 14,
                            Amount = 0.912970758181196m,
                            Category = "SEWER",
                            ClientId = 3,
                            CreatedOn = new DateTime(2022, 11, 21, 15, 47, 51, 629, DateTimeKind.Local).AddTicks(8571),
                            Period = 202002,
                            UpdatedOn = new DateTime(2022, 11, 21, 15, 47, 51, 629, DateTimeKind.Local).AddTicks(8572),
                            state = "Pending"
                        },
                        new
                        {
                            Id = 15,
                            Amount = 0.474639056016261m,
                            Category = "ELECTRICITY",
                            ClientId = 3,
                            CreatedOn = new DateTime(2022, 11, 21, 15, 47, 51, 629, DateTimeKind.Local).AddTicks(8574),
                            Period = 202001,
                            UpdatedOn = new DateTime(2022, 11, 21, 15, 47, 51, 629, DateTimeKind.Local).AddTicks(8575),
                            state = "Pending"
                        },
                        new
                        {
                            Id = 16,
                            Amount = 0.668130261668923m,
                            Category = "ELECTRICITY",
                            ClientId = 3,
                            CreatedOn = new DateTime(2022, 11, 21, 15, 47, 51, 629, DateTimeKind.Local).AddTicks(8577),
                            Period = 202002,
                            UpdatedOn = new DateTime(2022, 11, 21, 15, 47, 51, 629, DateTimeKind.Local).AddTicks(8577),
                            state = "Pending"
                        },
                        new
                        {
                            Id = 17,
                            Amount = 0.966838782572578m,
                            Category = "WATER",
                            ClientId = 3,
                            CreatedOn = new DateTime(2022, 11, 21, 15, 47, 51, 629, DateTimeKind.Local).AddTicks(8579),
                            Period = 202001,
                            UpdatedOn = new DateTime(2022, 11, 21, 15, 47, 51, 629, DateTimeKind.Local).AddTicks(8580),
                            state = "Pending"
                        },
                        new
                        {
                            Id = 18,
                            Amount = 0.712906273014131m,
                            Category = "WATER",
                            ClientId = 3,
                            CreatedOn = new DateTime(2022, 11, 21, 15, 47, 51, 629, DateTimeKind.Local).AddTicks(8583),
                            Period = 202002,
                            UpdatedOn = new DateTime(2022, 11, 21, 15, 47, 51, 629, DateTimeKind.Local).AddTicks(8584),
                            state = "Pending"
                        },
                        new
                        {
                            Id = 19,
                            Amount = 0.487092710911679m,
                            Category = "SEWER",
                            ClientId = 4,
                            CreatedOn = new DateTime(2022, 11, 21, 15, 47, 51, 629, DateTimeKind.Local).AddTicks(8586),
                            Period = 202001,
                            UpdatedOn = new DateTime(2022, 11, 21, 15, 47, 51, 629, DateTimeKind.Local).AddTicks(8586),
                            state = "Pending"
                        },
                        new
                        {
                            Id = 20,
                            Amount = 0.515092176613846m,
                            Category = "SEWER",
                            ClientId = 4,
                            CreatedOn = new DateTime(2022, 11, 21, 15, 47, 51, 629, DateTimeKind.Local).AddTicks(8588),
                            Period = 202002,
                            UpdatedOn = new DateTime(2022, 11, 21, 15, 47, 51, 629, DateTimeKind.Local).AddTicks(8589),
                            state = "Pending"
                        },
                        new
                        {
                            Id = 21,
                            Amount = 0.473430586815036m,
                            Category = "ELECTRICITY",
                            ClientId = 4,
                            CreatedOn = new DateTime(2022, 11, 21, 15, 47, 51, 629, DateTimeKind.Local).AddTicks(8591),
                            Period = 202001,
                            UpdatedOn = new DateTime(2022, 11, 21, 15, 47, 51, 629, DateTimeKind.Local).AddTicks(8591),
                            state = "Pending"
                        },
                        new
                        {
                            Id = 22,
                            Amount = 0.068158217428612m,
                            Category = "ELECTRICITY",
                            ClientId = 4,
                            CreatedOn = new DateTime(2022, 11, 21, 15, 47, 51, 629, DateTimeKind.Local).AddTicks(8632),
                            Period = 202002,
                            UpdatedOn = new DateTime(2022, 11, 21, 15, 47, 51, 629, DateTimeKind.Local).AddTicks(8633),
                            state = "Pending"
                        },
                        new
                        {
                            Id = 23,
                            Amount = 0.340807169970969m,
                            Category = "WATER",
                            ClientId = 4,
                            CreatedOn = new DateTime(2022, 11, 21, 15, 47, 51, 629, DateTimeKind.Local).AddTicks(8635),
                            Period = 202001,
                            UpdatedOn = new DateTime(2022, 11, 21, 15, 47, 51, 629, DateTimeKind.Local).AddTicks(8636),
                            state = "Pending"
                        },
                        new
                        {
                            Id = 24,
                            Amount = 0.316480027058623m,
                            Category = "WATER",
                            ClientId = 4,
                            CreatedOn = new DateTime(2022, 11, 21, 15, 47, 51, 629, DateTimeKind.Local).AddTicks(8637),
                            Period = 202002,
                            UpdatedOn = new DateTime(2022, 11, 21, 15, 47, 51, 629, DateTimeKind.Local).AddTicks(8638),
                            state = "Pending"
                        },
                        new
                        {
                            Id = 25,
                            Amount = 0.0536241983024341m,
                            Category = "SEWER",
                            ClientId = 5,
                            CreatedOn = new DateTime(2022, 11, 21, 15, 47, 51, 629, DateTimeKind.Local).AddTicks(8640),
                            Period = 202001,
                            UpdatedOn = new DateTime(2022, 11, 21, 15, 47, 51, 629, DateTimeKind.Local).AddTicks(8640),
                            state = "Pending"
                        },
                        new
                        {
                            Id = 26,
                            Amount = 0.940668601854327m,
                            Category = "SEWER",
                            ClientId = 5,
                            CreatedOn = new DateTime(2022, 11, 21, 15, 47, 51, 629, DateTimeKind.Local).AddTicks(8645),
                            Period = 202002,
                            UpdatedOn = new DateTime(2022, 11, 21, 15, 47, 51, 629, DateTimeKind.Local).AddTicks(8645),
                            state = "Pending"
                        },
                        new
                        {
                            Id = 27,
                            Amount = 0.340016102806142m,
                            Category = "ELECTRICITY",
                            ClientId = 5,
                            CreatedOn = new DateTime(2022, 11, 21, 15, 47, 51, 629, DateTimeKind.Local).AddTicks(8647),
                            Period = 202001,
                            UpdatedOn = new DateTime(2022, 11, 21, 15, 47, 51, 629, DateTimeKind.Local).AddTicks(8648),
                            state = "Pending"
                        },
                        new
                        {
                            Id = 28,
                            Amount = 0.544094823654411m,
                            Category = "ELECTRICITY",
                            ClientId = 5,
                            CreatedOn = new DateTime(2022, 11, 21, 15, 47, 51, 629, DateTimeKind.Local).AddTicks(8650),
                            Period = 202002,
                            UpdatedOn = new DateTime(2022, 11, 21, 15, 47, 51, 629, DateTimeKind.Local).AddTicks(8650),
                            state = "Pending"
                        },
                        new
                        {
                            Id = 29,
                            Amount = 0.770515330231688m,
                            Category = "WATER",
                            ClientId = 5,
                            CreatedOn = new DateTime(2022, 11, 21, 15, 47, 51, 629, DateTimeKind.Local).AddTicks(8652),
                            Period = 202001,
                            UpdatedOn = new DateTime(2022, 11, 21, 15, 47, 51, 629, DateTimeKind.Local).AddTicks(8653),
                            state = "Pending"
                        },
                        new
                        {
                            Id = 30,
                            Amount = 0.141469505692545m,
                            Category = "WATER",
                            ClientId = 5,
                            CreatedOn = new DateTime(2022, 11, 21, 15, 47, 51, 629, DateTimeKind.Local).AddTicks(8657),
                            Period = 202002,
                            UpdatedOn = new DateTime(2022, 11, 21, 15, 47, 51, 629, DateTimeKind.Local).AddTicks(8657),
                            state = "Pending"
                        });
                });

            modelBuilder.Entity("BillingLibrary.Models.ClientModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("UpdatedOn")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Clients");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedOn = new DateTime(2022, 11, 21, 15, 47, 51, 629, DateTimeKind.Local).AddTicks(8423),
                            Name = "Joseph Carlton",
                            UpdatedOn = new DateTime(2022, 11, 21, 15, 47, 51, 629, DateTimeKind.Local).AddTicks(8427)
                        },
                        new
                        {
                            Id = 2,
                            CreatedOn = new DateTime(2022, 11, 21, 15, 47, 51, 629, DateTimeKind.Local).AddTicks(8432),
                            Name = "Maria Juarez",
                            UpdatedOn = new DateTime(2022, 11, 21, 15, 47, 51, 629, DateTimeKind.Local).AddTicks(8433)
                        },
                        new
                        {
                            Id = 3,
                            CreatedOn = new DateTime(2022, 11, 21, 15, 47, 51, 629, DateTimeKind.Local).AddTicks(8434),
                            Name = "Albert Kenny",
                            UpdatedOn = new DateTime(2022, 11, 21, 15, 47, 51, 629, DateTimeKind.Local).AddTicks(8434)
                        },
                        new
                        {
                            Id = 4,
                            CreatedOn = new DateTime(2022, 11, 21, 15, 47, 51, 629, DateTimeKind.Local).AddTicks(8435),
                            Name = "Jessica Phillips",
                            UpdatedOn = new DateTime(2022, 11, 21, 15, 47, 51, 629, DateTimeKind.Local).AddTicks(8435)
                        },
                        new
                        {
                            Id = 5,
                            CreatedOn = new DateTime(2022, 11, 21, 15, 47, 51, 629, DateTimeKind.Local).AddTicks(8436),
                            Name = "Charles Johnson",
                            UpdatedOn = new DateTime(2022, 11, 21, 15, 47, 51, 629, DateTimeKind.Local).AddTicks(8437)
                        });
                });

            modelBuilder.Entity("BillingLibrary.Models.BillModel", b =>
                {
                    b.HasOne("BillingLibrary.Models.ClientModel", null)
                        .WithMany("Payments")
                        .HasForeignKey("ClientModelId");
                });

            modelBuilder.Entity("BillingLibrary.Models.ClientModel", b =>
                {
                    b.Navigation("Payments");
                });
#pragma warning restore 612, 618
        }
    }
}
