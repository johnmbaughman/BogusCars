using System.Collections.Generic;
using System.Linq;
using Bogus;

namespace Cars.Bogus
{
    public class CarsDataSet : DataSet
    {
        public IEnumerable<string> AllMakes
        {
            get { return DataLoader.Cars.Select(m => m.Make); }
        }

        public string Make()
        {
            return Car().Make;
        }

        public string Model(string make)
        {
            int index = Random.Number(DataLoader.Cars.FirstOrDefault(m => m.Make.Equals(make)).Models.Count - 1);
            return DataLoader.Cars.FirstOrDefault(m => m.Make.Equals(make)).Models[index].Name;
        }

        public string ModelYear(string make, string model)
        {
            DataLoader.Cars
                .FirstOrDefault(m => m.Make.Equals(make))?
                .Models.FirstOrDefault(m => m.Name.Equals(model))?.SetModelYears();

            int index = Random.Number(DataLoader.Cars
                                          .FirstOrDefault(m => m.Make.Equals(make))?
                                          .Models.FirstOrDefault(m => m.Name.Equals(model))?.ModelYears.Count ?? 1 - 1);
            return DataLoader.Cars
                .FirstOrDefault(m => m.Make.Equals(make))?
                .Models.FirstOrDefault(m => m.Name.Equals(model))?.ModelYears[index];
        }

        public Car Car()
        {
            int index = Random.Number(DataLoader.Cars.Count - 1);
            return DataLoader.Cars[index];
        }
    }
}