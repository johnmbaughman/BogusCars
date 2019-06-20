using System;
using System.Collections.Generic;
using System.Linq;

namespace Cars
{
    public class Model
    {
        public Model()
        {
            ModelYears = new List<string>();
        }

        public string Name { get; set; }

        public List<YearRange> YearRanges { get; set; }

        public List<string> ModelYears { get; }

        public void SetModelYears()
        {
            if (ModelYears.Any() && YearRanges.Any() || !YearRanges.Any())
            {
                return;
            }

            foreach (var yearRange in YearRanges)
            {
                int startYear = int.Parse(yearRange.StartYear);
                int endYear = int.Parse(yearRange.EndYear.ToLower().Equals("current") 
                    ? DateTime.Now.Year.ToString()
                    : yearRange.EndYear );
                int currentYear = startYear;
                while (currentYear <= endYear)
                {
                    ModelYears.Add(currentYear.ToString());
                    currentYear++;
                }
            }
        }
    }
}