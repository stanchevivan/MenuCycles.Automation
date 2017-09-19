using MenuCyclesData.DatabaseDataModel;
using MenuCyclesData.Helpers;
using MenuCyclesData.Repositories;
using System;
using System.Collections.Generic;
using System.IO;

namespace MenuCyclesData
{
    public class DataSeeding
    {
        public int baseValue                = Constants.baseValue; //Users
            private int groupBase           = Constants.groupBase;
            private int locationBase        = Constants.locationBase;
        private int menuCycleBase           = Constants.menuCycleBase;
            private int noteBase            = Constants.noteBase;
            private int mealPeriodBase      = Constants.mealPeriodBase;
            private int menuBase            = Constants.menuBase;
            private int recipePerMenu       = Constants.recipePerMenu;
            private int recipePerMealPeriod = Constants.recipePerMealPeriod;

        private List<User> userList = new List<User>();

        private Customer customer = new Customer();
        private User user = new User();

        private List<Group> groupList = new List<Group>();
        private List<Location> locationList = new List<Location>();
        private List<MenuCycle> menuCycleList = new List<MenuCycle>();
        private List<Recipe> recipesList = new List<Recipe>();
        private List<Menu> menusList = new List<Menu>();
        private List<MealPeriod> mealPeriodList = new List<MealPeriod>();
        private List<Note> notesList = new List<Note>();
        private List<MenuCycleItem> mcItems = new List<MenuCycleItem>();

