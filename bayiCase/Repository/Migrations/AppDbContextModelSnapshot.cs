// <auto-generated />
using Bayi.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Bayi.Repository.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Bayi.Core.Models.AltBayi", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("AltBayiAdi")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("AnaBayiId")
                        .HasColumnType("int");

                    b.Property<string>("Il")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ilce")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Mail")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("Telefon")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("AnaBayiId");

                    b.ToTable("AltBayiler", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AltBayiAdi = "AltTest",
                            AnaBayiId = 1,
                            Il = "İstanbul",
                            Ilce = "Maltepe",
                            Mail = "xxx@xx.x",
                            Telefon = 21424L
                        });
                });

            modelBuilder.Entity("Bayi.Core.Models.AnaBayi", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("AltBayiAdi")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AnaBayiAdi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Il")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ilce")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Mail")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("Telefon")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.ToTable("AnaBayiler", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AltBayiAdi = "AltTest",
                            AnaBayiAdi = "Test Bayi",
                            Il = "İstanbul",
                            Ilce = "Kartal",
                            Mail = "xxx@xxx.xx",
                            Telefon = 2160000L
                        });
                });

            modelBuilder.Entity("Bayi.Core.Models.AltBayi", b =>
                {
                    b.HasOne("Bayi.Core.Models.AnaBayi", "AnaBayi")
                        .WithMany("altBayi")
                        .HasForeignKey("AnaBayiId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AnaBayi");
                });

            modelBuilder.Entity("Bayi.Core.Models.AnaBayi", b =>
                {
                    b.Navigation("altBayi");
                });
#pragma warning restore 612, 618
        }
    }
}
