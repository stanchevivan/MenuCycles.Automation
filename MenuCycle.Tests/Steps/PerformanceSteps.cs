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

        MenuCycleSteps menuCycleSteps;
        MealMeriodDetailSteps mealMeriodDetailSteps;
        PlanningSteps planningSteps;

        public PerformanceSteps(MenuCycleSteps menuCycleSteps, MealMeriodDetailSteps mealMeriodDetailSteps, PlanningSteps planningSteps)
        {
            this.menuCycleSteps = menuCycleSteps;
            this.mealMeriodDetailSteps = mealMeriodDetailSteps;
            this.planningSteps = planningSteps;
        }

        [When(@"Measure performance of load menu cycles list for ""(.*)"" repetitions")]
        public void GivenIsLoggedIn(int repetitions)
        {
            for (int i = 0; i < repetitions; i++)
            {
                sw.Reset();
                sw.Start();
                menuCycleSteps.GivenACentralUserIsSelected();
                sw.Stop();
                singleTimes.Add(sw.Elapsed.TotalSeconds);
                Console.WriteLine(i + 1 + ": " + sw.Elapsed.TotalSeconds);
                menuCycleSteps.LocationNameIsClicked();
            }

            PrintSummary();
        }

        [When(@"Measure performance of recipe search for ""(.*)"" repetitions on ""(.*)""")]
        public void PerformanceOfRecipeIsSearchedIsMeasured(int repetitions, string recipeName)
        {
            for (int i = 0; i < repetitions; i++)
            {
                sw.Reset();
                sw.Start();
                mealMeriodDetailSteps.RecipeIsSearched(recipeName);
                sw.Stop();
                singleTimes.Add(sw.Elapsed.TotalSeconds);
                Console.WriteLine(i + 1 + ": " + sw.Elapsed.TotalSeconds);
            }

            PrintSummary();
        }

        [When(@"Measure performance of Open planning screen for ""(.*)"" repetitions on ""(.*)""")]
        public void PerformanceOfEnteringPlanningScreen(int repetitions, string day)
        {
            for (int i = 0; i < repetitions; i++)
            {
                sw.Reset();
                sw.Start();

                menuCycleSteps.WhenPlanningForADayIsOpened(day);

                sw.Stop();
                singleTimes.Add(sw.Elapsed.TotalSeconds);
                Console.WriteLine(i + 1 + ": " + sw.Elapsed.TotalSeconds);

                planningSteps.WhenCancelButtonIsClicked();
            }

            PrintSummary();
        }

        [When(@"Measure performance of Open nutrition screen for ""(.*)"" repetitions")]
        public void PerformanceOfEnteringNutritionScreen(int repetitions)
        {
            for (int i = 0; i < repetitions; i++)
            {
                sw.Reset();
                sw.Start();

                planningSteps.WhenNutritionTabIsOpened();

                sw.Stop();
                singleTimes.Add(sw.Elapsed.TotalSeconds);
                Console.WriteLine(i + 1 + ": " + sw.Elapsed.TotalSeconds);

                planningSteps.WhenPlanningTabIsOpened();
            }

            PrintSummary();
        }

        [When(@"Measure performance of Open weekly calendar view for ""(.*)"" repetitions")]
        public void PerformanceOfOpenWeeklyCalendarView(int repetitions)
        {
            for (int i = 0; i < repetitions; i++)
            {
                sw.Reset();
                sw.Start();

                menuCycleSteps.WeeksTabIsOpened();

                sw.Stop();
                singleTimes.Add(sw.Elapsed.TotalSeconds);
                Console.WriteLine(i + 1 + ": " + sw.Elapsed.TotalSeconds);

                menuCycleSteps.DaysTabIsOpened();
            }

            PrintSummary();
        }

        [When(@"Measure performance of Open menu cycle with 1800 items for ""(.*)"" repetitions for ""(.*)""")]
        public void PerformanceOfOpenMenuCycleWithManyItems(int repetitions, string menuCycle)
        {
            for (int i = 0; i < repetitions; i++)
            {
                sw.Reset();
                sw.Start();

                menuCycleSteps.GivenMenuCycleIsSelected(menuCycle);

                sw.Stop();
                singleTimes.Add(sw.Elapsed.TotalSeconds);
                Console.WriteLine(i + 1 + ": " + sw.Elapsed.TotalSeconds);

                menuCycleSteps.WhenHomeButtonIsClicked();
            }

            PrintSummary();
        }

        private double CalculatePercentile(double[] sequence, double percentile)
        {
            Array.Sort(sequence);

            int lenght = sequence.Length;
            double n = (lenght - 1) * percentile + 1;

            if (n == 1d) return sequence[0];
            else if (n == lenght) return sequence[lenght - 1];
            else
            {
                int k = (int)n;
                double d = n - k;
                return sequence[k - 1] + d * (sequence[k] - sequence[k - 1]);
            }
        }

        private void PrintSummary()
        {
            Console.WriteLine($"--Summary--");
            Console.WriteLine($"Number of measurments: {singleTimes.Count}");
            Console.WriteLine($"Total time: {totalTimeElapsed} seconds");
            Console.WriteLine($"~~~~~");
            Console.WriteLine($"Average time: {averageTimeElapsed} seconds");
            Console.WriteLine($"Min time: {minTimeElapsed} seconds");
            Console.WriteLine($"Max time: {maxTimeElapsed} seconds");
            Console.WriteLine($"50% are above: { CalculatePercentile(singleTimes.ToArray(), 0.5) } seconds");
            Console.WriteLine($"10% are above: { CalculatePercentile(singleTimes.ToArray(), 0.9) } seconds");
            Console.WriteLine($"-----");
        }
    }
}