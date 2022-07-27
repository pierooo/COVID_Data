using System;
using System.Collections.Generic;

namespace COVID_Data.Models
{
    public class Root
    {
        public Global Global { get; set; }
        public List<CountryData> Countries { get; set; }
        public DateTime Date { get; set; }
    }
}
