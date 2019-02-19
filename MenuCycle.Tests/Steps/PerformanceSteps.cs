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
        readonly List<double> singleTimesElapsed = new List<double>();

        double totalTimeElapsed => singleTimesElapsed.Sum();
        double minTimeElapsed => singleTimesElapsed.Min();
        double maxTimeElapsed => singleTimesElapsed.Max();
        double averageTimeElapsed => singleTimesElapsed.Average();

        ReportSteps reportSteps;
        LocalUserPlanningSteps localUserPlanningSteps;
        MenuCycleSteps menuCycleSteps;

        public PerformanceSteps(ReportSteps reportSteps, LocalUserPlanningSteps localUserPlanningSteps, MenuCycleSteps menuCycleSteps)
        {
            this.reportSteps = reportSteps;
            this.localUserPlanningSteps = localUserPlanningSteps;
            this.menuCycleSteps = menuCycleSteps;
        }

        [When(@"Performance for ""(.*)"" repetitions of Select Location -> Click location name for location ""(.*)"" is evaluated")]
        public void GivenIsLoggedIn(int repetitions,string location)
        {
            var sw = new Stopwatch();

            for (int i = 0; i < repetitions; i++)
            {
                sw.Start();
                menuCycleSteps.GivenAUserIsSelected("Local");
                localUserPlanningSteps.GivenLocationIsSelected(location);
                reportSteps.LocationNameIsClicked();

                sw.Stop();
                singleTimesElapsed.Add(sw.Elapsed.TotalSeconds);
            }

            Console.WriteLine($"Total time is: {totalTimeElapsed} seconds");
            Console.WriteLine($"Average time is: {averageTimeElapsed} seconds");
            Console.WriteLine($"Min time is: {minTimeElapsed} seconds");
            Console.WriteLine($"Max time is: {maxTimeElapsed} seconds");
        }
    }
}
