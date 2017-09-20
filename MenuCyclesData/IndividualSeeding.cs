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
        public List<MenuCycle> RandomMenuCycles(int quantity)
        {
            User user = new UserRepository().Find<User>(Constants.userId);

            MenuCycleRepository repository = new MenuCycleRepository();
            List<MenuCycle> list = new List<MenuCycle>();

            for (int i = 0; i < quantity; i++)
            {
                list.Add
                (
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
                    }
                );
            }

            return MenuCycles(list);
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
        public void DeleteScenarioData(List<MenuCycle> list)
        {
            new MenuCycleRepository().DeleteAllById(list.Select(l => l.MenuCycleId.ToString()).ToList());
        }
    }

}
