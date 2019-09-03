using System.Collections.Generic;
using System.Linq;
using MenuCycle.Tests.PageObjects;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace MenuCycle.Tests.Steps
{
    [Binding]
    public class InternalSearchSteps
    {
        readonly PlanningTabDays planningTabDays;
        readonly ToastNotification notification;
        readonly ScenarioContext scenarioContext;
        readonly ModalDialogPage modalDialogPage;
        readonly ReviewPage reviewPage;
        readonly InternalSearchView internalSearchView;
        readonly MealPeriodDetails mealPeriodDetails;

        public InternalSearchSteps(ScenarioContext scenarioContext, PlanningTabDays planningTabDays, ToastNotification notification,
                           ModalDialogPage modalDialogPage, ReviewPage reviewPage, InternalSearchView internalSearchView, MealPeriodDetails mealPeriodDetails)
        {
            this.planningTabDays = planningTabDays;
            this.notification = notification;
            this.modalDialogPage = modalDialogPage;
            this.reviewPage = reviewPage;
            this.internalSearchView = internalSearchView;
            this.mealPeriodDetails = mealPeriodDetails;

            this.scenarioContext = scenarioContext;
        }

        [When(@"search in Menu Cycle for ""(.*)""")]
        public void SearchInMCFor(string text)
        {
            internalSearchView.ClickSearchIcon();
            internalSearchView.EnterSearchCriteria(text);
            internalSearchView.ClickSearchButton();
            internalSearchView.WaitForLoad();
        }

        [When(@"view recipe ""(.*)"" in week ""(.*)""")]
        public void ViewRecipeInWeek(string recipeName, string weekName)
        {
            internalSearchView.GetLine(recipeName, weekName).ViewRecipe();
            mealPeriodDetails.WaitForLoad();
        }
    }
}