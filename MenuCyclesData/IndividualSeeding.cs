using MenuCyclesData.DatabaseDataModel;
using MenuCyclesData.Helpers;
using MenuCyclesData.Repositories;
using System;
using System.Collections.Generic;
using Bogus;
using System.Linq;

namespace MenuCyclesData
{
    public class Seeding
    {
        private Faker faker;
        public Seeding()
        {
            this.faker = new Faker();
        }

        public MenuCycle GenerateMenuCycle()
        {
            User user = new UserRepository().Find<User>(Constants.userId);

            return
                new MenuCycle()
                {
                    Name = Constants.myPrefix + this.faker.Name.FirstName(),
                    Description = Constants.myPrefix + this.faker.Lorem.Sentence(10),
                    ParentId = null,
                    IsPublished = 0,
                    IsDeleted = 0,
                    StartDate = null,
                    EndDate = null,
                    NonServingDays = 0,
                    CustomerId = Constants.customerId,
                    DateCreatedUtc = DateTime.UtcNow,
                    CreatedByExternalId = user.ExternalId,
                    DateUpdatedUtc = DateTime.UtcNow,
                    UpdatedByExternalId = user.ExternalId,
                };
        }
        public Recipe GenerateRecipe()
        {
            User user = new UserRepository().Find<User>(Constants.userId);

            return
                new Recipe()
                {
                    ExternalId = Guid.NewGuid().ToString(),
                    Name = Constants.myPrefix + this.faker.Lorem.Sentence(5),
                    Cost = new Random().Next(1, 50),
                    CostQuantity = new Random().Next(11, 39),
                    CostUnitOfMeasure = "kg",
                    CustomerId = Constants.customerId,
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
        public List<Recipe> RandomRecipe(int quantity)
        {
            List<Recipe> list = new List<Recipe>();

            for (int i = 0; i < quantity; i++)
            {
                list.Add
                (
                    GenerateRecipe()
                );
            }

            return Recipes(list);
        }

        public List<MenuCycle> MenuCycles(List<MenuCycle> list)
        {
            MenuCycleRepository mRepository = new MenuCycleRepository();
            RelationshipsRepository rRepository = new RelationshipsRepository();
            UserRepository uRepository = new UserRepository();
            GroupRepository gRepository = new GroupRepository();

            User user = uRepository.Find<User>(Constants.userId);
            Group group = gRepository.Find<Group>(Constants.groupName);

            List<MenuCycle> menuCycleList = mRepository.BulkInsertAndReturn(list);

            //MenuCycleGroup
            for (int i = 0; i < list.Count; i++)
            {
                dynamic dRelation = new
                {
                    id1 = menuCycleList[i].MenuCycleId,
                    id2 = group.GroupId,
                    DateCreatedUtc = DateTime.UtcNow,
                    CreatedByExternalId = user.ExternalId,
                    DateUpdatedUtc = DateTime.UtcNow,
                    UpdatedByExternalId = user.ExternalId
                };
                rRepository.InsertMenuCycleGroup(dRelation);
                //menuCycleList[i].GroupName = group.Name;
            }

            return menuCycleList;
        }
        public List<Recipe> Recipes(List<Recipe> list)
        {
            RecipeRepository reRepository = new RecipeRepository();
            GroupRepository gRepository = new GroupRepository();
            RelationshipsRepository rRepository = new RelationshipsRepository();

            List<Recipe> recipeList = reRepository.BulkInsertAndReturn(list);
            Group group = gRepository.Find<Group>(Constants.groupName);

            //GroupRecipe
            for (int i = 0; i < list.Count; i++)
            {
                dynamic dRelation = new
                {
                    id1 = group.GroupId,
                    id2 = recipeList[i].RecipeId,
                    DateCreatedUtc = DateTime.UtcNow,
                    CreatedByExternalId = "admin",
                    DateUpdatedUtc = DateTime.UtcNow,
                    UpdatedByExternalId = "admin"
                };
                rRepository.InsertGroupRecipe(dRelation);
            }

            return recipeList;
        }
        public void DeleteScenarioData(List<MenuCycle> list)
        {
            new MenuCycleRepository().DeleteAllById(list.Select(l => l.MenuCycleId.ToString()).ToList());
        }
    }

}
