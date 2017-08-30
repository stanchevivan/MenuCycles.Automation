using MenuCycles.Tests.PageObjects;
using TechTalk.SpecFlow;

namespace MenuCycles.Tests
{
    [Binding]
    public class SandboxSteps
    {
        private FourthLoginPage FourthLoginPage;
		private FourthHomePage FourthHomePage;
    
        public SandboxSteps(FourthLoginPage fourthLoginPage, FourthHomePage fourthHomePage)
		{
            FourthLoginPage = fourthLoginPage;
			FourthHomePage = fourthHomePage;
		}

		[When(@"MenuCycles navigation ends")]
		public void WhenMenuCyclesNavigationEnds()
		{
            FourthLoginPage.Open()
                           .PerformLogin()
                           .OpenMenuCycles()
                           .LoginAsCentralUser()
                           .Search("Buffet")
                           .GetMenuCyclesInfo();
   		}
    }
}