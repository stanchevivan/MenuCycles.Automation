using System;
using System.Collections.Generic;
using Bogus;
using MenuCycleData.Repositories;
using System.Configuration;

namespace MenuCycleData
{
    public class Seeding
    {
        private string myPrefix;

        private Faker faker;

        private User user;
        private Customer customer;
        private Group group;

        public Seeding()
        {
            this.faker = new Faker();
            var test = ConfigurationManager.ConnectionStrings;

            this.user = new UserRepository().FindById(36);
            this.customer = new CustomerRepository().FindById(1);
            this.group = new GroupRepository().FindByName("SodexoUp");

            this.myPrefix = "Ico ";
        }

        public MenuCycle GenerateMenuCycle()
        {
            return
                new MenuCycle()
                {
                    Name = this.myPrefix + this.faker.Name.FirstName(),
                    Description = this.myPrefix + this.faker.Lorem.Sentence(10),
                    ParentId = null,
                    IsPublished = false,
                    IsDeleted = false,
                    StartDate = null,
                    EndDate = null,
                    NonServingDays = 0,
                    CustomerId = this.customer.CustomerId,
                    DateCreatedUtc = DateTime.UtcNow,
                    CreatedByExternalId = user.ExternalId,
                    DateUpdatedUtc = DateTime.UtcNow,
                    UpdatedByExternalId = user.ExternalId,
                };
        }
        public MealPeriod GenerateMealPeriod()
        {
            return
                new MealPeriod()
                {
                    Name = this.myPrefix + this.faker.Name.FirstName(),
                    CustomerId = this.customer.CustomerId,
                    DateCreatedUtc = DateTime.UtcNow,
                    CreatedByExternalId = user.ExternalId,
                    DateUpdatedUtc = DateTime.UtcNow,
                    UpdatedByExternalId = user.ExternalId,
                    ExternalId = Guid.NewGuid(),
                };
        }

        public Recipe GenerateRecipe()
        {
            return
                new Recipe()
                {
                    ExternalId = Guid.NewGuid(),
                    Name = this.myPrefix + this.faker.Lorem.Sentence(5),
                    Cost = new Random().Next(1, 50),
                    CostQuantity = new Random().Next(11, 39),
                    CostUnitOfMeasure = "kg",
                    CustomerId = this.customer.CustomerId,
                    MinimumCost = new Random().Next(1, 10),
                    MaximumCost = new Random().Next(40, 50),
                    SellPriceModel = 1,
                    SellPriceModelValue = 1,
                    DateCreatedUtc = DateTime.UtcNow,
                    CreatedByExternalId = "admin",
                    DateUpdatedUtc = DateTime.UtcNow,
                    UpdatedByExternalId = "admin"
                };
        }

        public List<MenuCycle> RandomMenuCycles(int quantity)
        {
            List<MenuCycle> list = new List<MenuCycle>();

            for (int i = 0; i < quantity; i++)
            {
                list.Add
                (
                    GenerateMenuCycle()
                );
            }

            return MenuCycles(list);
        }

        public List<MealPeriod> RandomMealPeriods(int quantity)
        {
            List<MealPeriod> list = new List<MealPeriod>();

            for (int i = 0; i < quantity; i++)
            {
                list.Add
                (
                    GenerateMealPeriod()
                );
            }

            return MealPeriods(list);
        }

        //public List<Recipe> RandomRecipe(int quantity)
        //{
        //    List<Recipe> list = new List<Recipe>();

        //    for (int i = 0; i < quantity; i++)
        //    {
        //        list.Add
        //        (
        //            GenerateRecipe()
        //        );
        //    }

        //    return Recipes(list);
        //}

        public List<MenuCycle> MenuCycles(List<MenuCycle> list)
        {
            MenuCycleRepository mRepository = new MenuCycleRepository();
            RelationshipsRepository rRepository = new RelationshipsRepository();

            mRepository.BulkInsert(list);

            //MenuCycleGroup
            for (int i = 0; i < list.Count; i++)
            {
                rRepository.InsertMenuCycleGroup(new MenuCycleGroup()
                {
                    MenuCycleId = list[i].MenuCycleId,
                    GroupId = this.group.GroupId,
                    DateCreatedUtc = DateTime.UtcNow,
                    CreatedByExternalId = user.ExternalId,
                    DateUpdatedUtc = DateTime.UtcNow,
                    UpdatedByExternalId = user.ExternalId
                });
            }

            return list;
        }
        public List<MealPeriod> MealPeriods(List<MealPeriod> list)
        {
            MealPeriodRepository mRepository = new MealPeriodRepository();
            mRepository.BulkInsert(list);
            return list;
        }

        //public List<Recipe> Recipes(List<Recipe> list)
        //{
        //    RecipeRepository reRepository = new RecipeRepository();
        //    RelationshipsRepository rRepository = new RelationshipsRepository();

        //    reRepository.BulkInsert(list);

        //    //GroupRecipe
        //    for (int i = 0; i < list.Count; i++)
        //    {
        //        rRepository.InsertGroupRecipe(new GroupRecipe()
        //        {
        //            RecipeId = list[i].RecipeId,
        //            GroupId = this.group.GroupId,
        //            DateCreatedUtc = DateTime.UtcNow,
        //            CreatedByExternalId = user.ExternalId,
        //            DateUpdatedUtc = DateTime.UtcNow,
        //            UpdatedByExternalId = user.ExternalId
        //        });
        //    }

        //    return list;
        //}

        //NOT DONE YET
        public void DeleteScenarioData()
        {
            new MenuCycleRepository().CleanTestData();
        }
    }

}
