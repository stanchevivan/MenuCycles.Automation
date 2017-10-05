using MenuCycle.Tests.PageObjects;
using TechTalk.SpecFlow;

namespace MenuCycle.Tests.Steps
{
    [Binding]
    public class FourthEngageSteps
    {
        private EngageLogin engageLogin;
        private EngageDashboard engageDashboard;

        public FourthEngageSteps(EngageLogin engageLogin, EngageDashboard engageDashboard)
        {
            this.engageLogin = engageLogin;
            this.engageDashboard = engageDashboard;
        }

        [Given(@"Fourth Engage Dashboard is open")]
        public void GivenFourthEngageDashboarIsOpen()
        {
            engageLogin.OpenLoginPage();
            engageLogin.PerformLogin();
        }

        [Given(@"'(.*)' application is selected")]
        public void GivenApplicationIsSelected(string application)
        {
            engageDashboard.SelectApplication(application);
        }

        [Given(@"'(.*)' application is open")]
        public void GivenApplicationIsOpen(string application)
        {
            GivenFourthEngageDashboarIsOpen();
            GivenApplicationIsSelected(application);
        }
    }
}
