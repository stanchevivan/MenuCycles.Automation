using System;
using System.Collections.Generic;
using System.Linq;
using MenuCycle.Data.Generators;
using MenuCycle.Data.Repositories;
using MenuCycle.Data.Models;

namespace MenuCycle.Data.Services
{
    public class MenuCycleService
    {
        private readonly MenuCycleGenerator menuCycleGenerator;
        private readonly MenuCycleRepository menuCycleRepository;
        private readonly RelationshipsRepository relationshipsRepository;
        private readonly MenuCycleItemRepository menuCycleItemsRepository;
        private readonly DefaultValues defaultValues;

        public MenuCycleService(MenuCycleGenerator menuCycleGenerator, MenuCycleRepository menuCycleRepository, 
            RelationshipsRepository relationshipsRepository, DefaultValues defaultValues,
            MenuCycleItemRepository menuCycleItemsRepository)
        {
            this.menuCycleGenerator = menuCycleGenerator;
            this.menuCycleRepository = menuCycleRepository;
            this.relationshipsRepository = relationshipsRepository;
            this.menuCycleItemsRepository = menuCycleItemsRepository;
            this.defaultValues = defaultValues;
        }

        public IList<MenuCycles> CreateMenuCycle(int count)
        {
            var menuCycles = this.menuCycleGenerator.Generate(count, defaultValues.Customer.CustomerId);

            this.menuCycleRepository.BulkInsert(menuCycles.ToList());

            foreach (var item in menuCycles)
            {
                this.relationshipsRepository.InsertMenuCycleGroup(new MenuCycleGroups()
                {
                    MenuCycleId = item.MenuCycleId,
                    GroupId = this.defaultValues.Group.GroupId,
                    DateCreatedUtc = DateTime.UtcNow,
                    CreatedByExternalId = this.defaultValues.User.ExternalId,
                    DateUpdatedUtc = DateTime.UtcNow,
                    UpdatedByExternalId = this.defaultValues.User.ExternalId
                });
            }

            return menuCycles;
        }

        public void DeleteMenuCycle(IList<MenuCycles> list)
        {
            this.menuCycleItemsRepository.DeleteAllByMenuCycle(FixList(list));
            this.relationshipsRepository.DeleteMenuCycleGroup(FixList(list));
            this.menuCycleRepository.DeleteAll(FixList(list));
        }


        //This method makes sure that Menu Cycles created by UI will also be deleted instead of only the DB seeded ones.
        private List<MenuCycles> FixList(IList<MenuCycles> list)
        {
            List<MenuCycles> fixedList = new List<MenuCycles>();
            foreach (var item in list)
            {
                fixedList.Add((item.MenuCycleId == 0) ? this.menuCycleRepository.FindByName(item.Name) : item);
            }

            return fixedList;
        }
    }
}