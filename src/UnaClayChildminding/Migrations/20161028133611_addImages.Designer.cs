using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using UnaClayChildminding.Data;

namespace UnaClayChildminding.Migrations
{
    [DbContext(typeof(ChildmindingContext))]
    [Migration("20161028133611_addImages")]
    partial class addImages
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.0.1")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("UnaClayChildminding.Models.Image", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("description");

                    b.Property<string>("url");

                    b.HasKey("ID");

                    b.ToTable("Images");
                });

        }
    }
}
