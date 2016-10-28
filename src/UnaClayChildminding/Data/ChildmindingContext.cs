using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UnaClayChildminding.Models;

namespace UnaClayChildminding.Data
{
    public class ChildmindingContext : DbContext

    {
        public ChildmindingContext(DbContextOptions<ChildmindingContext> options) : base(options)
        {
        }

        public DbSet<Testimonial> Testimonials { get; set; }
        public DbSet<Image> Images { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Testimonial>().ToTable("Testimonials");
            modelBuilder.Entity<Image>().ToTable("Images");
        }
        
    }

    

}
