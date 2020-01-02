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
        readonly DestinationReviewPage destinationReviewPage;

        public ReviewSteps(ScenarioContext scenarioContext, PlanningTabDays planningTabDays, ToastNotification notification,
                           ModalDialogPage modalDialogPage, ReviewPage reviewPage, DestinationReviewPage destinationReviewPage)
        {
            this.planningTabDays = planningTabDays;
            this.notification = notification;
            this.modalDialogPage = modalDialogPage;
            this.reviewPage = reviewPage;
            this.destinationReviewPage = destinationReviewPage;
            this.scenarioContext = scenarioContext;
        }

        [Then(@"Verify review page is open")]
        [When(@"Verify review page is open")]
        public void VerifyReviewPageIsOpen()
        {
            Assert.IsTrue(reviewPage.IsLoaded);
        }

        [When(@"Select & Verify Destinations button is clicked")]
        public void WhenSelectVerifyDestinationsButtonIsClicked()
        {
            reviewPage.ClickSelectDestinationsBtn();
        }

        [When(@"All destinations are selected")]
        public void WhenAllDestinationsAreSelected()
        {
            destinationReviewPage.WaitForLoad();
            destinationReviewPage.ClickSelectAllCheckbox();
        }

        [When(@"Run button is clicked")]
        public void WhenRunButtonIsClicked()
        {
            destinationReviewPage.ClickRunButton();
            planningTabDays.WaitSpinnerToDisappear();
        }

        [Then(@"Verify Gap Check report are displayed")]
        public void ThenVerifyGapCheckReportAreDisplayed()
        {
            Assert.IsTrue(destinationReviewPage.GapCheckReportIsLoaded);
        }

        [When(@"Destination review page is opened")]
        public void WhenDestinationReviewPageIsOpened()
        {
            destinationReviewPage.WaitForLoad();
        }

    }
}