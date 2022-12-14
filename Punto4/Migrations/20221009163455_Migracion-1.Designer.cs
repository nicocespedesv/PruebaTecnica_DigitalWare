// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Punto4.DbConfig;

namespace Punto4.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20221009163455_Migracion-1")]
    partial class Migracion1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.29")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Punto4.Models.Grades.AcademicRecord", b =>
                {
                    b.Property<int>("RecordId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double>("FirstPeriodGrade")
                        .HasColumnType("float");

                    b.Property<double>("FourthPeriodGrade")
                        .HasColumnType("float");

                    b.Property<double>("SecondPeriodGrade")
                        .HasColumnType("float");

                    b.Property<string>("StudentId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Subject")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("ThirdPeriodGrade")
                        .HasColumnType("float");

                    b.HasKey("RecordId");

                    b.ToTable("AcademicRecord");
                });
#pragma warning restore 612, 618
        }
    }
}
