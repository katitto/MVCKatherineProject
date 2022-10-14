
using MVC_Katherine_Project.Models;
using Microsoft.AspNetCore.Identity;

namespace MVC_Katherine_Project.Data
{
    public class Seed
    {
        public static void SeedData(IApplicationBuilder applicationBuilder)
        {
            int Priceint = 160000;
            Decimal PriceDecimal1 = Convert.ToDecimal(Priceint);
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<ApplicationDbContext>();

                context.Database.EnsureCreated();

                if (!context.Properties.Any())
                {
                    context.Properties.AddRange(new List<Property>()

                    {

                    new Property
                        {
                            
                            Name = "C/ Maestro Bretón Nº 2",
                            Rooms = 4,
                            Meters = 120,
                            Bathroom = 2,
                            Lift = false,
                            Price = PriceDecimal1


                        },
                         new Property
                         {
                             
                             Name = "C/Apostol Santiago 12",
                             Rooms = 3,
                             Meters = 77,
                             Bathroom = 1,
                             Lift = false,
                             Price = PriceDecimal1


                         },
                         new Property
                         {
                            
                             Name = "C/Heredia",
                             Rooms = 1,
                             Meters = 65,
                             Bathroom = 1,
                             Lift = true,
                             Price = PriceDecimal1
                         },
                         new Property
                         {
                             
                             Name = "C/Pascual",
                             Rooms = 3,
                             Meters = 87,
                             Bathroom = 1,
                             Lift = true,
                             Price = PriceDecimal1
                         }

                    });
                    context.SaveChanges();          

            }
        }
    }
}
}
