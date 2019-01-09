﻿using System;using System.Linq;using MenuCycle.Tests.Models;using MenuCycle.Tests.PageObjects;using NUnit.Framework;using TechTalk.SpecFlow;using TechTalk.SpecFlow.Assist;namespace MenuCycle.Tests.Steps{    [Binding]    public class PostProductionSteps    {        readonly PlanningView planningView;        readonly PlanningTabDays planningTabDays;        readonly PlanningTabWeeks planningTabWeeks;        readonly NutritionTabDays nutritionTabDays;        readonly MenuCycleDailyCalendarView menuCycleDailyCalendarView;        readonly RecipeSearch recipeSearch;        readonly ToastNotification notification;        readonly ScenarioContext scenarioContext;        readonly PostProductionTabDays postProductionTabDays;        public PostProductionSteps(ScenarioContext scenarioContext, PlanningView dailyPlanningView, PlanningTabDays planningTab, PlanningTabWeeks planningTabWeeks, NutritionTabDays nutritionTab, MenuCycleDailyCalendarView menuCycleDailyCalendarView,            RecipeSearch recipeSearch, ToastNotification notification, PostProductionTabDays postProductionTabDays)        {            this.planningView = dailyPlanningView;            this.planningTabDays = planningTab;            this.planningTabWeeks = planningTabWeeks;            this.nutritionTabDays = nutritionTab;            this.menuCycleDailyCalendarView = menuCycleDailyCalendarView;            this.recipeSearch = recipeSearch;            this.notification = notification;            this.postProductionTabDays = postProductionTabDays;            this.scenarioContext = scenarioContext;        }        [Then(@"Verify all post production meal periods are expanded")]        public void VerifyAllPostProductionMealPeriodsAreExpanded()        {            Assert.IsTrue(postProductionTabDays.AreAllMealPeriodsExpanded);        }        [Then(@"Verify all post production meal periods are collapsed")]        public void VerifyAllPostProductionMealPeriodsAreCollapsed()        {            Assert.IsTrue(postProductionTabDays.AreAllMealPeriodsCollapsed);        }        [When(@"Post-production meal period ""(.*)"" is collapsed")]        public void WhenMealPeriodIsCollapsed(string periodName)        {            postProductionTabDays.GetMealPeriod(periodName).Collapse();        }        [When(@"Post-production meal period ""(.*)"" is expanded")]        public void WhenMealPeriodIsExpanded(string periodName)        {            postProductionTabDays.GetMealPeriod(periodName).Expand();        }        [Then(@"Verify main data for Meal Period ""(.*)"" is collapsed in Post production days")]        public void ThenMainDataForMealPeriodIsCollapsedInPostProductionDays(string periodName)        {            Assert.IsFalse(postProductionTabDays.GetMealPeriod(periodName).IsExpanded);        }        [Then(@"Verify main data for Meal Period ""(.*)"" is expanded in Post production days")]        public void ThenMainDataForMealPeriodIsExpandedInPostProductionDays(string periodName)        {            Assert.IsTrue(postProductionTabDays.GetMealPeriod(periodName).IsExpanded);        }    }}