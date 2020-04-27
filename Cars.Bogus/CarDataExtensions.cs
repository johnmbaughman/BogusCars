using Bogus;

namespace Cars.Bogus
{
    public static class CarDataExtensions
    {
        private static CarsDataSet _carsDataSet;

        public static CarsDataSet Cars(this Faker faker)
        {
            return _carsDataSet ?? (_carsDataSet = new CarsDataSet());
        }
    }
}
