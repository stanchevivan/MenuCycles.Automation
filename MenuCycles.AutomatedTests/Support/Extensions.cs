using TechTalk.SpecFlow;
using System;
using System.Collections.Generic;

namespace MenuCycles.AutomatedTests.Support
{
    public static class Extensions
    {
        private static int ToWeekDay(this string self)
        {
            List<DayOfWeek> list = new List<DayOfWeek>();

            if (self != "")
            {
                foreach (var item in self.Split(','))
                {
                    list.Add((DayOfWeek)Enum.Parse(typeof(DayOfWeek), item, true));
                }
            }

            return 0;
        }
    }
}

