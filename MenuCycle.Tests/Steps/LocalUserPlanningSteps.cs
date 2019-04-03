﻿using MenuCycle.Tests.PageObjects;using NUnit.Framework;using TechTalk.SpecFlow;namespace MenuCycle.Tests.Steps{    [Binding]    public class LocalUserPlanningSteps    {        readonly PlanningView planningView;        readonly PlanningTabDays planningTabDays;        readonly ToastNotification notification;        readonly ScenarioContext scenarioContext;        readonly LogInAs loginAs;        readonly PostProductionTabDays postProductionTabDays;        readonly MenuCyclesDashboard menuCyclesDashboard;        public LocalUserPlanningSteps(ScenarioContext scenarioContext, PlanningView dailyPlanningView, PlanningTabDays planningTab, ToastNotification notification, LogInAs loginAs, PostProductionTabDays postProductionTabDays,MenuCyclesDashboard menuCyclesDashboard)        {            this.planningView = dailyPlanningView;            this.planningTabDays = planningTab;            this.notification = notification;            this.loginAs = loginAs;            this.postProductionTabDays = postProductionTabDays;            this.menuCyclesDashboard = menuCyclesDashboard;            this.scenarioContext = scenarioContext;        }        [When(@"location ""(.*)"" is selected")]        [Given(@"location ""(.*)"" is selected")]        public void GivenLocationIsSelected(string locationName)        {            loginAs.SearchLocation(locationName);            loginAs.SelectLocation(locationName);            menuCyclesDashboard.WaitPageLoad();        }        [Then(@"location name ""(.*)"" is present on the top of the planning")]        public void ThenLocationNameIsPresentOnTheTopOfThePlanning(string locationName)        {            Assert.That(planningTabDays.DailyPlanningTitleText, Is.EqualTo(locationName));        }        [Given(@"daily post-production tab is opened")]        [When(@"daily post-production tab is opened")]        public void WhenPostProductionTabIsOpened()        {            planningView.OpenPostProductionTab();            postProductionTabDays.WaitForLoad();        }        [Then(@"Create menu cycle button is not displayed")]        public void ThenCreateMenuCycleButtonIsNotDisplayed()        {            Assert.IsFalse(menuCyclesDashboard.IsCreateMenuCycleButtonPresent());           }        [When(@"action menu is opened for menu cycle ""(.*)""")]        public void WhenActionMenuIsOpenedForMenuCycle(string menuCycleName)        {            menuCyclesDashboard.GetMenuCycle(menuCycleName).UseActionButton();        }        [Then(@"Verify delete button is not present for menu cycle ""(.*)""")]        public void ThenDeleteButtonIsNotPresentForMenuCycle(string menuCycleName)        {            Assert.IsFalse(menuCyclesDashboard.GetMenuCycle(menuCycleName).IsDeleteButtonPresent);        }    }}