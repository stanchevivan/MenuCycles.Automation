using System.Collections.Generic;
using System.Linq;
using MenuCycle.Tests.PageObjects;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace MenuCycle.Tests.Steps
{
    [Binding]
    public class ReviewSteps
    {
        readonly PlanningTabDays planningTabDays;
        readonly ToastNotification notification;
        readonly ScenarioContext scenarioContext;
        readonly ModalDialogPage modalDialogPage;
        readonly ReviewPage reviewPage;

        public ReviewSteps(ScenarioContext scenarioContext, PlanningTabDays planningTabDays, ToastNotification notification,
                           ModalDialogPage modalDialogPage, ReviewPage reviewPage)
        {
            this.planningTabDays = planningTabDays;
            this.notification = notification;
            this.modalDialogPage = modalDialogPage;
            this.reviewPage = reviewPage;

            this.scenarioContext = scenarioContext;
        }

        [Then(@"Verify review page is open")]
        public void VerifyReviewPageIsOpen()
        {
            Assert.IsTrue(reviewPage.IsLoaded);
        }
    }
}