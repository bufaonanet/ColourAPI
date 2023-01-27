using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System.Linq;

namespace ColourAPI.Models
{
    public static class PrepDb
    {
        public static void PrepPopulation(IApplicationBuilder app)
        {
            using (var serviceScope = app.ApplicationServices.CreateScope())
            {
                SeedData(serviceScope.ServiceProvider.GetService<ColourContext>());
            }
        }

        private static void SeedData(ColourContext context)
        {
            System.Console.WriteLine("Appling Migrations..");

            context.Database.Migrate();

            if (!context.ColoursItems.Any())
            {
                System.Console.WriteLine("Adding data - seeding..");
                context.ColoursItems.AddRange
                (
                    new Colour { ColourName = "Red" },
                    new Colour { ColourName = "Orange" },
                    new Colour { ColourName = "Blue" },
                    new Colour { ColourName = "Black" },
                    new Colour { ColourName = "White" }
                );
                context.SaveChanges();
            }
            else
            {
                System.Console.WriteLine("Already have data - not seeding");
            }
        }
    }
}
