using Bogus;

namespace Cars.Bogus
{
    public static class CarDataExtensions
    {
        public static CarsDataSet Cars(this Faker faker)
        {
            return new CarsDataSet();
        }
    }
}