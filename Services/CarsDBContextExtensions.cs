using System.Collections.Generic;
using System.Linq;
using CarAPI.Entities;

namespace CarAPI.Services
{
    public static class CarsDBContextExtensions
    {
        public static void CreateSeedData (this CarsDBContext context)
        {
            if (context.Cars.Any()) return;
            var cars = new List<Car>()
            {
                new Car()
                {
                    Firstname = "John",
                    Lastname = "Doe",
                    Name_speak = "Johnny",
                },
                new Car()
                {
                    Firstname = "Jane",
                    Lastname = "Doe",
                    Name_speak = "Jenny",
                }
            };
            context.AddRange(cars);
            context.SaveChanges();
        }
    }
}