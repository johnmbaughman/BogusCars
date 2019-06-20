using System;
using Bogus;
using Bogus.Premium;

namespace Cars.Bogus
{
    public static class CarDataExtensions
    {
        public static CarsDataSet Cars(this Faker faker)
        {
            return ContextHelper.GetOrSet(faker, () => new CarsDataSet());
        }
    }
}