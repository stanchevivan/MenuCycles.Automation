using System;
using System.Collections.Generic;

namespace MenuCycles.AutomatedTests.Model
{
    public class MenuCycle
    {
        public string Name { get; set;}
        public string Description { get; set;}
        public List<DayOfWeek> NonServingDays { get; set; }
        public string Offer { get; set; }
    }
}

