using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using TechTalk.SpecFlow;

namespace MenuCycle.Tests.Steps
{
    [Binding]
    public class PerformanceSteps
    {

        Stopwatch sw = new Stopwatch();
        readonly List<double> singleTimes = new List<double>();

        double totalTimeElapsed => singleTimes.Sum();
        double minTimeElapsed => singleTimes.Min();
        double maxTimeElapsed => singleTimes.Max();
        double averageTimeElapsed => singleTimes.Average();

        ReportSteps reportSteps;
        LocalUserPlanningSteps localUserPlanningSteps;
        MenuCycleSteps menuCycleSteps;
        MealMeriodDetailSteps mealMeriodDetailSteps;

        public PerformanceSteps(ReportSteps reportSteps, LocalUserPlanningSteps localUserPlanningSteps, MenuCycleSteps menuCycleSteps, MealMeriodDetailSteps mealMeriodDetailSteps)
        {
            this.reportSteps = reportSteps;
            this.localUserPlanningSteps = localUserPlanningSteps;
            this.menuCycleSteps = menuCycleSteps;
            this.mealMeriodDetailSteps = mealMeriodDetailSteps;
        }

        [When(@"Performance for ""(.*)"" repetitions of Select Location -> Click location name for location ""(.*)"" is evaluated")]
        public void GivenIsLoggedIn(int repetitions,string location)
        {
            sw.Reset();

            for (int i = 0; i < repetitions; i++)
            {
                menuCycleSteps.GivenAUserIsSelected("Local");

                localUserPlanningSteps.GivenLocationIsSelected(location);

                sw.Start();
                reportSteps.LocationNameIsClicked();
                sw.Stop();
                singleTimes.Add(sw.Elapsed.TotalSeconds);
            }

            Console.WriteLine($"Total time is: {totalTimeElapsed} seconds");
            Console.WriteLine($"Average time is: {averageTimeElapsed} seconds");
            Console.WriteLine($"Min time is: {minTimeElapsed} seconds");
            Console.WriteLine($"Max time is: {maxTimeElapsed} seconds");
        }

        [When(@"Performance for ""(.*)"" repetitions for recipe search on ""(.*)""")]
        public void PerformanceOfRecipeIsSearchedIsMeasured(int repetitions, string recipeName)
        {
            sw.Reset();

            for (int i = 0; i < repetitions; i++)
            {
                sw.Start();
                mealMeriodDetailSteps.RecipeIsSearched(recipeName);
                sw.Stop();
                singleTimes.Add(sw.Elapsed.TotalSeconds);
            }

            Console.WriteLine($"Total time is: {totalTimeElapsed} seconds");
            Console.WriteLine($"Average time is: {averageTimeElapsed} seconds");
            Console.WriteLine($"Min time is: {minTimeElapsed} seconds");
            Console.WriteLine($"Max time is: {maxTimeElapsed} seconds");
        }
    }
}
