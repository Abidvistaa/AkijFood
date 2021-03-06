// <auto-generated />
using AkijFood.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace AkijFood.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20210630143430_AddTblColdDrinksToDB")]
    partial class AddTblColdDrinksToDB
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.7")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("AkijFood.Models.tblColdDrink", b =>
                {
                    b.Property<int>("ColdDrinksId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ColdDrinksName")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)");

                    b.Property<decimal>("NumQuantity")
                        .HasColumnType("decimal(4)");

                    b.Property<decimal>("NumUnitPrice")
                        .HasColumnType("decimal(3)");

                    b.HasKey("ColdDrinksId");

                    b.ToTable("tblColdDrinks");
                });
#pragma warning restore 612, 618
        }
    }
}
