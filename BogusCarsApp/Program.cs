using System;
using Bogus;
using Cars.Bogus;

namespace BogusCarsApp
{
    internal class Program
    {
        private static void Main()
        {

            var faker = new Faker<Car>()
                .RuleFor(c => c.AllMakes, f => f.Cars().AllMakes)
                .RuleFor(c => c.Make, f => f.Cars().Make())
                .RuleFor(c => c.Model, (f, c) => f.Cars().Model(c.Make))
                .RuleFor(c => c.ModelYear, (f, c) => f.Cars().ModelYear(c.Make, c.Model));

            var cars = faker.Generate();


            Console.WriteLine($"Car.Make = {cars.Make}, Car.Model = {cars.Model}, Car.ModelYear = {cars.ModelYear}");
            Console.WriteLine($"Car.AllMakes = {string.Join(",", cars.AllMakes)}");
            Console.ReadKey();
        }
    }
}
