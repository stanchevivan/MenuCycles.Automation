using TechTalk.SpecFlow;
using Bogus;
using MenuCycles.AutomatedTests.Model;
using System;
using System.Collections.Generic;

namespace MenuCycles.AutomatedTests.Hooks
{
    [Binding]
    public static class Transform
    {
        //Converts a Specflow into a list of Menu Cycles
        //If the value is not in the table, it uses Bogus to generate a random value
        [StepArgumentTransformation]
        public static List<MenuCycle> MenuCycleList(Table table)
        {
            Faker faker = new Faker();

            List<MenuCycle> list = new List<MenuCycle>();
            foreach (TableRow row in table.Rows)
            {
                list.Add
                (
                    new MenuCycle()
                    {
                        Name = row.FindValue("Name", faker.Name.FirstName()),
                        Description = row.FindValue("Description", faker.Lorem.Sentence(10)),
                        Group = row.FindValue("Offer", ""),
                        NonServingDays = row.FindValue("NonServingDays", "").ToWeekDay()
                    }
                );
            }

            return list;
        }

        private static string FindValue(this TableRow row, string key, string ifNotFound)
        {
            if (row.ContainsKey(key))
            {
                return (row[key] != "") ? row[key] : ifNotFound;
            }
            return ifNotFound;
        }

        private static List<DayOfWeek> ToWeekDay(this string self)
        {
            List<DayOfWeek> list = new List<DayOfWeek>();

            if (self != "")
            {
                foreach (var item in self.Split(','))
                {
                    list.Add((DayOfWeek)Enum.Parse(typeof(DayOfWeek), item, true));
                }
            }
            return list;
        }
    }
}