        public void SeedAll()
        {
            customer = new CustomerRepository().Find<Customer>(Constants.customerId);
            user = new UserRepository().Find<User>(Constants.userId);

            SeedMenuCycles();
            SeedMealPeriod();
            SeedRecipes();
            SeedMenus();
            SeedNotes();
            SeedRelationships();
            SeedMenuCycleItems();
        }
        public void ClearAll()
        {
            new RelationshipsRepository().DeleteAll();
            new RecipeRepository().DeleteAll();
            new MenuRepository().DeleteAll();
            new MealPeriodRepository().DeleteAll();
            new NotesRepository().DeleteAll();
            new MenuCycleRepository().DeleteAll();
            new GroupRepository().DeleteAll();
            new LocationRepository().DeleteAll();
            new UserRepository().DeleteAll();
        }
        public void ResetDatabase()
        {
            new MenuCycleRepository().DeleteCreatedMenuCycles();
            new MenuCycleItemRepository().DeleteAdditionalItems();
        }
        public void DeleteScenarioData(List<string> ids)
        {
            new MenuCycleRepository().DeleteAllById(ids);
        }
        public void SeedCustomer(string customerName)
        {
            CustomerRepository repository = new CustomerRepository();

            customer = new Customer
            {
                Name = customerName,
                ExternalId = customerName,
                DateCreatedUtc = DateTime.UtcNow,
                CreatedByExternalId = "admin",
                DateUpdatedUtc = DateTime.UtcNow,
                UpdatedByExternalId = "admin"
            };

            customer.CustomerId = repository.SingleInsert(customer);
        }
        public void SeedUser()
        {
            UserRepository userRepo = new UserRepository();
            List<User> list = new List<User>();

            for (int i = 1; i <= baseValue; i++)
            {
                user = new User
                {
                    Name = "SeedUser" + i,
                    ExternalId = "SeedUser" + i,
                    IsCentral = 1,
                    CustomerId = customer.CustomerId,
                    DateCreatedUtc = DateTime.UtcNow,
                    CreatedByExternalId = "admin",
                    DateUpdatedUtc = DateTime.UtcNow,
                    UpdatedByExternalId = "admin",
                    
                };
                list.Add(user);
            }
            userList = userRepo.BulkInsertAndReturn(list);
        }
        public void SeedGroups()
        {
            GroupRepository groupRepo = new GroupRepository();
            List<Group> list = new List<Group>();

            for (int i = 1; i <= baseValue * groupBase; i++)
            {
                Group group = new Group
                {
                    ExternalId = Guid.NewGuid().ToString(),
                    Name = "Seed Group " + i,
                    CustomerId = customer.CustomerId,
                    DateCreatedUtc = DateTime.UtcNow,
                    CreatedByExternalId = "admin",
                    DateUpdatedUtc = DateTime.UtcNow,
                    UpdatedByExternalId = "admin"

                };

                list.Add(group);
            }

            groupList = groupRepo.BulkInsertAndReturn(list);
        }
        public void SeedLocations()
        {
            LocationRepository locationRepo = new LocationRepository();
            List<Location> list = new List<Location>();

            for (int i = 1; i <= baseValue * locationBase; i++)
            {
                Location location = new Location
                {
                    ExternalId = Guid.NewGuid().ToString(),
                    Name = "Seed Location " + i,
                    CustomerId = customer.CustomerId,
                    DateCreatedUtc = DateTime.UtcNow,
                    CreatedByExternalId = "admin",
                    DateUpdatedUtc = DateTime.UtcNow,
                    UpdatedByExternalId = "admin",
                    
                };

                list.Add(location);
            }

            locationList = locationRepo.BulkInsertAndReturn(list);
        } 
        public void SeedMenuCycles()
        {
            MenuCycleRepository repository = new MenuCycleRepository();
            List<MenuCycle> list = new List<MenuCycle>();
            for (int j = 0; j < locationBase; j++)
            {
                for (int i = 1; i <= (baseValue * menuCycleBase)/locationBase; i++)
                {

                    var menuCycle = new MenuCycle();
                    menuCycle.Name = "Seed Menu Cycle " + i;
                    menuCycle.Description = "Menu Cycle Seeded " + i;
                    menuCycle.ParentId = 0;
                    menuCycle.IsPublished = 0;
                    menuCycle.IsMaster = 1;
                    menuCycle.IsDeleted = 0;
                    menuCycle.StartDate = null;
                    menuCycle.EndDate = null;
                    menuCycle.NonServingDays = 0;
                    menuCycle.CustomerId = customer.CustomerId;
                    menuCycle.DateCreatedUtc = DateTime.UtcNow;
                    menuCycle.CreatedByExternalId = user.Name;
                    menuCycle.DateUpdatedUtc = DateTime.UtcNow;
                    menuCycle.UpdatedByExternalId = user.Name;
                    
                    list.Add(menuCycle);
                }
            }
            menuCycleList = repository.BulkInsertAndReturn(list);
        }
        public void SeedRecipes()
        {
            RecipeRepository repository = new RecipeRepository();
            List<Recipe> list = new List<Recipe>();

            int quantity = (baseValue * mealPeriodBase) * (recipePerMealPeriod + recipePerMenu) * menuCycleBase;

            for (int i = 1; i <= quantity; i++)
            {
                Recipe recipe = new Recipe
                {
                    ExternalId = Guid.NewGuid().ToString(),
                    Name = "Seed Recipe " + i,
                    Cost = new Random().Next(1, 50),
                    CostQuantity = new Random().Next(11, 39),
                    CostUnitOfMeasure = "kg",
                    CustomerId = customer.CustomerId,
                    MinimumCost = new Random().Next(1, 10),
                    MaximumCost = new Random().Next(40, 50),
                    SellPriceModel = 1,
                    SellPriceModelValue = 1,
                    DateCreatedUtc = DateTime.UtcNow,
                    CreatedByExternalId = "admin",
                    DateUpdatedUtc = DateTime.UtcNow,
                    UpdatedByExternalId = "admin"
                };

                list.Add(recipe);
            }

            recipesList = repository.BulkInsertAndReturn(list);
        }
        public void SeedMenus()
        {
            MenuRepository repository = new MenuRepository();
            List<Menu> list = new List<Menu>();

            for (int i = 1; i <= (baseValue * mealPeriodBase) * menuBase * menuCycleBase; i++)
            {
                Menu menu = new Menu
                {
                    ExternalId = Guid.NewGuid().ToString(),
                    Name = "Seed Menu " + i,
                    MenuType = 1,
                    CustomerId = customer.CustomerId,
                    DateCreatedUtc = DateTime.UtcNow,
                    CreatedByExternalId = "admin",
                    DateUpdatedUtc = DateTime.UtcNow,
                    UpdatedByExternalId = "admin"
                };

                list.Add(menu);
            }

            menusList = repository.BulkInsertAndReturn(list);
        }
        public void SeedMealPeriod()
        {
            MealPeriodRepository repository = new MealPeriodRepository();
            List<MealPeriod> list = new List<MealPeriod>();

            for (int i = 1; i <= (baseValue * menuCycleBase) * mealPeriodBase; i++)
            {
                MealPeriod mealPeriod = new MealPeriod
                {
                    ExternalId = Guid.NewGuid().ToString(),
                    Name = "Seed Meal Period " + i,
                    CustomerId = customer.CustomerId,
                    DateCreatedUtc = DateTime.UtcNow,
                    CreatedByExternalId = "admin",
                    DateUpdatedUtc = DateTime.UtcNow,
                    UpdatedByExternalId = "admin"
                };
                list.Add(mealPeriod);
            }
            mealPeriodList = repository.BulkInsertAndReturn(list);
        }
        public void SeedNotes()
        {
            NotesRepository repository = new NotesRepository();
            List<Note> list = new List<Note>();
            
            for (int j = 0; j < menuCycleList.Count; j++)
            {
                for (int i = 1; i <= noteBase; i++)
                {
                    Note note = new Note
                    {
                        Content = "Seed Notes " + i,
                        MenuCycleId = menuCycleList[j].MenuCycleId,
                        Date = DateTime.UtcNow,
                        DateCreatedUtc = DateTime.UtcNow,
                        CreatedByExternalId = "admin",
                        DateUpdatedUtc = DateTime.UtcNow,
                        UpdatedByExternalId = "admin"
                    };
                    list.Add(note);
                }
            }
            notesList = repository.BulkInsertAndReturn(list);
        }
        public void SeedRelationships()
        {
            RelationshipsRepository repository = new RelationshipsRepository();
            dynamic dRelation;
            int helpBase;

            //"For each user, relates x numbers of Locations"
            //UserLocation
            helpBase = userList.Count / locationList.Count;
            for (int i = 0; i < baseValue; i++)
            {
                for (int j = i * helpBase; j < i * helpBase + helpBase; j++)
                {
                    dRelation = new
                    {
                        id1 = userList[i].UserId,
                        id2 = locationList[j].LocationId,
                        DateCreatedUtc = DateTime.UtcNow,
                        CreatedByExternalId = "admin",
                        DateUpdatedUtc = DateTime.UtcNow,
                        UpdatedByExternalId = "admin",
                        
                    };
                    repository.InsertUserLocation(dRelation);
                }
            }

            //"For each user, relates x numbers of Groups"
            //GroupUser
            helpBase = userList.Count / groupList.Count;
            for (int i = 0; i < baseValue; i++)
            {
                for (int j = i * helpBase; j < i * helpBase + helpBase; j++)
                {
                    dRelation = new
                    {
                        id1 = groupList[j].GroupId,
                        id2 = userList[i].UserId,
                        DateCreatedUtc = DateTime.UtcNow,
                        CreatedByExternalId = "admin",
                        DateUpdatedUtc = DateTime.UtcNow,
                        UpdatedByExternalId = "admin"
                    };
                    repository.InsertGroupUser(dRelation);
                }
            }

            //GroupRecipe
            helpBase = recipesList.Count / groupList.Count;
            for (int i = 0; i < groupList.Count; i++)
            {
                for (int j = i * helpBase; j < i * helpBase + helpBase; j++)
                {
                    dRelation = new
                    {
                        id1 = groupList[i].GroupId,
                        id2 = recipesList[j].RecipeId,
                        DateCreatedUtc = DateTime.UtcNow,
                        CreatedByExternalId = "admin",
                        DateUpdatedUtc = DateTime.UtcNow,
                        UpdatedByExternalId = "admin"
                    };
                    repository.InsertGroupRecipe(dRelation);
                }
            }

            //GroupMenu
            helpBase = menusList.Count / groupList.Count;
            for (int i = 0; i < groupList.Count; i++)
            {
                for (int j = i * helpBase; j < i * helpBase + helpBase; j++)
                {
                    dRelation = new
                    {
                        id1 = groupList[i].GroupId,
                        id2 = menusList[j].MenuId,
                        DateCreatedUtc = DateTime.UtcNow,
                        CreatedByExternalId = "admin",
                        DateUpdatedUtc = DateTime.UtcNow,
                        UpdatedByExternalId = "admin"
                    };
                    repository.InsertGroupMenu(dRelation);
                }
            }



            //GroupLocation
            helpBase = locationList.Count / groupList.Count;
            for (int i = 0; i < groupList.Count; i++)
            {
                for (int j = i * helpBase; j < i * helpBase + helpBase; j++)
                {
                    dRelation = new
                    {
                        id1 = groupList[i].GroupId,
                        id2 = locationList[j].LocationId,
                        DateCreatedUtc = DateTime.UtcNow,
                        CreatedByExternalId = "admin",
                        DateUpdatedUtc = DateTime.UtcNow,
                        UpdatedByExternalId = "admin"
                    };
                    repository.InsertGroupLocation(dRelation);
                }
            }

            //MenuCycleGroup
            helpBase = menuCycleList.Count / groupList.Count;
            for (int i = 0; i < groupList.Count; i++)
            {
                for (int j = i * helpBase; j < i * helpBase + helpBase; j++)
                {
                    dRelation = new
                    {
                        id1 = menuCycleList[j].MenuCycleId,
                        id2 = groupList[i].GroupId,
                        DateCreatedUtc = DateTime.UtcNow,
                        CreatedByExternalId = user.Name,
                        DateUpdatedUtc = DateTime.UtcNow,
                        UpdatedByExternalId = user.Name
                    };
                    repository.InsertMenuCycleGroup(dRelation);
                    menuCycleList[j].GroupId = groupList[i].GroupId;
                }
            }


            //MenuCycleLocation
            helpBase = menuCycleList.Count / locationList.Count;
            for (int i = 0; i < locationList.Count; i++)
            {
                for (int j = i * helpBase; j < i * helpBase + helpBase; j++)
                {
                    dRelation = new
                    {
                        id1 = menuCycleList[j].MenuCycleId,
                        id2 = locationList[i].LocationId,
                        DateCreatedUtc = DateTime.UtcNow,
                        CreatedByExternalId = "admin",
                        DateUpdatedUtc = DateTime.UtcNow,
                        UpdatedByExternalId = "admin"
                    };
                    repository.InsertMenuCycleLocation(dRelation);
                }
            }

            //MenuRecipe
            for (int i = 0; i < menusList.Count; i++)
            {
                AddMenuToItemsList(menusList[i].MenuId);
                for (int j = i * recipePerMenu; j < i * recipePerMenu + recipePerMenu; j++)
                {
                    dRelation = new
                    {
                        id1 = menusList[i].MenuId,
                        id2 = recipesList[j].RecipeId,
                        Course = (string)null,
                        DateCreatedUtc = DateTime.UtcNow,
                        CreatedByExternalId = "admin",
                        DateUpdatedUtc = DateTime.UtcNow,
                        UpdatedByExternalId = "admin"
                    };
                    repository.InsertMenuRecipe(dRelation);
                    AddRecipeToItemsList(recipesList[j].RecipeId);
                }
                AddRemainingRecipesToItemsList(recipePerMealPeriod * i);
            }
        }
        private void AddMenuToItemsList(int menuId)
        {
            MenuCycleItem mcItem = new MenuCycleItem
            {
                MenuId = menuId,
                MenuName = "Seed Menu",
                MenuType = 0,
            };
            mcItems.Add(mcItem);
        }
        private void AddRecipeToItemsList(int recipeId)
        {
            MenuCycleItem mcItem = new MenuCycleItem
            {
                RecipeId = recipeId
            };
            mcItems.Add(mcItem);
        }
        private void AddRemainingRecipesToItemsList(int startPosition)
        {
            startPosition = recipesList.Count / 2 + startPosition;
            for (int i = 0; i < recipePerMealPeriod; i++)
            { 
                MenuCycleItem mcItem = new MenuCycleItem
                {
                    RecipeId = recipesList[startPosition].RecipeId
                };
                mcItems.Add(mcItem);
                startPosition++;
            }
        }
        private void SeedMenuCycleItems()
        {
            MenuCycleItemRepository repository = new MenuCycleItemRepository();

            int day = 1;
            int order = 1;
            int mealPeriodPerDay = 1;

            for (int i = 0; i < mealPeriodList.Count; i++)
            {
                int helpBase = mcItems.Count / mealPeriodList.Count;
                for (int j = i * helpBase; j < i * helpBase + helpBase; j++)
                {
                    mcItems[j].Day = day;
                    mcItems[j].Order = order;
                    mcItems[j].ParentId = null;
                    mcItems[j].MenuCycleId = 0;                    //////////////////////////////
                    mcItems[j].MenuCycleItemType = 0;
                    mcItems[j].Course = "Seed Course";
                    mcItems[j].MealPeriodId = mealPeriodList[i].MealPeriodId;
                    mcItems[j].DateCreatedUtc = DateTime.UtcNow;
                    mcItems[j].CreatedByExternalId = "admin";
                    mcItems[j].DateUpdatedUtc = DateTime.UtcNow;
                    mcItems[j].UpdatedByExternalId = "admin";

                    order++;
                }
                if (mealPeriodPerDay == Constants.mealPeriodsPerDay)
                {
                    day++;
                    if (day % Constants.nonServingDay == 0) day++;
                    if (day > Constants.scheduleWeeks * 6) day = 1;
                    order = 1;
                    mealPeriodPerDay = 0;
                }
                mealPeriodPerDay++;
            }

            for (int i = 0; i < menuCycleList.Count; i++)
            {
                int helpBase = mcItems.Count / menuCycleList.Count;
                for (int j = i * helpBase; j < i * helpBase + helpBase; j++)
                {
                    mcItems[j].MenuCycleId = menuCycleList[i].MenuCycleId;
                }
            }
            mcItems = repository.BulkInsertAndReturn(mcItems);
            mcItems = repository.GetAll<MenuCycleItem>();
            for (int i = 0; i < mcItems.Count; i++)
            {
                if (mcItems[i].MenuId != null)
                {
                    for (int j = i + 1; j <= i + recipePerMenu; j++)
                    {
                        mcItems[j].ParentId = mcItems[i].MenuCycleItemId;
                    }
                }
            }

            repository.Update<MenuCycleItem>(mcItems);
        }
    }

}
