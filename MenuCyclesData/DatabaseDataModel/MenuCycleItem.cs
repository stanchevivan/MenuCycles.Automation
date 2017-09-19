using System;

namespace MenuCyclesData.DatabaseDataModel
{
    public class MenuCycleItem
    {
        public int MenuCycleItemId { get; set; }
        public int Day { get; set; }
        public int Order { get; set; }
        public int? ParentId { get; set; }
        public int? MenuId { get; set; }
        public string MenuName { get; set; }
        public string Course { get; set; }
        public int MenuCycleId { get; set; }
        public int? RecipeId { get; set; }
        public int MenuCycleItemType { get; set; }
        public int? MenuType { get; set; }
        public int? MealPeriodId { get; set; }
        public DateTime DateCreatedUtc { get; set; }
        public string CreatedByExternalId { get; set; }
        public DateTime DateUpdatedUtc { get; set; }
        public string UpdatedByExternalId { get; set; }
    }
}
