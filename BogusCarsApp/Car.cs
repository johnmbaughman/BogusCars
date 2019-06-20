using System.Collections.Generic;

namespace BogusCarsApp
{
    public class Car
    {
        public IEnumerable<string> AllMakes { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string ModelYear { get; set; }
    }
}