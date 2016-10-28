using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using UnaClayChildminding.Data;

namespace UnaClayChildminding.Migrations
{
    [DbContext(typeof(ChildmindingContext))]
    partial class ChildmindingContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.0.1")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("UnaClayChildminding.Models.Image", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("description");

                    b.Property<string>("fileName");

                    b.HasKey("ID");

                    b.ToTable("Images");
                });

            modelBuilder.Entity("UnaClayChildminding.Models.Testimonial", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description");

                    b.HasKey("ID");

                    b.ToTable("Testimonials");
                });
        }
    }
}
