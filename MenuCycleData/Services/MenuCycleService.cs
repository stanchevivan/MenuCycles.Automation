using System;
using System.Collections.Generic;
using System.Linq;
using MenuCycleData.Generators;
using MenuCycleData.Repositories;

namespace MenuCycleData.Services
{
    public class MenuCycleService
    {
        private readonly MenuCycleGenerator menuCycleGenerator;
        private readonly MenuCycleRepository menuCycleRepository;
        private readonly RelationshipsRepository relationshipsRepository;
        private readonly DefaultValues defaultValues;

        public MenuCycleService(MenuCycleGenerator menuCycleGenerator, MenuCycleRepository menuCycleRepository, 
            RelationshipsRepository relationshipsRepository, DefaultValues defaultValues)
        {
            this.menuCycleGenerator = menuCycleGenerator;
            this.menuCycleRepository = menuCycleRepository;
            this.relationshipsRepository = relationshipsRepository;
            this.defaultValues = defaultValues;
        }

        public IList<MenuCycle> CreateMenuCycle(int count)
        {
            var menuCycles = this.menuCycleGenerator.Generate(count, defaultValues.Customer.CustomerId);

            this.menuCycleRepository.BulkInsert(menuCycles.ToList());

            foreach (var item in menuCycles)
            {
                this.relationshipsRepository.InsertMenuCycleGroup(new MenuCycleGroup()
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

        public void DeleteMenuCycle(IList<MenuCycle> list)
        {
            //Makes sure that Recipes created by user can also be deleted by the repository
            list.Where(l => l.MenuCycleId == 0).ToList().ForEach(l => l.MenuCycleId = this.menuCycleRepository.FindByName(l.Name).MenuCycleId);

            this.relationshipsRepository.DeleteMenuCycleItems(list);
            this.relationshipsRepository.DeleteMenuCycleGroup(list);
            this.menuCycleRepository.DeleteAll(list);
        }
    }
}