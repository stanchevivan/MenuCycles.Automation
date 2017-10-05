using System;
using System.Collections.Generic;

namespace MenuCycle.Data.Models
{
    public partial class MenuCycleItems
    {
        public MenuCycleItems()
        {
            InverseParent = new HashSet<MenuCycleItems>();
            PostProductions = new HashSet<PostProductions>();
            SellPrices = new HashSet<SellPrices>();
        }

        public long MenuCycleItemId { get; set; }
        public int Day { get; set; }
        public int Order { get; set; }
        public long? ParentId { get; set; }
        public long? MenuId { get; set; }
        public string MenuName { get; set; }
        public string Course { get; set; }
        public long MenuCycleId { get; set; }
        public long? RecipeId { get; set; }
        public int MenuCycleItemType { get; set; }
        public int? MenuType { get; set; }
        public long? MealPeriodId { get; set; }
        public DateTime DateCreatedUtc { get; set; }
        public string CreatedByExternalId { get; set; }
        public DateTime DateUpdatedUtc { get; set; }
        public string UpdatedByExternalId { get; set; }

        public MealPeriods MealPeriod { get; set; }
        public Menus Menu { get; set; }
        public MenuCycles MenuCycle { get; set; }
        public MenuCycleItems Parent { get; set; }
        public Recipes Recipe { get; set; }
        public ICollection<MenuCycleItems> InverseParent { get; set; }
        public ICollection<PostProductions> PostProductions { get; set; }
        public ICollection<SellPrices> SellPrices { get; set; }
    }
}
