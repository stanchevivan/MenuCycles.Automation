using System;
using System.Collections.Generic;

namespace MenuCycle.Data.Models
{
    public partial class Menus
    {
        public Menus()
        {
            GroupMenus = new HashSet<GroupMenus>();
            MenuCycleItems = new HashSet<MenuCycleItems>();
            MenuRecipes = new HashSet<MenuRecipes>();
        }

        public long MenuId { get; set; }
        public Guid ExternalId { get; set; }
        public string Name { get; set; }
        public int MenuType { get; set; }
        public long CustomerId { get; set; }
        public DateTime DateCreatedUtc { get; set; }
        public string CreatedByExternalId { get; set; }
        public DateTime DateUpdatedUtc { get; set; }
        public string UpdatedByExternalId { get; set; }
        public double? Cover { get; set; }

        public Customers Customer { get; set; }
        public ICollection<GroupMenus> GroupMenus { get; set; }
        public ICollection<MenuCycleItems> MenuCycleItems { get; set; }
        public ICollection<MenuRecipes> MenuRecipes { get; set; }
    }
}
