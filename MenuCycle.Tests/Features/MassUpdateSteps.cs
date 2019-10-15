using System;
using System.Collections.Generic;
using System.Linq;
using MenuCycle.Tests.Models;
using MenuCycle.Tests.PageObjects;
using NUnit.Framework;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace MenuCycle.Tests.Steps
{
    [Binding]
    public class MassUpdateSteps
    {
        readonly PlanningView dailyPlanningView;
        readonly PlanningTabDays planningTabDays;
        readonly PlanningTabWeeks planningTabWeeks;
        readonly NutritionTabDays nutritionTabDays;
        readonly MenuCycleDailyCalendarView menuCycleDailyCalendarView;
        readonly RecipeSearch recipeSearch;
        readonly ToastNotification notification;
        readonly ScenarioContext scenarioContext;
        readonly ModalDialogPage modalDialogPage;
        readonly CommonElements commonElements;
        readonly MassUpdatePage massUpdate;

        public MassUpdateSteps(ScenarioContext scenarioContext, PlanningView dailyPlanningView, PlanningTabDays planningTabDays, PlanningTabWeeks planningTabWeeks, NutritionTabDays nutritionTabDays, MenuCycleDailyCalendarView menuCycleDailyCalendarView, RecipeSearch recipeSearch, ToastNotification notification, ModalDialogPage modalDialogPage, CommonElements commonElements, MassUpdatePage massUpdate)
        {
            this.dailyPlanningView = dailyPlanningView;
            this.planningTabDays = planningTabDays;
            this.planningTabWeeks = planningTabWeeks;
            this.nutritionTabDays = nutritionTabDays;
            this.menuCycleDailyCalendarView = menuCycleDailyCalendarView;
            this.recipeSearch = recipeSearch;
            this.notification = notification;
            this.modalDialogPage = modalDialogPage;
            this.commonElements = commonElements;
            this.massUpdate = massUpdate;

            this.scenarioContext = scenarioContext;
        }

        [When(@"recipe ""(.*)"" is searched")]
        public void WhenRecipeIsSearched(string recipeName)
        {
            massUpdate.EnterKeywordInSearch(recipeName);
            planningTabDays.FocusOut();
            massUpdate.ClickSearchButton();
            planningTabDays.WaitSpinnerToDisappear();
        }

        [When(@"recipe ""(.*)"" is selected")]
        public void WhenRecipeIsSelected(string recipeName)
        {
            massUpdate.GetResultCard(recipeName).SelectRecipeCard();
        }
    }
}