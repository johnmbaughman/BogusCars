using System.Collections.Generic;

namespace Cars
{
    public class DataLoader
    {
        static DataLoader()
        {
            var assembly = typeof(DataLoader).Assembly;
            using (var stream = assembly.GetManifestResourceStream("Cars.cardata.json"))
            {
                Cars = Serializer.Deserialize<List<Car>>(stream);
            }
        }

        public static IReadOnlyList<Car> Cars { get; }
    }
}
