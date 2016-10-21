using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using UnaClayChildminding.Data;
using System.Threading.Tasks;
using UnaClayChildminding.Models;

namespace UnaClayChildminding.Data
{
    public class DbInitializer
    {
       public static void Initalize(ChildmindingContext context)
        {
            context.Database.EnsureCreated();

            // Look for Testimonials.
            if (context.Testimonials.Any())
            {
                return; // DB has been seeded
            }

            var testimonials = new Testimonial[]
            {
                new Testimonial {Description="Ms M XXX from Harmans Water remarks “We enjoy reading what our daughter has been upto in the daily contact book. We are very happy with all the outdoor activities and XXX seems happy.”" },
                new Testimonial {Description="Ms P XXX from Harmans Water comments “We have been very happy. The daily contact diary is very detailed. The activities our son does seem very varied. The meals are excellent. XXX has been very happy when being dropped off so we don’t worry about him. We have been very impressed with your level of childcare and efficiency.”" },
                new Testimonial {Description="Ms M XXX from Harmans Water states “I would like to take this opportunity to thank you for all the fantastic care and support you have given to XXX over the last year.I can honestly say we will be very hard pushed to find the same standard of care and development for XXX in Wales, as we relocate with the family.Many thanks.”" }
            };
            foreach (Testimonial t in testimonials)
            {
                context.Testimonials.Add(t);
            }
            context.SaveChanges();
        }
    }
}
