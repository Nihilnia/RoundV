// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using _4_oneToOne;

namespace _4_oneToOne.Migrations
{
    [DbContext(typeof(CardigansContext))]
    [Migration("20211031211422_addTableIsBand")]
    partial class addTableIsBand
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.11");

            modelBuilder.Entity("_4_oneToOne.Artist", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.HasKey("ID");

                    b.ToTable("Artists");
                });

            modelBuilder.Entity("_4_oneToOne.Info", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("ArtistID")
                        .HasColumnType("INTEGER");

                    b.Property<string>("FullName")
                        .HasColumnType("TEXT");

                    b.Property<string>("Varios")
                        .HasColumnType("TEXT");

                    b.Property<int>("YearOfBirth")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("isBand")
                        .HasColumnType("INTEGER");

                    b.HasKey("ID");

                    b.HasIndex("ArtistID")
                        .IsUnique();

                    b.ToTable("Infos");
                });

            modelBuilder.Entity("_4_oneToOne.isBand", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("InfoID")
                        .HasColumnType("INTEGER");

                    b.Property<string>("TextIsBand")
                        .HasColumnType("TEXT");

                    b.HasKey("ID");

                    b.HasIndex("InfoID")
                        .IsUnique();

                    b.ToTable("IsBands");
                });

            modelBuilder.Entity("_4_oneToOne.Info", b =>
                {
                    b.HasOne("_4_oneToOne.Artist", "Artist")
                        .WithOne("Info")
                        .HasForeignKey("_4_oneToOne.Info", "ArtistID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Artist");
                });

            modelBuilder.Entity("_4_oneToOne.isBand", b =>
                {
                    b.HasOne("_4_oneToOne.Info", "Info")
                        .WithOne("bandOrNot")
                        .HasForeignKey("_4_oneToOne.isBand", "InfoID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Info");
                });

            modelBuilder.Entity("_4_oneToOne.Artist", b =>
                {
                    b.Navigation("Info");
                });

            modelBuilder.Entity("_4_oneToOne.Info", b =>
                {
                    b.Navigation("bandOrNot");
                });
#pragma warning restore 612, 618
        }
    }
}
